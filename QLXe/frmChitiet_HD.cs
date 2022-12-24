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

        }
    }
}