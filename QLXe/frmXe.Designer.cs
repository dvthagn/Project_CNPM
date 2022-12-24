namespace QLXe
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.menuSave = new DevExpress.XtraBars.BarButtonItem();
            this.menuDel = new DevExpress.XtraBars.BarButtonItem();
            this.menuCancel = new DevExpress.XtraBars.BarButtonItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.grDanhsach = new DevExpress.XtraEditors.GroupControl();
            this.grThongtin = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoxe = new DevExpress.XtraEditors.TextEdit();
            this.cboMakhach = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtHieuxe = new DevExpress.XtraEditors.TextEdit();
            this.txtSosuon = new DevExpress.XtraEditors.TextEdit();
            this.txtSomay = new DevExpress.XtraEditors.TextEdit();
            this.txtNgaymua = new DevExpress.XtraEditors.DateEdit();
            this.txtGiamua = new DevExpress.XtraEditors.TextEdit();
            this.dgXe = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).BeginInit();
            this.grDanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).BeginInit();
            this.grThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoxe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMakhach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHieuxe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSosuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSomay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaymua.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaymua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.barButtonItem1,
            this.menuSave,
            this.menuDel,
            this.menuCancel});
            this.barManager1.MaxItemId = 4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(763, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(763, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(763, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // menuSave
            // 
            this.menuSave.Caption = "Save";
            this.menuSave.Id = 1;
            this.menuSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.menuSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.menuSave.Name = "menuSave";
            this.menuSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuSave_ItemClick);
            // 
            // menuDel
            // 
            this.menuDel.Caption = "Delete";
            this.menuDel.Id = 2;
            this.menuDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.menuDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.menuDel.Name = "menuDel";
            // 
            // menuCancel
            // 
            this.menuCancel.Caption = "Cancel";
            this.menuCancel.Id = 3;
            this.menuCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.menuCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.menuCancel.Name = "menuCancel";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(200, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(292, 33);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "QUẢN LÍ DANH SÁCH XE";
            // 
            // grDanhsach
            // 
            this.grDanhsach.Controls.Add(this.dgXe);
            this.grDanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDanhsach.Location = new System.Drawing.Point(0, 249);
            this.grDanhsach.Name = "grDanhsach";
            this.grDanhsach.Size = new System.Drawing.Size(763, 220);
            this.grDanhsach.TabIndex = 5;
            this.grDanhsach.Text = "Danh sách xe";
            // 
            // grThongtin
            // 
            this.grThongtin.Controls.Add(this.txtGiamua);
            this.grThongtin.Controls.Add(this.txtNgaymua);
            this.grThongtin.Controls.Add(this.txtSomay);
            this.grThongtin.Controls.Add(this.txtSosuon);
            this.grThongtin.Controls.Add(this.txtHieuxe);
            this.grThongtin.Controls.Add(this.cboMakhach);
            this.grThongtin.Controls.Add(this.txtSoxe);
            this.grThongtin.Controls.Add(this.labelControl8);
            this.grThongtin.Controls.Add(this.labelControl7);
            this.grThongtin.Controls.Add(this.labelControl6);
            this.grThongtin.Controls.Add(this.labelControl2);
            this.grThongtin.Controls.Add(this.labelControl5);
            this.grThongtin.Controls.Add(this.labelControl4);
            this.grThongtin.Controls.Add(this.labelControl3);
            this.grThongtin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grThongtin.Location = new System.Drawing.Point(0, 67);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(763, 182);
            this.grThongtin.TabIndex = 6;
            this.grThongtin.Text = "Thông tin xe";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 143);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số sườn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(69, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 18);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Số xe";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(69, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 18);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mã khách";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(69, 110);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Hiệu xe";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(440, 41);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 18);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Số máy";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(440, 75);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 18);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Ngày mua";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(440, 110);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(54, 18);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Giá mua";
            // 
            // txtSoxe
            // 
            this.txtSoxe.Location = new System.Drawing.Point(176, 38);
            this.txtSoxe.MenuManager = this.barManager1;
            this.txtSoxe.Name = "txtSoxe";
            this.txtSoxe.Size = new System.Drawing.Size(176, 22);
            this.txtSoxe.TabIndex = 6;
            // 
            // cboMakhach
            // 
            this.cboMakhach.Location = new System.Drawing.Point(176, 72);
            this.cboMakhach.MenuManager = this.barManager1;
            this.cboMakhach.Name = "cboMakhach";
            this.cboMakhach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMakhach.Properties.PopupView = this.gridLookUpEdit1View;
            this.cboMakhach.Size = new System.Drawing.Size(142, 22);
            this.cboMakhach.TabIndex = 7;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtHieuxe
            // 
            this.txtHieuxe.Location = new System.Drawing.Point(176, 104);
            this.txtHieuxe.MenuManager = this.barManager1;
            this.txtHieuxe.Name = "txtHieuxe";
            this.txtHieuxe.Size = new System.Drawing.Size(176, 22);
            this.txtHieuxe.TabIndex = 8;
            // 
            // txtSosuon
            // 
            this.txtSosuon.Location = new System.Drawing.Point(176, 140);
            this.txtSosuon.MenuManager = this.barManager1;
            this.txtSosuon.Name = "txtSosuon";
            this.txtSosuon.Size = new System.Drawing.Size(176, 22);
            this.txtSosuon.TabIndex = 9;
            // 
            // txtSomay
            // 
            this.txtSomay.Location = new System.Drawing.Point(538, 38);
            this.txtSomay.MenuManager = this.barManager1;
            this.txtSomay.Name = "txtSomay";
            this.txtSomay.Size = new System.Drawing.Size(176, 22);
            this.txtSomay.TabIndex = 10;
            // 
            // txtNgaymua
            // 
            this.txtNgaymua.EditValue = null;
            this.txtNgaymua.Location = new System.Drawing.Point(538, 69);
            this.txtNgaymua.MenuManager = this.barManager1;
            this.txtNgaymua.Name = "txtNgaymua";
            this.txtNgaymua.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaymua.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgaymua.Size = new System.Drawing.Size(152, 22);
            this.txtNgaymua.TabIndex = 11;
            // 
            // txtGiamua
            // 
            this.txtGiamua.Location = new System.Drawing.Point(538, 107);
            this.txtGiamua.MenuManager = this.barManager1;
            this.txtGiamua.Name = "txtGiamua";
            this.txtGiamua.Size = new System.Drawing.Size(176, 22);
            this.txtGiamua.TabIndex = 12;
            // 
            // dgXe
            // 
            this.dgXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgXe.Location = new System.Drawing.Point(2, 28);
            this.dgXe.MainView = this.gridView1;
            this.dgXe.MenuManager = this.barManager1;
            this.dgXe.Name = "dgXe";
            this.dgXe.Size = new System.Drawing.Size(759, 190);
            this.dgXe.TabIndex = 0;
            this.dgXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgXe;
            this.gridView1.Name = "gridView1";
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 469);
            this.Controls.Add(this.grThongtin);
            this.Controls.Add(this.grDanhsach);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmXe.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXe";
            this.Text = "Quản lí danh sách xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grDanhsach)).EndInit();
            this.grDanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grThongtin)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoxe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMakhach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHieuxe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSosuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSomay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaymua.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgaymua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtGiamua;
        private DevExpress.XtraEditors.DateEdit txtNgaymua;
        private DevExpress.XtraEditors.TextEdit txtSomay;
        private DevExpress.XtraEditors.TextEdit txtSosuon;
        private DevExpress.XtraEditors.TextEdit txtHieuxe;
        private DevExpress.XtraEditors.GridLookUpEdit cboMakhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSoxe;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl grDanhsach;
        private DevExpress.XtraGrid.GridControl dgXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}