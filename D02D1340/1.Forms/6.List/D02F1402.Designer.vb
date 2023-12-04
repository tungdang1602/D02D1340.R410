<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F1402
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F1402))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.txtSplitMethodNo = New System.Windows.Forms.TextBox()
        Me.lblSplitMethodNo = New System.Windows.Forms.Label()
        Me.txtSplitMethodName = New System.Windows.Forms.TextBox()
        Me.lblSplitMethodName = New System.Windows.Forms.Label()
        Me.chkDisabled = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tdbdCipNo = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbdCipNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSplitMethodNo
        '
        Me.txtSplitMethodNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSplitMethodNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtSplitMethodNo.Location = New System.Drawing.Point(163, 12)
        Me.txtSplitMethodNo.MaxLength = 20
        Me.txtSplitMethodNo.Name = "txtSplitMethodNo"
        Me.txtSplitMethodNo.Size = New System.Drawing.Size(161, 22)
        Me.txtSplitMethodNo.TabIndex = 1
        '
        'lblSplitMethodNo
        '
        Me.lblSplitMethodNo.AutoSize = True
        Me.lblSplitMethodNo.Location = New System.Drawing.Point(13, 17)
        Me.lblSplitMethodNo.Name = "lblSplitMethodNo"
        Me.lblSplitMethodNo.Size = New System.Drawing.Size(88, 13)
        Me.lblSplitMethodNo.TabIndex = 0
        Me.lblSplitMethodNo.Text = "Mã phương pháp"
        Me.lblSplitMethodNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSplitMethodName
        '
        Me.txtSplitMethodName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtSplitMethodName.Location = New System.Drawing.Point(162, 40)
        Me.txtSplitMethodName.MaxLength = 50
        Me.txtSplitMethodName.Name = "txtSplitMethodName"
        Me.txtSplitMethodName.Size = New System.Drawing.Size(420, 22)
        Me.txtSplitMethodName.TabIndex = 4
        '
        'lblSplitMethodName
        '
        Me.lblSplitMethodName.AutoSize = True
        Me.lblSplitMethodName.Location = New System.Drawing.Point(12, 45)
        Me.lblSplitMethodName.Name = "lblSplitMethodName"
        Me.lblSplitMethodName.Size = New System.Drawing.Size(92, 13)
        Me.lblSplitMethodName.TabIndex = 3
        Me.lblSplitMethodName.Text = "Tên phương pháp"
        Me.lblSplitMethodName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDisabled
        '
        Me.chkDisabled.AutoSize = True
        Me.chkDisabled.Location = New System.Drawing.Point(484, 15)
        Me.chkDisabled.Name = "chkDisabled"
        Me.chkDisabled.Size = New System.Drawing.Size(98, 17)
        Me.chkDisabled.TabIndex = 2
        Me.chkDisabled.Text = "Không sử dụng"
        Me.chkDisabled.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(354, 338)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 22)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(432, 338)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(72, 22)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Nhập &tiếp"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(510, 338)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 22)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Đó&ng"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tdbg
        '
        Me.tdbg.AllowAddNew = True
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowDelete = True
        Me.tdbg.AllowFilter = False
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowSort = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.CaptionHeight = 17
        Me.tdbg.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Floating
        Me.tdbg.ColumnFooters = True
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(12, 75)
        Me.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor
        Me.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.RowHeight = 15
        Me.tdbg.Size = New System.Drawing.Size(570, 254)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 5
        Me.tdbg.Tag = "COL"
        Me.tdbg.WrapCellPointer = True
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        '
        'tdbdCipNo
        '
        Me.tdbdCipNo.AllowColMove = False
        Me.tdbdCipNo.AllowColSelect = False
        Me.tdbdCipNo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbdCipNo.AllowSort = False
        Me.tdbdCipNo.AlternatingRows = True
        Me.tdbdCipNo.CaptionHeight = 17
        Me.tdbdCipNo.CaptionStyle = Style1
        Me.tdbdCipNo.ColumnCaptionHeight = 17
        Me.tdbdCipNo.ColumnFooterHeight = 17
        Me.tdbdCipNo.DisplayMember = "CipNo"
        Me.tdbdCipNo.EmptyRows = True
        Me.tdbdCipNo.EvenRowStyle = Style2
        Me.tdbdCipNo.ExtendRightColumn = True
        Me.tdbdCipNo.FetchRowStyles = False
        Me.tdbdCipNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbdCipNo.FooterStyle = Style3
        Me.tdbdCipNo.HeadingStyle = Style4
        Me.tdbdCipNo.HighLightRowStyle = Style5
        Me.tdbdCipNo.Images.Add(CType(resources.GetObject("tdbdCipNo.Images"), System.Drawing.Image))
        Me.tdbdCipNo.Location = New System.Drawing.Point(125, 160)
        Me.tdbdCipNo.Name = "tdbdCipNo"
        Me.tdbdCipNo.OddRowStyle = Style6
        Me.tdbdCipNo.RecordSelectorStyle = Style7
        Me.tdbdCipNo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbdCipNo.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbdCipNo.RowHeight = 15
        Me.tdbdCipNo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbdCipNo.ScrollTips = False
        Me.tdbdCipNo.Size = New System.Drawing.Size(350, 147)
        Me.tdbdCipNo.Style = Style8
        Me.tdbdCipNo.TabIndex = 9
        Me.tdbdCipNo.TabStop = False
        Me.tdbdCipNo.ValueMember = "SplitCipID"
        Me.tdbdCipNo.ValueTranslate = True
        Me.tdbdCipNo.Visible = False
        Me.tdbdCipNo.PropBag = resources.GetString("tdbdCipNo.PropBag")
        '
        'D02F1402
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 372)
        Me.Controls.Add(Me.tdbdCipNo)
        Me.Controls.Add(Me.tdbg)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkDisabled)
        Me.Controls.Add(Me.txtSplitMethodName)
        Me.Controls.Add(Me.txtSplitMethodNo)
        Me.Controls.Add(Me.lblSplitMethodNo)
        Me.Controls.Add(Me.lblSplitMethodName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F1402"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CËp nhËt ph§¥ng phÀp tÀch chi phÛ - D02F1402"
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbdCipNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtSplitMethodNo As System.Windows.Forms.TextBox
    Private WithEvents lblSplitMethodNo As System.Windows.Forms.Label
    Private WithEvents txtSplitMethodName As System.Windows.Forms.TextBox
    Private WithEvents lblSplitMethodName As System.Windows.Forms.Label
    Private WithEvents chkDisabled As System.Windows.Forms.CheckBox
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents tdbdCipNo As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
End Class