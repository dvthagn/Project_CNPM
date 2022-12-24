namespace QLXe
{
    partial class frmPhutung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhutung));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.menuSave = new DevExpress.XtraBars.BarButtonItem();
            this.menuDel = new DevExpress.XtraBars.BarButtonItem();
            this.menuCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grDanhsach = new DevExpress.XtraEditors.GroupControl();
            this.dgPhutung = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grThongtin = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtThoigianbaohanh = new DevExpress.XtraEditors.DateEdit();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.txtNuocsanxuat = new DevExpress.XtraEditors.TextEdit();
            this.txtTenphutung = new DevExpress.XtraEditors.TextEdit();
            this.txtMaphutung = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).BeginInit();
            this.grDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhutung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.grThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoigianbaohanh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoigianbaohanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocsanxuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenphutung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphutung.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
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
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(68, 168);
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
            this.menuSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuSave_ItemClick);
            // 
            // menuDel
            // 
            this.menuDel.Caption = "Delete";
            this.menuDel.Id = 1;
            this.menuDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuDel.ImageOptions.Image")));
            this.menuDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuDel.ImageOptions.LargeImage")));
            this.menuDel.Name = "menuDel";
            this.menuDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuDel_ItemClick);
            // 
            // menuCancel
            // 
            this.menuCancel.Caption = "Cancel";
            this.menuCancel.Id = 2;
            this.menuCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuCancel.ImageOptions.Image")));
            this.menuCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuCancel.ImageOptions.LargeImage")));
            this.menuCancel.Name = "menuCancel";
            this.menuCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuCancel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(737, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 453);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(737, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 423);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(737, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 423);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(160, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(390, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "QUẢN LÍ DANH SÁCH PHỤ TÙNG";
            // 
            // grDanhsach
            // 
            this.grDanhsach.Controls.Add(this.dgPhutung);
            this.grDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDanhsach.Location = new System.Drawing.Point(0, 238);
            this.grDanhsach.Name = "grDanhsach";
            this.grDanhsach.Size = new System.Drawing.Size(737, 215);
            this.grDanhsach.TabIndex = 5;
            this.grDanhsach.Text = "Danh sách phụ tùng";
            // 
            // dgPhutung
            // 
            this.dgPhutung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPhutung.Location = new System.Drawing.Point(2, 28);
            this.dgPhutung.MainView = this.gridView1;
            this.dgPhutung.MenuManager = this.barManager1;
            this.dgPhutung.Name = "dgPhutung";
            this.dgPhutung.Size = new System.Drawing.Size(733, 185);
            this.dgPhutung.TabIndex = 0;
            this.dgPhutung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgPhutung;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grThongtin
            // 
            this.grThongtin.Controls.Add(this.groupControl1);
            this.grThongtin.Controls.Add(this.labelControl5);
            this.grThongtin.Controls.Add(this.labelControl4);
            this.grThongtin.Controls.Add(this.labelControl3);
            this.grThongtin.Controls.Add(this.labelControl2);
            this.grThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grThongtin.Location = new System.Drawing.Point(0, 87);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(737, 151);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.Text = "Thông tin phụ tùng";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtThoigianbaohanh);
            this.groupControl1.Controls.Add(this.txtDongia);
            this.groupControl1.Controls.Add(this.txtNuocsanxuat);
            this.groupControl1.Controls.Add(this.txtTenphutung);
            this.groupControl1.Controls.Add(this.txtMaphutung);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(2, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 151);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thông tin phụ tùng";
            // 
            // txtThoigianbaohanh
            // 
            this.txtThoigianbaohanh.EditValue = null;
            this.txtThoigianbaohanh.Location = new System.Drawing.Point(543, 72);
            this.txtThoigianbaohanh.MenuManager = this.barManager1;
            this.txtThoigianbaohanh.Name = "txtThoigianbaohanh";
            this.txtThoigianbaohanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThoigianbaohanh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtThoigianbaohanh.Size = new System.Drawing.Size(160, 22);
            this.txtThoigianbaohanh.TabIndex = 9;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(543, 37);
            this.txtDongia.MenuManager = this.barManager1;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(160, 22);
            this.txtDongia.TabIndex = 8;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtNuocsanxuat
            // 
            this.txtNuocsanxuat.Location = new System.Drawing.Point(201, 111);
            this.txtNuocsanxuat.MenuManager = this.barManager1;
            this.txtNuocsanxuat.Name = "txtNuocsanxuat";
            this.txtNuocsanxuat.Size = new System.Drawing.Size(160, 22);
            this.txtNuocsanxuat.TabIndex = 7;
            // 
            // txtTenphutung
            // 
            this.txtTenphutung.Location = new System.Drawing.Point(201, 75);
            this.txtTenphutung.MenuManager = this.barManager1;
            this.txtTenphutung.Name = "txtTenphutung";
            this.txtTenphutung.Size = new System.Drawing.Size(160, 22);
            this.txtTenphutung.TabIndex = 6;
            // 
            // txtMaphutung
            // 
            this.txtMaphutung.Location = new System.Drawing.Point(201, 40);
            this.txtMaphutung.MenuManager = this.barManager1;
            this.txtMaphutung.Name = "txtMaphutung";
            this.txtMaphutung.Size = new System.Drawing.Size(160, 22);
            this.txtMaphutung.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(408, 76);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(125, 18);
            this.labelControl10.TabIndex = 4;
            this.labelControl10.Text = "Thời gian bảo hành";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(408, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 18);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Đơn giá";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(76, 112);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(96, 18);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Nước sản xuất";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(76, 76);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(89, 18);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Tên phụ tùng";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(76, 41);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(83, 18);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Mã phụ tùng";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(408, 41);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 16);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Đơn giá";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(76, 112);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Nước sản xuất";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(76, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Tên phụ tùng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(76, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(71, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã phụ tùng";
            // 
            // frmPhutung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 453);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.grDanhsach);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmPhutung.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhutung";
            this.Text = "Quản lí phụ tùng";
            this.Load += new System.EventHandler(this.frmPhutung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).EndInit();
            this.grDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhutung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoigianbaohanh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoigianbaohanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuocsanxuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenphutung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaphutung.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem menuSave;
        private DevExpress.XtraBars.BarButtonItem menuDel;
        private DevExpress.XtraBars.BarButtonItem menuCancel;
        private DevExpress.XtraEditors.GroupControl grThongtin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit txtThoigianbaohanh;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private DevExpress.XtraEditors.TextEdit txtNuocsanxuat;
        private DevExpress.XtraEditors.TextEdit txtTenphutung;
        private DevExpress.XtraEditors.TextEdit txtMaphutung;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grDanhsach;
        private DevExpress.XtraGrid.GridControl dgPhutung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}