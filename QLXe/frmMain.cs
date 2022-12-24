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
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void menuKhach_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhach f = new frmKhach();
            f.MdiParent = this;
            f.Show();
        }

        private void menuXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmXe f = new frmXe();
            f.MdiParent = this;
            f.Show();
        }

        private void menuPhutung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPhutung f = new frmPhutung();
            f.MdiParent = this;
            f.Show();
        }

        private void menuHoadon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHoadon f = new frmHoadon();
            f.MdiParent = this;
            f.Show();
        }

        private void menuChitiet_HD_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChitiet_HD f = new frmChitiet_HD();
            f.MdiParent = this;
            f.Show();
        }
    }
}