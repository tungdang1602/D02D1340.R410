<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0056
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0056))
        Me.txtNormNo = New System.Windows.Forms.TextBox()
        Me.lblNormNo = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnsAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator_Find = New System.Windows.Forms.ToolStripSeparator()
        Me.mnsFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsListAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbToolStripTable = New System.Windows.Forms.ToolStrip()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbFind = New System.Windows.Forms.ToolStripButton()
        Me.tsbListAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsdActive = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmListAll = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tsbToolStripTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNormNo
        '
        Me.txtNormNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNormNo.Enabled = False
        Me.txtNormNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtNormNo.Location = New System.Drawing.Point(101, 35)
        Me.txtNormNo.Name = "txtNormNo"
        Me.txtNormNo.Size = New System.Drawing.Size(204, 20)
        Me.txtNormNo.TabIndex = 1
        '
        'lblNormNo
        '
        Me.lblNormNo.AutoSize = True
        Me.lblNormNo.Location = New System.Drawing.Point(7, 40)
        Me.lblNormNo.Name = "lblNormNo"
        Me.lblNormNo.Size = New System.Drawing.Size(67, 13)
        Me.lblNormNo.TabIndex = 0
        Me.lblNormNo.Text = "Bộ định mức"
        Me.lblNormNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription
        '
        Me.txtDescription.Enabled = False
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!)
        Me.txtDescription.Location = New System.Drawing.Point(311, 35)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(702, 20)
        Me.txtDescription.TabIndex = 2
        '
        'tdbg
        '
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowFilter = False
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowUpdate = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.ColumnFooters = True
        Me.tdbg.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FilterBar = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(3, 66)
        Me.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.Size = New System.Drawing.Size(1010, 581)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 3
        Me.tdbg.Tag = "COL"
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsAdd, Me.mnsEdit, Me.mnsDelete, Me.ToolStripSeparator_Find, Me.mnsFind, Me.mnsListAll})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(141, 120)
        '
        'mnsAdd
        '
        Me.mnsAdd.Name = "mnsAdd"
        Me.mnsAdd.Size = New System.Drawing.Size(140, 22)
        Me.mnsAdd.Text = "&Thêm"
        '
        'mnsEdit
        '
        Me.mnsEdit.Name = "mnsEdit"
        Me.mnsEdit.Size = New System.Drawing.Size(140, 22)
        Me.mnsEdit.Text = "&Sửa"
        '
        'mnsDelete
        '
        Me.mnsDelete.Name = "mnsDelete"
        Me.mnsDelete.Size = New System.Drawing.Size(140, 22)
        Me.mnsDelete.Text = "&Xóa"
        '
        'ToolStripSeparator_Find
        '
        Me.ToolStripSeparator_Find.Name = "ToolStripSeparator_Find"
        Me.ToolStripSeparator_Find.Size = New System.Drawing.Size(137, 6)
        '
        'mnsFind
        '
        Me.mnsFind.Name = "mnsFind"
        Me.mnsFind.Size = New System.Drawing.Size(140, 22)
        Me.mnsFind.Text = "Tìm &kiếm"
        '
        'mnsListAll
        '
        Me.mnsListAll.Name = "mnsListAll"
        Me.mnsListAll.Size = New System.Drawing.Size(140, 22)
        Me.mnsListAll.Text = "&Liệt kê tất cả"
        '
        'tsbToolStripTable
        '
        Me.tsbToolStripTable.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.tsbToolStripTable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbEdit, Me.tsbDelete, Me.ToolStripSeparator1, Me.tsbFind, Me.tsbListAll, Me.ToolStripSeparator2, Me.tsbClose, Me.ToolStripSeparator3, Me.tsdActive})
        Me.tsbToolStripTable.Location = New System.Drawing.Point(0, 0)
        Me.tsbToolStripTable.Name = "tsbToolStripTable"
        Me.tsbToolStripTable.Size = New System.Drawing.Size(1018, 25)
        Me.tsbToolStripTable.TabIndex = 4
        Me.tsbToolStripTable.Text = "tbrToolStripTable"
        '
        'tsbAdd
        '
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(42, 22)
        Me.tsbAdd.Text = "&Thêm"
        '
        'tsbEdit
        '
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(30, 22)
        Me.tsbEdit.Text = "&Sửa"
        '
        'tsbDelete
        '
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(31, 22)
        Me.tsbDelete.Text = "&Xóa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbFind
        '
        Me.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFind.Name = "tsbFind"
        Me.tsbFind.Size = New System.Drawing.Size(61, 22)
        Me.tsbFind.Text = "Tìm &kiếm"
        '
        'tsbListAll
        '
        Me.tsbListAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbListAll.Name = "tsbListAll"
        Me.tsbListAll.Size = New System.Drawing.Size(77, 22)
        Me.tsbListAll.Text = "&Liệt kê tất cả"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsbClose
        '
        Me.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(40, 22)
        Me.tsbClose.Text = "Đó&ng"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsdActive
        '
        Me.tsdActive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsdActive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdd, Me.tsmEdit, Me.tsmDelete, Me.ToolStripSeparator5, Me.tsmFind, Me.tsmListAll})
        Me.tsdActive.Image = CType(resources.GetObject("tsdActive.Image"), System.Drawing.Image)
        Me.tsdActive.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdActive.Name = "tsdActive"
        Me.tsdActive.Size = New System.Drawing.Size(73, 22)
        Me.tsdActive.Text = "Thực hiện"
        '
        'tsmAdd
        '
        Me.tsmAdd.Name = "tsmAdd"
        Me.tsmAdd.Size = New System.Drawing.Size(140, 22)
        Me.tsmAdd.Text = "Thêm"
        '
        'tsmEdit
        '
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(140, 22)
        Me.tsmEdit.Text = "Sửa"
        '
        'tsmDelete
        '
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(140, 22)
        Me.tsmDelete.Text = "Xóa"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(137, 6)
        '
        'tsmFind
        '
        Me.tsmFind.Name = "tsmFind"
        Me.tsmFind.Size = New System.Drawing.Size(140, 22)
        Me.tsmFind.Text = "Tìm kiếm"
        '
        'tsmListAll
        '
        Me.tsmListAll.Name = "tsmListAll"
        Me.tsmListAll.Size = New System.Drawing.Size(140, 22)
        Me.tsmListAll.Text = "Liệt kê tất cả"
        '
        'D02F0056
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 655)
        Me.Controls.Add(Me.tsbToolStripTable)
        Me.Controls.Add(Me.tdbg)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtNormNo)
        Me.Controls.Add(Me.lblNormNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0056"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HiÓn thÜ chi tiÕt bè ¢Ünh m÷c - D02F0056"
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tsbToolStripTable.ResumeLayout(False)
        Me.tsbToolStripTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtNormNo As System.Windows.Forms.TextBox
    Private WithEvents lblNormNo As System.Windows.Forms.Label
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tsbToolStripTable As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbListAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsdActive As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmListAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnsAdd As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsDelete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_Find As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnsFind As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsListAll As System.Windows.Forms.ToolStripMenuItem
End Class