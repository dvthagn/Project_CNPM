namespace QLXe
{
    partial class frmHoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoadon));
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
            this.dgHoadon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grThongtin = new DevExpress.XtraEditors.GroupControl();
            this.txtNgaythanhlap = new DevExpress.XtraEditors.DateEdit();
            this.cboSoxe = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSohoadon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).BeginInit();
            this.grDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.grThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaythanhlap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaythanhlap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSoxe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSohoadon.Properties)).BeginInit();
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 462);
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
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(737, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(171, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(379, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "QUẢN LÍ DANH SÁCH HÓA ĐƠN";
            // 
            // grDanhsach
            // 
            this.grDanhsach.Controls.Add(this.dgHoadon);
            this.grDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDanhsach.Location = new System.Drawing.Point(0, 222);
            this.grDanhsach.Name = "grDanhsach";
            this.grDanhsach.Size = new System.Drawing.Size(737, 240);
            this.grDanhsach.TabIndex = 5;
            this.grDanhsach.Text = "Danh sách hóa đơn";
            // 
            // dgHoadon
            // 
            this.dgHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHoadon.Location = new System.Drawing.Point(2, 28);
            this.dgHoadon.MainView = this.gridView1;
            this.dgHoadon.MenuManager = this.barManager1;
            this.dgHoadon.Name = "dgHoadon";
            this.dgHoadon.Size = new System.Drawing.Size(733, 210);
            this.dgHoadon.TabIndex = 0;
            this.dgHoadon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgHoadon;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // grThongtin
            // 
            this.grThongtin.Controls.Add(this.txtNgaythanhlap);
            this.grThongtin.Controls.Add(this.cboSoxe);
            this.grThongtin.Controls.Add(this.txtSohoadon);
            this.grThongtin.Controls.Add(this.labelControl4);
            this.grThongtin.Controls.Add(this.labelControl3);
            this.grThongtin.Controls.Add(this.labelControl2);
            this.grThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grThongtin.Location = new System.Drawing.Point(0, 80);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(737, 142);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.Text = "Thông tin hóa đơn";
            // 
            // txtNgaythanhlap
            // 
            this.txtNgaythanhlap.EditValue = null;
            this.txtNgaythanhlap.Location = new System.Drawing.Point(493, 37);
            this.txtNgaythanhlap.MenuManager = this.barManager1;
            this.txtNgaythanhlap.Name = "txtNgaythanhlap";
            this.txtNgaythanhlap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaythanhlap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaythanhlap.Size = new System.Drawing.Size(141, 22);
            this.txtNgaythanhlap.TabIndex = 5;
            // 
            // cboSoxe
            // 
            this.cboSoxe.Location = new System.Drawing.Point(190, 81);
            this.cboSoxe.MenuManager = this.barManager1;
            this.cboSoxe.Name = "cboSoxe";
            this.cboSoxe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSoxe.Properties.PopupView = this.gridLookUpEdit1View;
            this.cboSoxe.Size = new System.Drawing.Size(146, 22);
            this.cboSoxe.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtSohoadon
            // 
            this.txtSohoadon.Location = new System.Drawing.Point(190, 37);
            this.txtSohoadon.MenuManager = this.barManager1;
            this.txtSohoadon.Name = "txtSohoadon";
            this.txtSohoadon.Size = new System.Drawing.Size(146, 22);
            this.txtSohoadon.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(380, 40);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Ngày thành lập";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(89, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Số xe";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số hóa đơn";
            // 
            // frmHoadon
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 482);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.grDanhsach);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmHoadon.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoadon";
            this.Text = "Quản lí hóa đơn";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).EndInit();
            this.grDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaythanhlap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaythanhlap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSoxe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSohoadon.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DateEdit txtNgaythanhlap;
        private DevExpress.XtraEditors.GridLookUpEdit cboSoxe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSohoadon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl grDanhsach;
        private DevExpress.XtraGrid.GridControl dgHoadon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}