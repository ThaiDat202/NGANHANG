namespace NganHang
{
    partial class frmGuiRut
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
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuiRut));
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
            this.cmbSoTK = new System.Windows.Forms.ComboBox();
            this.TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NGANHANGDataSet = new NganHang.NGANHANGDataSet();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            this.GD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.txtSoTien = new DevExpress.XtraEditors.TextEdit();
            this.GD_GOIRUTTableAdapter = new NganHang.NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter();
            this.tableAdapterManager = new NganHang.NGANHANGDataSetTableAdapters.TableAdapterManager();
            this.TaiKhoanTableAdapter = new NganHang.NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter();
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).BeginInit();
            this.pnlCN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(75, 123);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(99, 26);
            sOTIENLabel.TabIndex = 0;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(529, 123);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(83, 26);
            mANVLabel.TabIndex = 2;
            mANVLabel.Text = "MANV:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(908, 49);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(104, 26);
            lOAIGDLabel.TabIndex = 8;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(98, 46);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(76, 28);
            sOTKLabel.TabIndex = 9;
            sOTKLabel.Text = "SOTK:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(529, 46);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(83, 28);
            cMNDLabel.TabIndex = 10;
            cMNDLabel.Text = "CMND:";
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
            this.btnItemAdd.Caption = "Thực hiện giao dịch";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1467, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1034);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1467, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 983);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1467, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 983);
            // 
            // pnlCN
            // 
            this.pnlCN.Controls.Add(this.cmbChiNhanh);
            this.pnlCN.Controls.Add(this.label1);
            this.pnlCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCN.Location = new System.Drawing.Point(0, 51);
            this.pnlCN.Name = "pnlCN";
            this.pnlCN.Size = new System.Drawing.Size(1467, 65);
            this.pnlCN.TabIndex = 4;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(258, 15);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(272, 34);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.cmbSoTK);
            this.pnlDetail.Controls.Add(cMNDLabel);
            this.pnlDetail.Controls.Add(this.txtCMND);
            this.pnlDetail.Controls.Add(sOTKLabel);
            this.pnlDetail.Controls.Add(lOAIGDLabel);
            this.pnlDetail.Controls.Add(this.cmbLoaiGD);
            this.pnlDetail.Controls.Add(mANVLabel);
            this.pnlDetail.Controls.Add(this.txtMANV);
            this.pnlDetail.Controls.Add(sOTIENLabel);
            this.pnlDetail.Controls.Add(this.txtSoTien);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Enabled = false;
            this.pnlDetail.Location = new System.Drawing.Point(0, 860);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1467, 174);
            this.pnlDetail.TabIndex = 5;
            // 
            // cmbSoTK
            // 
            this.cmbSoTK.DataSource = this.TaiKhoanBindingSource;
            this.cmbSoTK.DisplayMember = "SOTK";
            this.cmbSoTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSoTK.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSoTK.FormattingEnabled = true;
            this.cmbSoTK.Location = new System.Drawing.Point(215, 46);
            this.cmbSoTK.Name = "cmbSoTK";
            this.cmbSoTK.Size = new System.Drawing.Size(220, 36);
            this.cmbSoTK.TabIndex = 12;
            this.cmbSoTK.ValueMember = "SOTK";
            // 
            // TaiKhoanBindingSource
            // 
            this.TaiKhoanBindingSource.DataMember = "TaiKhoan";
            this.TaiKhoanBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // NGANHANGDataSet
            // 
            this.NGANHANGDataSet.DataSetName = "NGANHANGDataSet";
            this.NGANHANGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TaiKhoanBindingSource, "CMND", true));
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(650, 43);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(172, 35);
            this.txtCMND.TabIndex = 11;
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GD_GOIRUTBindingSource, "LOAIGD", true));
            this.cmbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiGD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Location = new System.Drawing.Point(1061, 46);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(121, 34);
            this.cmbLoaiGD.TabIndex = 9;
            // 
            // GD_GOIRUTBindingSource
            // 
            this.GD_GOIRUTBindingSource.DataMember = "GD_GOIRUT";
            this.GD_GOIRUTBindingSource.DataSource = this.NGANHANGDataSet;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.GD_GOIRUTBindingSource, "MANV", true));
            this.txtMANV.Enabled = false;
            this.txtMANV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Location = new System.Drawing.Point(650, 120);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(172, 34);
            this.txtMANV.TabIndex = 3;
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.GD_GOIRUTBindingSource, "SOTIEN", true));
            this.txtSoTien.Location = new System.Drawing.Point(215, 122);
            this.txtSoTien.MenuManager = this.barManager1;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Properties.Appearance.Options.UseFont = true;
            this.txtSoTien.Size = new System.Drawing.Size(220, 32);
            this.txtSoTien.TabIndex = 1;
            // 
            // GD_GOIRUTTableAdapter
            // 
            this.GD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.GD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.TaiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.NGANHANGDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // TaiKhoanTableAdapter
            // 
            this.TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.DataSource = this.GD_GOIRUTBindingSource;
            this.gD_GOIRUTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(0, 116);
            this.gD_GOIRUTGridControl.MainView = this.gridView1;
            this.gD_GOIRUTGridControl.MenuManager = this.barManager1;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(1467, 744);
            this.gD_GOIRUTGridControl.TabIndex = 15;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView1.GridControl = this.gD_GOIRUTGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 25;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 94;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            this.colSOTK.Width = 94;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.MinWidth = 25;
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            this.colLOAIGD.Width = 94;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 25;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            this.colNGAYGD.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            this.colSOTIEN.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            this.colMANV.Width = 94;
            // 
            // frmGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1467, 1034);
            this.Controls.Add(this.gD_GOIRUTGridControl);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmGuiRut";
            this.Text = "frmGuiRut";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGuiRut_FormClosed);
            this.Load += new System.EventHandler(this.frmGuiRut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCN)).EndInit();
            this.pnlCN.ResumeLayout(false);
            this.pnlCN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGANHANGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnItemAdd;
        private DevExpress.XtraBars.BarButtonItem btnItemSave;
        private DevExpress.XtraBars.BarButtonItem btnItemReload;
        private DevExpress.XtraBars.BarButtonItem btnItemUndo;
        private DevExpress.XtraBars.BarButtonItem btnItemExit;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl pnlDetail;
        private DevExpress.XtraEditors.PanelControl pnlCN;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource GD_GOIRUTBindingSource;
        private NGANHANGDataSet NGANHANGDataSet;
        private NGANHANGDataSetTableAdapters.GD_GOIRUTTableAdapter GD_GOIRUTTableAdapter;
        private NGANHANGDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private NGANHANGDataSetTableAdapters.TaiKhoanTableAdapter TaiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource TaiKhoanBindingSource;
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private DevExpress.XtraEditors.TextEdit txtSoTien;
        private System.Windows.Forms.TextBox txtMANV;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.ComboBox cmbSoTK;
    }
}