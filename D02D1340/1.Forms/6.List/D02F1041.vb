'#---------------------------------------------------------------------------------------------------
'# Title: D02E1041
'# Created User: Lê Thị Thanh Hiền
'# Created Date: 31/07/2007 10:51:43
'# Modified User: 
'# Modified Date: 
'# Description: 
'#---------------------------------------------------------------------------------------------------
Public Class D02F1041
	Private _formIDPermission As String = "D02F1041"
	Public WriteOnly Property FormIDPermission() As String
		Set(ByVal Value As String)
			       _formIDPermission = Value
		   End Set
	End Property

   
    Dim dtGrid, dtCaptionCols As DataTable
    Dim bRefreshFilter As Boolean
    Dim sFilter As New System.Text.StringBuilder()

#Region "Const of tdbg"
    Private Const COL_SplitMethodNo As Integer = 0    ' Mã phương pháp
    Private Const COL_SplitMethodName As Integer = 1  ' Tên phương pháp
    Private Const COL_Disabled As Integer = 2         ' Không sử dụng
    Private Const COL_CreateUserID As Integer = 3     ' CreateUserID
    Private Const COL_CreateDate As Integer = 4       ' CreateDate
    Private Const COL_LastModifyUserID As Integer = 5 ' LastModifyUserID
    Private Const COL_LastModifyDate As Integer = 6   ' LastModifyDate
#End Region

    Private Sub D02F1041_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
    End Sub

    Private Sub D02F1041_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        gbEnabledUseFind = False
        SetShortcutPopupMenu(Me, TableToolStrip, ContextMenuStrip1)
        Loadlanguage()
        ResetColorGrid(tdbg)
        LoadTDBGrid()
    SetResolutionForm(Me)

SetResolutionForm(Me, ContextMenuStrip1)
Me.Cursor = Cursors.Default
End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Danh_muc_phuong_phap_tach_chi_phi__D02F1041") & UnicodeCaption(gbUnicode) 'Danh móc ph§¥ng phÀp tÀch chi phÛ - D02F1041
        '================================================================ 
        tdbg.Columns("SplitMethodNo").Caption = rl3("Ma_phuong_phap") 'Mã phương pháp
        tdbg.Columns("SplitMethodName").Caption = rl3("Ten_phuong_phap") 'Tên phương pháp
        tdbg.Columns("Disabled").Caption = rl3("KSD") 'KSD
        '================================================================ 
        chkShowDisabled.Text = rl3("Hien_thi_danh_muc_khong_su_dung") 'Hiển thị danh mục không sử dụng
    End Sub

    Private Sub LoadTDBGrid(Optional ByVal FlagAdd As Boolean = False, Optional ByVal sKey As String = "")
        Dim sSQL As String
        sSQL = "Select SplitMethodNo, SplitMethodName" & UnicodeJoin(gbUnicode) & " As SplitMethodName, Disabled, "
        sSQL &= "CreateUserID, CreateDate, LastModifyUserID, LastModifyDate " & vbCrLf
        sSQL &= "From D02T0014 WITH(NOLOCK) "
        sSQL &= "Order by SplitMethodNo"
        dtGrid = ReturnDataTable(sSQL)

        gbEnabledUseFind = dtGrid.Rows.Count > 0

        If FlagAdd Then ' Thêm mới thì set Filter = "" và sFind =""
            ResetFilter(tdbg, sFilter, bRefreshFilter)
            sFind = ""
            sFilter = New System.Text.StringBuilder("")
        End If

        LoadDataSource(tdbg, dtGrid, gbUnicode)
        ReLoadTDBGrid()

        If sKey <> "" Then
            Dim dt1 As DataTable = dtGrid.DefaultView.ToTable
            Dim dr() As DataRow = dt1.Select("SplitMethodNo = " & SQLString(sKey), dt1.DefaultView.Sort)
            If dr.Length > 0 Then tdbg.Row = dt1.Rows.IndexOf(dr(0))
        End If

        If Not tdbg.Focused Then tdbg.Focus() 'Nếu con trỏ chưa đứng trên lưới thì Focus về lưới
    End Sub

    Private Sub ReLoadTDBGrid()
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
        CheckMenu(_formIDPermission, TableToolStrip, tdbg.RowCount, gbEnabledUseFind, False, ContextMenuStrip1)
        FooterTotalGrid(tdbg, COL_SplitMethodName)
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
        ''If Not CallMenuFromGrid(sender, tdbg) Then Exit Sub
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
        ''If Not CallMenuFromGrid(sender, tdbg) Then Exit Sub
        sFind = ""
        ResetFilter(tdbg, sFilter, bRefreshFilter)
        ReLoadTDBGrid()
    End Sub

#End Region

#Region "Menu bar"

    Private Sub tsbAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbAdd.Click, tsmAdd.Click, mnsAdd.Click
        Dim f As New D02F1402()
        With f
            .SplitMethodNo = ""
            .FormState = EnumFormState.FormAdd
            .ShowDialog()
            If f.SavedOK Then LoadTDBGrid(True, .SplitMethodNo)
            .Dispose()
        End With
    End Sub

    Private Sub tsbView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbView.Click, tsmView.Click, mnsView.Click
        Dim f As New D02F1402()
        With f
            .SplitMethodNo = tdbg.Columns(COL_SplitMethodNo).Text
            .FormState = EnumFormState.FormView
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbEdit.Click, tsmEdit.Click, mnsEdit.Click
        If Not AllowEdit_Delete(SQLStoreD02P1400(0)) Then Exit Sub
        Dim f As New D02F1402
        With f
            .SplitMethodNo = tdbg.Columns(COL_SplitMethodNo).Text
            .FormState = EnumFormState.FormEdit
            .ShowDialog()
            .Dispose()
        End With
        If f.SavedOK Then LoadTDBGrid(False, tdbg.Columns(COL_SplitMethodNo).Text)
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbDelete.Click, tsmDelete.Click, mnsDelete.Click
        If Not AllowEdit_Delete(SQLStoreD02P1400(1)) Then Exit Sub
        If D99C0008.MsgAskDelete = Windows.Forms.DialogResult.No Then Exit Sub

        Dim sSQL As String = ""
        sSQL = SQLDeleteD02T0014() & vbCrLf
        sSQL &= SQLDeleteD02T0015()

        Dim bResult As Boolean = ExecuteSQL(sSQL)
        If bResult Then
            DeleteGridEvent(tdbg, dtGrid, gbEnabledUseFind)
            ResetGrid()
            DeleteOK()
        Else
            DeleteNotOK()
        End If
    End Sub

    Function AllowEdit_Delete(ByVal sSQL As String) As Boolean
        Return CheckStore(sSQL)
    End Function

    Private Sub tsbSysInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbSysInfo.Click, tsmSysInfo.Click, mnsSysInfo.Click
        ShowSysInfoDialog(Me,tdbg.Columns(COL_CreateUserID).Text, tdbg.Columns(COL_CreateDate).Text, tdbg.Columns(COL_LastModifyUserID).Text, tdbg.Columns(COL_LastModifyDate).Text)
    End Sub

    Private Sub tsbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub chkShowDisabled_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkShowDisabled.CheckedChanged
        If dtGrid Is Nothing Then Exit Sub
        ReLoadTDBGrid()
    End Sub

#End Region

#Region "Grid"

    Private Sub tdbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.DoubleClick
        If tdbg.FilterActive Then Exit Sub
        If tsbEdit.Enabled Then
            tsbEdit_Click(sender, Nothing)
        ElseIf tsbView.Enabled Then
            tsbView_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter Then tdbg_DoubleClick(Nothing, Nothing)
        HotKeyCtrlVOnGrid(tdbg, e)
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

#End Region

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P1400
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 26/09/2007 10:13:12
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P1400(ByVal iMode As Integer) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P1400 "
        sSQL &= SQLString(tdbg.Columns(COL_SplitMethodNo).Text) & COMMA 'SplitMethodNo, varchar[20], NOT NULL
        sSQL &= SQLNumber(geLanguage) & COMMA 'Language, int, NOT NULL
        sSQL &= SQLNumber(iMode) 'IsDelete, tinyint, NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD02T0014
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 10:12:05
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0014() As String
        Dim sSQL As String = ""
        sSQL &= "Delete From D02T0014"
        sSQL &= " Where "
        sSQL &= "SplitMethodNo = " & SQLString(tdbg.Columns(COL_SplitMethodNo).Text)
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD02T0015
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 10:13:26
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0015() As String
        Dim sSQL As String = ""
        sSQL &= "Delete From D02T0015"
        sSQL &= " Where "
        sSQL &= "SplitMethodNo = " & SQLString(tdbg.Columns(COL_SplitMethodNo).Text)
        Return sSQL
    End Function

End Class
