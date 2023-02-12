<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QLSV
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QLSV))
        Me.cbLop = New System.Windows.Forms.ComboBox()
        Me.DataSet5 = New QLSV_final.DataSet1()
        Me.lbLop = New System.Windows.Forms.Label()
        Me.cbMaMH = New System.Windows.Forms.ComboBox()
        Me.cbMaKhoa = New System.Windows.Forms.ComboBox()
        Me.lbMaMH = New System.Windows.Forms.Label()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btCapNhat = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.rbNu = New System.Windows.Forms.RadioButton()
        Me.rbNam = New System.Windows.Forms.RadioButton()
        Me.pnExit = New System.Windows.Forms.Panel()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.pnDMSinhVien = New System.Windows.Forms.Panel()
        Me.pnQLSV_Bot = New System.Windows.Forms.Panel()
        Me.dtpNgaySinh = New System.Windows.Forms.DateTimePicker()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.lbMaKhoa = New System.Windows.Forms.Label()
        Me.lbNgaySinh = New System.Windows.Forms.Label()
        Me.lbHoTenSV = New System.Windows.Forms.Label()
        Me.lbMaSV = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.txtHoTenSV = New System.Windows.Forms.TextBox()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.dgQLSV = New System.Windows.Forms.DataGridView()
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LopDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaChiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaMHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTimKiem = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnExit.SuspendLayout()
        Me.pnDMSinhVien.SuspendLayout()
        Me.pnQLSV_Bot.SuspendLayout()
        CType(Me.dgQLSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbLop
        '
        Me.cbLop.DataSource = Me.DataSet5
        Me.cbLop.DisplayMember = "SV.Lop"
        Me.cbLop.FormattingEnabled = True
        Me.cbLop.Location = New System.Drawing.Point(261, 138)
        Me.cbLop.Name = "cbLop"
        Me.cbLop.Size = New System.Drawing.Size(163, 24)
        Me.cbLop.TabIndex = 27
        '
        'DataSet5
        '
        Me.DataSet5.DataSetName = "DataSet1"
        Me.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbLop
        '
        Me.lbLop.AutoSize = True
        Me.lbLop.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLop.Location = New System.Drawing.Point(258, 117)
        Me.lbLop.Name = "lbLop"
        Me.lbLop.Size = New System.Drawing.Size(41, 18)
        Me.lbLop.TabIndex = 26
        Me.lbLop.Text = "Lớp:"
        '
        'cbMaMH
        '
        Me.cbMaMH.DataSource = Me.DataSet5
        Me.cbMaMH.DisplayMember = "SV.MaMH"
        Me.cbMaMH.FormattingEnabled = True
        Me.cbMaMH.Location = New System.Drawing.Point(472, 88)
        Me.cbMaMH.Name = "cbMaMH"
        Me.cbMaMH.Size = New System.Drawing.Size(163, 24)
        Me.cbMaMH.TabIndex = 25
        '
        'cbMaKhoa
        '
        Me.cbMaKhoa.DataSource = Me.DataSet5
        Me.cbMaKhoa.DisplayMember = "SV.MaKhoa"
        Me.cbMaKhoa.FormattingEnabled = True
        Me.cbMaKhoa.Location = New System.Drawing.Point(472, 32)
        Me.cbMaKhoa.Name = "cbMaKhoa"
        Me.cbMaKhoa.Size = New System.Drawing.Size(163, 24)
        Me.cbMaKhoa.TabIndex = 24
        '
        'lbMaMH
        '
        Me.lbMaMH.AutoSize = True
        Me.lbMaMH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaMH.Location = New System.Drawing.Point(469, 67)
        Me.lbMaMH.Name = "lbMaMH"
        Me.lbMaMH.Size = New System.Drawing.Size(100, 18)
        Me.lbMaMH.TabIndex = 17
        Me.lbMaMH.Text = "Mã Môn Học:"
        '
        'btXoa
        '
        Me.btXoa.BackColor = System.Drawing.Color.HotPink
        Me.btXoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btXoa.Location = New System.Drawing.Point(672, 108)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(146, 42)
        Me.btXoa.TabIndex = 15
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = False
        '
        'btCapNhat
        '
        Me.btCapNhat.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btCapNhat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCapNhat.Location = New System.Drawing.Point(672, 60)
        Me.btCapNhat.Name = "btCapNhat"
        Me.btCapNhat.Size = New System.Drawing.Size(146, 42)
        Me.btCapNhat.TabIndex = 14
        Me.btCapNhat.Text = "Cập Nhật"
        Me.btCapNhat.UseVisualStyleBackColor = False
        '
        'btThem
        '
        Me.btThem.BackColor = System.Drawing.Color.Cyan
        Me.btThem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btThem.Location = New System.Drawing.Point(672, 12)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(146, 42)
        Me.btThem.TabIndex = 13
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = False
        '
        'rbNu
        '
        Me.rbNu.AutoSize = True
        Me.rbNu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet5, "SV.GioiTinh", True))
        Me.rbNu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNu.Location = New System.Drawing.Point(180, 127)
        Me.rbNu.Name = "rbNu"
        Me.rbNu.Size = New System.Drawing.Size(55, 22)
        Me.rbNu.TabIndex = 12
        Me.rbNu.TabStop = True
        Me.rbNu.Text = "Nữ."
        Me.rbNu.UseVisualStyleBackColor = True
        '
        'rbNam
        '
        Me.rbNam.AutoSize = True
        Me.rbNam.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet5, "SV.GioiTinh", True))
        Me.rbNam.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNam.Location = New System.Drawing.Point(99, 127)
        Me.rbNam.Name = "rbNam"
        Me.rbNam.Size = New System.Drawing.Size(64, 22)
        Me.rbNam.TabIndex = 11
        Me.rbNam.TabStop = True
        Me.rbNam.Text = "Nam."
        Me.rbNam.UseVisualStyleBackColor = True
        '
        'pnExit
        '
        Me.pnExit.BackColor = System.Drawing.Color.DarkOrange
        Me.pnExit.Controls.Add(Me.btMenu)
        Me.pnExit.Controls.Add(Me.btExit)
        Me.pnExit.Location = New System.Drawing.Point(846, 264)
        Me.pnExit.Name = "pnExit"
        Me.pnExit.Size = New System.Drawing.Size(164, 180)
        Me.pnExit.TabIndex = 2
        '
        'btMenu
        '
        Me.btMenu.BackColor = System.Drawing.Color.LimeGreen
        Me.btMenu.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btMenu.Location = New System.Drawing.Point(21, 33)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(125, 42)
        Me.btMenu.TabIndex = 19
        Me.btMenu.Text = "Menu"
        Me.btMenu.UseVisualStyleBackColor = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.OrangeRed
        Me.btExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btExit.Location = New System.Drawing.Point(21, 105)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(125, 42)
        Me.btExit.TabIndex = 18
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'pnDMSinhVien
        '
        Me.pnDMSinhVien.BackColor = System.Drawing.SystemColors.Control
        Me.pnDMSinhVien.Controls.Add(Me.pnExit)
        Me.pnDMSinhVien.Controls.Add(Me.pnQLSV_Bot)
        Me.pnDMSinhVien.Controls.Add(Me.dgQLSV)
        Me.pnDMSinhVien.Location = New System.Drawing.Point(9, 95)
        Me.pnDMSinhVien.Name = "pnDMSinhVien"
        Me.pnDMSinhVien.Size = New System.Drawing.Size(1013, 447)
        Me.pnDMSinhVien.TabIndex = 6
        '
        'pnQLSV_Bot
        '
        Me.pnQLSV_Bot.BackColor = System.Drawing.Color.SkyBlue
        Me.pnQLSV_Bot.Controls.Add(Me.dtpNgaySinh)
        Me.pnQLSV_Bot.Controls.Add(Me.cbLop)
        Me.pnQLSV_Bot.Controls.Add(Me.lbLop)
        Me.pnQLSV_Bot.Controls.Add(Me.cbMaMH)
        Me.pnQLSV_Bot.Controls.Add(Me.cbMaKhoa)
        Me.pnQLSV_Bot.Controls.Add(Me.lbMaMH)
        Me.pnQLSV_Bot.Controls.Add(Me.btXoa)
        Me.pnQLSV_Bot.Controls.Add(Me.btCapNhat)
        Me.pnQLSV_Bot.Controls.Add(Me.btThem)
        Me.pnQLSV_Bot.Controls.Add(Me.rbNu)
        Me.pnQLSV_Bot.Controls.Add(Me.rbNam)
        Me.pnQLSV_Bot.Controls.Add(Me.lbGioiTinh)
        Me.pnQLSV_Bot.Controls.Add(Me.lbDiaChi)
        Me.pnQLSV_Bot.Controls.Add(Me.lbMaKhoa)
        Me.pnQLSV_Bot.Controls.Add(Me.lbNgaySinh)
        Me.pnQLSV_Bot.Controls.Add(Me.lbHoTenSV)
        Me.pnQLSV_Bot.Controls.Add(Me.lbMaSV)
        Me.pnQLSV_Bot.Controls.Add(Me.txtDiaChi)
        Me.pnQLSV_Bot.Controls.Add(Me.txtHoTenSV)
        Me.pnQLSV_Bot.Controls.Add(Me.txtMaSV)
        Me.pnQLSV_Bot.Location = New System.Drawing.Point(3, 264)
        Me.pnQLSV_Bot.Name = "pnQLSV_Bot"
        Me.pnQLSV_Bot.Size = New System.Drawing.Size(837, 180)
        Me.pnQLSV_Bot.TabIndex = 1
        '
        'dtpNgaySinh
        '
        Me.dtpNgaySinh.CustomFormat = "MM/dd/yy"
        Me.dtpNgaySinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet5, "SV.NgaySinh", True))
        Me.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgaySinh.Location = New System.Drawing.Point(261, 33)
        Me.dtpNgaySinh.Name = "dtpNgaySinh"
        Me.dtpNgaySinh.Size = New System.Drawing.Size(163, 22)
        Me.dtpNgaySinh.TabIndex = 28
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGioiTinh.Location = New System.Drawing.Point(16, 129)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(79, 18)
        Me.lbGioiTinh.TabIndex = 10
        Me.lbGioiTinh.Text = "Giới Tính:"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiaChi.Location = New System.Drawing.Point(258, 67)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(63, 18)
        Me.lbDiaChi.TabIndex = 9
        Me.lbDiaChi.Text = "Địa Chỉ:"
        '
        'lbMaKhoa
        '
        Me.lbMaKhoa.AutoSize = True
        Me.lbMaKhoa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaKhoa.Location = New System.Drawing.Point(469, 12)
        Me.lbMaKhoa.Name = "lbMaKhoa"
        Me.lbMaKhoa.Size = New System.Drawing.Size(74, 18)
        Me.lbMaKhoa.TabIndex = 8
        Me.lbMaKhoa.Text = "Mã Khoa:"
        '
        'lbNgaySinh
        '
        Me.lbNgaySinh.AutoSize = True
        Me.lbNgaySinh.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgaySinh.Location = New System.Drawing.Point(258, 12)
        Me.lbNgaySinh.Name = "lbNgaySinh"
        Me.lbNgaySinh.Size = New System.Drawing.Size(83, 18)
        Me.lbNgaySinh.TabIndex = 7
        Me.lbNgaySinh.Text = "Ngày Sinh:"
        '
        'lbHoTenSV
        '
        Me.lbHoTenSV.AutoSize = True
        Me.lbHoTenSV.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoTenSV.Location = New System.Drawing.Point(16, 67)
        Me.lbHoTenSV.Name = "lbHoTenSV"
        Me.lbHoTenSV.Size = New System.Drawing.Size(86, 18)
        Me.lbHoTenSV.TabIndex = 6
        Me.lbHoTenSV.Text = "Họ Tên SV:"
        '
        'lbMaSV
        '
        Me.lbMaSV.AutoSize = True
        Me.lbMaSV.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMaSV.Location = New System.Drawing.Point(16, 12)
        Me.lbMaSV.Name = "lbMaSV"
        Me.lbMaSV.Size = New System.Drawing.Size(55, 18)
        Me.lbMaSV.TabIndex = 5
        Me.lbMaSV.Text = "Mã SV:"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaChi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet5, "SV.DiaChi", True))
        Me.txtDiaChi.Location = New System.Drawing.Point(261, 88)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDiaChi.Size = New System.Drawing.Size(163, 22)
        Me.txtDiaChi.TabIndex = 4
        '
        'txtHoTenSV
        '
        Me.txtHoTenSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoTenSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet5, "SV.TenSV", True))
        Me.txtHoTenSV.Location = New System.Drawing.Point(19, 88)
        Me.txtHoTenSV.Name = "txtHoTenSV"
        Me.txtHoTenSV.Size = New System.Drawing.Size(195, 22)
        Me.txtHoTenSV.TabIndex = 1
        '
        'txtMaSV
        '
        Me.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet5, "SV.MaSV", True))
        Me.txtMaSV.Location = New System.Drawing.Point(19, 33)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(195, 22)
        Me.txtMaSV.TabIndex = 0
        '
        'dgQLSV
        '
        Me.dgQLSV.AllowUserToAddRows = False
        Me.dgQLSV.AllowUserToDeleteRows = False
        Me.dgQLSV.AllowUserToResizeColumns = False
        Me.dgQLSV.AutoGenerateColumns = False
        Me.dgQLSV.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dgQLSV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgQLSV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhoaDataGridViewTextBoxColumn, Me.LopDataGridViewTextBoxColumn, Me.MaSVDataGridViewTextBoxColumn, Me.TenSVDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.DiaChiDataGridViewTextBoxColumn, Me.MaMHDataGridViewTextBoxColumn})
        Me.dgQLSV.DataMember = "SV"
        Me.dgQLSV.DataSource = Me.DataSet5
        Me.dgQLSV.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgQLSV.Location = New System.Drawing.Point(3, 3)
        Me.dgQLSV.MultiSelect = False
        Me.dgQLSV.Name = "dgQLSV"
        Me.dgQLSV.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgQLSV.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgQLSV.RowHeadersWidth = 51
        Me.dgQLSV.RowTemplate.Height = 24
        Me.dgQLSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgQLSV.Size = New System.Drawing.Size(1007, 255)
        Me.dgQLSV.TabIndex = 0
        '
        'MaKhoaDataGridViewTextBoxColumn
        '
        Me.MaKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn.Name = "MaKhoaDataGridViewTextBoxColumn"
        Me.MaKhoaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'LopDataGridViewTextBoxColumn
        '
        Me.LopDataGridViewTextBoxColumn.DataPropertyName = "Lop"
        Me.LopDataGridViewTextBoxColumn.HeaderText = "Lop"
        Me.LopDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LopDataGridViewTextBoxColumn.Name = "LopDataGridViewTextBoxColumn"
        Me.LopDataGridViewTextBoxColumn.ReadOnly = True
        Me.LopDataGridViewTextBoxColumn.Width = 125
        '
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaSVDataGridViewTextBoxColumn.Width = 125
        '
        'TenSVDataGridViewTextBoxColumn
        '
        Me.TenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV"
        Me.TenSVDataGridViewTextBoxColumn.HeaderText = "TenSV"
        Me.TenSVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenSVDataGridViewTextBoxColumn.Name = "TenSVDataGridViewTextBoxColumn"
        Me.TenSVDataGridViewTextBoxColumn.ReadOnly = True
        Me.TenSVDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.ReadOnly = True
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.ReadOnly = True
        Me.GioiTinhDataGridViewTextBoxColumn.Width = 125
        '
        'DiaChiDataGridViewTextBoxColumn
        '
        Me.DiaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi"
        Me.DiaChiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiaChiDataGridViewTextBoxColumn.Name = "DiaChiDataGridViewTextBoxColumn"
        Me.DiaChiDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiaChiDataGridViewTextBoxColumn.Width = 125
        '
        'MaMHDataGridViewTextBoxColumn
        '
        Me.MaMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.HeaderText = "MaMH"
        Me.MaMHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaMHDataGridViewTextBoxColumn.Name = "MaMHDataGridViewTextBoxColumn"
        Me.MaMHDataGridViewTextBoxColumn.ReadOnly = True
        Me.MaMHDataGridViewTextBoxColumn.Width = 125
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbTimKiem)
        Me.Panel1.Controls.Add(Me.txtTimKiem)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1007, 80)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Tìm Kiếm:"
        '
        'cbTimKiem
        '
        Me.cbTimKiem.FormattingEnabled = True
        Me.cbTimKiem.Location = New System.Drawing.Point(127, 43)
        Me.cbTimKiem.Name = "cbTimKiem"
        Me.cbTimKiem.Size = New System.Drawing.Size(163, 24)
        Me.cbTimKiem.TabIndex = 26
        '
        'txtTimKiem
        '
        Me.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimKiem.Location = New System.Drawing.Point(296, 44)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(381, 22)
        Me.txtTimKiem.TabIndex = 1
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT SV.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     SV"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DESKTOP-BGCQDCK\HAIVAN;Persist Security Info=True" &
    ";Password=haivandg2001;User ID=sa;Initial Catalog=QLSV_Test"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [SV] ([MaKhoa], [Lop], [MaSV], [TenSV], [NgaySinh], [GioiTinh], [DiaC" &
    "hi], [MaMH]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop"), New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("GioiTinh", System.Data.OleDb.OleDbType.VarWChar, 0, "GioiTinh"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("Lop", System.Data.OleDb.OleDbType.VarChar, 0, "Lop"), New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.VarChar, 0, "MaSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("GioiTinh", System.Data.OleDb.OleDbType.VarWChar, 0, "GioiTinh"), New System.Data.OleDb.OleDbParameter("DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, "DiaChi"), New System.Data.OleDb.OleDbParameter("MaMH", System.Data.OleDb.OleDbType.VarChar, 0, "MaMH"), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenSV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_GioiTinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GioiTinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiaChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Lop", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Lop", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_TenSV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_GioiTinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GioiTinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_DiaChi", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_DiaChi", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DiaChi", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaMH", System.Data.OleDb.OleDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaMH", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SV", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("Lop", "Lop"), New System.Data.Common.DataColumnMapping("MaSV", "MaSV"), New System.Data.Common.DataColumnMapping("TenSV", "TenSV"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("GioiTinh", "GioiTinh"), New System.Data.Common.DataColumnMapping("DiaChi", "DiaChi"), New System.Data.Common.DataColumnMapping("MaMH", "MaMH")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'QLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 556)
        Me.Controls.Add(Me.pnDMSinhVien)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "QLSV"
        Me.Text = "QLSV"
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnExit.ResumeLayout(False)
        Me.pnDMSinhVien.ResumeLayout(False)
        Me.pnQLSV_Bot.ResumeLayout(False)
        Me.pnQLSV_Bot.PerformLayout()
        CType(Me.dgQLSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbLop As ComboBox
    Friend WithEvents lbLop As Label
    Friend WithEvents cbMaMH As ComboBox
    Friend WithEvents cbMaKhoa As ComboBox
    Friend WithEvents lbMaMH As Label
    Friend WithEvents btXoa As Button
    Friend WithEvents btCapNhat As Button
    Friend WithEvents btThem As Button
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents pnExit As Panel
    Friend WithEvents btMenu As Button
    Friend WithEvents btExit As Button
    Public WithEvents pnDMSinhVien As Panel
    Friend WithEvents pnQLSV_Bot As Panel
    Friend WithEvents lbGioiTinh As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents lbMaKhoa As Label
    Friend WithEvents lbNgaySinh As Label
    Friend WithEvents lbHoTenSV As Label
    Friend WithEvents lbMaSV As Label
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents txtHoTenSV As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents dgQLSV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbTimKiem As ComboBox
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LopDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiaChiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaMHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet5 As DataSet1
    Friend WithEvents dtpNgaySinh As DateTimePicker
End Class
