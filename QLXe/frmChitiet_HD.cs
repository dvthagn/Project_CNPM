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
    public partial class frmChitiet_HD : DevExpress.XtraEditors.XtraForm
    {
        QUANLIBAOHANHXEMAYEntities data = new QUANLIBAOHANHXEMAYEntities();
        bool action = false;
        public frmChitiet_HD()
        {
            InitializeComponent();
        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }


        private void frmChitiet_HD_Load(object sender, EventArgs e)
        {
            getHoadon();
            getPhutung();
            getData();
        }

        void resetText()
        {
            cboMaphutung.ResetText();
            cboSohoadon.ResetText();
            txtDongia.ResetText();
            txtSoluong.ResetText();
        }
        void getPhutung()
        {

            List<PHUTUNG> lstPhutung = data.PHUTUNGs.ToList();

            var v = from t in lstPhutung
                    select new
                    {
                        MAPHUTUNG = t.MAPHUTUNG,
                        TENPHUTUNG = t.TENPHUTUNG

                    };

            cboMaphutung.Properties.ValueMember = "MAPHUTUNG";
            cboMaphutung.Properties.DisplayMember = "TENPHUTUNG";
            cboMaphutung.EditValue = "";
            cboMaphutung.Properties.DataSource = v.ToList();
        }
        void getHoadon()
        {

            List<HOADON> lstPhutung = data.HOADONs.ToList();

            var v = from t in lstPhutung
                    select new
                    {
                        SOHOADON = t.SOHOADON,


                    };

            cboSohoadon.Properties.ValueMember = "SOHOADON";
            cboSohoadon.Properties.DisplayMember = "SOHOADON";
            cboSohoadon.EditValue = "";
            cboSohoadon.Properties.DataSource = v.ToList();
        }
        void getData()
        {
            List<CHITIET_HD> lst = data.CHITIET_HD.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        SOHOADON = t.SOHOADON,
                        MAPHUTUNG = t.PHUTUNG.TENPHUTUNG,
                        SOLUONG = t.SOLUONG,
                        DONGIA = t.DONGIA

                    };
            dgChitiethoadon.DataSource = v.ToList();
            resetText();
        }
        private void menuSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false) //insert
            {
                if (int.Parse(txtDongia.Text.Trim()) < 0)
                {
                    MessageBox.Show("Đơn giá không được số âm", "Thông báo");
                }
                else if (int.Parse(txtSoluong.Text.Trim()) < 0)
                {
                    MessageBox.Show("Số lượng không được số âm", "Thông báo");
                }
                else
                {

                    var k = new CHITIET_HD
                    {
                        SOHOADON = cboSohoadon.EditValue.ToString(),
                        MAPHUTUNG = cboMaphutung.EditValue.ToString(),
                        SOLUONG = int.Parse(txtSoluong.Text.Trim()),
                        DONGIA = int.Parse(txtDongia.Text.Trim())


                    };
                    resetText();
                    data.CHITIET_HD.Add(k);
                    data.SaveChanges();
                    getData();
                }

            }
            else
            {
                if (MessageBox.Show("Do you want to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //update
                    var s = (from t in data.CHITIET_HD
                             where ((t.SOHOADON == cboSohoadon.EditValue.ToString()) && (t.MAPHUTUNG == cboMaphutung.EditValue.ToString()))
                             select t
                             ).SingleOrDefault();

                    s.SOLUONG = int.Parse(txtSoluong.Text.Trim());

                    s.DONGIA = int.Parse(txtDongia.Text.Trim());
                    resetText();
                    data.SaveChanges();
                    getData();
                }
            }
        }

        private void menuDel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {


                var s = (from t in data.CHITIET_HD
                         where ((t.SOHOADON == cboSohoadon.EditValue.ToString()) && (t.MAPHUTUNG == cboMaphutung.EditValue.ToString()))
                         select t
                             ).SingleOrDefault();
                data.CHITIET_HD.Remove(s);
                data.SaveChanges();
                getData();
            }
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            cboSohoadon.Text = gridView2.GetFocusedRowCellValue("SOHOADON").ToString();
            cboMaphutung.Text = gridView2.GetFocusedRowCellValue("MAPHUTUNG").ToString();

            txtSoluong.Text = gridView2.GetFocusedRowCellValue("SOLUONG").ToString();
            txtDongia.Text = gridView2.GetFocusedRowCellValue("DONGIA").ToString();




            menuDel.Enabled = true;
            action = true; //update
        }

        private void menuCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            menuDel.Enabled = false;
            action = false; //insert
            resetText();
        }
    }
}