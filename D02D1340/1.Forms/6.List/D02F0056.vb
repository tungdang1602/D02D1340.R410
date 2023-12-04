Imports System
'#-------------------------------------------------------------------------------------
'# Created Date: 14/11/2007 10:51:29 AM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 14/11/2007 10:51:29 AM
'# Modify User: Trần Thị ÁiTrâm
'#-------------------------------------------------------------------------------------
Public Class D02F0056
	Private _formIDPermission As String = "D02F0056"
	Public WriteOnly Property FormIDPermission() As String
		Set(ByVal Value As String)
			       _formIDPermission = Value
		   End Set
	End Property

    Private dtFind, dtCaptionCols As DataTable
    Dim sFilter As New System.Text.StringBuilder()
    Dim bRefreshFilter As Boolean = False 'Cờ bật set FilterText =""
    Dim iCols() As Integer = {COL_ConvertedAmount, COL_Amount, COL_MinDep, COL_MaxDep}

#Region "Const of tdbg - Total of Columns: 9"
    Private Const COL_No As Integer = 0              ' STT
    Private Const COL_AssetID As Integer = 1         ' Mã tài sản
    Private Const COL_AssetName As Integer = 2       ' Tên tài sản
    Private Const COL_GroupID As Integer = 3         ' Mã nhóm
    Private Const COL_ConvertedAmount As Integer = 4 ' Nguyên tệ
    Private Const COL_Amount As Integer = 5          ' Mức khấu hao
    Private Const COL_MinDep As Integer = 6          ' Mức khấu hao tối thiểu
    Private Const COL_MaxDep As Integer = 7          ' Mức khấu hao tối đa
    Private Const COL_IsNotCalDep As Integer = 8     ' Không tính khấu hao
#End Region

    Private _normNo As String = ""
    Public Property NormNo() As String
        Get
            Return _normNo
        End Get
        Set(ByVal value As String)
            _normNo = value
        End Set
    End Property

    Private _normID As String = ""
    Public Property NormID() As String
        Get
            Return _normID
        End Get
        Set(ByVal value As String)
            _normID = value
        End Set
    End Property

    Private _description As String = ""
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _status As String = ""
    Public Property Status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property


    Private Sub D02F0056_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
        If e.KeyCode = Keys.F11 Then
            HotKeyF11(Me, tdbg)
        End If
    End Sub

    Private Sub D02F0056_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	LoadInfoGeneral()
        gbEnabledUseFind = False
        Loadlanguage()
        ResetColorGrid(tdbg)
        LoadMaster()
        tdbg_NumberFormat()
        LoadTDBGrid()
        '***************
        InputbyUnicode(Me, gbUnicode)
        '***************
        SetShortcutPopupMenu(Me, tsbToolStripTable, ContextMenuStrip1)
        SetResolutionForm(Me, ContextMenuStrip1)
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Hien_thi_chi_tiet_bo_dinh_muc_-_D02F0056") & UnicodeCaption(gbUnicode) 'HiÓn thÜ chi tiÕt bè ¢Ünh m÷c - D02F0056
        '================================================================ 
        lblNormNo.Text = rl3("Bo_dinh_muc") 'Bộ định mức
        '================================================================ 
        tdbg.Columns("No").Caption = rl3("STT") 'STT
        tdbg.Columns("AssetID").Caption = rl3("Ma_tai_san") 'Mã tài sản
        tdbg.Columns("AssetName").Caption = rl3("Ten_tai_san") 'Tên tài sản
        tdbg.Columns("GroupID").Caption = rl3("Ma_nhom") 'Mã nhóm
        tdbg.Columns("ConvertedAmount").Caption = rl3("Nguyen_te") 'Nguyên tệ
        tdbg.Columns("Amount").Caption = rl3("Muc_khau_hao") 'Mức khấu hao
        tdbg.Columns("MinDep").Caption = rl3("Muc_khau_hao_toi_thieu") 'Mức khấu hao tối thiểu
        tdbg.Columns("MaxDep").Caption = rL3("Muc_khau_hao_toi_da") 'Mức khấu hao tối đa
        '24/3/2022, Đinh Văn Khanh:id 217176-SVI_ Cập nhật PP khấu hao TSCD cho tất cả các TS có nghiệp vụ tác động
        tdbg.Columns("IsNotCalDep").Caption = rL3("Khong_tinh_khau_hao")     ' Không tính khấu hao
        '================================================================ 
    End Sub

    Private Sub tdbg_NumberFormat()
        tdbg.Columns(COL_ConvertedAmount).NumberFormat = DxxFormat.D90_ConvertedDecimals
        tdbg.Columns(COL_Amount).NumberFormat = DxxFormat.DecimalPlaces
        tdbg.Columns(COL_MinDep).NumberFormat = DxxFormat.D90_ConvertedDecimals
        tdbg.Columns(COL_MaxDep).NumberFormat = DxxFormat.D90_ConvertedDecimals
    End Sub

    Private Sub LoadMaster()
        txtNormNo.Text = _normNo
        txtDescription.Text = _description
    End Sub

    Private Sub LoadTDBGrid(Optional ByVal FlagAdd As Boolean = False, Optional ByVal sKey As String = "")
        Dim sSQL As String = ""

        If _normID = "BDMKHDT" Then
            sSQL = SQLStoreD02P0040()
            dtFind = ReturnDataTable(sSQL)
        Else
            'sSQL = "Select '' as No, T01.AssetID, T01.AssetName" & UnicodeJoin(gbUnicode) & " As AssetName, " & vbCrLf
            'sSQL &= "T55.Amount, T01.ConvertedAmount, T55.GroupID, T55.MaxDep, T55.MinDep" & vbCrLf
            'sSQL &= "From D02T0055 T55 Inner Join D02T0001 T01 On T01.AssetID = T55.AssetID" & vbCrLf
            'sSQL &= "Where NormID =" & SQLString(_normID) & " And T01.DivisionID = " & SQLString(gsDivisionID) & vbCrLf
            dtFind = ReturnDataTable(SQLStoreD02P0040)
        End If

        'Cách mới theo chuẩn: Tìm kiếm và Liệt kê tất cả luôn luôn sáng Khi(dt.Rows.Count > 0)
        gbEnabledUseFind = dtFind.Rows.Count > 0

        If FlagAdd Then
            ' Thêm mới thì gán sFind ="" và gán FilterText =''
            ResetFilter(tdbg, sFilter, bRefreshFilter)
            sFind = ""
        End If
        LoadDataSource(tdbg, dtFind, gbUnicode)
        ReLoadTDBGrid()

        If sKey <> "" Then
            Dim dt1 As DataTable = dtFind.DefaultView.ToTable
            Dim dr() As DataRow = dt1.Select("AssetID =" & SQLString(sKey), dt1.DefaultView.Sort)
            If dr.Length > 0 Then tdbg.Row = dt1.Rows.IndexOf(dr(0)) 'dùng tdbg.Bookmark có thể không đúng
            If Not tdbg.Focused Then tdbg.Focus() 'Nếu con trỏ chưa đứng trên lưới thì Focus về lưới
        End If
    End Sub

    Private Sub ResetGrid()
        If _status = "1" Or _normID = "BDMKHDT" Then
            tsbAdd.Enabled = False
            tsmAdd.Enabled = tsbAdd.Enabled
            tsbEdit.Enabled = False
            tsmEdit.Enabled = tsbEdit.Enabled
            tsbDelete.Enabled = False
            tsmDelete.Enabled = tsbDelete.Enabled
            tsbFind.Enabled = tdbg.RowCount > 0
            tsmFind.Enabled = tsbFind.Enabled
            tsbListAll.Enabled = tdbg.RowCount > 0
            tsmListAll.Enabled = tsbListAll.Enabled
        Else
            CheckMenu(_formIDPermission, tsbToolStripTable, tdbg.RowCount, gbEnabledUseFind, False, ContextMenuStrip1)
        End If
        If _status = "0" Then
            tsbAdd.Enabled = True
            tsmAdd.Enabled = tsbAdd.Enabled
            mnsAdd.Enabled = tsbAdd.Enabled
            tsbEdit.Enabled = (tdbg.RowCount > 0) ' True
            tsmEdit.Enabled = tsbEdit.Enabled
            mnsEdit.Enabled = tsbEdit.Enabled
            tsbDelete.Enabled = (tdbg.RowCount > 0) 'True
            tsmDelete.Enabled = tsbDelete.Enabled
            mnsDelete.Enabled = tsbDelete.Enabled
        Else
            tsbAdd.Enabled = False
            tsmAdd.Enabled = tsbAdd.Enabled
            mnsAdd.Enabled = tsbAdd.Enabled
            tsbEdit.Enabled = False
            tsmEdit.Enabled = tsbEdit.Enabled
            mnsEdit.Enabled = tsbEdit.Enabled
            tsbDelete.Enabled = False
            tsmDelete.Enabled = tsbDelete.Enabled
            mnsDelete.Enabled = tsbDelete.Enabled
        End If
        FooterTotalGrid(tdbg, COL_AssetName)
        FooterSum(tdbg, iCols, COL_No, True)
    End Sub

#Region "Context Menu items"

    Private Sub tsbAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbAdd.Click, tsmAdd.Click, mnsAdd.Click
        Dim f As New D02F0057
        With f
            .AssetID = ""
            .NormID = _normID
            .FormState = EnumFormState.FormAdd
            .ShowDialog()
            If f.SavedOK Then
                LoadTDBGrid(True, .AssetID)
            End If
            .Dispose()
        End With
    End Sub

    Private Sub tsbEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbEdit.Click, tsmEdit.Click, mnsEdit.Click
        If Not CheckStore(SQLStoreD02P1056(1)) Then Exit Sub
        Dim f As New D02F0057
        With f
            .NormID = _normID
            .AssetID = tdbg.Columns(COL_AssetID).Text
            .FormState = EnumFormState.FormEdit
            .ShowDialog()
            .Dispose()
        End With

        If f.SavedOK Then LoadTDBGrid(False, tdbg.Columns(COL_AssetID).Text)
    End Sub

    Private Sub tsbDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbDelete.Click, tsmDelete.Click, mnsDelete.Click
        If AskDelete() = Windows.Forms.DialogResult.No Then Exit Sub
        If Not CheckStore(SQLStoreD02P1056(2)) Then Exit Sub
        Dim sArrAssetID As String = ""
        Dim nRowDelete As Integer
        Dim SelectedRows As C1.Win.C1TrueDBGrid.SelectedRowCollection = tdbg.SelectedRows

        Dim sSQL As String = ""
        sSQL &= "Delete D02T0055 Where NormID=" & SQLString(_normID) & " And AssetID IN ( " & vbCrLf
        If SelectedRows.Count > 1 Then
            For i As Integer = 0 To SelectedRows.Count - 1
                sArrAssetID &= SQLString(tdbg(SelectedRows.Item(i), COL_AssetID)) & ","
            Next
            If sArrAssetID <> "" Then sArrAssetID = sArrAssetID.Substring(0, sArrAssetID.Length - 1) 'Bo dau "," cuoi cung
            nRowDelete = SelectedRows.Count
        Else
            sArrAssetID = SQLString(tdbg.Columns(COL_AssetID).Text)
            nRowDelete = 1
        End If

        sSQL &= sArrAssetID & ")" & vbCrLf
        sSQL &= " And DivisionID = " & SQLString(gsDivisionID)
        Dim bResult As Boolean = ExecuteSQL(sSQL)

        If bResult Then
            DeleteOK()
            DeleteGridEvent(tdbg, dtFind, gbEnabledUseFind)
            ResetGrid()
        Else
            DeleteNotOK()
        End If
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P1056
    '# Created User: HUỲNH KHANH
    '# Created Date: 25/09/2015 10:35:13
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P1056(ByVal iMode As Integer) As String
        Dim sSQL As String = ""
        sSQL &= ("-- Kiem tra truoc khi sua - delete" & vbCrLf)
        sSQL &= "Exec D02P1056 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, int, NOT NULL
        sSQL &= SQLNumber(giTranYear) & COMMA 'TranYear, int, NOT NULL
        sSQL &= SQLString(Me.Name) & COMMA 'FormID, varchar[20], NOT NULL
        sSQL &= SQLString(My.Computer.Name) & COMMA 'HostName, varchar[20], NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, int, NOT NULL
        sSQL &= SQLNumber(gsLanguage) & COMMA 'Language, int, NOT NULL
        sSQL &= SQLNumber(iMode) & COMMA 'Mode, int, NOT NULL
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[50], NOT NULL
        sSQL &= SQLString(tdbg.Columns(COL_AssetID).Text) 'AsetID, varchar[20], NOT NULL
        Return sSQL
    End Function


    Private Sub tsbClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbClose.Click
        Me.Close()
    End Sub
#End Region

    Private Sub tdbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.DoubleClick
        If tdbg.FilterActive Then Exit Sub

        If tsbEdit.Enabled Then
            tsbEdit_Click(sender, Nothing)
        End If
    End Sub

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter Then tdbg_DoubleClick(Nothing, Nothing)
        HotKeyCtrlVOnGrid(tdbg, e) 'Đã bổ sung D99X0000
    End Sub

    'không cho nhấn giá trị trên cột Filter bar đối với cột STT
    Private Sub tdbg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbg.KeyPress
        Select Case tdbg.Col
            Case COL_No 'Chặn nhập liệu trên cột STT tăng tự động trong code
                e.Handled = Not (ChrW(Keys.Return).Equals(e.KeyChar) Or ChrW(Keys.Tab).Equals(e.KeyChar))
            Case COL_ConvertedAmount, COL_Amount, COL_MinDep, COL_MaxDep
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
            Case COL_IsNotCalDep
                e.Handled = CheckKeyPress(e.KeyChar)
        End Select
    End Sub

    Private Sub tdbg_FilterChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.FilterChange
        Try
            If (dtFind Is Nothing) Then Exit Sub
            If bRefreshFilter Then Exit Sub 'set FilterText ="" thì thoát
            'Filter the data 
            FilterChangeGrid(tdbg, sFilter)
            ReLoadTDBGrid()
        Catch ex As Exception
            'Update 11/05/2011: Tạm thời có lỗi thì bỏ qua không hiện message
            'MessageBox.Show(ex.Message & " - " & ex.Source)
            WriteLogFile(ex.Message) 'Ghi file log TH nhập số >MaxInt cột Byte
        End Try
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
        'If dtCaptionCols Is Nothing OrElse dtCaptionCols.Rows.Count < 1 Then'Incident 72333
        Dim arrColObligatory() As Integer = {}
        Dim Arr As New ArrayList
        AddColVisible(tdbg, SPLIT0, Arr, arrColObligatory, False, False, gbUnicode)
        'Tạo tableCaption: đưa tất cả các cột trên lưới có Visible = True vào table 
        dtCaptionCols = CreateTableForExcelOnly(tdbg, Arr)
        'End If

        ShowFindDialogClient(Finder, dtCaptionCols, Me, "0", gbUnicode)
        '*****************************************
    End Sub


    Private Sub tsbListAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsbListAll.Click, tsmListAll.Click, mnsListAll.Click
        sFind = ""
        ResetFilter(tdbg, sFilter, bRefreshFilter)
        ReLoadTDBGrid()
    End Sub

    Private Sub ReLoadTDBGrid()
        Dim strFind As String = sFind
        If sFilter.ToString.Equals("") = False And strFind.Equals("") = False Then strFind &= " And "
        strFind &= sFilter.ToString

        dtFind.DefaultView.RowFilter = strFind
        ResetGrid()
    End Sub
#End Region

    ''#---------------------------------------------------------------------------------------------------
    ''# Title: SQLStoreD02P0040
    ''# Created User: Trần Thị ÁiTrâm
    ''# Created Date: 15/11/2007 02:51:48
    ''# Modified User: 
    ''# Modified Date: 
    ''# Description: 
    ''#---------------------------------------------------------------------------------------------------
    'Private Function SQLStoreD02P0040() As String
    '    Dim sSQL As String = ""
    '    sSQL &= "Exec D02P0040 "
    '    sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
    '    sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, int, NOT NULL
    '    sSQL &= SQLNumber(giTranYear) & COMMA 'TranYear, int, NOT NULL
    '    sSQL &= SQLNumber(gbUnicode) 'CodeTable, tinyint, NOT NULL
    '    Return sSQL
    'End Function

    '#Incident 80385
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0040
    '# Created User: HUỲNH KHANH
    '# Created Date: 16/10/2015 08:47:13
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0040() As String
        Dim sSQL As String = ""
        sSQL &= ("-- Do nguon cho luoi" & vbCrlf)
        sSQL &= "Exec D02P0040 "
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, int, NOT NULL
        sSQL &= SQLNumber(giTranYear) & COMMA 'TranYear, int, NOT NULL
        sSQL &= SQLNumber(gbUnicode) & COMMA 'CodeTable, tinyint, NOT NULL
        sSQL &= SQLString(gsDivisionID) 'DivisionID, varchar[20], NOT NULL
        Return sSQL
    End Function
End Class