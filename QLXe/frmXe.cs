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
    public partial class frmXe : DevExpress.XtraEditors.XtraForm
    {
        QUANLIBAOHANHXEMAYEntities data = new QUANLIBAOHANHXEMAYEntities();
        bool action = false;
        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            getData();
            init();
            getKhach();
        }
        void getKhach()
        {
            List<KHACH> lstKhach = data.KHACHes.ToList();

            var v = from t in lstKhach
                    select new
                    {
                        MAKHACH = t.MAKHACH,
                        TENKHACH = t.TENKHACH

                    };

            cboMakhach.Properties.ValueMember = "MAKHACH";
            cboMakhach.Properties.DisplayMember = "TENKHACH";
            cboMakhach.EditValue = "";
            cboMakhach.Properties.DataSource = v.ToList();




        }
        void init()
        {

            txtNgaymua.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtNgaymua.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtNgaymua.Properties.Mask.UseMaskAsDisplayFormat = true;
            txtGiamua.Text = "0";
            menuDel.Enabled = false;//no
        }
        void resetText()
        {
            txtSoxe.ResetText();
            cboMakhach.ResetText();
            txtHieuxe.ResetText();
            txtSosuon.ResetText();
            txtSomay.ResetText();
            txtNgaymua.ResetText();
            txtGiamua.ResetText();
        }
        void getData()
        {
            List<XE> lst = data.XEs.ToList();

            int i = 0;
            var v = from t in lst

                    select new
                    {

                        No = ++i,
                        SOXE = t.SOXE,
                        MAKHACH = t.KHACH.TENKHACH,
                        HIEUXE = t.HIEUXE,
                        SOSUON = t.SOSUON,
                        SOMAY = t.SOMAY,
                        NGAYMUA = t.NGAYMUA,
                        GIAMUA = t.GIAMUA
                    };
            dgXe.DataSource = v.ToList();
            resetText();
        }

        private void menuSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false) //insert
            {
                if (int.Parse(txtGiamua.Text.Trim()) < 0)
                {
                    MessageBox.Show("Giá mua không được số âm", "Thông báo");
                }
                else
                {


                    var k = new XE
                    {

                        SOXE = txtSoxe.Text.Trim(),
                        MAKHACH = cboMakhach.EditValue.ToString(),
                        HIEUXE = txtHieuxe.Text.Trim(),
                        SOSUON = txtSosuon.Text.Trim(),
                        SOMAY = txtSomay.Text.Trim(),
                        NGAYMUA = DateTime.Parse(txtNgaymua.EditValue.ToString()),
                        GIAMUA = int.Parse(txtGiamua.Text.Trim()),

                    };
                    resetText();


                    data.XEs.Add(k);
                    data.SaveChanges();
                    getData();
                }
            }
            else
            {
                if (MessageBox.Show("Do you want to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //update
                    var s = (from t in data.XEs
                             where t.SOXE == txtSoxe.Text
                             select t
                             ).SingleOrDefault();

                    s.MAKHACH = cboMakhach.SelectedText.ToString();
                    s.HIEUXE = txtHieuxe.Text.Trim();
                    s.SOSUON = txtSosuon.Text.Trim();
                    s.SOMAY = txtSomay.Text.Trim();
                    s.NGAYMUA = DateTime.Parse(txtNgaymua.EditValue.ToString());
                    s.GIAMUA = int.Parse(txtGiamua.Text.Trim());

                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtSoxe.Text = gridView1.GetFocusedRowCellValue("SOXE").ToString();
            cboMakhach.Text = gridView1.GetFocusedRowCellValue("MAKHACH").ToString();

            txtHieuxe.Text = gridView1.GetFocusedRowCellValue("HIEUXE").ToString();
            txtSosuon.Text = gridView1.GetFocusedRowCellValue("SOSUON").ToString();
            txtSomay.Text = gridView1.GetFocusedRowCellValue("SOMAY").ToString();
            txtNgaymua.Text = gridView1.GetFocusedRowCellValue("NGAYMUA").ToString();
            txtGiamua.Text = gridView1.GetFocusedRowCellValue("GIAMUA").ToString();


            menuDel.Enabled = true;
            action = true; //update
        }

        private void menuDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var delItem = data.HOADONs.FirstOrDefault(x => x.SOXE.Contains(txtSoxe.Text));
                if (delItem != null)
                {
                    MessageBox.Show("Không xóa được !");
                }
                else
                {

                    var s = (from t in data.XEs
                             where t.SOXE == txtSoxe.Text
                             select t
                             ).SingleOrDefault();
                    data.XEs.Remove(s);
                    data.SaveChanges();
                    getData();
                }

            }
        }

        private void menuCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            action = false; //insert
            txtSoxe.ReadOnly = false;
            menuDel.Enabled = false;
            resetText();
        }

        private void txtGiamua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}