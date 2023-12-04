'#-------------------------------------------------------------------------------------
'# Created Date: 06/11/2007 8:57:16 AM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 06/11/2007 8:57:16 AM
'# Modify User: Trần Thị ÁiTrâm
'#-------------------------------------------------------------------------------------
Public Class D02F0020
	Dim report As D99C2003
	Private _bSaved As Boolean = False
	Public ReadOnly Property bSaved() As Boolean
		Get
			Return _bSaved
		   End Get
	End Property

	Private _formIDPermission As String = "D02F0020"
	Public WriteOnly Property FormIDPermission() As String
		Set(ByVal Value As String)
			       _formIDPermission = Value
		   End Set
	End Property


#Region "Const of tdbg"
    Private Const COL_DeprTableID As Integer = 0      ' Mã bảng
    Private Const COL_DeprTableName As Integer = 1    ' Tên bảng
    Private Const COL_ServiceYear As Integer = 2      ' Số năm 
    Private Const COL_QuickRate As Integer = 3        ' Tỷ lệ
    Private Const COL_Description As Integer = 4      ' Diễn giải
    Private Const COL_Disabled As Integer = 5         ' Không sử dụng 
    Private Const COL_Auto As Integer = 6             ' Auto
    Private Const COL_CreateUserID As Integer = 7     ' CreateUserID
    Private Const COL_CreateDate As Integer = 8       ' CreateDate
    Private Const COL_LastModifyUserID As Integer = 9 ' LastModifyUserID
    Private Const COL_LastModifyDate As Integer = 10  ' LastModifyDate
#End Region

    Dim dtGrid, dtCaptionCols As DataTable
    Dim bRefreshFilter As Boolean
    Dim sFilter As New System.Text.StringBuilder()

    Private Sub D02F0020_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	LoadInfoGeneral()
        SetShortcutPopupMenu(Me, TableToolStrip, ContextMenuStrip1)
        Loadlanguage()
        ResetColorGrid(tdbg)
        gbEnabledUseFind = False
        LoadTDBGrid()
        tdbg_NumberFormat()
        InputbyUnicode(Me, gbUnicode)
        SetResolutionForm(Me, ContextMenuStrip1)
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Danh_muc_bang_khau_hao_-_D02F0020") & UnicodeCaption(gbUnicode) 'Danh móc b¶ng khÊu hao - D02F0020
        '================================================================ 
        tdbg.Columns("DeprTableID").Caption = rl3("Ma_bang") 'Mã bảng
        tdbg.Columns("DeprTableName").Caption = rl3("Ten_bang") 'Tên bảng
        tdbg.Columns("ServiceYear").Caption = rl3("So_nam_") 'Số năm 
        tdbg.Columns("QuickRate").Caption = rl3("Ty_le") 'Tỷ lệ
        tdbg.Columns("Description").Caption = rl3("Dien_giai") 'Diễn giải
        tdbg.Columns("Disabled").Caption = rl3("KSD") 'KSD
        '================================================================ 
        chkShowDisabled.Text = rL3("Hien_thi_danh_muc_khong_su_dung") 'Hiển thị danh mục không sử dụng
    End Sub

    Private Sub tdbg_NumberFormat()
        tdbg.Columns(COL_QuickRate).NumberFormat = DxxFormat.DefaultNumber2
    End Sub

    Private Sub LoadTDBGrid(Optional ByVal FlagAdd As Boolean = False, Optional ByVal sKey As String = "")
        Dim sSQL As String
        sSQL = "Select     DeprTableID, DeprTableName" & UnicodeJoin(gbUnicode) & " As DeprTableName, " & vbCrLf
        sSQL &= "           ServiceYear, QuickRate, Description" & UnicodeJoin(gbUnicode) & " As Description, " & vbCrLf
        sSQL &= "           Disabled, Auto, " & vbCrLf
        sSQL &= "           Disabled, CreateDate, CreateUserID, LastModifyDate,LastModifyUserID" & vbCrLf
        sSQL &= "From       D02T0070 WITH(NOLOCK) " & vbCrLf
        sSQL &= "Where      DivisionID = " & SQLString(gsDivisionID) & vbCrLf
        sSQL &= "Order By   DeprTableID"

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
            Dim dr() As DataRow = dt1.Select("DeprTableID = " & SQLString(sKey), dt1.DefaultView.Sort)
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
            strFind &= "Disabled = 0"
        End If
        dtGrid.DefaultView.RowFilter = strFind
        ResetGrid()
    End Sub

    Private Sub ResetGrid()
        CheckMenu(_formIDPermission, TableToolStrip, tdbg.RowCount, gbEnabledUseFind, False, ContextMenuStrip1)
        FooterTotalGrid(tdbg, COL_DeprTableName)
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
        Dim f As New D02F0021
        With f
            .DeprTableID = ""
            .FormState = EnumFormState.FormAdd
            .ShowDialog()
            If .SavedOK Then LoadTDBGrid(True, .DeprTableID)
            .Dispose()
        End With
    End Sub

    Private Sub tsbView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbView.Click, tsmView.Click, mnsView.Click
        Dim f As New D02F0021
        With f
            .DeprTableID = tdbg.Columns(COL_DeprTableID).Text
            .FormState = EnumFormState.FormView
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbEdit.Click, tsmEdit.Click, mnsEdit.Click
        If Not CheckStore(SQLStoreD02P1406) Then Exit Sub
        Dim f As New D02F0021
        With f
            .DeprTableID = tdbg.Columns(COL_DeprTableID).Text
            .FormState = EnumFormState.FormEdit
            .ShowDialog()
            .Dispose()
        End With
        If f.SavedOK = True Then LoadTDBGrid(False, tdbg.Columns(COL_DeprTableID).Text)
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbDelete.Click, tsmDelete.Click, mnsDelete.Click
        If AskDelete() = Windows.Forms.DialogResult.No Then Exit Sub
        If Not CheckStore(SQLStoreD02P1405) Then Exit Sub

        Dim sSQL As String = SQLStoreD02P0071()
        Dim bRunSQL As Boolean = ExecuteSQL(sSQL)
        If bRunSQL = True Then
            DeleteGridEvent(tdbg, dtGrid, gbEnabledUseFind)
            ResetGrid()
            DeleteOK()
        Else
            DeleteNotOK()
        End If
    End Sub

    Private Sub tsbSysInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbSysInfo.Click, tsmSysInfo.Click, mnsSysInfo.Click
        ShowSysInfoDialog(Me,tdbg.Columns(COL_CreateUserID).Text, tdbg.Columns(COL_CreateDate).Text, tdbg.Columns(COL_LastModifyUserID).Text, tdbg.Columns(COL_LastModifyDate).Text)
    End Sub

    Private Sub tsbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub

    Private Sub tsbPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbPrint.Click, tsmPrint.Click, mnsPrint.Click
        'Dim report As New D99C1003
        'Đưa vể đầu tiên hàm In trước khi gọi AllowPrint()
		If Not AllowNewD99C2003(report, Me) Then Exit Sub
		'************************************
        Dim conn As New SqlConnection(gsConnectionString)
        Dim sReportName As String = "D02R0070"
        Dim sSubReportName As String = "D02R0000"
        Dim sReportCaption As String = ""
        Dim sPathReport As String = ""
        Dim sSQL As String = ""
        Dim sSQLSub As String = ""

        sReportCaption = rL3("Danh_muc_bang_khau_hao") & " - " & sReportName
        sPathReport = UnicodeGetReportPath(gbUnicode, D02Options.ReportLanguage, "") & sReportName & ".rpt"

        sSQL = "Select * From D02T0070 WITH(NOLOCK) Where DivisionID=" & SQLString(gsDivisionID)
        sSQLSub = "Select Top 1 * From D91T0025 WITH(NOLOCK)"
        UnicodeSubReport(sSubReportName, sSQLSub, , gbUnicode)

        With report
            .OpenConnection(conn)
            .AddSub(sSQLSub, sSubReportName & ".rpt")
            .AddMain(dtGrid.DefaultView.ToTable)
            .PrintReport(sPathReport, sReportCaption)
        End With
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

    Private Sub tdbg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbg.KeyPress
        '--- Chỉ cho nhập số
        Select Case tdbg.Col
            Case COL_ServiceYear
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
            Case COL_QuickRate
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
        End Select
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

    Private Function SQLStoreD02P1406() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P1406 "
        sSQL &= SQLString(tdbg.Columns(COL_DeprTableID).Text) & COMMA 'DeprTableID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gsLanguage) 'Language, tinyint, NOT NULL
        Return sSQL
    End Function

    Private Function SQLStoreD02P1405() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P1405 "
        sSQL &= SQLString(tdbg.Columns(COL_DeprTableID).Text) & COMMA 'DeprTableID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gsLanguage) 'Language, tinyint, NOT NULL
        Return sSQL
    End Function

    Private Function SQLStoreD02P0071() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0071 "
        sSQL &= SQLString(tdbg.Columns(COL_DeprTableID).Text) & COMMA 'DeprTableID, varchar[20], NOT NULL
        sSQL &= SQLString(gsDivisionID) 'DivisionID, varchar[20], NOT NULL
        Return sSQL
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AnchorResizeColumnsGrid(EnumAnchorStyles.TopLeftRightBottom, tdbg)
        AnchorForControl(EnumAnchorStyles.BottomLeft, chkShowDisabled)
    End Sub
End Class