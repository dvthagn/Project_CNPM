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
    }
}