<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLDuLieu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnKhoa = New System.Windows.Forms.Panel()
        Me.pnKhoa_Bot = New System.Windows.Forms.Panel()
        Me.lbTenKhoa = New System.Windows.Forms.Label()
        Me.lbMaKhoa = New System.Windows.Forms.Label()
        Me.btThem = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.txtTenKhoa = New System.Windows.Forms.TextBox()
        Me.DataSet4 = New QLSV_final.DataSet1()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.dgKhoa = New System.Windows.Forms.DataGridView()
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btMH = New System.Windows.Forms.Button()
        Me.pnTab = New System.Windows.Forms.Panel()
        Me.btLop = New System.Windows.Forms.Button()
        Me.btKhoa = New System.Windows.Forms.Button()
        Me.lbLop = New System.Windows.Forms.Label()
        Me.btThemL = New System.Windows.Forms.Button()
        Me.btXoaL = New System.Windows.Forms.Button()
        Me.pnLop_Bot = New System.Windows.Forms.Panel()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.DataSet3 = New QLSV_final.DataSet1()
        Me.pnLop = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.pnExit = New System.Windows.Forms.Panel()
        Me.txtTinChi = New System.Windows.Forms.TextBox()
        Me.DataSet2 = New QLSV_final.DataSet1()
        Me.pnMH_Bot = New System.Windows.Forms.Panel()
        Me.lbTinChi = New System.Windows.Forms.Label()
        Me.lbTenMH = New System.Windows.Forms.Label()
        Me.lbMaMH = New System.Windows.Forms.Label()
        Me.btThemMH = New System.Windows.Forms.Button()
        Me.btCapNhatMH = New System.Windows.Forms.Button()
        Me.btXoaMH = New System.Windows.Forms.Button()
        Me.txtTenMH = New System.Windows.Forms.TextBox()
        Me.txtMaMH = New System.Windows.Forms.TextBox()
        Me.dgMH = New System.Windows.Forms.DataGridView()
        Me.MaMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnMH = New System.Windows.Forms.Panel()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand3 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter3 = New System.Data.OleDb.OleDbDataAdapter()
        Me.pnKhoa.SuspendLayout()
        Me.pnKhoa_Bot.SuspendLayout()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnTab.SuspendLayout()
        Me.pnLop_Bot.SuspendLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLop.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnExit.SuspendLayout()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMH_Bot.SuspendLayout()
        CType(Me.dgMH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMH.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnKhoa
        '
        Me.pnKhoa.Controls.Add(Me.pnKhoa_Bot)
        Me.pnKhoa.Controls.Add(Me.dgKhoa)
        Me.pnKhoa.Location = New System.Drawing.Point(12, 139)
        Me.pnKhoa.Name = "pnKhoa"
        Me.pnKhoa.Size = New System.Drawing.Size(829, 430)
        Me.pnKhoa.TabIndex = 13
        '
        'pnKhoa_Bot
        '
        Me.pnKhoa_Bot.BackColor = System.Drawing.Color.LightPink
        Me.pnKhoa_Bot.Controls.Add(Me.lbTenKhoa)
        Me.pnKhoa_Bot.Controls.Add(Me.lbMaKhoa)
        Me.pnKhoa_Bot.Controls.Add(Me.btThem)
        Me.pnKhoa_Bot.Controls.Add(Me.btCapNhat)
        Me.pnKhoa_Bot.Controls.Add(Me.txtTenKhoa)
        Me.pnKhoa_Bot.Controls.Add(Me.btXoa)
        Me.pnKhoa_Bot.Controls.Add(Me.txtMaKhoa)
        Me.pnKhoa_Bot.Location = New System.Drawing.Point(419, 3)
        Me.pnKhoa_Bot.Name = "pnKhoa_Bot"
        Me.pnKhoa_Bot.Size = New System.Drawing.Size(407, 318)
        Me.pnKhoa_Bot.TabIndex = 1
        '
        'lbTenKhoa
        '
        Me.lbTenKhoa.AutoSize = True
        Me.lbTenKhoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenKhoa.Location = New System.Drawing.Point(21, 89)
        Me.lbTenKhoa.Name = "lbTenKhoa"
        Me.lbTenKhoa.Size = New System.Drawing.Size(81, 18)
        Me.lbTenKhoa.TabIndex = 20
        Me.lbTenKhoa.Text = "Tên Khoa:"
        '
        'lbMaKhoa
        '
        Me.lbMaKhoa.AutoSize = True
        Me.lbMaKhoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaKhoa.Location = New System.Drawing.Point(21, 37)
        Me.lbMaKhoa.Name = "lbMaKhoa"
        Me.lbMaKhoa.Size = New System.Drawing.Size(74, 18)
        Me.lbMaKhoa.TabIndex = 19
        Me.lbMaKhoa.Text = "Mã Khoa:"
        '
        'btThem
        '
        Me.btThem.BackColor = System.Drawing.Color.Cyan
        Me.btThem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThem.Location = New System.Drawing.Point(6, 182)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(125, 42)
        Me.btThem.TabIndex = 18
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = False
        '
        'btCapNhat
        '
        Me.btCapNhat.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btCapNhat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapNhat.Location = New System.Drawing.Point(137, 182)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(125, 42)
        Me.btCapNhat.TabIndex = 17
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = False
        '
        'txtTenKhoa
        '
        Me.txtTenKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet4, "Khoa.TenKhoa", True))
        Me.txtTenKhoa.Location = New System.Drawing.Point(131, 85)
        Me.txtTenKhoa.Name = "txtTenKhoa"
        Me.txtTenKhoa.Size = New System.Drawing.Size(181, 22)
        Me.txtTenKhoa.TabIndex = 1
        '
        'DataSet4
        '
        Me.DataSet4.DataSetName = "DataSet1"
        Me.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btXoa
        '
        Me.btXoa.BackColor = System.Drawing.Color.HotPink
        Me.btXoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoa.Location = New System.Drawing.Point(268, 182)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(125, 42)
        Me.btXoa.TabIndex = 16
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = False
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet4, "Khoa.MaKhoa", True))
        Me.txtMaKhoa.Location = New System.Drawing.Point(131, 33)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(181, 22)
        Me.txtMaKhoa.TabIndex = 0
        '
        'dgKhoa
        '
        Me.dgKhoa.AutoGenerateColumns = False
        Me.dgKhoa.BackgroundColor = System.Drawing.Color.Pink
        Me.dgKhoa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKhoa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhoaDataGridViewTextBoxColumn, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.dgKhoa.DataMember = "Khoa"
        Me.dgKhoa.DataSource = Me.DataSet4
        Me.dgKhoa.Location = New System.Drawing.Point(3, 3)
        Me.dgKhoa.Name = "dgKhoa"
        Me.dgKhoa.RowHeadersWidth = 51
        Me.dgKhoa.RowTemplate.Height = 24
        Me.dgKhoa.Size = New System.Drawing.Size(410, 424)
        Me.dgKhoa.TabIndex = 0
        '
        'MaKhoaDataGridViewTextBoxColumn
        '
        Me.MaKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn.Name = "MaKhoaDataGridViewTextBoxColumn"
        Me.MaKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
        Me.TenKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'btMH
        '
        Me.btMH.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btMH.Cursor = System.Windows.Forms.Cursors.Default
        Me.btMH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btMH.FlatAppearance.BorderSize = 2
        Me.btMH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMH.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMH.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btMH.Location = New System.Drawing.Point(3, 3)
        Me.btMH.Name = "btMH"
        Me.btMH.Size = New System.Drawing.Size(272, 121)
        Me.btMH.TabIndex = 0
        Me.btMH.Text = "Danh Sách Môn"
        Me.btMH.UseVisualStyleBackColor = False
        '
        'pnTab
        '
        Me.pnTab.BackColor = System.Drawing.SystemColors.Control
        Me.pnTab.Controls.Add(Me.btLop)
        Me.pnTab.Controls.Add(Me.btKhoa)
        Me.pnTab.Controls.Add(Me.btMH)
        Me.pnTab.Location = New System.Drawing.Point(12, 12)
        Me.pnTab.Name = "pnTab"
        Me.pnTab.Size = New System.Drawing.Size(829, 127)
        Me.pnTab.TabIndex = 12
        '
        'btLop
        '
        Me.btLop.BackColor = System.Drawing.Color.SpringGreen
        Me.btLop.FlatAppearance.BorderSize = 2
        Me.btLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btLop.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLop.ForeColor = System.Drawing.Color.DarkGreen
        Me.btLop.Location = New System.Drawing.Point(281, 3)
        Me.btLop.Name = "btLop"
        Me.btLop.Size = New System.Drawing.Size(266, 121)
        Me.btLop.TabIndex = 2
        Me.btLop.Text = "Danh Sách Lớp"
        Me.btLop.UseVisualStyleBackColor = False
        '
        'btKhoa
        '
        Me.btKhoa.BackColor = System.Drawing.Color.LightPink
        Me.btKhoa.FlatAppearance.BorderSize = 2
        Me.btKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btKhoa.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btKhoa.ForeColor = System.Drawing.Color.Crimson
        Me.btKhoa.Location = New System.Drawing.Point(553, 3)
        Me.btKhoa.Name = "btKhoa"
        Me.btKhoa.Size = New System.Drawing.Size(273, 121)
        Me.btKhoa.TabIndex = 1
        Me.btKhoa.Text = "Danh Sách Khoa"
        Me.btKhoa.UseVisualStyleBackColor = False
        '
        'lbLop
        '
        Me.lbLop.AutoSize = True
        Me.lbLop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLop.Location = New System.Drawing.Point(21, 37)
        Me.lbLop.Name = "lbLop"
        Me.lbLop.Size = New System.Drawing.Size(73, 18)
        Me.lbLop.TabIndex = 19
        Me.lbLop.Text = "Tên Lớp:"
        '
        'btThemL
        '
        Me.btThemL.BackColor = System.Drawing.Color.Cyan
        Me.btThemL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemL.Location = New System.Drawing.Point(130, 182)
        Me.btThemL.Name = "btThemL"
        Me.btThemL.Size = New System.Drawing.Size(125, 42)
        Me.btThemL.TabIndex = 18
        Me.btThemL.Text = "Thêm"
        Me.btThemL.UseVisualStyleBackColor = False
        '
        'btXoaL
        '
        Me.btXoaL.BackColor = System.Drawing.Color.HotPink
        Me.btXoaL.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaL.Location = New System.Drawing.Point(268, 182)
        Me.btXoaL.Name = "btXoaL"
        Me.btXoaL.Size = New System.Drawing.Size(125, 42)
        Me.btXoaL.TabIndex = 16
        Me.btXoaL.Text = "Xóa"
        Me.btXoaL.UseVisualStyleBackColor = False
        '
        'pnLop_Bot
        '
        Me.pnLop_Bot.BackColor = System.Drawing.Color.SpringGreen
        Me.pnLop_Bot.Controls.Add(Me.lbLop)
        Me.pnLop_Bot.Controls.Add(Me.btThemL)
        Me.pnLop_Bot.Controls.Add(Me.btXoaL)
        Me.pnLop_Bot.Controls.Add(Me.txtLop)
        Me.pnLop_Bot.Location = New System.Drawing.Point(419, 3)
        Me.pnLop_Bot.Name = "pnLop_Bot"
        Me.pnLop_Bot.Size = New System.Drawing.Size(407, 318)
        Me.pnLop_Bot.TabIndex = 1
        '
        'txtLop
        '
        Me.txtLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet3, "Lop.Lop", True))
        Me.txtLop.Location = New System.Drawing.Point(131, 33)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(181, 22)
        Me.txtLop.TabIndex = 0
        '
        'DataSet3
        '
        Me.DataSet3.DataSetName = "DataSet1"
        Me.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnLop
        '
        Me.pnLop.Controls.Add(Me.pnLop_Bot)
        Me.pnLop.Controls.Add(Me.DataGridView1)
        Me.pnLop.Location = New System.Drawing.Point(12, 139)
        Me.pnLop.Name = "pnLop"
        Me.pnLop.Size = New System.Drawing.Size(829, 430)
        Me.pnLop.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumSpringGreen
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LopDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "Lop"
        Me.DataGridView1.DataSource = Me.DataSet3
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(410, 424)
        Me.DataGridView1.TabIndex = 0
        '
        'LopDataGridViewTextBoxColumn
        '
        Me.LopDataGridViewTextBoxColumn.DataPropertyName = "Lop"
        Me.LopDataGridViewTextBoxColumn.HeaderText = "Lop"
        Me.LopDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LopDataGridViewTextBoxColumn.Name = "LopDataGridViewTextBoxColumn"
        Me.LopDataGridViewTextBoxColumn.Width = 125
        '
        'btMenu
        '
        Me.btMenu.BackColor = System.Drawing.Color.LimeGreen
        Me.btMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btMenu.Location = New System.Drawing.Point(64, 30)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(125, 42)
        Me.btMenu.TabIndex = 18
        Me.btMenu.Text = "Menu"
        Me.btMenu.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btExit.Location = New System.Drawing.Point(233, 30)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(125, 42)
        Me.btExit.TabIndex = 17
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'pnExit
        '
        Me.pnExit.BackColor = System.Drawing.Color.DarkOrange
        Me.pnExit.Controls.Add(Me.btMenu)
        Me.pnExit.Controls.Add(Me.btExit)
        Me.pnExit.Location = New System.Drawing.Point(431, 466)
        Me.pnExit.Name = "pnExit"
        Me.pnExit.Size = New System.Drawing.Size(407, 100)
        Me.pnExit.TabIndex = 11
        '
        'txtTinChi
        '
        Me.txtTinChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTinChi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet2, "MH.TinChi", True))
        Me.txtTinChi.Location = New System.Drawing.Point(131, 133)
        Me.txtTinChi.Name = "txtTinChi"
        Me.txtTinChi.Size = New System.Drawing.Size(181, 22)
        Me.txtTinChi.TabIndex = 22
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet1"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnMH_Bot
        '
        Me.pnMH_Bot.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnMH_Bot.Controls.Add(Me.txtTinChi)
        Me.pnMH_Bot.Controls.Add(Me.lbTinChi)
        Me.pnMH_Bot.Controls.Add(Me.lbTenMH)
        Me.pnMH_Bot.Controls.Add(Me.lbMaMH)
        Me.pnMH_Bot.Controls.Add(Me.btThemMH)
        Me.pnMH_Bot.Controls.Add(Me.btCapNhatMH)
        Me.pnMH_Bot.Controls.Add(Me.btXoaMH)
        Me.pnMH_Bot.Controls.Add(Me.txtTenMH)
        Me.pnMH_Bot.Controls.Add(Me.txtMaMH)
        Me.pnMH_Bot.Location = New System.Drawing.Point(419, 3)
        Me.pnMH_Bot.Name = "pnMH_Bot"
        Me.pnMH_Bot.Size = New System.Drawing.Size(407, 318)
        Me.pnMH_Bot.TabIndex = 1
        '
        'lbTinChi
        '
        Me.lbTinChi.AutoSize = True
        Me.lbTinChi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTinChi.Location = New System.Drawing.Point(21, 137)
        Me.lbTinChi.Name = "lbTinChi"
        Me.lbTinChi.Size = New System.Drawing.Size(86, 18)
        Me.lbTinChi.TabIndex = 21
        Me.lbTinChi.Text = "Số Tín Chỉ:"
        '
        'lbTenMH
        '
        Me.lbTenMH.AutoSize = True
        Me.lbTenMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTenMH.Location = New System.Drawing.Point(18, 89)
        Me.lbTenMH.Name = "lbTenMH"
        Me.lbTenMH.Size = New System.Drawing.Size(107, 18)
        Me.lbTenMH.TabIndex = 20
        Me.lbTenMH.Text = "Tên Môn Học:"
        '
        'lbMaMH
        '
        Me.lbMaMH.AutoSize = True
        Me.lbMaMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaMH.Location = New System.Drawing.Point(21, 37)
        Me.lbMaMH.Name = "lbMaMH"
        Me.lbMaMH.Size = New System.Drawing.Size(100, 18)
        Me.lbMaMH.TabIndex = 19
        Me.lbMaMH.Text = "Mã Môn Học:"
        '
        'btThemMH
        '
        Me.btThemMH.BackColor = System.Drawing.Color.Cyan
        Me.btThemMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThemMH.Location = New System.Drawing.Point(6, 182)
        Me.btThemMH.Name = "btThemMH"
        Me.btThemMH.Size = New System.Drawing.Size(125, 42)
        Me.btThemMH.TabIndex = 18
        Me.btThemMH.Text = "Thêm"
        Me.btThemMH.UseVisualStyleBackColor = False
        '
        'btCapNhatMH
        '
        Me.btCapNhatMH.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btCapNhatMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapNhatMH.Location = New System.Drawing.Point(137, 182)
        Me.btCapNhatMH.Name = "btCapNhatMH"
        Me.btCapNhatMH.Size = New System.Drawing.Size(125, 42)
        Me.btCapNhatMH.TabIndex = 17
        Me.btCapNhatMH.Text = "Cập Nhật"
        Me.btCapNhatMH.UseVisualStyleBackColor = False
        '
        'btXoaMH
        '
        Me.btXoaMH.BackColor = System.Drawing.Color.HotPink
        Me.btXoaMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoaMH.Location = New System.Drawing.Point(268, 182)
        Me.btXoaMH.Name = "btXoaMH"
        Me.btXoaMH.Size = New System.Drawing.Size(125, 42)
        Me.btXoaMH.TabIndex = 16
        Me.btXoaMH.Text = "Xóa"
        Me.btXoaMH.UseVisualStyleBackColor = False
        '
        'txtTenMH
        '
        Me.txtTenMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet2, "MH.TenMH", True))
        Me.txtTenMH.Location = New System.Drawing.Point(131, 85)
        Me.txtTenMH.Name = "txtTenMH"
        Me.txtTenMH.Size = New System.Drawing.Size(181, 22)
        Me.txtTenMH.TabIndex = 1
        '
        'txtMaMH
        '
        Me.txtMaMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaMH.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet2, "MH.MaMH", True))
        Me.txtMaMH.Location = New System.Drawing.Point(130, 33)
        Me.txtMaMH.Name = "txtMaMH"
        Me.txtMaMH.Size = New System.Drawing.Size(181, 22)
        Me.txtMaMH.TabIndex = 0
        '
        'dgMH
        '
        Me.dgMH.AutoGenerateColumns = False
        Me.dgMH.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgMH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaMHDataGridViewTextBoxColumn, Me.TenMHDataGridViewTextBoxColumn, Me.TinChiDataGridViewTextBoxColumn})
        Me.dgMH.DataMember = "MH"
        Me.dgMH.DataSource = Me.DataSet2
        Me.dgMH.Location = New System.Drawing.Point(3, 3)
        Me.dgMH.Name = "dgMH"
        Me.dgMH.RowHeadersWidth = 51
        Me.dgMH.RowTemplate.Height = 24
        Me.dgMH.Size = New System.Drawing.Size(410, 424)
        Me.dgMH.TabIndex = 0
        '
        'MaMHDataGridViewTextBoxColumn
        '
        Me.MaMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.HeaderText = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaMHDataGridViewTextBoxColumn.Name = "MaMHDataGridViewTextBoxColumn"
        Me.MaMHDataGridViewTextBoxColumn.Width = 125
        '
        'TenMHDataGridViewTextBoxColumn
        '
        Me.TenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH"
        Me.TenMHDataGridViewTextBoxColumn.HeaderText = "TenMH"
        Me.TenMHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenMHDataGridViewTextBoxColumn.Name = "TenMHDataGridViewTextBoxColumn"
        Me.TenMHDataGridViewTextBoxColumn.Width = 125
        '
        'TinChiDataGridViewTextBoxColumn
        '
        Me.TinChiDataGridViewTextBoxColumn.DataPropertyName = "TinChi"
        Me.TinChiDataGridViewTextBoxColumn.HeaderText = "TinChi"
        Me.TinChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TinChiDataGridViewTextBoxColumn.Name = "TinChiDataGridViewTextBoxColumn"
        Me.TinChiDataGridViewTextBoxColumn.Width = 125
        '
        'pnMH
        '
        Me.pnMH.Controls.Add(Me.pnMH_Bot)
        Me.pnMH.Controls.Add(Me.dgMH)
        Me.pnMH.Location = New System.Drawing.Point(12, 139)
        Me.pnMH.Name = "pnMH"
        Me.pnMH.Size = New System.Drawing.Size(829, 430)
        Me.pnMH.TabIndex = 14
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT MH.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     MH"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-BGCQDCK\HAIVAN;Persist Security Info=True" &
    ";Password=haivandg2001;User ID=sa;Initial Catalog=QLSV_Test"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [MH] ([MaMH], [TenMH], [TinChi]) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenMH"), New System.Data.OleDb.OleDbParameter("TinChi", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TinChi")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [MH] SET [MaMH] = ?, [TenMH] = ?, [TinChi] = ? WHERE (([MaMH] = ?) AND ([T" &
    "enMH] = ?) AND ((? = 1 AND [TinChi] IS NULL) OR ([TinChi] = ?)))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, "TenMH"), New System.Data.OleDb.OleDbParameter("TinChi", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, "TinChi"), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinChi", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinChi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [MH] WHERE (([MaMH] = ?) AND ([TenMH] = ?) AND ((? = 1 AND [TinChi] I" &
    "S NULL) OR ([TinChi] = ?)))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenMH", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenMH", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TinChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TinChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TinChi", System.Data.OleDb.OleDbType.UnsignedTinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TinChi", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MH", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaMH", "MaMH"), New System.Data.Common.DataColumnMapping("TenMH", "TenMH"), New System.Data.Common.DataColumnMapping("TinChi", "TinChi")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT Lop.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Lop"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO [Lop] ([Lop]) VALUES (?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE [Lop] SET [Lop] = ? WHERE (([Lop] = ?))"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop"), New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM [Lop] WHERE (([Lop] = ?))"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lop", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Lop", "Lop")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT Khoa.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     Khoa"
        Me.OleDbSelectCommand3.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand3
        '
        Me.OleDbInsertCommand3.CommandText = "INSERT INTO [Khoa] ([MaKhoa], [TenKhoa]) VALUES (?, ?)"
        Me.OleDbInsertCommand3.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa")})
        '
        'OleDbUpdateCommand3
        '
        Me.OleDbUpdateCommand3.CommandText = "UPDATE [Khoa] SET [MaKhoa] = ?, [TenKhoa] = ? WHERE (([MaKhoa] = ?) AND ([TenKhoa" &
    "] = ?))"
        Me.OleDbUpdateCommand3.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa"), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand3
        '
        Me.OleDbDeleteCommand3.CommandText = "DELETE FROM [Khoa] WHERE (([MaKhoa] = ?) AND ([TenKhoa] = ?))"
        Me.OleDbDeleteCommand3.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand3.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter3
        '
        Me.OleDbDataAdapter3.DeleteCommand = Me.OleDbDeleteCommand3
        Me.OleDbDataAdapter3.InsertCommand = Me.OleDbInsertCommand3
        Me.OleDbDataAdapter3.SelectCommand = Me.OleDbSelectCommand3
        Me.OleDbDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Khoa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("TenKhoa", "TenKhoa")})})
        Me.OleDbDataAdapter3.UpdateCommand = Me.OleDbUpdateCommand3
        '
        'QLDuLieu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 579)
        Me.Controls.Add(Me.pnExit)
        Me.Controls.Add(Me.pnMH)
        Me.Controls.Add(Me.pnLop)
        Me.Controls.Add(Me.pnKhoa)
        Me.Controls.Add(Me.pnTab)
        Me.Name = "QLDuLieu"
        Me.Text = "QLDuLieu"
        Me.pnKhoa.ResumeLayout(False)
        Me.pnKhoa_Bot.ResumeLayout(False)
        Me.pnKhoa_Bot.PerformLayout()
        CType(Me.DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnTab.ResumeLayout(False)
        Me.pnLop_Bot.ResumeLayout(False)
        Me.pnLop_Bot.PerformLayout()
        CType(Me.DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLop.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnExit.ResumeLayout(False)
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMH_Bot.ResumeLayout(False)
        Me.pnMH_Bot.PerformLayout()
        CType(Me.dgMH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMH.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pnKhoa As Panel
    Friend WithEvents pnKhoa_Bot As Panel
    Friend WithEvents lbTenKhoa As Label
    Friend WithEvents lbMaKhoa As Label
    Friend WithEvents btThem As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents txtTenKhoa As TextBox
    Friend WithEvents btXoa As Button
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents dgKhoa As DataGridView
    Friend WithEvents btMH As Button
    Friend WithEvents pnTab As Panel
    Friend WithEvents btLop As Button
    Friend WithEvents btKhoa As Button
    Friend WithEvents lbLop As Label
    Friend WithEvents btThemL As Button
    Friend WithEvents btXoaL As Button
    Friend WithEvents pnLop_Bot As Panel
    Friend WithEvents txtLop As TextBox
    Public WithEvents pnLop As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btMenu As Button
    Friend WithEvents btExit As Button
    Public WithEvents pnExit As Panel
    Friend WithEvents txtTinChi As TextBox
    Friend WithEvents pnMH_Bot As Panel
    Friend WithEvents lbTinChi As Label
    Friend WithEvents lbTenMH As Label
    Friend WithEvents lbMaMH As Label
    Friend WithEvents btThemMH As Button
    Friend WithEvents btCapNhatMH As Button
    Friend WithEvents btXoaMH As Button
    Friend WithEvents txtTenMH As TextBox
    Friend WithEvents txtMaMH As TextBox
    Friend WithEvents dgMH As DataGridView
    Public WithEvents pnMH As Panel
    Friend WithEvents DataSet2 As DataSet1
    Friend WithEvents MaMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TinChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet4 As DataSet1
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet3 As DataSet1
    Friend WithEvents LopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand3 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter3 As OleDb.OleDbDataAdapter
End Class
