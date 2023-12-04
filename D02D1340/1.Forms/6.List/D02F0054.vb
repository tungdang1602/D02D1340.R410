'#-------------------------------------------------------------------------------------
'# Created Date: 13/11/2007 8:45:10 AM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 05/05/2011 8:31:19 AM
'# Modify User: Nguyễn Đức Trọng
'#-------------------------------------------------------------------------------------

Public Class D02F0054
	Dim report As D99C2003
	Private _formIDPermission As String = "D02F0054"
	Public WriteOnly Property FormIDPermission() As String
		Set(ByVal Value As String)
			       _formIDPermission = Value
		   End Set
	End Property


#Region "Const of tdbg"
    Private Const COL_No As Integer = 0                ' STT
    Private Const COL_NormID As Integer = 1            ' NormID
    Private Const COL_NormNo As Integer = 2            ' Mã bộ định mức
    Private Const COL_NormDate As Integer = 3          ' Ngày thiết lập
    Private Const COL_NormCreatorID As Integer = 4     ' Người thiết lập
    Private Const COL_Description As Integer = 5       ' Diễn giải
    Private Const COL_Disabled As Integer = 6          ' Không sử dụng 
    Private Const COL_GroupField As Integer = 7        ' Nhóm theo
    Private Const COL_CreateUserID As Integer = 8      ' CreateUserID
    Private Const COL_CreateDate As Integer = 9        ' CreateDate
    Private Const COL_LastModifyUserID As Integer = 10 ' LastModifyUserID
    Private Const COL_LastModifyDate As Integer = 11   ' LastModifyDate
#End Region

    Dim dtGrid, dtCaptionCols As DataTable
    Dim bRefreshFilter As Boolean
    Dim sFilter As New System.Text.StringBuilder()

    Private Sub D02F0054_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        Me.Cursor = Cursors.WaitCursor
        gbEnabledUseFind = False
        tdbg.Columns(COL_NormDate).Editor = c1dateDate
        ResetColorGrid(tdbg)
        Loadlanguage()
        LoadTDBGrid()
        SetShortcutPopupMenu(Me, TableToolStrip, ContextMenuStrip1)
        SetResolutionForm(Me, ContextMenuStrip1)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Danh_muc_dinh_muc_khau_hao_-__D02F0054") & UnicodeCaption(gbUnicode) 'Danh móc ¢Ünh m÷c khÊu hao -  D02F0054
        '================================================================ 
        tdbg.Columns("No").Caption = rl3("STT") 'STT
        tdbg.Columns("NormNo").Caption = rl3("Ma_bo_dinh_muc") 'Mã bộ định mức
        tdbg.Columns("NormDate").Caption = rl3("Ngay_thiet_lap") 'Ngày thiết lập
        tdbg.Columns("NormCreatorID").Caption = rl3("Nguoi_thiet_lap") 'Người thiết lập
        tdbg.Columns("Description").Caption = rl3("Dien_giai") 'Diễn giải
        tdbg.Columns("Disabled").Caption = rl3("KSD") 'KSD
        tdbg.Columns("GroupField").Caption = rl3("Nhom_theo") 'Nhóm theo
        '================================================================ 
        chkShowDisabled.Text = rl3("Hien_thi_danh_muc_khong_su_dung") 'Hiển thị danh mục không sử dụng
    End Sub

    Private Sub LoadTDBGrid(Optional ByVal FlagAdd As Boolean = False, Optional ByVal sKey As String = "")
        Dim sSQL As String = ""
        sSQL = "Select 0 as No, T54.NormID, T54.NormNo, T54.NormDate, T54.NormCreatorID, " & vbCrLf
        sSQL &= "T54.Description" & UnicodeJoin(gbUnicode) & " As Description, " & vbCrLf
        sSQL &= "T54.Disabled, T54.GroupField, T54.CreateUserID, T54.CreateDate, T54.LastModifyUserID, T54.LastModifyDate" & vbCrLf
        sSQL &= "From D02T0054 T54 WITH(NOLOCK)" & vbCrLf
        sSQL &= "Where T54.DivisionID = " & SQLString(gsDivisionID) & " Or T54.NormID = 'BDMKHDT'" & vbCrLf
        sSQL &= "Order By T54.NormNo"
        dtGrid = ReturnDataTable(sSQL)

        gbEnabledUseFind = dtGrid.Rows.Count > 0

        If FlagAdd Then ' Thêm mới thì set Filter = "" và sFind =""
            ResetFilter(tdbg, sFilter, bRefreshFilter)
            sFind = ""
        End If

        LoadDataSource(tdbg, dtGrid, gbUnicode)
        ReLoadTDBGrid()

        If sKey <> "" Then
            Dim dt1 As DataTable = dtGrid.DefaultView.ToTable
            Dim dr() As DataRow = dt1.Select("NormNo = " & SQLString(sKey), dt1.DefaultView.Sort)
            If dr.Length > 0 Then tdbg.Row = dt1.Rows.IndexOf(dr(0))
        End If

        If Not tdbg.Focused Then tdbg.Focus() 'Nếu con trỏ chưa đứng trên lưới thì Focus về lưới
    End Sub

    Private Sub ReLoadTDBGrid(Optional ByVal bUseFilterBar As Boolean = False)
        Dim strFind As String = sFind
        If sFilter.ToString.Equals("") = False And strFind.Equals("") = False Then strFind &= " And "
        strFind &= sFilter.ToString

        If Not chkShowDisabled.Checked Then
            If strFind <> "" Then strFind &= " And "
            strFind &= "Disabled =0"
        End If
        dtGrid.DefaultView.RowFilter = strFind
        ResetGrid()
    End Sub

    Private Sub ResetGrid()
        CheckMyMenu()
        FooterTotalGrid(tdbg, COL_NormNo)
        UpdateTDBGOrderNum(tdbg, COL_No, , True)
    End Sub

    Private Sub CheckMyMenu()
        CheckMenu(_formIDPermission, TableToolStrip, tdbg.RowCount, gbEnabledUseFind, False, ContextMenuStrip1)

        If tdbg.Columns(COL_NormID).Text = "BDMKHDT" Then
            tsbInherit.Enabled = False
            tsmInherit.Enabled = tsbInherit.Enabled
            mnsInherit.Enabled = tsbInherit.Enabled

            'tsbEdit.Enabled = tsbEdit.Enabled And Not ExistRecord("Select top 1 1 From D02T0012 Where TransactionTypeID = 'KH'")
            'tsmEdit.Enabled = tsbEdit.Enabled
            'mnsEdit.Enabled = tsbEdit.Enabled

            tsbDelete.Enabled = False
            tsmDelete.Enabled = tsbDelete.Enabled
            mnsDelete.Enabled = tsbDelete.Enabled
        Else
            tsbInherit.Enabled = tsbAdd.Enabled And tdbg.RowCount > 0
            tsmInherit.Enabled = tsbInherit.Enabled
            mnsInherit.Enabled = tsbInherit.Enabled

            'If ExistRecord("SELECT Top 1 1 FROM D02T0012 WHERE NormID = " & SQLString(tdbg.Columns(COL_NormID).Text)) Then
            '    tsbEdit.Enabled = False
            '    tsmEdit.Enabled = tsbEdit.Enabled
            '    mnsEdit.Enabled = tsbEdit.Enabled

            tsbDelete.Enabled = True
            tsmDelete.Enabled = tsbDelete.Enabled
            mnsDelete.Enabled = tsbDelete.Enabled
            'End If
        End If

        'tsmEditOther.Enabled = tsbEdit.Enabled
        'mnsEditOther.Enabled = tsmEditOther.Enabled
    End Sub

#Region "Active Find Client - List All "
    Private WithEvents Finder As New D99C1001
	Dim gbEnabledUseFind As Boolean = False
    'Cần sửa Tìm kiếm như sau:
	'Bỏ sự kiện Finder_FindClick.
	'Sửa tham số Me.Name -> Me
	'Phải tạo biến properties có tên chính xác strNewFind và strNewServer
	'Sửa gdtCaptionExcel thành dtCaptionCols: biến toàn cục trong form
	'Nếu có F12 dùng D09U1111 thì Sửa dtCaptionCols thành ResetTableByGrid(usrOption, dtCaptionCols.DefaultView.ToTable)
    Private sFind As String = ""
	Public WriteOnly Property strNewFind() As String
		Set(ByVal Value As String)
			sFind = Value
			ReLoadTDBGrid()'Làm giống sự kiện Finder_FindClick. Ví dụ đối với form Báo cáo thường gọi btnPrint_Click(Nothing, Nothing): sFind = "
		End Set
	End Property


    Private Sub tsbFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbFind.Click, tsmFind.Click, mnsFind.Click
        gbEnabledUseFind = True
        '*****************************************
        'Chuẩn hóa D09U1111 : Tìm kiếm dùng table caption có sẵn
        tdbg.UpdateData()
        'If dtCaptionCols Is Nothing OrElse dtCaptionCols.Rows.Count < 1 Then 'Incident 72333
        Dim Arr As New ArrayList
        AddColVisible(tdbg, SPLIT0, Arr, , , , gbUnicode)
        dtCaptionCols = CreateTableForExcelOnly(tdbg, Arr)
        'End If
        ShowFindDialogClient(Finder, dtCaptionCols, Me, "0", gbUnicode)
    End Sub

    Private Sub tsbListAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbListAll.Click, tsmListAll.Click, mnsListAll.Click

        sFind = ""
        ResetFilter(tdbg, sFilter, bRefreshFilter)
        ReLoadTDBGrid()
    End Sub

#End Region

#Region "Menu bar"

    Private Sub tsbAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbAdd.Click, tsmAdd.Click, mnsAdd.Click
        Dim f As New D02F0055
        With f
            .NormID = ""
            .NormNo = ""
            .FormState = EnumFormState.FormAdd
            .ShowDialog()
            If f.SavedOK Then LoadTDBGrid(True, .NormNo)
            .Dispose()
        End With
    End Sub

    Private Sub tsbInherit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbInherit.Click, tsmInherit.Click, mnsInherit.Click
        Dim f As New D02F0055
        With f
            .InheritNormID = tdbg.Columns(COL_NormID).Text
            .NormNo = tdbg.Columns(COL_NormNo).Text
            .FormState = EnumFormState.FormOther
            .ShowDialog()
            .Dispose()
            If f.SavedOK Then LoadTDBGrid(True, .NormNo)
        End With
    End Sub

    Private Sub tsbView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbView.Click, tsmView.Click, mnsView.Click
        Dim f As New D02F0055
        With f
            .NormID = tdbg.Columns(COL_NormID).Text
            .NormNo = tdbg.Columns(COL_NormNo).Text
            .FormState = EnumFormState.FormView
            .ShowDialog()
            .Dispose()
        End With

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbEdit.Click, tsmEdit.Click, mnsEdit.Click

        'Dim sSQL As String = SQLStoreD02P1054(0)
        'Dim dt As DataTable = ReturnDataTable(sSQL)

        If CheckStore(SQLStoreD02P1054(0)) Then

            'End If
            'If dt.Rows.Count > 0 Then
            '    If dt.Rows(0).Item("Status").ToString <> "0" Then
            '        D99C0008.Msg(dt.Rows(0).Item("Message").ToString)
            '        Exit Sub
            '    End If
            'If IsExistKey("D02T0012", "NormID", tdbg.Columns(COL_NormID).Text) Then
            '    D99C0008.MsgL3(rl3("Bo_dinh_muc_nay_da_duoc_su_dung_de_tinh_khau_hao") & Space(1) & rl3("Ban_khong_duoc_phep_suaU"))
            '    Exit Sub
            'End If
            'If IsExistKey("D02T0055", "NormID", tdbg.Columns(COL_NormID).Text) Then
            '    D99C0008.MsgL3(rl3("Bo_dinh_muc_nay_da_duoc_nhap_chi_tiet_cho_cac_tai_san") & Space(1) & rl3("Ban_khong_duoc_phep_suaU"))
            '    Exit Sub
            'End If

            Dim f As New D02F0055
            With f
                .NormID = tdbg.Columns(COL_NormID).Text
                .NormNo = tdbg.Columns(COL_NormNo).Text
                .FormState = EnumFormState.FormEdit
                .ShowDialog()
                .Dispose()
            End With

            If f.SavedOK Then LoadTDBGrid(False, tdbg.Columns(COL_NormNo).Text)
        End If
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbDelete.Click, tsmDelete.Click, mnsDelete.Click
        If CheckStore(SQLStoreD02P1054(1)) Then
            Dim sSQL As String = "" 'SQLStoreD02P1054(1)
            'Dim dt As DataTable = ReturnDataTable(sSQL)
            'If dt.Rows.Count > 0 Then
            '    If dt.Rows(0).Item("Status").ToString <> "0" Then
            '        D99C0008.Msg(dt.Rows(0).Item("Message").ToString)
            '        Exit Sub
            '    End If
            'da kiem tra trong store SQLStoreD02P1054 theo incident 52348 của Thị Hiệp bởi Văn Vinh
            'If IsExistKey("D02T0012", "NormID", tdbg.Columns(COL_NormID).Text) Then
            '    D99C0008.MsgL3(rl3("Bo_dinh_muc_nay_da_duoc_su_dung_de_tinh_khau_hao") & Space(1) & rl3("Ban_khong_duoc_phep_xoa"))
            '    Exit Sub
            'End If
            'If IsExistKey("D02T0055", "NormID", tdbg.Columns(COL_NormID).Text) Then
            '    D99C0008.MsgL3(rl3("Bo_dinh_muc_nay_da_duoc_nhap_chi_tiet_cho_cac_tai_san") & Space(1) & rl3("Ban_khong_duoc_phep_xoa"))
            '    Exit Sub
            'End If

            If D99C0008.MsgAskDelete = Windows.Forms.DialogResult.No Then Exit Sub
            sSQL = "Delete D02T0055 Where NormID=" & SQLString(tdbg.Columns(COL_NormID).Text) & vbCrLf
            sSQL &= "Delete D02T0054 Where NormID=" & SQLString(tdbg.Columns(COL_NormID).Text)
            Dim bResult As Boolean = ExecuteSQL(sSQL)
            If bResult Then
                DeleteOK()
                DeleteGridEvent(tdbg, dtGrid, gbEnabledUseFind)
                ResetGrid()
            Else
                DeleteNotOK()
            End If
        End If
    End Sub

    Private Sub tsmEditOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEditOther.Click, mnsEditOther.Click
        Dim f As New D02F0055
        With f
            .NormID = tdbg.Columns(COL_NormID).Text
            .NormNo = tdbg.Columns(COL_NormNo).Text
            .FormState = EnumFormState.FormEditOther
            .ShowDialog()
            .Dispose()
        End With

        If f.SavedOK Then LoadTDBGrid(False, tdbg.Columns(COL_NormNo).Text)

    End Sub

    Private Sub tsmShowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbShowDetail.Click, tsmShowDetail.Click, mnsShowDetail.Click
        Dim sSQL As String = SQLStoreD02P1054(2)
        Dim dt As DataTable = ReturnDataTable(sSQL)
        If CheckStore(SQLStoreD02P1054(2), True) Then
            'If dt.Rows.Count > 0 Then
            '    If dt.Rows(0).Item("Status").ToString <> "0" Then
            '        Dim dialog As DialogResult = D99C0008.MsgAsk(dt.Rows(0).Item("Message").ToString)
            '        If dialog = Windows.Forms.DialogResult.No Then
            '            Exit Sub
            '        End If
            '        'If MessageBox.Show(dt.Rows(0).Item("Message").ToString, MsgAnnouncement, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then
            '        '    Exit Sub
            '        'End If
            '    End If
            Dim f As New D02F0056
            With f
                .NormID = tdbg.Columns(COL_NormID).Text
                .NormNo = tdbg.Columns(COL_NormNo).Text
                .Description = tdbg.Columns(COL_Description).Text
                .Status = dt.Rows(0).Item("Status").ToString

                .ShowDialog()
                .Dispose()
            End With
        End If
    End Sub

    Private Sub tsbSysInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbSysInfo.Click, tsmSysInfo.Click, mnsSysInfo.Click
        ShowSysInfoDialog(Me,tdbg.Columns(COL_CreateUserID).Text, tdbg.Columns(COL_CreateDate).Text, tdbg.Columns(COL_LastModifyUserID).Text, tdbg.Columns(COL_LastModifyDate).Text)
    End Sub

    Private Sub tsbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbPrint.Click, tsmPrint.Click, mnsPrint.Click

        Me.Cursor = Cursors.WaitCursor

        'Dim report As New D99C1003
        'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
		If Not AllowNewD99C2003(report, Me) Then Exit Sub
		'************************************
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sReportName As String = "D02R0054"
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        sReportCaption = rl3("Danh_muc_dinh_muc_khau_haoF") & " - " & sReportName
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, "") & sReportName & ".rpt"

        sSQL = "Select      * From D02T0054 WITH(NOLOCK)" & vbCrLf
        sSQL &= "Where      Case When NormID = 'BDMKHDT' Then  " & SQLString(gsDivisionID) & vbCrLf
        sSQL &= "           Else DivisionID End =" & SQLString(gsDivisionID) & vbCrLf
        sSQL &= "Order By   NormNo"
        sSQLSub = "Select Top 1 * From D91T0025 WITH(NOLOCK)"
        UnicodeSubReport(sSubReportName, sSQLSub, , gbUnicode)

        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(dtGrid.DefaultView.ToTable)
            .PrintReport(sPathReport, sReportCaption)
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chkShowDisabled_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowDisabled.CheckedChanged
        If dtGrid Is Nothing Then Exit Sub
        ReLoadTDBGrid()
    End Sub
#End Region

#Region "Grid"

    Private Sub tdbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.DoubleClick
        If tdbg.FilterActive Then Exit Sub
        CheckMyMenu()

        If tsbEdit.Enabled Then
            tsbEdit_Click(sender, Nothing)
        ElseIf tsbView.Enabled Then
            tsbView_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tdbg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbg.KeyPress
        Select Case tdbg.Col
            Case COL_No 'Chặn nhập liệu trên cột STT tăng tự động trong code
                e.Handled = Not (ChrW(Keys.Return).Equals(e.KeyChar) Or ChrW(Keys.Tab).Equals(e.KeyChar))
            Case COL_Disabled 'Chặn Ctrl + V trên cột Check
                e.Handled = Not ChrW(Keys.Space).Equals(e.KeyChar)
        End Select

    End Sub

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter Then tdbg_DoubleClick(Nothing, Nothing)
        HotKeyCtrlVOnGrid(tdbg, e)
    End Sub

    Private Sub tdbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbg.RowColChange
  If e IsNot Nothing AndAlso e.LastRow = -1 Then Exit Sub
        If e.LastRow = tdbg.Row Then Exit Sub
        CheckMyMenu()
    End Sub

    Private Sub tdbg_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.FilterChange
        Try
            If (dtGrid Is Nothing) Then Exit Sub
            If bRefreshFilter Then Exit Sub 'set FilterText ="" thì thoát
            FilterChangeGrid(tdbg, sFilter)
            ReLoadTDBGrid()
        Catch ex As Exception
            'MessageBox.Show(ex.Message & " - " & ex.Source)
            WriteLogFile(ex.Message) 'Ghi file log TH nhập số >MaxInt cột Byte
        End Try
    End Sub

    Private Sub c1dateDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1dateDate.KeyDown
        'Fix: khi xóa giá trị sau đó nhấn TAB thì không giữ lại giá trị cũ
        Try
            If e.KeyCode = Keys.Tab Then
                'Chú ý: Nếu cột cuối cùng hiển thị là Date thì không cộng
                tdbg.Col = tdbg.Col + 1
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

#Region "Store"

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P1054
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 13/11/2007 04:48:40
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P1054(ByVal imode As Integer) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P1054 "
        sSQL &= SQLString(tdbg.Columns(COL_NormID).Text) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(gsLanguage) & COMMA 'Language, varchar[20], NOT NULL
        sSQL &= SQLNumber(imode)
        Return sSQL
    End Function

    Public Function CheckStore1(ByVal SQL As String) As Boolean
        Dim dt As New DataTable
        dt = ReturnDataTable(SQL)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Status").ToString <> "0" Then
                'MessageBox.Show(dt.Rows(0).Item("Message").ToString, MsgAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Information)
                dt = Nothing
                Return False
            End If
            dt = Nothing
        Else
            D99C0008.MsgL3(rl3("Khong_co_dong_nao_tra_ra_tu_Store"))
            Return False
        End If
        Return True
    End Function


#End Region

    Private Sub tdbg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbg.MouseDown
        'COL_NormID
       
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AnchorResizeColumnsGrid(EnumAnchorStyles.TopLeftRightBottom, tdbg)
        AnchorForControl(EnumAnchorStyles.BottomLeft, chkShowDisabled)
    End Sub
End Class