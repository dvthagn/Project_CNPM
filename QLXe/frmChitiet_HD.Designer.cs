namespace QLXe
{
    partial class frmChitiet_HD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChitiet_HD));
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
            this.dgChitiethoadon = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grThongtin = new DevExpress.XtraEditors.GroupControl();
            this.cboMaphutung = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboSohoadon = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDongia = new DevExpress.XtraEditors.TextEdit();
            this.txtSoluong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).BeginInit();
            this.grDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChitiethoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.grThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaphutung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSohoadon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).BeginInit();
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
            this.bar1.FloatLocation = new System.Drawing.Point(98, 151);
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
            this.barDockControlTop.Size = new System.Drawing.Size(737, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 438);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(737, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 408);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(737, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 408);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(120, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(496, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "QUẢN LÍ DANH SÁCH CHI TIẾT HÓA ĐƠN";
            // 
            // grDanhsach
            // 
            this.grDanhsach.Controls.Add(this.dgChitiethoadon);
            this.grDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDanhsach.Location = new System.Drawing.Point(0, 232);
            this.grDanhsach.Name = "grDanhsach";
            this.grDanhsach.Size = new System.Drawing.Size(737, 206);
            this.grDanhsach.TabIndex = 5;
            this.grDanhsach.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dgChitiethoadon
            // 
            this.dgChitiethoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChitiethoadon.Location = new System.Drawing.Point(2, 28);
            this.dgChitiethoadon.MainView = this.gridView2;
            this.dgChitiethoadon.MenuManager = this.barManager1;
            this.dgChitiethoadon.Name = "dgChitiethoadon";
            this.dgChitiethoadon.Size = new System.Drawing.Size(733, 176);
            this.dgChitiethoadon.TabIndex = 0;
            this.dgChitiethoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.dgChitiethoadon;
            this.gridView2.Name = "gridView2";
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
            // 
            // grThongtin
            // 
            this.grThongtin.Appearance.BackColor = System.Drawing.Color.White;
            this.grThongtin.Appearance.Options.UseBackColor = true;
            this.grThongtin.Controls.Add(this.cboMaphutung);
            this.grThongtin.Controls.Add(this.cboSohoadon);
            this.grThongtin.Controls.Add(this.txtDongia);
            this.grThongtin.Controls.Add(this.txtSoluong);
            this.grThongtin.Controls.Add(this.labelControl6);
            this.grThongtin.Controls.Add(this.labelControl5);
            this.grThongtin.Controls.Add(this.labelControl4);
            this.grThongtin.Controls.Add(this.labelControl3);
            this.grThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grThongtin.Location = new System.Drawing.Point(0, 85);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(737, 147);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.Text = "Thông tin chi tiết hóa đơn";
            // 
            // cboMaphutung
            // 
            this.cboMaphutung.Location = new System.Drawing.Point(195, 92);
            this.cboMaphutung.MenuManager = this.barManager1;
            this.cboMaphutung.Name = "cboMaphutung";
            this.cboMaphutung.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMaphutung.Properties.PopupView = this.gridView1;
            this.cboMaphutung.Size = new System.Drawing.Size(146, 22);
            this.cboMaphutung.TabIndex = 7;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboSohoadon
            // 
            this.cboSohoadon.Location = new System.Drawing.Point(195, 39);
            this.cboSohoadon.MenuManager = this.barManager1;
            this.cboSohoadon.Name = "cboSohoadon";
            this.cboSohoadon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSohoadon.Properties.PopupView = this.gridLookUpEdit1View;
            this.cboSohoadon.Size = new System.Drawing.Size(146, 22);
            this.cboSohoadon.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(502, 92);
            this.txtDongia.MenuManager = this.barManager1;
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(151, 22);
            this.txtDongia.TabIndex = 5;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(502, 39);
            this.txtSoluong.MenuManager = this.barManager1;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(151, 22);
            this.txtSoluong.TabIndex = 4;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(419, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 18);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Số lượng";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(419, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Đơn giá";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(104, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 18);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mã phụ tùng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(104, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số hóa đơn";
            // 
            // frmChitiet_HD
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 458);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.grDanhsach);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmChitiet_HD.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChitiet_HD";
            this.Text = "Quản lí chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.frmChitiet_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).EndInit();
            this.grDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChitiethoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboMaphutung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSohoadon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDongia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoluong.Properties)).EndInit();
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
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl grDanhsach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cboMaphutung;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit cboSohoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDongia;
        private DevExpress.XtraEditors.TextEdit txtSoluong;
        private DevExpress.XtraGrid.GridControl dgChitiethoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}