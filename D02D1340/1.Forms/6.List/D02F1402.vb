'#---------------------------------------------------------------------------------------------------
'# Title: D02E1402
'# Created User: Lê Thị Thanh Hiền
'# Created Date: 31/07/2007 10:51:43
'# Modified User: 
'# Modified Date: 
'# Description: 
'#---------------------------------------------------------------------------------------------------
Imports System.Drawing
Imports System.Text
Imports System
Public Class D02F1402
    Private _savedOK As Boolean
    Public ReadOnly Property SavedOK() As Boolean
        Get
            Return _savedOK
        End Get
    End Property

#Region "Const of tdbg"
    Private Const COL_NCodeID As Integer = 0         ' STT
    Private Const COL_Description As Integer = 1     ' Diễn giải
    Private Const COL_SplitCipID As Integer = 2      ' Mã XDCB
    Private Const COL_Ratio As Integer = 3           ' Tỷ trọng
    Private Const COL_SplitDetailedID As Integer = 4 ' SplitDetailedID
#End Region


    Public dt As DataTable
    Private _splitMethodNo As String
    Private iCount As Integer
    Private bInsertRow As Boolean = False
    Private iCountCol As Integer = 0
    Private createUserID As String = ""
    Private createDate As String = ""

    Public Property SplitMethodNo() As String
        Get
            Return _splitMethodNo
        End Get
        Set(ByVal Value As String)
            _splitMethodNo = Value
        End Set
    End Property
    Dim bLoadFormState As Boolean = False
	Private _FormState As EnumFormState
    Public WriteOnly Property FormState() As EnumFormState
        Set(ByVal value As EnumFormState)
	bLoadFormState = True
	LoadInfoGeneral()
            _FormState = value
            Select Case _FormState
                Case EnumFormState.FormAdd
                    btnNext.Enabled = False
                    'LoadForm_Grid()

                Case EnumFormState.FormEdit
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    'LoadForm_Grid()
                    txtSplitMethodNo.Enabled = False
                Case EnumFormState.FormView
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    btnSave.Enabled = False
                    'LoadForm_Grid()
                    txtSplitMethodNo.Enabled = False
            End Select
        End Set
    End Property
    Private _splitMethodNo1 As String
    Public Property SplitMethodNo1() As String
        Get
            Return _splitMethodNo1
        End Get
        Set(ByVal Value As String)
            _splitMethodNo1 = Value
        End Set
    End Property
    Private Sub SetBackColorObligatory()
        txtSplitMethodNo.BackColor = COLOR_BACKCOLOROBLIGATORY
        txtSplitMethodName.BackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub
    Private Sub LoadForm_Grid()
        Dim sSQL As String
        sSQL = "Select '' as NCodeID , T14.SplitMethodNo, T14.SplitMethodName, T14.SplitMethodNameU," & vbCrLf
        sSQL &= "T14.Disabled, T15.SplitDetailedID," & vbCrLf
        sSQL &= "T15.Description" & UnicodeJoin(gbUnicode) & " As Description, T15.Ratio," & vbCrLf
        sSQL &= "T15.CreateUserID, T15.CreateDate, ISNULL(T15.SplitCipID,'') AS SplitCipID " & vbCrLf
        sSQL &= "From D02T0015 T15 WITH(NOLOCK)" & vbCrLf
        sSQL &= " Inner join D02T0014 T14 on T15.SplitMethodNo=T14.SplitMethodNo " & vbCrLf
        sSQL &= "where T14.SplitMethodNo=" & SQLString(_splitMethodNo) & vbCrLf
        sSQL &= " order by convert(int,SUBSTRING(T15.SplitDetailedID,LEN(T14.SplitMethodNo)+1,20))"

        dt = ReturnDataTable(sSQL)
        If dt.Rows.Count > 0 Then
            txtSplitMethodNo.Text = dt.Rows(0).Item("SplitMethodNo").ToString
            txtSplitMethodName.Text = dt.Rows(0).Item("SplitMethodName" & UnicodeJoin(gbUnicode)).ToString
            chkDisabled.Checked = Convert.ToBoolean(dt.Rows(0).Item("Disabled"))
            createUserID = dt.Rows(0).Item("CreateUserID").ToString
            createDate = dt.Rows(0).Item("CreateDate").ToString
        End If
        LoadDataSource(tdbg, dt, gbUnicode)
        UpdateOrderNum(tdbg, COL_NCodeID)

    End Sub

    Private Sub D02F1402_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
        If e.KeyCode = Keys.F11 Then
            HotKeyF11(Me, tdbg)
        End If
    End Sub

    Private Sub D02F1402_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	If bLoadFormState = False Then FormState = _formState
        Loadlanguage()
        SetBackColorObligatory()
        LoadForm_Grid()
        ResetFooterGrid(tdbg)
        LoadTDBDropDown()
        tdbg_LockedColumns()
        tdbg_NumberFormat()
        iCountCol = CountCol(tdbg, 0)
        CheckIdTextBox(txtSplitMethodNo)
        InputbyUnicode(Me, gbUnicode)
    SetResolutionForm(Me)
Me.Cursor = Cursors.Default
End Sub

    Private Sub tdbg_LockedColumns()
        tdbg.Splits(SPLIT0).DisplayColumns(COL_NCodeID).Style.BackColor = Color.FromArgb(COLOR_BACKCOLOR)
    End Sub

    Private Sub tdbg_NumberFormat()
        tdbg.Columns(COL_Ratio).NumberFormat = DxxFormat.DefaultNumber2 '"#,##0.000" 
    End Sub

    Private Sub tdbg_ComboSelect(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbg.ComboSelect
        tdbg.UpdateData()
    End Sub

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter And tdbg.Col = COL_Ratio Then
            HotKeyEnterGrid(tdbg, COL_Description, e)
        End If
        If e.Shift And e.KeyCode = Keys.Insert Then
            bInsertRow = True
            HotKeyShiftInsert(tdbg, 0, COL_NCodeID, tdbg.Columns.Count)
        End If
        If e.KeyCode = Keys.F7 Then
            HotKeyF7(tdbg)
            UpdateTDBGOrderNum(tdbg, COL_NCodeID)
        End If
        If e.KeyCode = Keys.F8 Then
            'tdbg.Col = 1
            HotKeyF8(tdbg)
            UpdateTDBGOrderNum(tdbg, COL_NCodeID)
        End If
    End Sub

    Private Sub tdbg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbg.KeyPress
        Select Case tdbg.Col
            Case COL_Ratio
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
        End Select
    End Sub

    Private Sub tdbg_BeforeColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles tdbg.BeforeColUpdate
        Select Case e.ColIndex
            Case COL_SplitCipID
                If tdbg.Columns(e.ColIndex).Text <> "" Then
                    If L3Int(tdbdCipNo.Columns("Status").Text) = 2 Then
                        tdbg.Columns(e.ColIndex).Text = tdbdCipNo.Columns("CipNo").Text
                        D99C0008.MsgL3(rl3("Ma_XDCB_da_ket_thuc"))
                        e.Cancel = True
                    End If
                End If
            Case COL_Ratio
                If Not IsNumeric(tdbg.Columns(COL_Ratio).Text) Then e.Cancel = True
        End Select
    End Sub

    Private Sub tdbg_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbg.AfterColUpdate
        Select Case e.ColIndex
            'Case COL_SplitCipID
            '    If tdbg.Columns(e.ColIndex).Text <> "" Then
            '        If L3Int(tdbdCipNo.Columns("Status").Text) = 2 Then
            '            D99C0008.MsgL3(rl3("Ma_XDCB_da_ket_thuc"))
            '            tdbg.Col = COL_SplitCipID
            '            tdbg.Focus()
            '        End If
            '    End If
            Case COL_Description
                UpdateTDBGOrderNum(tdbg, COL_NCodeID, COL_Description)
            Case COL_Ratio
                UpdateTDBGOrderNum(tdbg, COL_NCodeID, COL_Ratio)
        End Select
        tdbg.UpdateData()
    End Sub


    Private Function AllowSave() As Boolean
        If txtSplitMethodNo.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Ma_phuong_phap"))
            txtSplitMethodNo.Focus()
            Return False
        End If
        If txtSplitMethodName.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Ten_phuong_phap"))
            txtSplitMethodName.Focus()
            Return False
        End If
        If _FormState = EnumFormState.FormAdd Then
            If IsExistKey("D02T0014", "SplitMethodNo", txtSplitMethodNo.Text) Then
                D99C0008.MsgDuplicatePKey()
                txtSplitMethodNo.Focus()
                Return False
            End If
        End If
        If tdbg.RowCount <= 0 Then
            D99C0008.MsgNoDataInGrid()
            tdbg.Focus()
            Return False
        End If
        For i As Integer = 0 To tdbg.RowCount - 1
            If tdbg(i, COL_Description).ToString = "" Then
                D99C0008.MsgNotYetEnter(rl3("Dien_giai"))
                tdbg.SplitIndex = SPLIT0
                tdbg.Col = COL_Description
                tdbg.Row = i
                tdbg.Focus()
                Return False
            End If
            If tdbg(i, COL_Ratio).ToString = "" Then
                D99C0008.MsgNotYetEnter(rl3("Ty_trong"))
                tdbg.SplitIndex = SPLIT0
                tdbg.Col = COL_Ratio
                tdbg.Row = i
                tdbg.Focus()
                Return False
            End If
            If tdbg(i, COL_Ratio).ToString <> "" Then
                If CDbl(tdbg(i, COL_Ratio)) > MaxMoney Then
                    D99C0008.MsgL3(rl3("Ty_trong_qua_lon"))
                    tdbg.SplitIndex = SPLIT0
                    tdbg.Col = COL_Ratio
                    tdbg.Row = i
                    tdbg.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If AskSave() = Windows.Forms.DialogResult.No Then Exit Sub
        tdbg.Update()
        If Not AllowSave() Then Exit Sub

        'Kiểm tra Ngày phiếu có phù hợp với kỳ kế toán hiện tại không (gọi hàm CheckVoucherDateInPeriod)

        btnSave.Enabled = False
        btnClose.Enabled = False
        _savedOK = False

        Me.Cursor = Cursors.WaitCursor
        Dim sSQL As New StringBuilder
        Select Case _FormState
            Case EnumFormState.FormAdd
                sSQL.Append(SQLInsertD02T0014().ToString & vbCrLf)
                sSQL.Append(SQLInsertD02T0015())

                'Lưu LastKey của Số phiếu xuống Database (gọi hàm CreateIGEVoucherNo bật cờ True)
                'Kiểm tra trùng Số phiếu (gọi hàm CheckDuplicateVoucherNo)

            Case EnumFormState.FormEdit
                sSQL.Append(SQLUpdateD02T0014().ToString & vbCrLf)
                sSQL.Append(SQLDeleteD02T0015().ToString & vbCrLf)
                sSQL.Append(SQLInsertD02T0015())
        End Select

        Dim bRunSQL As Boolean = ExecuteSQL(sSQL.ToString)
        Me.Cursor = Cursors.Default

        If bRunSQL Then
            SaveOK()
            _savedOK = True
            btnClose.Enabled = True
            Select Case _FormState
                Case EnumFormState.FormAdd
                    _splitMethodNo = txtSplitMethodNo.Text
                    btnNext.Enabled = True
                    btnNext.Focus()
                    '_splitMethodNo1 = txtSplitMethodNo.Text
                Case EnumFormState.FormEdit
                    btnSave.Enabled = True
                    btnClose.Focus()
            End Select
        Else
            SaveNotOK()
            btnClose.Enabled = True
            btnSave.Enabled = True
        End If
    End Sub
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0014
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 10:51:43
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0014() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Insert Into D02T0014(")
        sSQL.Append("SplitMethodNo, SplitMethodNameU, Disabled, CreateUserID, CreateDate, ")
        sSQL.Append("LastModifyUserID, LastModifyDate")
        sSQL.Append(") Values(")
        sSQL.Append(SQLString(txtSplitMethodNo.Text) & COMMA) 'SplitMethodNo [KEY], varchar[20], NOT NULL
        sSQL.Append(SQLStringUnicode(txtSplitMethodName.Text, gbUnicode, True) & COMMA) 'SplitMethodName, varchar[50], NULL
        sSQL.Append(SQLNumber(chkDisabled.Checked) & COMMA) 'Disabled, tinyint, NOT NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'CreateUserID, varchar[20], NULL
        sSQL.Append("GetDate()" & COMMA) 'CreateDate, datetime, NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'LastModifyUserID, varchar[20], NULL
        sSQL.Append("GetDate()") 'LastModifyDate, datetime, NULL
        sSQL.Append(")")

        Return sSQL
    End Function
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0015
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 10:55:42
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0015() As StringBuilder
        Dim sSQL As New StringBuilder
        Dim i As Integer

        For i = 0 To tdbg.RowCount - 1
            sSQL.Append("Insert Into D02T0015(")
            sSQL.Append("SplitMethodNo, SplitDetailedID, SplitCipID, Ratio, DescriptionU, CreateUserID, ")
            sSQL.Append("CreateDate, LastModifyUserID, LastModifyDate")
            sSQL.Append(") Values(")
            sSQL.Append(SQLString(txtSplitMethodNo.Text) & COMMA) 'SplitMethodNo [KEY], varchar[20], NOT NULL
            sSQL.Append(SQLString(txtSplitMethodNo.Text & tdbg(i, COL_NCodeID).ToString) & COMMA) 'SplitDetailedID [KEY], varchar[20], NOT NULL
            sSQL.Append(SQLString(tdbg(i, COL_SplitCipID)) & COMMA)
            sSQL.Append(SQLMoney(tdbg(i, COL_Ratio)) & COMMA) 'Ratio, money, NULL
            sSQL.Append(SQLStringUnicode(tdbg(i, COL_Description).ToString, gbUnicode, True) & COMMA) 'Description, varchar[250], NULL
            If _FormState = EnumFormState.FormAdd Then
                sSQL.Append(SQLString(gsUserID) & COMMA) 'CreateUserID, varchar[20], NULL
                sSQL.Append("GetDate()" & COMMA) 'CreateDate, datetime, NULL
            Else
                sSQL.Append(SQLString(createUserID) & COMMA) 'CreateUserID, varchar[20], NULL
                sSQL.Append(SQLDateTimeSave(createDate) & COMMA) 'CreateDate, datetime, NULL
            End If
            sSQL.Append(SQLString(gsUserID) & COMMA) 'LastModifyUserID, varchar[20], NULL
            sSQL.Append("GetDate()") 'LastModifyDate, datetime, NULL
            sSQL.Append(")" & vbCrLf)
        Next
        Return sSQL
    End Function
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0014
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 11:38:51
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0014() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0014 Set ")
        sSQL.Append("SplitMethodNameU = " & SQLStringUnicode(txtSplitMethodName.Text, gbUnicode, True) & COMMA) 'varchar[50], NULL
        sSQL.Append("Disabled = " & SQLNumber(chkDisabled.Checked) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("LastModifyUserID = " & SQLString(gsUserID) & COMMA) 'varchar[20], NULL
        sSQL.Append("LastModifyDate = GetDate()") 'datetime, NULL
        sSQL.Append(" Where ")
        sSQL.Append("SplitMethodNo = " & SQLString(txtSplitMethodNo.Text))

        Return sSQL
    End Function
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD02T0015
    '# Created User: Lê Thị Thanh Hiền
    '# Created Date: 31/07/2007 01:39:48
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0015() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Delete From D02T0015")
        sSQL.Append(" Where ")
        sSQL.Append("SplitMethodNo = " & SQLString(txtSplitMethodNo.Text))
        Return sSQL
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        '_splitMethodNo = ""
        txtSplitMethodNo.Text = ""
        txtSplitMethodName.Text = ""
        chkDisabled.Checked = False
        btnSave.Enabled = True
        btnNext.Enabled = False
        LoadForm_Grid()
        txtSplitMethodNo.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Cap_nhat_phuong_phap_tach_chi_phi__D02F1402") & UnicodeCaption(gbUnicode) 'CËp nhËt ph§¥ng phÀp tÀch chi phÛ - D02F1402
        '================================================================ 
        lblSplitMethodNo.Text = rl3("Ma_phuong_phap") 'Mã phương pháp
        lblSplitMethodName.Text = rl3("Ten_phuong_phap") 'Tên phương pháp
        '================================================================ 
        btnSave.Text = rl3("_Luu") '&Lưu
        btnNext.Text = rl3("Nhap__tiep") 'Nhập &tiếp
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        chkDisabled.Text = rl3("Khong_su_dung") 'Không sử dụng
        '================================================================ 
        tdbg.Columns("NCodeID").Caption = rl3("STT") 'rl3("So_TT") 'Số TT
        tdbg.Columns("Description").Caption = rl3("Dien_giai") 'Diễn Giải
        tdbg.Columns(COL_SplitCipID).Caption = rL3("Ma_XDCB")
        tdbg.Columns("Ratio").Caption = rL3("Ty_trong") 'Tỷ trọng
        '================================================================ 
        tdbdCipNo.Columns("CipNo").Caption = rL3("Ma")
        tdbdCipNo.Columns("CipName").Caption = rL3("Ten")
    End Sub

    Private Sub tdbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbg.RowColChange
  If e IsNot Nothing AndAlso e.LastRow = -1 Then Exit Sub
        If bInsertRow = True And tdbg.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
            tdbg.Columns(COL_Description).Text = "" ' Gán 1 cột bất kỳ ="" cho lưới
            bInsertRow = False
        End If
    End Sub

    Private Sub LoadTDBDropDown()
        Dim sSQL As String = ""
        'Load tdbdCipNo
        sSQL = "Select CipID as SplitCipID, CipNo, CipName" & UnicodeJoin(gbUnicode) & " as CipName, Status From D02T0100 Where Disabled =0 And Status <2" & vbCrLf
        sSQL &= "Order by CipNo"
        LoadDataSource(tdbdCipNo, sSQL, gbUnicode)
    End Sub


End Class