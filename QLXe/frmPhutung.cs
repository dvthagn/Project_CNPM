using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLXe
{
    public partial class frmPhutung : DevExpress.XtraEditors.XtraForm
    {
        QUANLIBAOHANHXEMAYEntities data = new QUANLIBAOHANHXEMAYEntities();
        bool action = false;
        public frmPhutung()
        {
            InitializeComponent();
        }

        private void frmPhutung_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }
        void resetText()
        {
            txtMaphutung.ResetText();
            txtTenphutung.ResetText();
            txtNuocsanxuat.ResetText();
            txtDongia.ResetText();
            txtThoigianbaohanh.ResetText();
        }
        void init()
        {
            txtThoigianbaohanh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtThoigianbaohanh.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtThoigianbaohanh.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtDongia.Text = "0";
            menuDel.Enabled = false;//no
        }
        void getData()
        {
            List<PHUTUNG> lst = data.PHUTUNGs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MAPHUTUNG = t.MAPHUTUNG,
                        TENPHUTUNG = t.TENPHUTUNG,
                        NUOCSANXUAT = t.NUOCSX,
                        DONGIA = t.DONGIA,
                        THOIGIANBAOHANH = t.THOIGIANBAOHANH
                    };
            dgPhutung.DataSource = v.ToList();
            resetText();



        }

        private void menuSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false) //insert
            {
                if (int.Parse(txtDongia.Text.Trim()) < 0)
                {
                    MessageBox.Show("Giá mua không được số âm", "Thông báo");
                }
                else
                {
                    var k = new PHUTUNG
                    {
                        MAPHUTUNG = txtMaphutung.Text.Trim(),
                        TENPHUTUNG = txtTenphutung.Text.Trim(),
                        NUOCSX = txtNuocsanxuat.Text.Trim(),
                        DONGIA = int.Parse(txtDongia.Text.Trim()),
                        THOIGIANBAOHANH = DateTime.Parse(txtThoigianbaohanh.EditValue.ToString()),
                    };

                    resetText();

                    data.PHUTUNGs.Add(k);
                    data.SaveChanges();
                    getData();

                }

            }
            else
            {
                if (MessageBox.Show("Do you want to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //update
                    var s = (from t in data.PHUTUNGs
                             where t.MAPHUTUNG == txtMaphutung.Text
                             select t
                             ).SingleOrDefault();

                    s.TENPHUTUNG = txtTenphutung.Text.Trim();
                    s.NUOCSX = txtNuocsanxuat.Text.Trim();
                    s.DONGIA = int.Parse(txtDongia.Text.Trim());
                    s.THOIGIANBAOHANH = DateTime.Parse(txtThoigianbaohanh.EditValue.ToString());


                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtMaphutung.Text = gridView1.GetFocusedRowCellValue("MAPHUTUNG").ToString();
            txtTenphutung.Text = gridView1.GetFocusedRowCellValue("TENPHUTUNG").ToString();

            txtNuocsanxuat.Text = gridView1.GetFocusedRowCellValue("NUOCSANXUAT").ToString();
            txtDongia.Text = gridView1.GetFocusedRowCellValue("DONGIA").ToString();
            txtThoigianbaohanh.Text = gridView1.GetFocusedRowCellValue("THOIGIANBAOHANH").ToString();



            menuDel.Enabled = true;
            action = true; //update
        }

        private void menuDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var delItem = data.CHITIET_HD.FirstOrDefault(x => x.MAPHUTUNG.Contains(txtMaphutung.Text));
                if (delItem != null)
                {
                    MessageBox.Show("Không xóa được !");
                }
                else
                {

                    var s = (from t in data.PHUTUNGs
                             where t.MAPHUTUNG == txtMaphutung.Text
                             select t
                             ).SingleOrDefault();
                    data.PHUTUNGs.Remove(s);
                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void menuCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            action = false; //insert
            txtMaphutung.ReadOnly = false;
            menuDel.Enabled = false;
            resetText();
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}