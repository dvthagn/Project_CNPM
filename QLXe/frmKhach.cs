using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraBars;

namespace QLXe
{
    public partial class frmKhach : DevExpress.XtraEditors.XtraForm
    {
        QUANLIBAOHANHXEMAYEntities data = new QUANLIBAOHANHXEMAYEntities();
        bool action = false;
        public frmKhach()
        {
            InitializeComponent();
        }

        private void frmKhach_Load(object sender, EventArgs e)
        {
            getData();
            init();
        }

        void init()
        {
            menuDel.Enabled = false;//no
        }
        void getData()
        {

            List<KHACH> lst = data.KHACHes.ToList();
            int i = 0;
            var v = from t in lst
                    select new
                    {
                        No = ++i,
                        MAKHACH = t.MAKHACH,
                        TENKHACH = t.TENKHACH,
                        DIACHI = t.DIACHI,
                        SODIENTHOAI = t.SODIENTHOAI
                    };
            dgKhach.DataSource = v.ToList();
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";


        }

        private void menuSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (action == false) //insert
            {

                var k = new KHACH
                {
                    MAKHACH = txtMakhach.Text.Trim(),
                    TENKHACH = txtTenkhach.Text.Trim(),
                    SODIENTHOAI = txtSDT.Text.Trim(),
                    DIACHI = txtDiachi.Text.Trim()
                };
                txtMakhach.Text = "";
                txtTenkhach.Text = "";
                txtSDT.Text = "";
                txtDiachi.Text = "";
                data.KHACHes.Add(k);
                data.SaveChanges();
                getData();
            }
            else
            {
                if (MessageBox.Show("Do you want to update?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //update
                    var s = (from t in data.KHACHes
                             where t.MAKHACH == txtMakhach.Text
                             select t
                             ).SingleOrDefault();

                    s.TENKHACH = txtTenkhach.Text.Trim();
                    s.DIACHI = txtDiachi.Text.Trim();
                    s.SODIENTHOAI = txtSDT.Text.Trim();

                    data.SaveChanges();

                    getData();

                }

            }
        }
    }
}