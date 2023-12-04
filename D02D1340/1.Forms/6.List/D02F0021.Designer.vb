<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0021
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0021))
        Me.grpGeneralInfo = New System.Windows.Forms.GroupBox()
        Me.chkDisabled = New System.Windows.Forms.CheckBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtDeprTableName = New System.Windows.Forms.TextBox()
        Me.txtDeprTableID = New System.Windows.Forms.TextBox()
        Me.lblDeprTableID = New System.Windows.Forms.Label()
        Me.lblDeprTableName = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.grpParameter = New System.Windows.Forms.GroupBox()
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.chkAuto = New System.Windows.Forms.CheckBox()
        Me.txtQuickRate = New System.Windows.Forms.TextBox()
        Me.txtServiceYear = New System.Windows.Forms.TextBox()
        Me.lblServiceYear = New System.Windows.Forms.Label()
        Me.lblQuickRate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpGeneralInfo.SuspendLayout()
        Me.grpParameter.SuspendLayout()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGeneralInfo
        '
        Me.grpGeneralInfo.Controls.Add(Me.chkDisabled)
        Me.grpGeneralInfo.Controls.Add(Me.txtDescription)
        Me.grpGeneralInfo.Controls.Add(Me.txtDeprTableName)
        Me.grpGeneralInfo.Controls.Add(Me.txtDeprTableID)
        Me.grpGeneralInfo.Controls.Add(Me.lblDeprTableID)
        Me.grpGeneralInfo.Controls.Add(Me.lblDeprTableName)
        Me.grpGeneralInfo.Controls.Add(Me.lblDescription)
        Me.grpGeneralInfo.Location = New System.Drawing.Point(6, 1)
        Me.grpGeneralInfo.Name = "grpGeneralInfo"
        Me.grpGeneralInfo.Size = New System.Drawing.Size(555, 100)
        Me.grpGeneralInfo.TabIndex = 0
        Me.grpGeneralInfo.TabStop = False
        '
        'chkDisabled
        '
        Me.chkDisabled.AutoSize = True
        Me.chkDisabled.Location = New System.Drawing.Point(274, 15)
        Me.chkDisabled.Name = "chkDisabled"
        Me.chkDisabled.Size = New System.Drawing.Size(98, 17)
        Me.chkDisabled.TabIndex = 2
        Me.chkDisabled.Text = "Không sử dụng"
        Me.chkDisabled.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDescription.Location = New System.Drawing.Point(103, 70)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(440, 22)
        Me.txtDescription.TabIndex = 6
        '
        'txtDeprTableName
        '
        Me.txtDeprTableName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDeprTableName.Location = New System.Drawing.Point(103, 41)
        Me.txtDeprTableName.MaxLength = 50
        Me.txtDeprTableName.Name = "txtDeprTableName"
        Me.txtDeprTableName.Size = New System.Drawing.Size(440, 22)
        Me.txtDeprTableName.TabIndex = 4
        '
        'txtDeprTableID
        '
        Me.txtDeprTableID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeprTableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDeprTableID.Location = New System.Drawing.Point(103, 12)
        Me.txtDeprTableID.MaxLength = 20
        Me.txtDeprTableID.Name = "txtDeprTableID"
        Me.txtDeprTableID.Size = New System.Drawing.Size(128, 22)
        Me.txtDeprTableID.TabIndex = 1
        '
        'lblDeprTableID
        '
        Me.lblDeprTableID.AutoSize = True
        Me.lblDeprTableID.Location = New System.Drawing.Point(6, 17)
        Me.lblDeprTableID.Name = "lblDeprTableID"
        Me.lblDeprTableID.Size = New System.Drawing.Size(49, 13)
        Me.lblDeprTableID.TabIndex = 0
        Me.lblDeprTableID.Text = "Mã bảng"
        Me.lblDeprTableID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeprTableName
        '
        Me.lblDeprTableName.AutoSize = True
        Me.lblDeprTableName.Location = New System.Drawing.Point(6, 46)
        Me.lblDeprTableName.Name = "lblDeprTableName"
        Me.lblDeprTableName.Size = New System.Drawing.Size(53, 13)
        Me.lblDeprTableName.TabIndex = 3
        Me.lblDeprTableName.Text = "Tên bảng"
        Me.lblDeprTableName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(6, 75)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(48, 13)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Diễn giải"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpParameter
        '
        Me.grpParameter.Controls.Add(Me.tdbg)
        Me.grpParameter.Controls.Add(Me.chkAuto)
        Me.grpParameter.Controls.Add(Me.txtQuickRate)
        Me.grpParameter.Controls.Add(Me.txtServiceYear)
        Me.grpParameter.Controls.Add(Me.lblServiceYear)
        Me.grpParameter.Controls.Add(Me.lblQuickRate)
        Me.grpParameter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpParameter.Location = New System.Drawing.Point(7, 110)
        Me.grpParameter.Name = "grpParameter"
        Me.grpParameter.Size = New System.Drawing.Size(554, 245)
        Me.grpParameter.TabIndex = 1
        Me.grpParameter.TabStop = False
        Me.grpParameter.Text = "Thông số tính khấu hao"
        '
        'tdbg
        '
        Me.tdbg.AllowAddNew = True
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowDelete = True
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowSort = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.CaptionHeight = 17
        Me.tdbg.ColumnFooters = True
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(289, 14)
        Me.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.RowHeight = 15
        Me.tdbg.Size = New System.Drawing.Size(253, 222)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 5
        Me.tdbg.Tag = "COL"
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        '
        'chkAuto
        '
        Me.chkAuto.AutoSize = True
        Me.chkAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuto.Location = New System.Drawing.Point(11, 92)
        Me.chkAuto.Name = "chkAuto"
        Me.chkAuto.Size = New System.Drawing.Size(198, 17)
        Me.chkAuto.TabIndex = 4
        Me.chkAuto.Text = "Tự động tính và điền tỷ lệ vào bảng"
        Me.chkAuto.UseVisualStyleBackColor = True
        '
        'txtQuickRate
        '
        Me.txtQuickRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtQuickRate.Location = New System.Drawing.Point(147, 58)
        Me.txtQuickRate.MaxLength = 8
        Me.txtQuickRate.Name = "txtQuickRate"
        Me.txtQuickRate.Size = New System.Drawing.Size(128, 22)
        Me.txtQuickRate.TabIndex = 3
        Me.txtQuickRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiceYear
        '
        Me.txtServiceYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtServiceYear.Location = New System.Drawing.Point(147, 28)
        Me.txtServiceYear.MaxLength = 3
        Me.txtServiceYear.Name = "txtServiceYear"
        Me.txtServiceYear.Size = New System.Drawing.Size(128, 22)
        Me.txtServiceYear.TabIndex = 1
        Me.txtServiceYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblServiceYear
        '
        Me.lblServiceYear.AutoSize = True
        Me.lblServiceYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceYear.Location = New System.Drawing.Point(11, 32)
        Me.lblServiceYear.Name = "lblServiceYear"
        Me.lblServiceYear.Size = New System.Drawing.Size(91, 13)
        Me.lblServiceYear.TabIndex = 0
        Me.lblServiceYear.Text = "Số năm khấu hao"
        Me.lblServiceYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQuickRate
        '
        Me.lblQuickRate.AutoSize = True
        Me.lblQuickRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuickRate.Location = New System.Drawing.Point(11, 62)
        Me.lblQuickRate.Name = "lblQuickRate"
        Me.lblQuickRate.Size = New System.Drawing.Size(111, 13)
        Me.lblQuickRate.TabIndex = 2
        Me.lblQuickRate.Text = "Tỷ lệ khấu hao nhanh"
        Me.lblQuickRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(319, 365)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 22)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(402, 365)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(76, 22)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Nhập &tiếp"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(485, 365)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 22)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'D02F0021
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 395)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpParameter)
        Me.Controls.Add(Me.grpGeneralInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0021"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CËp nhËt b¶ng khÊu hao - D02F0021"
        Me.grpGeneralInfo.ResumeLayout(False)
        Me.grpGeneralInfo.PerformLayout()
        Me.grpParameter.ResumeLayout(False)
        Me.grpParameter.PerformLayout()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpGeneralInfo As System.Windows.Forms.GroupBox
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents txtDeprTableName As System.Windows.Forms.TextBox
    Private WithEvents txtDeprTableID As System.Windows.Forms.TextBox
    Private WithEvents lblDeprTableID As System.Windows.Forms.Label
    Private WithEvents lblDeprTableName As System.Windows.Forms.Label
    Private WithEvents lblDescription As System.Windows.Forms.Label
    Private WithEvents chkDisabled As System.Windows.Forms.CheckBox
    Friend WithEvents grpParameter As System.Windows.Forms.GroupBox
    Private WithEvents txtServiceYear As System.Windows.Forms.TextBox
    Private WithEvents txtQuickRate As System.Windows.Forms.TextBox
    Private WithEvents lblServiceYear As System.Windows.Forms.Label
    Private WithEvents lblQuickRate As System.Windows.Forms.Label
    Private WithEvents chkAuto As System.Windows.Forms.CheckBox
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
End Class