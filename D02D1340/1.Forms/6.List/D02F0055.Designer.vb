<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0055
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0055))
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.chkUseFormular = New System.Windows.Forms.CheckBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.tdbcNormCreatorID = New C1.Win.C1List.C1Combo()
        Me.chkDisabled = New System.Windows.Forms.CheckBox()
        Me.c1dateNormDate = New C1.Win.C1Input.C1DateEdit()
        Me.txtNormNo = New System.Windows.Forms.TextBox()
        Me.lblNormNo = New System.Windows.Forms.Label()
        Me.lblteNormDate = New System.Windows.Forms.Label()
        Me.lblNormCreatorID = New System.Windows.Forms.Label()
        Me.txtNormCreatorName = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grpGuide = New System.Windows.Forms.GroupBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtFormular = New System.Windows.Forms.TextBox()
        Me.btnCloseFrame = New System.Windows.Forms.Button()
        Me.lblFormular = New System.Windows.Forms.Label()
        Me.grpValue = New System.Windows.Forms.GroupBox()
        Me.txtFormular1 = New System.Windows.Forms.TextBox()
        Me.tdbcGroupTypeID = New C1.Win.C1List.C1Combo()
        Me.tdbcMaxDepField02 = New C1.Win.C1List.C1Combo()
        Me.cboMaxDepOperator = New System.Windows.Forms.ComboBox()
        Me.tdbcMaxDepField01 = New C1.Win.C1List.C1Combo()
        Me.tdbcMinDepField02 = New C1.Win.C1List.C1Combo()
        Me.cboMinDepOperator = New System.Windows.Forms.ComboBox()
        Me.tdbcMinDepField01 = New C1.Win.C1List.C1Combo()
        Me.tdbcDepField02 = New C1.Win.C1List.C1Combo()
        Me.cboDepOperator = New System.Windows.Forms.ComboBox()
        Me.tdbcDepField01 = New C1.Win.C1List.C1Combo()
        Me.lblDepFile01 = New System.Windows.Forms.Label()
        Me.lblMinDepField01 = New System.Windows.Forms.Label()
        Me.lblMaxDepField01 = New System.Windows.Forms.Label()
        Me.lblGroupTypeID = New System.Windows.Forms.Label()
        Me.txtGroupTypeName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnGuide = New System.Windows.Forms.Button()
        Me.grp1.SuspendLayout()
        CType(Me.tdbcNormCreatorID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1dateNormDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGuide.SuspendLayout()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpValue.SuspendLayout()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcMaxDepField02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcMaxDepField01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcMinDepField02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcMinDepField01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDepField02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcDepField01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.chkUseFormular)
        Me.grp1.Controls.Add(Me.txtDescription)
        Me.grp1.Controls.Add(Me.tdbcNormCreatorID)
        Me.grp1.Controls.Add(Me.chkDisabled)
        Me.grp1.Controls.Add(Me.c1dateNormDate)
        Me.grp1.Controls.Add(Me.txtNormNo)
        Me.grp1.Controls.Add(Me.lblNormNo)
        Me.grp1.Controls.Add(Me.lblteNormDate)
        Me.grp1.Controls.Add(Me.lblNormCreatorID)
        Me.grp1.Controls.Add(Me.txtNormCreatorName)
        Me.grp1.Controls.Add(Me.lblDescription)
        Me.grp1.Location = New System.Drawing.Point(5, 9)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(513, 131)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        '
        'chkUseFormular
        '
        Me.chkUseFormular.AutoSize = True
        Me.chkUseFormular.Location = New System.Drawing.Point(108, 103)
        Me.chkUseFormular.Name = "chkUseFormular"
        Me.chkUseFormular.Size = New System.Drawing.Size(129, 19)
        Me.chkUseFormular.TabIndex = 10
        Me.chkUseFormular.Text = "Thiết lập công thức"
        Me.chkUseFormular.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDescription.Location = New System.Drawing.Point(108, 74)
        Me.txtDescription.MaxLength = 150
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(394, 20)
        Me.txtDescription.TabIndex = 9
        '
        'tdbcNormCreatorID
        '
        Me.tdbcNormCreatorID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcNormCreatorID.AllowColMove = False
        Me.tdbcNormCreatorID.AllowColSelect = True
        Me.tdbcNormCreatorID.AllowSort = False
        Me.tdbcNormCreatorID.AlternatingRows = True
        Me.tdbcNormCreatorID.AutoCompletion = True
        Me.tdbcNormCreatorID.AutoDropDown = True
        Me.tdbcNormCreatorID.Caption = ""
        Me.tdbcNormCreatorID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcNormCreatorID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcNormCreatorID.DisplayMember = "EmployeeID"
        Me.tdbcNormCreatorID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcNormCreatorID.DropDownWidth = 500
        Me.tdbcNormCreatorID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcNormCreatorID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcNormCreatorID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcNormCreatorID.EmptyRows = True
        Me.tdbcNormCreatorID.ExtendRightColumn = True
        Me.tdbcNormCreatorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcNormCreatorID.Images.Add(CType(resources.GetObject("tdbcNormCreatorID.Images"), System.Drawing.Image))
        Me.tdbcNormCreatorID.Location = New System.Drawing.Point(108, 44)
        Me.tdbcNormCreatorID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcNormCreatorID.MaxDropDownItems = CType(8, Short)
        Me.tdbcNormCreatorID.MaxLength = 32767
        Me.tdbcNormCreatorID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcNormCreatorID.Name = "tdbcNormCreatorID"
        Me.tdbcNormCreatorID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcNormCreatorID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcNormCreatorID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcNormCreatorID.TabIndex = 6
        Me.tdbcNormCreatorID.ValueMember = "EmployeeID"
        Me.tdbcNormCreatorID.PropBag = resources.GetString("tdbcNormCreatorID.PropBag")
        '
        'chkDisabled
        '
        Me.chkDisabled.AutoSize = True
        Me.chkDisabled.Location = New System.Drawing.Point(406, 18)
        Me.chkDisabled.Name = "chkDisabled"
        Me.chkDisabled.Size = New System.Drawing.Size(109, 19)
        Me.chkDisabled.TabIndex = 4
        Me.chkDisabled.Text = "Không sử dụng"
        Me.chkDisabled.UseVisualStyleBackColor = True
        '
        'c1dateNormDate
        '
        Me.c1dateNormDate.AutoSize = False
        Me.c1dateNormDate.CustomFormat = "dd/MM/yyyy"
        Me.c1dateNormDate.EmptyAsNull = True
        Me.c1dateNormDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.c1dateNormDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.c1dateNormDate.Location = New System.Drawing.Point(293, 15)
        Me.c1dateNormDate.Name = "c1dateNormDate"
        Me.c1dateNormDate.Size = New System.Drawing.Size(100, 22)
        Me.c1dateNormDate.TabIndex = 3
        Me.c1dateNormDate.Tag = Nothing
        Me.c1dateNormDate.TrimStart = True
        Me.c1dateNormDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'txtNormNo
        '
        Me.txtNormNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNormNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtNormNo.Location = New System.Drawing.Point(108, 15)
        Me.txtNormNo.MaxLength = 20
        Me.txtNormNo.Name = "txtNormNo"
        Me.txtNormNo.Size = New System.Drawing.Size(128, 20)
        Me.txtNormNo.TabIndex = 1
        '
        'lblNormNo
        '
        Me.lblNormNo.AutoSize = True
        Me.lblNormNo.Location = New System.Drawing.Point(5, 20)
        Me.lblNormNo.Name = "lblNormNo"
        Me.lblNormNo.Size = New System.Drawing.Size(96, 15)
        Me.lblNormNo.TabIndex = 0
        Me.lblNormNo.Text = "Mã bộ định mức"
        Me.lblNormNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblteNormDate
        '
        Me.lblteNormDate.AutoSize = True
        Me.lblteNormDate.Location = New System.Drawing.Point(244, 20)
        Me.lblteNormDate.Name = "lblteNormDate"
        Me.lblteNormDate.Size = New System.Drawing.Size(35, 15)
        Me.lblteNormDate.TabIndex = 2
        Me.lblteNormDate.Text = "Ngày"
        Me.lblteNormDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNormCreatorID
        '
        Me.lblNormCreatorID.AutoSize = True
        Me.lblNormCreatorID.Location = New System.Drawing.Point(5, 49)
        Me.lblNormCreatorID.Name = "lblNormCreatorID"
        Me.lblNormCreatorID.Size = New System.Drawing.Size(86, 15)
        Me.lblNormCreatorID.TabIndex = 5
        Me.lblNormCreatorID.Text = "Người thiết lập"
        Me.lblNormCreatorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNormCreatorName
        '
        Me.txtNormCreatorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtNormCreatorName.Location = New System.Drawing.Point(240, 44)
        Me.txtNormCreatorName.Name = "txtNormCreatorName"
        Me.txtNormCreatorName.ReadOnly = True
        Me.txtNormCreatorName.Size = New System.Drawing.Size(262, 20)
        Me.txtNormCreatorName.TabIndex = 7
        Me.txtNormCreatorName.TabStop = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(5, 79)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(56, 15)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Diễn giải"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpGuide
        '
        Me.grpGuide.BackColor = System.Drawing.SystemColors.Control
        Me.grpGuide.Controls.Add(Me.btnSelect)
        Me.grpGuide.Controls.Add(Me.tdbg)
        Me.grpGuide.Controls.Add(Me.txtFormular)
        Me.grpGuide.Controls.Add(Me.btnCloseFrame)
        Me.grpGuide.Controls.Add(Me.lblFormular)
        Me.grpGuide.Location = New System.Drawing.Point(55, -5)
        Me.grpGuide.Name = "grpGuide"
        Me.grpGuide.Size = New System.Drawing.Size(421, 293)
        Me.grpGuide.TabIndex = 6
        Me.grpGuide.TabStop = False
        Me.grpGuide.Visible = False
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(351, 254)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(61, 22)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "&Chọn"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'tdbg
        '
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowSort = False
        Me.tdbg.AllowUpdate = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.ColumnHeaders = False
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(8, 31)
        Me.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.RecordSelectors = False
        Me.tdbg.Size = New System.Drawing.Size(404, 208)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 1
        Me.tdbg.Tag = "COL"
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        '
        'txtFormular
        '
        Me.txtFormular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtFormular.ForeColor = System.Drawing.Color.Blue
        Me.txtFormular.Location = New System.Drawing.Point(81, 254)
        Me.txtFormular.MaxLength = 100
        Me.txtFormular.Name = "txtFormular"
        Me.txtFormular.Size = New System.Drawing.Size(264, 20)
        Me.txtFormular.TabIndex = 3
        '
        'btnCloseFrame
        '
        Me.btnCloseFrame.Image = Global.D02D1340.My.Resources.Resources.Stop_hov
        Me.btnCloseFrame.Location = New System.Drawing.Point(404, 5)
        Me.btnCloseFrame.Name = "btnCloseFrame"
        Me.btnCloseFrame.Size = New System.Drawing.Size(17, 17)
        Me.btnCloseFrame.TabIndex = 0
        Me.btnCloseFrame.UseVisualStyleBackColor = True
        '
        'lblFormular
        '
        Me.lblFormular.AutoSize = True
        Me.lblFormular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormular.Location = New System.Drawing.Point(8, 259)
        Me.lblFormular.Name = "lblFormular"
        Me.lblFormular.Size = New System.Drawing.Size(62, 15)
        Me.lblFormular.TabIndex = 2
        Me.lblFormular.Text = "Công thức"
        Me.lblFormular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpValue
        '
        Me.grpValue.Controls.Add(Me.txtFormular1)
        Me.grpValue.Controls.Add(Me.tdbcGroupTypeID)
        Me.grpValue.Controls.Add(Me.tdbcMaxDepField02)
        Me.grpValue.Controls.Add(Me.cboMaxDepOperator)
        Me.grpValue.Controls.Add(Me.tdbcMaxDepField01)
        Me.grpValue.Controls.Add(Me.tdbcMinDepField02)
        Me.grpValue.Controls.Add(Me.cboMinDepOperator)
        Me.grpValue.Controls.Add(Me.tdbcMinDepField01)
        Me.grpValue.Controls.Add(Me.tdbcDepField02)
        Me.grpValue.Controls.Add(Me.cboDepOperator)
        Me.grpValue.Controls.Add(Me.tdbcDepField01)
        Me.grpValue.Controls.Add(Me.lblDepFile01)
        Me.grpValue.Controls.Add(Me.lblMinDepField01)
        Me.grpValue.Controls.Add(Me.lblMaxDepField01)
        Me.grpValue.Controls.Add(Me.lblGroupTypeID)
        Me.grpValue.Controls.Add(Me.txtGroupTypeName)
        Me.grpValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValue.Location = New System.Drawing.Point(5, 151)
        Me.grpValue.Name = "grpValue"
        Me.grpValue.Size = New System.Drawing.Size(513, 152)
        Me.grpValue.TabIndex = 1
        Me.grpValue.TabStop = False
        Me.grpValue.Text = "Giá trị hằng"
        '
        'txtFormular1
        '
        Me.txtFormular1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtFormular1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFormular1.Location = New System.Drawing.Point(148, 27)
        Me.txtFormular1.MaxLength = 100
        Me.txtFormular1.Name = "txtFormular1"
        Me.txtFormular1.Size = New System.Drawing.Size(349, 20)
        Me.txtFormular1.TabIndex = 4
        Me.txtFormular1.Visible = False
        '
        'tdbcGroupTypeID
        '
        Me.tdbcGroupTypeID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupTypeID.AllowColMove = False
        Me.tdbcGroupTypeID.AllowColSelect = True
        Me.tdbcGroupTypeID.AllowSort = False
        Me.tdbcGroupTypeID.AlternatingRows = True
        Me.tdbcGroupTypeID.AutoCompletion = True
        Me.tdbcGroupTypeID.AutoDropDown = True
        Me.tdbcGroupTypeID.Caption = ""
        Me.tdbcGroupTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupTypeID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupTypeID.DisplayMember = "GroupTypeID"
        Me.tdbcGroupTypeID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupTypeID.DropDownWidth = 500
        Me.tdbcGroupTypeID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupTypeID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupTypeID.EmptyRows = True
        Me.tdbcGroupTypeID.ExtendRightColumn = True
        Me.tdbcGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupTypeID.Images.Add(CType(resources.GetObject("tdbcGroupTypeID.Images"), System.Drawing.Image))
        Me.tdbcGroupTypeID.Location = New System.Drawing.Point(148, 116)
        Me.tdbcGroupTypeID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupTypeID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupTypeID.MaxLength = 32767
        Me.tdbcGroupTypeID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupTypeID.Name = "tdbcGroupTypeID"
        Me.tdbcGroupTypeID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupTypeID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupTypeID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcGroupTypeID.TabIndex = 14
        Me.tdbcGroupTypeID.ValueMember = "GroupTypeID"
        Me.tdbcGroupTypeID.PropBag = resources.GetString("tdbcGroupTypeID.PropBag")
        '
        'tdbcMaxDepField02
        '
        Me.tdbcMaxDepField02.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMaxDepField02.AllowColMove = False
        Me.tdbcMaxDepField02.AllowSort = False
        Me.tdbcMaxDepField02.AlternatingRows = True
        Me.tdbcMaxDepField02.AutoCompletion = True
        Me.tdbcMaxDepField02.AutoDropDown = True
        Me.tdbcMaxDepField02.Caption = ""
        Me.tdbcMaxDepField02.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMaxDepField02.ColumnWidth = 100
        Me.tdbcMaxDepField02.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMaxDepField02.DisplayMember = "Caption"
        Me.tdbcMaxDepField02.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMaxDepField02.DropDownWidth = 140
        Me.tdbcMaxDepField02.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMaxDepField02.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMaxDepField02.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMaxDepField02.EmptyRows = True
        Me.tdbcMaxDepField02.ExtendRightColumn = True
        Me.tdbcMaxDepField02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMaxDepField02.Images.Add(CType(resources.GetObject("tdbcMaxDepField02.Images"), System.Drawing.Image))
        Me.tdbcMaxDepField02.Location = New System.Drawing.Point(369, 86)
        Me.tdbcMaxDepField02.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMaxDepField02.MaxDropDownItems = CType(8, Short)
        Me.tdbcMaxDepField02.MaxLength = 100
        Me.tdbcMaxDepField02.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMaxDepField02.Name = "tdbcMaxDepField02"
        Me.tdbcMaxDepField02.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMaxDepField02.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMaxDepField02.Size = New System.Drawing.Size(128, 21)
        Me.tdbcMaxDepField02.TabIndex = 12
        Me.tdbcMaxDepField02.ValueMember = "FieldName"
        Me.tdbcMaxDepField02.PropBag = resources.GetString("tdbcMaxDepField02.PropBag")
        '
        'cboMaxDepOperator
        '
        Me.cboMaxDepOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaxDepOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.cboMaxDepOperator.FormattingEnabled = True
        Me.cboMaxDepOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cboMaxDepOperator.Location = New System.Drawing.Point(280, 86)
        Me.cboMaxDepOperator.MaxLength = 1
        Me.cboMaxDepOperator.Name = "cboMaxDepOperator"
        Me.cboMaxDepOperator.Size = New System.Drawing.Size(83, 21)
        Me.cboMaxDepOperator.TabIndex = 11
        '
        'tdbcMaxDepField01
        '
        Me.tdbcMaxDepField01.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMaxDepField01.AllowColMove = False
        Me.tdbcMaxDepField01.AllowSort = False
        Me.tdbcMaxDepField01.AlternatingRows = True
        Me.tdbcMaxDepField01.AutoCompletion = True
        Me.tdbcMaxDepField01.AutoDropDown = True
        Me.tdbcMaxDepField01.Caption = ""
        Me.tdbcMaxDepField01.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMaxDepField01.ColumnWidth = 100
        Me.tdbcMaxDepField01.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMaxDepField01.DisplayMember = "Caption"
        Me.tdbcMaxDepField01.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMaxDepField01.DropDownWidth = 140
        Me.tdbcMaxDepField01.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMaxDepField01.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMaxDepField01.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMaxDepField01.EmptyRows = True
        Me.tdbcMaxDepField01.ExtendRightColumn = True
        Me.tdbcMaxDepField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMaxDepField01.Images.Add(CType(resources.GetObject("tdbcMaxDepField01.Images"), System.Drawing.Image))
        Me.tdbcMaxDepField01.Location = New System.Drawing.Point(148, 86)
        Me.tdbcMaxDepField01.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMaxDepField01.MaxDropDownItems = CType(8, Short)
        Me.tdbcMaxDepField01.MaxLength = 100
        Me.tdbcMaxDepField01.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMaxDepField01.Name = "tdbcMaxDepField01"
        Me.tdbcMaxDepField01.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMaxDepField01.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMaxDepField01.Size = New System.Drawing.Size(128, 21)
        Me.tdbcMaxDepField01.TabIndex = 10
        Me.tdbcMaxDepField01.ValueMember = "FieldName"
        Me.tdbcMaxDepField01.PropBag = resources.GetString("tdbcMaxDepField01.PropBag")
        '
        'tdbcMinDepField02
        '
        Me.tdbcMinDepField02.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMinDepField02.AllowColMove = False
        Me.tdbcMinDepField02.AllowSort = False
        Me.tdbcMinDepField02.AlternatingRows = True
        Me.tdbcMinDepField02.AutoCompletion = True
        Me.tdbcMinDepField02.AutoDropDown = True
        Me.tdbcMinDepField02.Caption = ""
        Me.tdbcMinDepField02.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMinDepField02.ColumnWidth = 100
        Me.tdbcMinDepField02.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMinDepField02.DisplayMember = "Caption"
        Me.tdbcMinDepField02.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMinDepField02.DropDownWidth = 140
        Me.tdbcMinDepField02.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMinDepField02.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMinDepField02.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMinDepField02.EmptyRows = True
        Me.tdbcMinDepField02.ExtendRightColumn = True
        Me.tdbcMinDepField02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMinDepField02.Images.Add(CType(resources.GetObject("tdbcMinDepField02.Images"), System.Drawing.Image))
        Me.tdbcMinDepField02.Location = New System.Drawing.Point(369, 56)
        Me.tdbcMinDepField02.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMinDepField02.MaxDropDownItems = CType(8, Short)
        Me.tdbcMinDepField02.MaxLength = 100
        Me.tdbcMinDepField02.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMinDepField02.Name = "tdbcMinDepField02"
        Me.tdbcMinDepField02.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMinDepField02.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMinDepField02.Size = New System.Drawing.Size(128, 21)
        Me.tdbcMinDepField02.TabIndex = 8
        Me.tdbcMinDepField02.ValueMember = "FieldName"
        Me.tdbcMinDepField02.PropBag = resources.GetString("tdbcMinDepField02.PropBag")
        '
        'cboMinDepOperator
        '
        Me.cboMinDepOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMinDepOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.cboMinDepOperator.FormattingEnabled = True
        Me.cboMinDepOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cboMinDepOperator.Location = New System.Drawing.Point(280, 56)
        Me.cboMinDepOperator.MaxLength = 1
        Me.cboMinDepOperator.Name = "cboMinDepOperator"
        Me.cboMinDepOperator.Size = New System.Drawing.Size(83, 21)
        Me.cboMinDepOperator.TabIndex = 7
        '
        'tdbcMinDepField01
        '
        Me.tdbcMinDepField01.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcMinDepField01.AllowColMove = False
        Me.tdbcMinDepField01.AllowSort = False
        Me.tdbcMinDepField01.AlternatingRows = True
        Me.tdbcMinDepField01.AutoCompletion = True
        Me.tdbcMinDepField01.AutoDropDown = True
        Me.tdbcMinDepField01.Caption = ""
        Me.tdbcMinDepField01.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcMinDepField01.ColumnWidth = 100
        Me.tdbcMinDepField01.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcMinDepField01.DisplayMember = "Caption"
        Me.tdbcMinDepField01.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcMinDepField01.DropDownWidth = 140
        Me.tdbcMinDepField01.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcMinDepField01.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMinDepField01.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcMinDepField01.EmptyRows = True
        Me.tdbcMinDepField01.ExtendRightColumn = True
        Me.tdbcMinDepField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcMinDepField01.Images.Add(CType(resources.GetObject("tdbcMinDepField01.Images"), System.Drawing.Image))
        Me.tdbcMinDepField01.Location = New System.Drawing.Point(148, 56)
        Me.tdbcMinDepField01.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcMinDepField01.MaxDropDownItems = CType(8, Short)
        Me.tdbcMinDepField01.MaxLength = 100
        Me.tdbcMinDepField01.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcMinDepField01.Name = "tdbcMinDepField01"
        Me.tdbcMinDepField01.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcMinDepField01.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcMinDepField01.Size = New System.Drawing.Size(128, 21)
        Me.tdbcMinDepField01.TabIndex = 6
        Me.tdbcMinDepField01.ValueMember = "FieldName"
        Me.tdbcMinDepField01.PropBag = resources.GetString("tdbcMinDepField01.PropBag")
        '
        'tdbcDepField02
        '
        Me.tdbcDepField02.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDepField02.AllowColMove = False
        Me.tdbcDepField02.AllowSort = False
        Me.tdbcDepField02.AlternatingRows = True
        Me.tdbcDepField02.AutoCompletion = True
        Me.tdbcDepField02.AutoDropDown = True
        Me.tdbcDepField02.Caption = ""
        Me.tdbcDepField02.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDepField02.ColumnWidth = 100
        Me.tdbcDepField02.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDepField02.DisplayMember = "Caption"
        Me.tdbcDepField02.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDepField02.DropDownWidth = 140
        Me.tdbcDepField02.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDepField02.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDepField02.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDepField02.EmptyRows = True
        Me.tdbcDepField02.ExtendRightColumn = True
        Me.tdbcDepField02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDepField02.Images.Add(CType(resources.GetObject("tdbcDepField02.Images"), System.Drawing.Image))
        Me.tdbcDepField02.Location = New System.Drawing.Point(369, 26)
        Me.tdbcDepField02.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDepField02.MaxDropDownItems = CType(8, Short)
        Me.tdbcDepField02.MaxLength = 32767
        Me.tdbcDepField02.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDepField02.Name = "tdbcDepField02"
        Me.tdbcDepField02.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDepField02.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDepField02.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDepField02.TabIndex = 3
        Me.tdbcDepField02.ValueMember = "FieldName"
        Me.tdbcDepField02.PropBag = resources.GetString("tdbcDepField02.PropBag")
        '
        'cboDepOperator
        '
        Me.cboDepOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.cboDepOperator.FormattingEnabled = True
        Me.cboDepOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cboDepOperator.Location = New System.Drawing.Point(280, 26)
        Me.cboDepOperator.MaxLength = 1
        Me.cboDepOperator.Name = "cboDepOperator"
        Me.cboDepOperator.Size = New System.Drawing.Size(83, 21)
        Me.cboDepOperator.TabIndex = 2
        '
        'tdbcDepField01
        '
        Me.tdbcDepField01.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcDepField01.AllowColMove = False
        Me.tdbcDepField01.AllowSort = False
        Me.tdbcDepField01.AlternatingRows = True
        Me.tdbcDepField01.AutoCompletion = True
        Me.tdbcDepField01.AutoDropDown = True
        Me.tdbcDepField01.Caption = ""
        Me.tdbcDepField01.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcDepField01.ColumnWidth = 100
        Me.tdbcDepField01.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcDepField01.DisplayMember = "Caption"
        Me.tdbcDepField01.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcDepField01.DropDownWidth = 140
        Me.tdbcDepField01.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcDepField01.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDepField01.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcDepField01.EmptyRows = True
        Me.tdbcDepField01.ExtendRightColumn = True
        Me.tdbcDepField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcDepField01.Images.Add(CType(resources.GetObject("tdbcDepField01.Images"), System.Drawing.Image))
        Me.tdbcDepField01.Location = New System.Drawing.Point(148, 26)
        Me.tdbcDepField01.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcDepField01.MaxDropDownItems = CType(8, Short)
        Me.tdbcDepField01.MaxLength = 32767
        Me.tdbcDepField01.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcDepField01.Name = "tdbcDepField01"
        Me.tdbcDepField01.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcDepField01.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcDepField01.Size = New System.Drawing.Size(128, 21)
        Me.tdbcDepField01.TabIndex = 1
        Me.tdbcDepField01.ValueMember = "FieldName"
        Me.tdbcDepField01.PropBag = resources.GetString("tdbcDepField01.PropBag")
        '
        'lblDepFile01
        '
        Me.lblDepFile01.AutoSize = True
        Me.lblDepFile01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepFile01.Location = New System.Drawing.Point(6, 31)
        Me.lblDepFile01.Name = "lblDepFile01"
        Me.lblDepFile01.Size = New System.Drawing.Size(85, 15)
        Me.lblDepFile01.TabIndex = 0
        Me.lblDepFile01.Text = "Mức khấu hao"
        Me.lblDepFile01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinDepField01
        '
        Me.lblMinDepField01.AutoSize = True
        Me.lblMinDepField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinDepField01.Location = New System.Drawing.Point(6, 61)
        Me.lblMinDepField01.Name = "lblMinDepField01"
        Me.lblMinDepField01.Size = New System.Drawing.Size(131, 15)
        Me.lblMinDepField01.TabIndex = 5
        Me.lblMinDepField01.Text = "Mức khấu hao tối thiểu"
        Me.lblMinDepField01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaxDepField01
        '
        Me.lblMaxDepField01.AutoSize = True
        Me.lblMaxDepField01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDepField01.Location = New System.Drawing.Point(6, 91)
        Me.lblMaxDepField01.Name = "lblMaxDepField01"
        Me.lblMaxDepField01.Size = New System.Drawing.Size(118, 15)
        Me.lblMaxDepField01.TabIndex = 9
        Me.lblMaxDepField01.Text = "Mức khấu hao tối đa"
        Me.lblMaxDepField01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGroupTypeID
        '
        Me.lblGroupTypeID.AutoSize = True
        Me.lblGroupTypeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupTypeID.Location = New System.Drawing.Point(6, 121)
        Me.lblGroupTypeID.Name = "lblGroupTypeID"
        Me.lblGroupTypeID.Size = New System.Drawing.Size(115, 15)
        Me.lblGroupTypeID.TabIndex = 13
        Me.lblGroupTypeID.Text = "Tài sản thuộc nhóm"
        Me.lblGroupTypeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGroupTypeName
        '
        Me.txtGroupTypeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtGroupTypeName.Location = New System.Drawing.Point(281, 116)
        Me.txtGroupTypeName.Name = "txtGroupTypeName"
        Me.txtGroupTypeName.ReadOnly = True
        Me.txtGroupTypeName.Size = New System.Drawing.Size(216, 20)
        Me.txtGroupTypeName.TabIndex = 15
        Me.txtGroupTypeName.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(277, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 22)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(359, 312)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 22)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Nhập &tiếp"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(441, 312)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnGuide
        '
        Me.btnGuide.Location = New System.Drawing.Point(5, 312)
        Me.btnGuide.Name = "btnGuide"
        Me.btnGuide.Size = New System.Drawing.Size(76, 22)
        Me.btnGuide.TabIndex = 5
        Me.btnGuide.Text = "&Hướng dẫn"
        Me.btnGuide.UseVisualStyleBackColor = True
        '
        'D02F0055
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 343)
        Me.Controls.Add(Me.btnGuide)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpValue)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.grpGuide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0055"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ThiÕt lËp bè ¢Ünh m÷c - D02F0055"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.tdbcNormCreatorID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1dateNormDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGuide.ResumeLayout(False)
        Me.grpGuide.PerformLayout()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpValue.ResumeLayout(False)
        Me.grpValue.PerformLayout()
        CType(Me.tdbcGroupTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcMaxDepField02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcMaxDepField01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcMinDepField02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcMinDepField01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDepField02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcDepField01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Private WithEvents txtNormNo As System.Windows.Forms.TextBox
    Private WithEvents lblNormNo As System.Windows.Forms.Label
    Private WithEvents c1dateNormDate As C1.Win.C1Input.C1DateEdit
    Private WithEvents lblteNormDate As System.Windows.Forms.Label
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents tdbcNormCreatorID As C1.Win.C1List.C1Combo
    Private WithEvents chkDisabled As System.Windows.Forms.CheckBox
    Private WithEvents lblNormCreatorID As System.Windows.Forms.Label
    Private WithEvents txtNormCreatorName As System.Windows.Forms.TextBox
    Private WithEvents lblDescription As System.Windows.Forms.Label
    Private WithEvents chkUseFormular As System.Windows.Forms.CheckBox
    Friend WithEvents grpValue As System.Windows.Forms.GroupBox
    Private WithEvents tdbcDepField01 As C1.Win.C1List.C1Combo
    Private WithEvents lblDepFile01 As System.Windows.Forms.Label
    Private WithEvents tdbcDepField02 As C1.Win.C1List.C1Combo
    Private WithEvents cboDepOperator As System.Windows.Forms.ComboBox
    Private WithEvents tdbcMinDepField01 As C1.Win.C1List.C1Combo
    Private WithEvents lblMinDepField01 As System.Windows.Forms.Label
    Private WithEvents tdbcMinDepField02 As C1.Win.C1List.C1Combo
    Private WithEvents cboMinDepOperator As System.Windows.Forms.ComboBox
    Private WithEvents tdbcMaxDepField01 As C1.Win.C1List.C1Combo
    Private WithEvents lblMaxDepField01 As System.Windows.Forms.Label
    Private WithEvents cboMaxDepOperator As System.Windows.Forms.ComboBox
    Private WithEvents tdbcMaxDepField02 As C1.Win.C1List.C1Combo
    Private WithEvents tdbcGroupTypeID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupTypeID As System.Windows.Forms.Label
    Private WithEvents txtGroupTypeName As System.Windows.Forms.TextBox
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnGuide As System.Windows.Forms.Button
    Friend WithEvents grpGuide As System.Windows.Forms.GroupBox
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents btnCloseFrame As System.Windows.Forms.Button
    Private WithEvents txtFormular As System.Windows.Forms.TextBox
    Private WithEvents lblFormular As System.Windows.Forms.Label
    Private WithEvents btnSelect As System.Windows.Forms.Button
    Private WithEvents txtFormular1 As System.Windows.Forms.TextBox
End Class