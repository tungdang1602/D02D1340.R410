<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0057
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0057))
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.tdbcPeriodTo = New C1.Win.C1List.C1Combo()
        Me.tdbcPeriodFr = New C1.Win.C1List.C1Combo()
        Me.txtMaxDep = New System.Windows.Forms.TextBox()
        Me.txtMinDep = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.tdbcToAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcFromAssetID = New C1.Win.C1List.C1Combo()
        Me.tdbcGroupID = New C1.Win.C1List.C1Combo()
        Me.lblGroupID = New System.Windows.Forms.Label()
        Me.txtGroupCaption = New System.Windows.Forms.TextBox()
        Me.lblFromAssetID = New System.Windows.Forms.Label()
        Me.lblToAssetID = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblMinDep = New System.Windows.Forms.Label()
        Me.lblMaxDep = New System.Windows.Forms.Label()
        Me.lblPeriodFr = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grp1.SuspendLayout()
        CType(Me.tdbcPeriodTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcPeriodFr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbcGroupID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lbl1)
        Me.grp1.Controls.Add(Me.tdbcPeriodTo)
        Me.grp1.Controls.Add(Me.tdbcPeriodFr)
        Me.grp1.Controls.Add(Me.txtMaxDep)
        Me.grp1.Controls.Add(Me.txtMinDep)
        Me.grp1.Controls.Add(Me.txtAmount)
        Me.grp1.Controls.Add(Me.tdbcToAssetID)
        Me.grp1.Controls.Add(Me.tdbcFromAssetID)
        Me.grp1.Controls.Add(Me.tdbcGroupID)
        Me.grp1.Controls.Add(Me.lblGroupID)
        Me.grp1.Controls.Add(Me.txtGroupCaption)
        Me.grp1.Controls.Add(Me.lblFromAssetID)
        Me.grp1.Controls.Add(Me.lblToAssetID)
        Me.grp1.Controls.Add(Me.lblAmount)
        Me.grp1.Controls.Add(Me.lblMinDep)
        Me.grp1.Controls.Add(Me.lblMaxDep)
        Me.grp1.Controls.Add(Me.lblPeriodFr)
        Me.grp1.Location = New System.Drawing.Point(6, 3)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(538, 163)
        Me.grp1.TabIndex = 0
        Me.grp1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(313, 45)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(16, 15)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "..."
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tdbcPeriodTo
        '
        Me.tdbcPeriodTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcPeriodTo.AllowColMove = False
        Me.tdbcPeriodTo.AllowSort = False
        Me.tdbcPeriodTo.AlternatingRows = True
        Me.tdbcPeriodTo.AutoCompletion = True
        Me.tdbcPeriodTo.AutoDropDown = True
        Me.tdbcPeriodTo.Caption = ""
        Me.tdbcPeriodTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcPeriodTo.ColumnHeaders = False
        Me.tdbcPeriodTo.ColumnWidth = 100
        Me.tdbcPeriodTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcPeriodTo.DisplayMember = "Period"
        Me.tdbcPeriodTo.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcPeriodTo.DropDownWidth = 128
        Me.tdbcPeriodTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcPeriodTo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcPeriodTo.EmptyRows = True
        Me.tdbcPeriodTo.ExtendRightColumn = True
        Me.tdbcPeriodTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodTo.Images.Add(CType(resources.GetObject("tdbcPeriodTo.Images"), System.Drawing.Image))
        Me.tdbcPeriodTo.Location = New System.Drawing.Point(396, 46)
        Me.tdbcPeriodTo.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcPeriodTo.MaxDropDownItems = CType(8, Short)
        Me.tdbcPeriodTo.MaxLength = 32767
        Me.tdbcPeriodTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcPeriodTo.Name = "tdbcPeriodTo"
        Me.tdbcPeriodTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcPeriodTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcPeriodTo.Size = New System.Drawing.Size(128, 21)
        Me.tdbcPeriodTo.TabIndex = 6
        Me.tdbcPeriodTo.ValueMember = "Period"
        Me.tdbcPeriodTo.PropBag = resources.GetString("tdbcPeriodTo.PropBag")
        '
        'tdbcPeriodFr
        '
        Me.tdbcPeriodFr.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcPeriodFr.AllowColMove = False
        Me.tdbcPeriodFr.AllowSort = False
        Me.tdbcPeriodFr.AlternatingRows = True
        Me.tdbcPeriodFr.AutoCompletion = True
        Me.tdbcPeriodFr.AutoDropDown = True
        Me.tdbcPeriodFr.Caption = ""
        Me.tdbcPeriodFr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcPeriodFr.ColumnHeaders = False
        Me.tdbcPeriodFr.ColumnWidth = 100
        Me.tdbcPeriodFr.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcPeriodFr.DisplayMember = "Period"
        Me.tdbcPeriodFr.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcPeriodFr.DropDownWidth = 128
        Me.tdbcPeriodFr.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcPeriodFr.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodFr.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcPeriodFr.EmptyRows = True
        Me.tdbcPeriodFr.ExtendRightColumn = True
        Me.tdbcPeriodFr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcPeriodFr.Images.Add(CType(resources.GetObject("tdbcPeriodFr.Images"), System.Drawing.Image))
        Me.tdbcPeriodFr.Location = New System.Drawing.Point(142, 46)
        Me.tdbcPeriodFr.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcPeriodFr.MaxDropDownItems = CType(8, Short)
        Me.tdbcPeriodFr.MaxLength = 32767
        Me.tdbcPeriodFr.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcPeriodFr.Name = "tdbcPeriodFr"
        Me.tdbcPeriodFr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcPeriodFr.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcPeriodFr.Size = New System.Drawing.Size(128, 21)
        Me.tdbcPeriodFr.TabIndex = 4
        Me.tdbcPeriodFr.ValueMember = "Period"
        Me.tdbcPeriodFr.PropBag = resources.GetString("tdbcPeriodFr.PropBag")
        '
        'txtMaxDep
        '
        Me.txtMaxDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtMaxDep.Location = New System.Drawing.Point(396, 131)
        Me.txtMaxDep.MaxLength = 18
        Me.txtMaxDep.Name = "txtMaxDep"
        Me.txtMaxDep.Size = New System.Drawing.Size(128, 20)
        Me.txtMaxDep.TabIndex = 16
        Me.txtMaxDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinDep
        '
        Me.txtMinDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtMinDep.Location = New System.Drawing.Point(142, 131)
        Me.txtMinDep.MaxLength = 18
        Me.txtMinDep.Name = "txtMinDep"
        Me.txtMinDep.Size = New System.Drawing.Size(128, 20)
        Me.txtMinDep.TabIndex = 14
        Me.txtMinDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtAmount.Location = New System.Drawing.Point(142, 103)
        Me.txtAmount.MaxLength = 18
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(128, 20)
        Me.txtAmount.TabIndex = 12
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tdbcToAssetID
        '
        Me.tdbcToAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcToAssetID.AllowColMove = False
        Me.tdbcToAssetID.AllowSort = False
        Me.tdbcToAssetID.AlternatingRows = True
        Me.tdbcToAssetID.AutoCompletion = True
        Me.tdbcToAssetID.AutoDropDown = True
        Me.tdbcToAssetID.AutoSelect = True
        Me.tdbcToAssetID.Caption = ""
        Me.tdbcToAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcToAssetID.ColumnWidth = 100
        Me.tdbcToAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcToAssetID.DisplayMember = "AssetID"
        Me.tdbcToAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcToAssetID.DropDownWidth = 500
        Me.tdbcToAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcToAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcToAssetID.EmptyRows = True
        Me.tdbcToAssetID.ExtendRightColumn = True
        Me.tdbcToAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcToAssetID.Images.Add(CType(resources.GetObject("tdbcToAssetID.Images"), System.Drawing.Image))
        Me.tdbcToAssetID.Location = New System.Drawing.Point(396, 75)
        Me.tdbcToAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcToAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcToAssetID.MaxLength = 32767
        Me.tdbcToAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcToAssetID.Name = "tdbcToAssetID"
        Me.tdbcToAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcToAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcToAssetID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcToAssetID.TabIndex = 10
        Me.tdbcToAssetID.ValueMember = "AssetID"
        Me.tdbcToAssetID.PropBag = resources.GetString("tdbcToAssetID.PropBag")
        '
        'tdbcFromAssetID
        '
        Me.tdbcFromAssetID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcFromAssetID.AllowColMove = False
        Me.tdbcFromAssetID.AllowSort = False
        Me.tdbcFromAssetID.AlternatingRows = True
        Me.tdbcFromAssetID.AutoCompletion = True
        Me.tdbcFromAssetID.AutoDropDown = True
        Me.tdbcFromAssetID.AutoSelect = True
        Me.tdbcFromAssetID.Caption = ""
        Me.tdbcFromAssetID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcFromAssetID.ColumnWidth = 100
        Me.tdbcFromAssetID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcFromAssetID.DisplayMember = "AssetID"
        Me.tdbcFromAssetID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcFromAssetID.DropDownWidth = 500
        Me.tdbcFromAssetID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcFromAssetID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcFromAssetID.EmptyRows = True
        Me.tdbcFromAssetID.ExtendRightColumn = True
        Me.tdbcFromAssetID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcFromAssetID.Images.Add(CType(resources.GetObject("tdbcFromAssetID.Images"), System.Drawing.Image))
        Me.tdbcFromAssetID.Location = New System.Drawing.Point(142, 75)
        Me.tdbcFromAssetID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcFromAssetID.MaxDropDownItems = CType(8, Short)
        Me.tdbcFromAssetID.MaxLength = 32767
        Me.tdbcFromAssetID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcFromAssetID.Name = "tdbcFromAssetID"
        Me.tdbcFromAssetID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcFromAssetID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcFromAssetID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcFromAssetID.TabIndex = 8
        Me.tdbcFromAssetID.ValueMember = "AssetID"
        Me.tdbcFromAssetID.PropBag = resources.GetString("tdbcFromAssetID.PropBag")
        '
        'tdbcGroupID
        '
        Me.tdbcGroupID.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.tdbcGroupID.AllowColMove = False
        Me.tdbcGroupID.AllowSort = False
        Me.tdbcGroupID.AlternatingRows = True
        Me.tdbcGroupID.AutoCompletion = True
        Me.tdbcGroupID.AutoDropDown = True
        Me.tdbcGroupID.Caption = ""
        Me.tdbcGroupID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.tdbcGroupID.ColumnWidth = 100
        Me.tdbcGroupID.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.tdbcGroupID.DisplayMember = "GroupID"
        Me.tdbcGroupID.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.tdbcGroupID.DropDownWidth = 500
        Me.tdbcGroupID.EditorBackColor = System.Drawing.SystemColors.Window
        Me.tdbcGroupID.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupID.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.tdbcGroupID.EmptyRows = True
        Me.tdbcGroupID.ExtendRightColumn = True
        Me.tdbcGroupID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbcGroupID.Images.Add(CType(resources.GetObject("tdbcGroupID.Images"), System.Drawing.Image))
        Me.tdbcGroupID.Location = New System.Drawing.Point(142, 17)
        Me.tdbcGroupID.MatchEntryTimeout = CType(2000, Long)
        Me.tdbcGroupID.MaxDropDownItems = CType(8, Short)
        Me.tdbcGroupID.MaxLength = 32767
        Me.tdbcGroupID.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.tdbcGroupID.Name = "tdbcGroupID"
        Me.tdbcGroupID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.tdbcGroupID.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbcGroupID.Size = New System.Drawing.Size(128, 21)
        Me.tdbcGroupID.TabIndex = 1
        Me.tdbcGroupID.ValueMember = "GroupID"
        Me.tdbcGroupID.PropBag = resources.GetString("tdbcGroupID.PropBag")
        '
        'lblGroupID
        '
        Me.lblGroupID.AutoSize = True
        Me.lblGroupID.Location = New System.Drawing.Point(7, 22)
        Me.lblGroupID.Name = "lblGroupID"
        Me.lblGroupID.Size = New System.Drawing.Size(80, 15)
        Me.lblGroupID.TabIndex = 0
        Me.lblGroupID.Text = "Nhóm tài sản"
        Me.lblGroupID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGroupCaption
        '
        Me.txtGroupCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtGroupCaption.Location = New System.Drawing.Point(273, 17)
        Me.txtGroupCaption.Name = "txtGroupCaption"
        Me.txtGroupCaption.ReadOnly = True
        Me.txtGroupCaption.Size = New System.Drawing.Size(251, 20)
        Me.txtGroupCaption.TabIndex = 2
        Me.txtGroupCaption.TabStop = False
        '
        'lblFromAssetID
        '
        Me.lblFromAssetID.AutoSize = True
        Me.lblFromAssetID.Location = New System.Drawing.Point(7, 79)
        Me.lblFromAssetID.Name = "lblFromAssetID"
        Me.lblFromAssetID.Size = New System.Drawing.Size(47, 15)
        Me.lblFromAssetID.TabIndex = 7
        Me.lblFromAssetID.Text = "Tài sản"
        Me.lblFromAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblToAssetID
        '
        Me.lblToAssetID.AutoSize = True
        Me.lblToAssetID.Location = New System.Drawing.Point(313, 79)
        Me.lblToAssetID.Name = "lblToAssetID"
        Me.lblToAssetID.Size = New System.Drawing.Size(16, 15)
        Me.lblToAssetID.TabIndex = 9
        Me.lblToAssetID.Text = "..."
        Me.lblToAssetID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(7, 106)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(85, 15)
        Me.lblAmount.TabIndex = 11
        Me.lblAmount.Text = "Mức khấu hao"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinDep
        '
        Me.lblMinDep.AutoSize = True
        Me.lblMinDep.Location = New System.Drawing.Point(7, 134)
        Me.lblMinDep.Name = "lblMinDep"
        Me.lblMinDep.Size = New System.Drawing.Size(131, 15)
        Me.lblMinDep.TabIndex = 13
        Me.lblMinDep.Text = "Mức khấu hao tối thiểu"
        Me.lblMinDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaxDep
        '
        Me.lblMaxDep.AutoSize = True
        Me.lblMaxDep.Location = New System.Drawing.Point(275, 136)
        Me.lblMaxDep.Name = "lblMaxDep"
        Me.lblMaxDep.Size = New System.Drawing.Size(118, 15)
        Me.lblMaxDep.TabIndex = 15
        Me.lblMaxDep.Text = "Mức khấu hao tối đa"
        Me.lblMaxDep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPeriodFr
        '
        Me.lblPeriodFr.AutoSize = True
        Me.lblPeriodFr.Location = New System.Drawing.Point(7, 50)
        Me.lblPeriodFr.Name = "lblPeriodFr"
        Me.lblPeriodFr.Size = New System.Drawing.Size(20, 15)
        Me.lblPeriodFr.TabIndex = 3
        Me.lblPeriodFr.Text = "Kỳ"
        Me.lblPeriodFr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(307, 172)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 22)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(468, 172)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(388, 172)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 22)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Nhập &tiếp"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'D02F0057
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 202)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grp1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0057"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "˜Ünh m÷c khÊu hao - D02F0057"
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.tdbcPeriodTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcPeriodFr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcToAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcFromAssetID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbcGroupID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Private WithEvents tdbcGroupID As C1.Win.C1List.C1Combo
    Private WithEvents lblGroupID As System.Windows.Forms.Label
    Private WithEvents txtGroupCaption As System.Windows.Forms.TextBox
    Private WithEvents tdbcFromAssetID As C1.Win.C1List.C1Combo
    Private WithEvents lblFromAssetID As System.Windows.Forms.Label
    Private WithEvents tdbcToAssetID As C1.Win.C1List.C1Combo
    Private WithEvents lblToAssetID As System.Windows.Forms.Label
    Private WithEvents txtAmount As System.Windows.Forms.TextBox
    Private WithEvents lblAmount As System.Windows.Forms.Label
    Private WithEvents txtMaxDep As System.Windows.Forms.TextBox
    Private WithEvents txtMinDep As System.Windows.Forms.TextBox
    Private WithEvents lblMinDep As System.Windows.Forms.Label
    Private WithEvents lblMaxDep As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents tdbcPeriodTo As C1.Win.C1List.C1Combo
    Private WithEvents tdbcPeriodFr As C1.Win.C1List.C1Combo
    Private WithEvents lblPeriodFr As System.Windows.Forms.Label
    Private WithEvents lbl1 As System.Windows.Forms.Label
End Class