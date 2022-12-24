namespace QLXe
{
    partial class frmKhach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhach));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.menuSave = new DevExpress.XtraBars.BarButtonItem();
            this.menuDel = new DevExpress.XtraBars.BarButtonItem();
            this.menuCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grDanhsach = new DevExpress.XtraEditors.GroupControl();
            this.dgKhach = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grThongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiachi = new DevExpress.XtraEditors.TextEdit();
            this.txtMakhach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenkhach = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).BeginInit();
            this.grDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.grThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuSave,
            this.menuDel,
            this.menuCancel});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // menuSave
            // 
            this.menuSave.Caption = "Save";
            this.menuSave.Id = 0;
            this.menuSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.ImageOptions.Image")));
            this.menuSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuSave.ImageOptions.LargeImage")));
            this.menuSave.Name = "menuSave";
            // 
            // menuDel
            // 
            this.menuDel.Caption = "Delete";
            this.menuDel.Id = 1;
            this.menuDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuDel.ImageOptions.Image")));
            this.menuDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuDel.ImageOptions.LargeImage")));
            this.menuDel.Name = "menuDel";
            // 
            // menuCancel
            // 
            this.menuCancel.Caption = "Cancel";
            this.menuCancel.Id = 2;
            this.menuCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuCancel.ImageOptions.Image")));
            this.menuCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuCancel.ImageOptions.LargeImage")));
            this.menuCancel.Name = "menuCancel";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(784, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(784, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(784, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(209, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(345, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "QUẢN LÍ DANH SÁCH KHÁCH";
            // 
            // grDanhsach
            // 
            this.grDanhsach.Controls.Add(this.dgKhach);
            this.grDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDanhsach.Location = new System.Drawing.Point(0, 251);
            this.grDanhsach.Name = "grDanhsach";
            this.grDanhsach.Size = new System.Drawing.Size(784, 232);
            this.grDanhsach.TabIndex = 5;
            this.grDanhsach.Text = "Danh sách khách";
            // 
            // dgKhach
            // 
            this.dgKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKhach.Location = new System.Drawing.Point(2, 28);
            this.dgKhach.MainView = this.gridView1;
            this.dgKhach.MenuManager = this.barManager1;
            this.dgKhach.Name = "dgKhach";
            this.dgKhach.Size = new System.Drawing.Size(780, 202);
            this.dgKhach.TabIndex = 0;
            this.dgKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgKhach;
            this.gridView1.Name = "gridView1";
            // 
            // grThongtin
            // 
            this.grThongtin.Controls.Add(this.txtTenkhach);
            this.grThongtin.Controls.Add(this.txtSDT);
            this.grThongtin.Controls.Add(this.txtDiachi);
            this.grThongtin.Controls.Add(this.txtMakhach);
            this.grThongtin.Controls.Add(this.labelControl5);
            this.grThongtin.Controls.Add(this.labelControl4);
            this.grThongtin.Controls.Add(this.labelControl3);
            this.grThongtin.Controls.Add(this.labelControl2);
            this.grThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grThongtin.Location = new System.Drawing.Point(0, 82);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(784, 169);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.Text = "Thông tin khách";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(522, 107);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(185, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(522, 43);
            this.txtDiachi.MenuManager = this.barManager1;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(178, 22);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(189, 43);
            this.txtMakhach.MenuManager = this.barManager1;
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(169, 22);
            this.txtMakhach.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(411, 110);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 16);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Số điện thoại";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(411, 46);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(86, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(59, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên khách";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(86, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã khách";
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Location = new System.Drawing.Point(189, 107);
            this.txtTenkhach.MenuManager = this.barManager1;
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(190, 22);
            this.txtTenkhach.TabIndex = 8;
            // 
            // frmKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 503);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.grDanhsach);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmKhach.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhach";
            this.Text = "Quản lí danh sách khách";
            this.Load += new System.EventHandler(this.frmKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).EndInit();
            this.grDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenkhach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem menuSave;
        private DevExpress.XtraBars.BarButtonItem menuDel;
        private DevExpress.XtraBars.BarButtonItem menuCancel;
        private DevExpress.XtraEditors.GroupControl grThongtin;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.TextEdit txtDiachi;
        private DevExpress.XtraEditors.TextEdit txtMakhach;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grDanhsach;
        private DevExpress.XtraGrid.GridControl dgKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenkhach;
    }
}