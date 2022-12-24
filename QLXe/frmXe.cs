﻿using System;
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
    }
}