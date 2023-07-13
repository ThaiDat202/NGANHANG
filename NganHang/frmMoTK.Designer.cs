namespace NganHang
{
    partial class frmMoTK
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoTK));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnItemAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnItemExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pnlCN = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDetail = new DevExpress.XtraEditors.PanelControl();
            this.cbxCMND = new System.Windows.Forms.ComboBox();
            this.infoKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NGANHANGDataSet = new NganHang.NGANHANGDataSet();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGAYMOTKDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.sODTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.infoKhachHangTableAdapter = new NganHang.NGANHANGDataSetTableAdapters.InfoKhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.TaiKhoanTableAdapter = new NganHang.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.TaiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).BeginInit();
            this.pnlCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYMOTKDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYMOTKDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(478, 136);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(50, 26);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLabel.Location = new System.Drawing.Point(915, 136);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(61, 26);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODTLabel.Location = new System.Drawing.Point(47, 212);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(77, 26);
            sODTLabel.TabIndex = 6;
            sODTLabel.Text = "SODT:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(40, 139);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(84, 26);
            cMNDLabel.TabIndex = 7;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(444, 212);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(84, 26);
            mACNLabel.TabIndex = 8;
            mACNLabel.Text = "MACN:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYMOTKLabel.Location = new System.Drawing.Point(830, 212);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(146, 26);
            nGAYMOTKLabel.TabIndex = 10;
            nGAYMOTKLabel.Text = "NGAYMOTK:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(47, 62);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(76, 28);
            sOTKLabel.TabIndex = 12;
            sOTKLabel.Text = "SOTK:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnItemAdd,
            this.btnItemSave,
            this.btnItemReload,
            this.btnItemUndo,
            this.btnItemExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnItemExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Caption = "Mở tài khoản mới";
            this.btnItemAdd.Enabled = false;
            this.btnItemAdd.Id = 0;
            this.btnItemAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.Image")));
            this.btnItemAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.ImageOptions.LargeImage")));
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemAdd_ItemClick);
            // 
            // btnItemSave
            // 
            this.btnItemSave.Caption = "Ghi";
            this.btnItemSave.Enabled = false;
            this.btnItemSave.Id = 1;
            this.btnItemSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.Image")));
            this.btnItemSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemSave.ImageOptions.LargeImage")));
            this.btnItemSave.Name = "btnItemSave";
            this.btnItemSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemSave_ItemClick);
            // 
            // btnItemReload
            // 
            this.btnItemReload.Caption = "Reload";
            this.btnItemReload.Id = 2;
            this.btnItemReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.Image")));
            this.btnItemReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemReload.ImageOptions.LargeImage")));
            this.btnItemReload.Name = "btnItemReload";
            this.btnItemReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemReload_ItemClick);
            // 
            // btnItemUndo
            // 
            this.btnItemUndo.Caption = "Undo";
            this.btnItemUndo.Enabled = false;
            this.btnItemUndo.Id = 3;
            this.btnItemUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.Image")));
            this.btnItemUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemUndo.ImageOptions.LargeImage")));
            this.btnItemUndo.Name = "btnItemUndo";
            this.btnItemUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemUndo_ItemClick);
            // 
            // btnItemExit
            // 
            this.btnItemExit.Caption = "Thoát";
            this.btnItemExit.Id = 4;
            this.btnItemExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.Image")));
            this.btnItemExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItemExit.ImageOptions.LargeImage")));
            this.btnItemExit.Name = "btnItemExit";
            this.btnItemExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItemExit_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1517, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1517, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1517, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
            // 
            // pnlCN
            // 
            this.pnlCN.Controls.Add(this.cmbChiNhanh);
            this.pnlCN.Controls.Add(this.label1);
            this.pnlCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCN.Location = new System.Drawing.Point(0, 51);
            this.pnlCN.Name = "pnlCN";
            this.pnlCN.Size = new System.Drawing.Size(1517, 113);
            this.pnlCN.TabIndex = 4;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(237, 37);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(368, 36);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.cbxCMND);
            this.pnlDetail.Controls.Add(sOTKLabel);
            this.pnlDetail.Controls.Add(this.txtSoTK);
            this.pnlDetail.Controls.Add(this.nGAYMOTKDateEdit);
            this.pnlDetail.Controls.Add(nGAYMOTKLabel);
            this.pnlDetail.Controls.Add(mACNLabel);
            this.pnlDetail.Controls.Add(this.txtMACN);
            this.pnlDetail.Controls.Add(cMNDLabel);
            this.pnlDetail.Controls.Add(sODTLabel);
            this.pnlDetail.Controls.Add(this.sODTTextEdit);
            this.pnlDetail.Controls.Add(tENLabel);
            this.pnlDetail.Controls.Add(this.tENTextEdit);
            this.pnlDetail.Controls.Add(hOLabel);
            this.pnlDetail.Controls.Add(this.hOTextEdit);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 386);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1517, 285);
            this.pnlDetail.TabIndex = 5;
            // 
            // cbxCMND
            // 
            this.cbxCMND.DataSource = this.infoKhachHangBindingSource;
            this.cbxCMND.DisplayMember = "CMND";
            this.cbxCMND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCMND.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCMND.FormattingEnabled = true;
            this.cbxCMND.Location = new System.Drawing.Point(183, 143);
            this.cbxCMND.Name = "cbxCMND";
            this.cbxCMND.Size = new System.Drawing.Size(218, 36);
            this.cbxCMND.TabIndex = 14;
            this.cbxCMND.ValueMember = "CMND";
            // 
            // infoKhachHangBindingSource
            // 
            this.infoKhachHangBindingSource.DataMember = "InfoKhachHang";
            this.infoKhachHangBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // NGANHANGDataSet
            // 
            this.NGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.NGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoTK
            // 
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaiKhoanBindingSource, "SOTK", true));
            this.txtSoTK.Enabled = false;
            this.txtSoTK.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTK.Location = new System.Drawing.Point(183, 59);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(218, 35);
            this.txtSoTK.TabIndex = 13;
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // nGAYMOTKDateEdit
            // 
            this.nGAYMOTKDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.TaiKhoanBindingSource, "NGAYMOTK", true));
            this.nGAYMOTKDateEdit.EditValue = null;
            this.nGAYMOTKDateEdit.Enabled = false;
            this.nGAYMOTKDateEdit.Location = new System.Drawing.Point(1009, 206);
            this.nGAYMOTKDateEdit.MenuManager = this.barManager1;
            this.nGAYMOTKDateEdit.Name = "nGAYMOTKDateEdit";
            this.nGAYMOTKDateEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nGAYMOTKDateEdit.Properties.Appearance.Options.UseFont = true;
            this.nGAYMOTKDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYMOTKDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYMOTKDateEdit.Size = new System.Drawing.Size(176, 34);
            this.nGAYMOTKDateEdit.TabIndex = 12;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaiKhoanBindingSource, "MACN", true));
            this.txtMACN.Enabled = false;
            this.txtMACN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACN.Location = new System.Drawing.Point(565, 204);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(213, 34);
            this.txtMACN.TabIndex = 9;
            // 
            // sODTTextEdit
            // 
            this.sODTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "SODT", true));
            this.sODTTextEdit.Enabled = false;
            this.sODTTextEdit.Location = new System.Drawing.Point(183, 209);
            this.sODTTextEdit.MenuManager = this.barManager1;
            this.sODTTextEdit.Name = "sODTTextEdit";
            this.sODTTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sODTTextEdit.Properties.Appearance.Options.UseFont = true;
            this.sODTTextEdit.Size = new System.Drawing.Size(218, 32);
            this.sODTTextEdit.TabIndex = 7;
            // 
            // tENTextEdit
            // 
            this.tENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "TEN", true));
            this.tENTextEdit.Enabled = false;
            this.tENTextEdit.Location = new System.Drawing.Point(1009, 133);
            this.tENTextEdit.MenuManager = this.barManager1;
            this.tENTextEdit.Name = "tENTextEdit";
            this.tENTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENTextEdit.Properties.Appearance.Options.UseFont = true;
            this.tENTextEdit.Size = new System.Drawing.Size(176, 32);
            this.tENTextEdit.TabIndex = 5;
            // 
            // hOTextEdit
            // 
            this.hOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.infoKhachHangBindingSource, "HO", true));
            this.hOTextEdit.Enabled = false;
            this.hOTextEdit.Location = new System.Drawing.Point(565, 133);
            this.hOTextEdit.MenuManager = this.barManager1;
            this.hOTextEdit.Name = "hOTextEdit";
            this.hOTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTextEdit.Properties.Appearance.Options.UseFont = true;
            this.hOTextEdit.Size = new System.Drawing.Size(213, 32);
            this.hOTextEdit.TabIndex = 3;
            // 
            // infoKhachHangTableAdapter
            // 
            this.infoKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.TaiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TaiKhoanTableAdapter
            // 
            this.TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // TaiKhoanGridControl
            // 
            this.TaiKhoanGridControl.DataSource = this.TaiKhoanBindingSource;
            this.TaiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaiKhoanGridControl.Location = new System.Drawing.Point(0, 164);
            this.TaiKhoanGridControl.MainView = this.gridView1;
            this.TaiKhoanGridControl.MenuManager = this.barManager1;
            this.TaiKhoanGridControl.Name = "TaiKhoanGridControl";
            this.TaiKhoanGridControl.Size = new System.Drawing.Size(1517, 222);
            this.TaiKhoanGridControl.TabIndex = 9;
            this.TaiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView1.GridControl = this.TaiKhoanGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 94;
            // 
            // frmMoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1517, 671);
            this.Controls.Add(this.TaiKhoanGridControl);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMoTK";
            this.Text = "frmMoTK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMoTK_FormClosed);
            this.Load += new System.EventHandler(this.frmMoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).EndInit();
            this.pnlCN.ResumeLayout(false);
            this.pnlCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYMOTKDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYMOTKDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sODTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraEditors.PanelControl pnlCN;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource infoKhachHangBindingSource;
        private NGANHANGDataSet NGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.InfoKhachHangTableAdapter infoKhachHangTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit sODTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTextEdit;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter TaiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
        private DevExpress.XtraGrid.GridControl TaiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.TextBox txtMACN;
        private DevExpress.XtraEditors.DateEdit nGAYMOTKDateEdit;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.ComboBox cbxCMND;
    }
}