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
    public partial class frmHoadon : DevExpress.XtraEditors.XtraForm
    {
        QUANLIBAOHANHXEMAYEntities data = new QUANLIBAOHANHXEMAYEntities();
        bool action = false;
        public frmHoadon()
        {
            InitializeComponent();
        }

        private void frmHoadon_Load(object sender, EventArgs e)
        {
            getData();
            init();
            getXe();
        }
        void resetText()
        {
            txtSohoadon.ResetText();
            cboSoxe.ResetText();
            txtNgaythanhlap.ResetText();
        }
        void getXe()
        {
            List<XE> lstXe = data.XEs.ToList();

            var v = from t in lstXe
                    select new
                    {
                        SOXE = t.SOXE,
                        HIEUXE = t.HIEUXE

                    };

            cboSoxe.Properties.ValueMember = "SOXE";
            cboSoxe.Properties.DisplayMember = "HIEUXE";
            cboSoxe.EditValue = "";
            cboSoxe.Properties.DataSource = v.ToList();
        }
        void init()
        {
            txtNgaythanhlap.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            txtNgaythanhlap.Properties.Mask.EditMask = "dd/MM/yyyy";
            txtNgaythanhlap.Properties.Mask.UseMaskAsDisplayFormat = true;
            menuDel.Enabled = false;//no

        }
        void getData()
        {
            List<HOADON> lst = data.HOADONs.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        SOHOADON = t.SOHOADON,
                        SOXE = t.XE.HIEUXE,
                        NGAYLAPHD = t.NGAYLAPHD
                    };
            dgHoadon.DataSource = v.ToList();
            resetText();
        }
    }
}