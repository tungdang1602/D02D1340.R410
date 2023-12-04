<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class D02F0054
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(D02F0054))
        Me.tdbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnsAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsInherit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsEditOther = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_Find = New System.Windows.Forms.ToolStripSeparator
        Me.mnsFind = New System.Windows.Forms.ToolStripMenuItem
        Me.mnsListAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_SysInfo = New System.Windows.Forms.ToolStripSeparator
        Me.mnsSysInfo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_Print = New System.Windows.Forms.ToolStripSeparator
        Me.mnsPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.chkShowDisabled = New System.Windows.Forms.CheckBox
        Me.c1dateDate = New C1.Win.C1Input.C1DateEdit
        Me.TableToolStrip = New System.Windows.Forms.ToolStrip
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton
        Me.tsbInherit = New System.Windows.Forms.ToolStripButton
        Me.tsbView = New System.Windows.Forms.ToolStripButton
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbFind = New System.Windows.Forms.ToolStripButton
        Me.tsbListAll = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSysInfo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.tsdActive = New System.Windows.Forms.ToolStripDropDownButton
        Me.tsmAdd = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmInherit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmView = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmEditOther = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_DFind = New System.Windows.Forms.ToolStripSeparator
        Me.tsmFind = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmListAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_DSysInfo = New System.Windows.Forms.ToolStripSeparator
        Me.tsmSysInfo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator_DPrint = New System.Windows.Forms.ToolStripSeparator
        Me.tsmPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbShowDetail = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmShowDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnsShowDetail = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.c1dateDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'tdbg
        '
        Me.tdbg.AllowColMove = False
        Me.tdbg.AllowColSelect = False
        Me.tdbg.AllowFilter = False
        Me.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg.AllowUpdate = False
        Me.tdbg.AlternatingRows = True
        Me.tdbg.CaptionHeight = 17
        Me.tdbg.ColumnFooters = True
        Me.tdbg.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tdbg.EmptyRows = True
        Me.tdbg.ExtendRightColumn = True
        Me.tdbg.FilterBar = True
        Me.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard
        Me.tdbg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tdbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg.Images.Add(CType(resources.GetObject("tdbg.Images"), System.Drawing.Image))
        Me.tdbg.Location = New System.Drawing.Point(3, 29)
        Me.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell
        Me.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None
        Me.tdbg.Name = "tdbg"
        Me.tdbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg.PreviewInfo.ZoomFactor = 75
        Me.tdbg.PrintInfo.PageSettings = CType(resources.GetObject("tdbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg.RowHeight = 15
        Me.tdbg.Size = New System.Drawing.Size(1012, 594)
        Me.tdbg.TabAcrossSplits = True
        Me.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation
        Me.tdbg.TabIndex = 0
        Me.tdbg.Tag = "COL"
        Me.tdbg.PropBag = resources.GetString("tdbg.PropBag")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnsAdd, Me.mnsInherit, Me.mnsView, Me.mnsEdit, Me.mnsEditOther, Me.mnsDelete, Me.ToolStripSeparator6, Me.mnsShowDetail, Me.ToolStripSeparator_Find, Me.mnsFind, Me.mnsListAll, Me.ToolStripSeparator_SysInfo, Me.mnsSysInfo, Me.ToolStripSeparator_Print, Me.mnsPrint})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 270)
        '
        'mnsAdd
        '
        Me.mnsAdd.Name = "mnsAdd"
        Me.mnsAdd.Size = New System.Drawing.Size(167, 22)
        Me.mnsAdd.Text = "&Thêm"
        '
        'mnsInherit
        '
        Me.mnsInherit.Name = "mnsInherit"
        Me.mnsInherit.Size = New System.Drawing.Size(167, 22)
        Me.mnsInherit.Text = "Kế thừ&a"
        '
        'mnsView
        '
        Me.mnsView.Name = "mnsView"
        Me.mnsView.Size = New System.Drawing.Size(167, 22)
        Me.mnsView.Text = "Xe&m"
        '
        'mnsEdit
        '
        Me.mnsEdit.Name = "mnsEdit"
        Me.mnsEdit.Size = New System.Drawing.Size(167, 22)
        Me.mnsEdit.Text = "&Sửa"
        '
        'mnsEditOther
        '
        Me.mnsEditOther.Name = "mnsEditOther"
        Me.mnsEditOther.Size = New System.Drawing.Size(167, 22)
        Me.mnsEditOther.Text = "Sửa khác"
        '
        'mnsDelete
        '
        Me.mnsDelete.Name = "mnsDelete"
        Me.mnsDelete.Size = New System.Drawing.Size(167, 22)
        Me.mnsDelete.Text = "&Xóa"
        '
        'ToolStripSeparator_Find
        '
        Me.ToolStripSeparator_Find.Name = "ToolStripSeparator_Find"
        Me.ToolStripSeparator_Find.Size = New System.Drawing.Size(164, 6)
        '
        'mnsFind
        '
        Me.mnsFind.Name = "mnsFind"
        Me.mnsFind.Size = New System.Drawing.Size(167, 22)
        Me.mnsFind.Text = "Tìm &kiếm"
        '
        'mnsListAll
        '
        Me.mnsListAll.Name = "mnsListAll"
        Me.mnsListAll.Size = New System.Drawing.Size(167, 22)
        Me.mnsListAll.Text = "&Liệt kê tất cả"
        '
        'ToolStripSeparator_SysInfo
        '
        Me.ToolStripSeparator_SysInfo.Name = "ToolStripSeparator_SysInfo"
        Me.ToolStripSeparator_SysInfo.Size = New System.Drawing.Size(164, 6)
        '
        'mnsSysInfo
        '
        Me.mnsSysInfo.Name = "mnsSysInfo"
        Me.mnsSysInfo.Size = New System.Drawing.Size(167, 22)
        Me.mnsSysInfo.Text = "Thông tin &hệ thống"
        '
        'ToolStripSeparator_Print
        '
        Me.ToolStripSeparator_Print.Name = "ToolStripSeparator_Print"
        Me.ToolStripSeparator_Print.Size = New System.Drawing.Size(164, 6)
        '
        'mnsPrint
        '
        Me.mnsPrint.Name = "mnsPrint"
        Me.mnsPrint.Size = New System.Drawing.Size(167, 22)
        Me.mnsPrint.Text = "&In"
        '
        'chkShowDisabled
        '
        Me.chkShowDisabled.AutoSize = True
        Me.chkShowDisabled.Location = New System.Drawing.Point(3, 629)
        Me.chkShowDisabled.Name = "chkShowDisabled"
        Me.chkShowDisabled.Size = New System.Drawing.Size(186, 17)
        Me.chkShowDisabled.TabIndex = 11
        Me.chkShowDisabled.Text = "Hiển thị danh mục không sử dụng"
        Me.chkShowDisabled.UseVisualStyleBackColor = True
        '
        'c1dateDate
        '
        Me.c1dateDate.AutoSize = False
        Me.c1dateDate.CustomFormat = "dd/MM/yyyy"
        Me.c1dateDate.EmptyAsNull = True
        Me.c1dateDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.c1dateDate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1dateDate.Location = New System.Drawing.Point(369, 130)
        Me.c1dateDate.Name = "c1dateDate"
        Me.c1dateDate.Size = New System.Drawing.Size(100, 22)
        Me.c1dateDate.TabIndex = 12
        Me.c1dateDate.Tag = Nothing
        Me.c1dateDate.TrimStart = True
        Me.c1dateDate.Visible = False
        Me.c1dateDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'TableToolStrip
        '
        Me.TableToolStrip.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TableToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAdd, Me.tsbInherit, Me.tsbView, Me.tsbEdit, Me.tsbDelete, Me.ToolStripSeparator2, Me.tsbShowDetail, Me.ToolStripSeparator1, Me.tsbFind, Me.tsbListAll, Me.ToolStripSeparator4, Me.tsbSysInfo, Me.ToolStripSeparator5, Me.tsbPrint, Me.ToolStripSeparator9, Me.tsbClose, Me.ToolStripSeparator10, Me.tsdActive})
        Me.TableToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.TableToolStrip.Name = "TableToolStrip"
        Me.TableToolStrip.Size = New System.Drawing.Size(1018, 25)
        Me.TableToolStrip.TabIndex = 13
        '
        'tsbAdd
        '
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(38, 22)
        Me.tsbAdd.Text = "&Thêm"
        '
        'tsbInherit
        '
        Me.tsbInherit.Name = "tsbInherit"
        Me.tsbInherit.Size = New System.Drawing.Size(48, 22)
        Me.tsbInherit.Text = "Kế thừ&a"
        '
        'tsbView
        '
        Me.tsbView.Name = "tsbView"
        Me.tsbView.Size = New System.Drawing.Size(32, 22)
        Me.tsbView.Text = "Xe&m"
        '
        'tsbEdit
        '
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(30, 22)
        Me.tsbEdit.Text = "&Sửa"
        '
        'tsbDelete
        '
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(30, 22)
        Me.tsbDelete.Text = "&Xóa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsbFind
        '
        Me.tsbFind.Name = "tsbFind"
        Me.tsbFind.Size = New System.Drawing.Size(53, 22)
        Me.tsbFind.Text = "Tìm &kiếm"
        '
        'tsbListAll
        '
        Me.tsbListAll.Name = "tsbListAll"
        Me.tsbListAll.Size = New System.Drawing.Size(73, 22)
        Me.tsbListAll.Text = "&Liệt kê tất cả"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbSysInfo
        '
        Me.tsbSysInfo.Name = "tsbSysInfo"
        Me.tsbSysInfo.Size = New System.Drawing.Size(101, 22)
        Me.tsbSysInfo.Text = "Thông tin &hệ thống"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbPrint
        '
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(23, 22)
        Me.tsbPrint.Text = "&In"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tsbClose
        '
        Me.tsbClose.Name = "tsbClose"
        Me.tsbClose.Size = New System.Drawing.Size(37, 22)
        Me.tsbClose.Text = "Đón&g"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'tsdActive
        '
        Me.tsdActive.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAdd, Me.tsmInherit, Me.tsmView, Me.tsmEdit, Me.tsmEditOther, Me.tsmDelete, Me.ToolStripSeparator3, Me.tsmShowDetail, Me.ToolStripSeparator_DFind, Me.tsmFind, Me.tsmListAll, Me.ToolStripSeparator_DSysInfo, Me.tsmSysInfo, Me.ToolStripSeparator_DPrint, Me.tsmPrint})
        Me.tsdActive.Name = "tsdActive"
        Me.tsdActive.Size = New System.Drawing.Size(68, 22)
        Me.tsdActive.Text = "&Thực hiện"
        '
        'tsmAdd
        '
        Me.tsmAdd.Name = "tsmAdd"
        Me.tsmAdd.Size = New System.Drawing.Size(167, 22)
        Me.tsmAdd.Text = "&Thêm"
        '
        'tsmInherit
        '
        Me.tsmInherit.Name = "tsmInherit"
        Me.tsmInherit.Size = New System.Drawing.Size(167, 22)
        Me.tsmInherit.Text = "Kế thừ&a"
        '
        'tsmView
        '
        Me.tsmView.Name = "tsmView"
        Me.tsmView.Size = New System.Drawing.Size(167, 22)
        Me.tsmView.Text = "Xe&m"
        '
        'tsmEdit
        '
        Me.tsmEdit.Name = "tsmEdit"
        Me.tsmEdit.Size = New System.Drawing.Size(167, 22)
        Me.tsmEdit.Text = "&Sửa"
        '
        'tsmEditOther
        '
        Me.tsmEditOther.Name = "tsmEditOther"
        Me.tsmEditOther.Size = New System.Drawing.Size(167, 22)
        Me.tsmEditOther.Text = "Sửa khác"
        '
        'tsmDelete
        '
        Me.tsmDelete.Name = "tsmDelete"
        Me.tsmDelete.Size = New System.Drawing.Size(167, 22)
        Me.tsmDelete.Text = "&Xóa"
        '
        'ToolStripSeparator_DFind
        '
        Me.ToolStripSeparator_DFind.Name = "ToolStripSeparator_DFind"
        Me.ToolStripSeparator_DFind.Size = New System.Drawing.Size(164, 6)
        '
        'tsmFind
        '
        Me.tsmFind.Name = "tsmFind"
        Me.tsmFind.Size = New System.Drawing.Size(167, 22)
        Me.tsmFind.Text = "Tìm &kiếm"
        '
        'tsmListAll
        '
        Me.tsmListAll.Name = "tsmListAll"
        Me.tsmListAll.Size = New System.Drawing.Size(167, 22)
        Me.tsmListAll.Text = "&Liệt kê tất cả"
        '
        'ToolStripSeparator_DSysInfo
        '
        Me.ToolStripSeparator_DSysInfo.Name = "ToolStripSeparator_DSysInfo"
        Me.ToolStripSeparator_DSysInfo.Size = New System.Drawing.Size(164, 6)
        '
        'tsmSysInfo
        '
        Me.tsmSysInfo.Name = "tsmSysInfo"
        Me.tsmSysInfo.Size = New System.Drawing.Size(167, 22)
        Me.tsmSysInfo.Text = "Thông tin &hệ thống"
        '
        'ToolStripSeparator_DPrint
        '
        Me.ToolStripSeparator_DPrint.Name = "ToolStripSeparator_DPrint"
        Me.ToolStripSeparator_DPrint.Size = New System.Drawing.Size(164, 6)
        '
        'tsmPrint
        '
        Me.tsmPrint.Name = "tsmPrint"
        Me.tsmPrint.Size = New System.Drawing.Size(167, 22)
        Me.tsmPrint.Text = "&In"
        '
        'tsbShowDetail
        '
        Me.tsbShowDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbShowDetail.Image = CType(resources.GetObject("tsbShowDetail.Image"), System.Drawing.Image)
        Me.tsbShowDetail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShowDetail.Name = "tsbShowDetail"
        Me.tsbShowDetail.Size = New System.Drawing.Size(23, 22)
        Me.tsbShowDetail.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tsmShowDetail
        '
        Me.tsmShowDetail.Name = "tsmShowDetail"
        Me.tsmShowDetail.Size = New System.Drawing.Size(167, 22)
        Me.tsmShowDetail.Text = "Hiển thị chi tiết"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(164, 6)
        '
        'mnsShowDetail
        '
        Me.mnsShowDetail.Name = "mnsShowDetail"
        Me.mnsShowDetail.Size = New System.Drawing.Size(167, 22)
        Me.mnsShowDetail.Text = "Hiển thị chi tiết"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(164, 6)
        '
        'D02F0054
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 655)
        Me.Controls.Add(Me.c1dateDate)
        Me.Controls.Add(Me.chkShowDisabled)
        Me.Controls.Add(Me.tdbg)
        Me.Controls.Add(Me.TableToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "D02F0054"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh móc ¢Ünh m÷c khÊu hao -  D02F0054"
        CType(Me.tdbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.c1dateDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableToolStrip.ResumeLayout(False)
        Me.TableToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tdbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private WithEvents chkShowDisabled As System.Windows.Forms.CheckBox
    Private WithEvents c1dateDate As C1.Win.C1Input.C1DateEdit
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnsAdd As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsInherit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsView As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsDelete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_Find As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnsFind As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnsListAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_SysInfo As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnsSysInfo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_Print As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnsPrint As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents TableToolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents tsbAdd As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbInherit As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbView As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbEdit As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbDelete As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbFind As System.Windows.Forms.ToolStripButton
    Private WithEvents tsbListAll As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbSysInfo As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbPrint As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsbClose As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsdActive As System.Windows.Forms.ToolStripDropDownButton
    Private WithEvents tsmAdd As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmInherit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmView As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmDelete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_DFind As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsmFind As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsmListAll As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_DSysInfo As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsmSysInfo As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator_DPrint As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tsmPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsEditOther As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmEditOther As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnsShowDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShowDetail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmShowDetail As System.Windows.Forms.ToolStripMenuItem
End Class