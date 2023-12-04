'#-------------------------------------------------------------------------------------
'# Created Date: 06/11/2007 9:19:21 AM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 06/11/2007 9:19:21 AM
'# Modify User: Trần Thị ÁiTrâm
'#-------------------------------------------------------------------------------------
Imports System.Text
Imports System.Xml
Imports System


Public Class D02F0021
    Private _savedOK As Boolean
    Public ReadOnly Property SavedOK() As Boolean
        Get
            Return _savedOK
        End Get
    End Property

#Region "Const of tdbg"
    Private Const COL_YearNo As Integer = 0 ' Số năm
    Private Const COL_Rate As Integer = 1   ' Tỷ lệ 
#End Region
    Private _deprTableID As String
    Private dRateBeforeUpdate As Double
    Private bInserRow As Boolean = False


    Public Property DeprTableID() As String
        Get
            Return _deprTableID
        End Get
        Set(ByVal value As String)
            _deprTableID = value
        End Set
    End Property

    Dim bLoadFormState As Boolean = False
	Private _FormState As EnumFormState
    Public WriteOnly Property FormState() As EnumFormState
        Set(ByVal value As EnumFormState)
	bLoadFormState = True
	LoadInfoGeneral()
            _FormState = value
            LoadAuto()
            LoadTDBGrid()
            Select Case _FormState
                Case EnumFormState.FormAdd
                    btnSave.Enabled = True
                    btnNext.Enabled = False
                    LoadAddNew()
                Case EnumFormState.FormEdit
                    btnSave.Enabled = True
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    LoadEdit()
                Case EnumFormState.FormView
                    btnSave.Enabled = False
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    LoadEdit()
            End Select
        End Set
    End Property

    Private Sub D02F0021_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
    End Sub

    Private Sub D02F0021_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
	If bLoadFormState = False Then FormState = _formState
        Loadlanguage()
        SetBackColorObligatory()
        tdbg_LockedColumns()
        ResetFooterGrid(tdbg)
        CheckIdTextBox(txtDeprTableID)
        InputbyUnicode(Me, gbUnicode)
        SetResolutionForm(Me)
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Cap_nhat_bang_khau_hao_-_D02F0021") & UnicodeCaption(gbUnicode) 'CËp nhËt b¶ng khÊu hao - D02F0021
        '================================================================ 
        lblDeprTableID.Text = rl3("Ma_bang") 'Mã bảng
        lblDeprTableName.Text = rl3("Ten_bang") 'Tên bảng
        lblDescription.Text = rl3("Dien_giai") 'Diễn giải
        lblServiceYear.Text = rl3("So_nam_khau_hao") 'Số năm khấu hao
        lblQuickRate.Text = rl3("Ty_le_khau_hao_nhanh") 'Tỷ lệ khấu hao nhanh
        '================================================================ 
        btnSave.Text = rl3("_Luu") '&Lưu
        btnNext.Text = rl3("Nhap__tiep") 'Nhập &tiếp
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        '================================================================ 
        chkDisabled.Text = rl3("Khong_su_dung") 'Không sử dụng
        chkAuto.Text = rl3("Tu_dong_tinh_va_dien_ty_le_vao_bang") 'Tự động tính và điền tỷ lệ vào bảng
        '================================================================ 
        grpParameter.Text = rl3("Thong_so_tinh_khau_hao") 'Thông số tính khấu hao
        '================================================================ 
        tdbg.Columns("YearNo").Caption = rl3("So_nam_") 'Số năm
        tdbg.Columns("Rate").Caption = rl3("Ty_le") 'Tỷ lệ 
        tdbg.Columns("YearNo").FooterText = rl3("Tong_cong") 'Tổng cộng
    End Sub

    Private Sub LoadAddNew()
        chkDisabled.Visible = False
        LoadMaster()
    End Sub

    Private Sub LoadEdit()
        txtDeprTableID.Enabled = False
        chkDisabled.Visible = True
        LoadMaster()
        txtDeprTableName.Focus()
    End Sub

    Private Sub LoadAuto()
        chkAuto.Enabled = False
    End Sub

    Private Sub LoadMaster()
        Dim sSQL As String
        sSQL = "Select  DeprTableID, DeprTableName, DeprTableNameU, Description, DescriptionU, ServiceYear, QuickRate, Disabled, Auto" & vbCrLf
        sSQL &= "From D02T0070 WITH(NOLOCK) " & vbCrLf
        sSQL &= "Where DeprTableID = " & SQLString(_deprTableID) & vbCrLf
        Dim dtMaster As DataTable = ReturnDataTable(sSQL)
        If dtMaster.Rows.Count > 0 Then
            With dtMaster.Rows(0)
                txtDeprTableID.Text = .Item("DeprTableID").ToString
                txtDeprTableName.Text = .Item("DeprTableName" & UnicodeJoin(gbUnicode)).ToString
                txtDescription.Text = .Item("Description" & UnicodeJoin(gbUnicode)).ToString
                chkDisabled.Checked = CBool(.Item("Disabled"))
                txtServiceYear.Text = .Item("ServiceYear").ToString
                txtQuickRate.Text = SQLNumber(.Item("QuickRate").ToString, DxxFormat.DefaultNumber2)
                If IsDBNull(.Item("Auto")) Or Trim(.Item("Auto").ToString) = "" Or CDbl(.Item("Auto")) = 0 Then
                    chkAuto.Checked = False
                    txtServiceYear.Enabled = True
                    txtQuickRate.Enabled = True
                Else
                    chkAuto.Checked = True
                    txtServiceYear.Enabled = False
                    txtQuickRate.Enabled = False
                End If
            End With
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub tdbg_LockedColumns()
        tdbg.Splits(SPLIT0).DisplayColumns(COL_YearNo).Style.BackColor = Color.FromArgb(COLOR_BACKCOLOR)
    End Sub

    Private Sub SetBackColorObligatory()
        txtDeprTableID.BackColor = COLOR_BACKCOLOROBLIGATORY
        txtDeprTableName.BackColor = COLOR_BACKCOLOROBLIGATORY
        txtServiceYear.BackColor = COLOR_BACKCOLOROBLIGATORY
        txtQuickRate.BackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        btnNext.Enabled = False
        btnSave.Enabled = True

        txtDeprTableID.Text = ""
        txtDeprTableName.Text = ""
        txtDescription.Text = ""
        txtServiceYear.Text = ""
        txtQuickRate.Text = ""
        chkAuto.Checked = False
        chkAuto_Click(Nothing, Nothing)
        txtDeprTableID.Focus()
    End Sub

    Private Sub txtServiceYear_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServiceYear.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.Number)
    End Sub

    Private Sub txtQuickRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuickRate.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
    End Sub

    Private Sub LoadTDBGrid()
        Dim sSQL As String = ""
        sSQL = "Select  * " & vbCrLf
        sSQL &= "From D02T0071 WITH(NOLOCK)" & vbCrLf
        sSQL &= "Where DeprTableID = " & SQLString(_deprTableID)
        Dim dtGrid As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbg, dtGrid, gbUnicode)
        tdbg_NumberFormat()
        tdbg_FooterText()
    End Sub

    Private Sub tdbg_NumberFormat()
        tdbg.Columns(COL_Rate).NumberFormat = DxxFormat.DefaultNumber2
    End Sub

    Private Sub tdbg_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.AfterDelete
        UpdateTDBGOrderNum(tdbg, COL_YearNo)
        tdbg_FooterText()
    End Sub

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tdbg.Col = COL_Rate Then
                HotKeyEnterGrid(tdbg, COL_Rate, e)
            End If
        End If
        If e.Shift Then
            If e.KeyCode = Keys.Insert Then
                bInserRow = True
                HotKeyShiftInsert(tdbg, SPLIT0, COL_YearNo, tdbg.Columns.Count)
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            HotKeyF7(tdbg)
            UpdateTDBGOrderNum(tdbg, COL_YearNo, COL_Rate)
            tdbg_FooterText()
        End If
    End Sub

    Private Sub tdbg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tdbg.KeyPress
        Select Case tdbg.Col
            Case COL_YearNo
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.Number)
            Case COL_Rate
                e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
        End Select
    End Sub

    Private Sub txtQuickRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuickRate.LostFocus
        If txtQuickRate.Text <> "" Then
            If IsNumeric(txtQuickRate.Text) Then
                If CDbl(txtQuickRate.Text) < 1 Or CDbl(txtQuickRate.Text) > 100 Then
                    txtQuickRate.Text = ""
                    D99C0008.MsgL3(rl3("Ty_le_khau_hao_nhanh") & Space(1) & ">=1" & Space(1) & rl3("_va_") & Space(1) & "<=100")
                    txtQuickRate.Focus()
                Else
                    txtQuickRate.Text = SQLNumber(txtQuickRate.Text, DxxFormat.DefaultNumber2)
                End If
            Else
                txtQuickRate.Text = ""
                D99C0008.MsgL3(rl3("MSG000009"))
                txtQuickRate.Focus()
            End If
        End If
    End Sub

    Private Sub txtQuickRate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuickRate.Validated
        If txtQuickRate.Text <> "" Then
            txtQuickRate.Text = SQLNumber(txtQuickRate.Text, DxxFormat.DefaultNumber2)
        End If

        If txtServiceYear.Text <> "" Or txtQuickRate.Text <> "" Then
            chkAuto.Enabled = True
        ElseIf txtServiceYear.Text = "" And txtQuickRate.Text = "" Then
            chkAuto.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If AskSave() = Windows.Forms.DialogResult.No Then Exit Sub
        tdbg.UpdateData()
        If Not AllowSave() Then Exit Sub

        'Kiểm tra Ngày phiếu có phù hợp với kỳ kế toán hiện tại không (gọi hàm CheckVoucherDateInPeriod)

        btnSave.Enabled = False
        btnClose.Enabled = False
        _savedOK = False
        Me.Cursor = Cursors.WaitCursor
        Dim sSQL As New StringBuilder
        Select Case _FormState
            Case EnumFormState.FormAdd
                sSQL.Append(SQLInsertD02T0070)
                sSQL.Append(vbCrLf)
                sSQL.Append(SQLInsertD02T0071s)
                'Lưu LastKey của Số phiếu xuống Database (gọi hàm CreateIGEVoucherNo bật cờ True)
                'Kiểm tra trùng Số phiếu (gọi hàm CheckDuplicateVoucherNo)

            Case EnumFormState.FormEdit
                sSQL.Append(SQLDeleteD02T0071)
                sSQL.Append(vbCrLf)
                sSQL.Append(SQLUpdateD02T0070)
                sSQL.Append(vbCrLf)
                sSQL.Append(SQLInsertD02T0071s)

        End Select

        Dim bRunSQL As Boolean = ExecuteSQL(sSQL.ToString)
        Me.Cursor = Cursors.Default

        If bRunSQL Then
            SaveOK()
            _savedOK = True
            btnClose.Enabled = True
            Select Case _FormState
                Case EnumFormState.FormAdd
                    _deprTableID = txtDeprTableID.Text
                    btnNext.Enabled = True
                    btnNext.Focus()
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

    Private Function AllowSave() As Boolean
        If txtDeprTableID.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Ma_bang"))
            txtDeprTableID.Focus()
            Return False
        End If
        If txtDeprTableName.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Ten_bang"))
            txtDeprTableName.Focus()
            Return False
        End If
        If txtServiceYear.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("So_nam_khau_hao"))
            txtServiceYear.Focus()
            Return False
        End If

        If txtServiceYear.Text.Trim <> "" Then
            If CInt(txtServiceYear.Text) < 1 Or CInt(txtServiceYear.Text) > 300 Then
                D99C0008.MsgL3(rl3("So_nam_khau_hao_phai") & Space(1) & ">=1" & Space(1) & rl3("_va_") & Space(1) & "<=300")
                txtServiceYear.Focus()
                Return False
            End If
        End If

        If txtQuickRate.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rl3("Ty_le_khau_hao_nhanh"))
            txtQuickRate.Focus()
            Return False
        End If
        If txtQuickRate.Text.Trim <> "" Then
            If CInt(txtQuickRate.Text) < 1 Or CInt(txtQuickRate.Text) > 100 Then
                D99C0008.MsgL3(rl3("Ty_le_khau_hao_nhanh") & Space(1) & ">=1" & Space(1) & rl3("_va_") & Space(1) & "<=100")
                txtQuickRate.Focus()
                Return False
            End If
        End If
        If txtServiceYear.Text.Trim <> "" And txtQuickRate.Text.Trim <> "" Then
            If tdbg.RowCount <= 0 Then
                D99C0008.MsgL3(rl3("Ban_phai_nhap_khau_hao_tung_nam_tren_luoi"))
                tdbg.Focus()
                Return False
            End If
        End If

        If SQLNumber(Sum(COL_Rate, tdbg)) < SQLNumber(100) Or SQLNumber(Sum(COL_Rate, tdbg)) > SQLNumber(100) Then
            D99C0008.MsgL3(rl3("Tong_ty_le_phai_bang_100"))
            tdbg.Col = COL_Rate
            tdbg.Row = 0
            tdbg.Focus()
            Return False
        End If

        If _FormState = EnumFormState.FormAdd Then
            If IsExistKey("D02T0070", "DeprTableID", txtDeprTableID.Text) Then
                D99C0008.MsgDuplicatePKey()
                txtDeprTableID.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub txtDeprTableName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDeprTableName.Validated
        If Microsoft.VisualBasic.Left(txtDeprTableName.Text, 1) <> UCase(Microsoft.VisualBasic.Left(txtDeprTableName.Text, 1)) Then
            txtDeprTableName.Text = UCase(Microsoft.VisualBasic.Left(txtDeprTableName.Text, 1)) + Microsoft.VisualBasic.Right(txtDeprTableName.Text, Len(txtDeprTableName.Text) - 1)
        End If
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0070
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 06/11/2007 11:39:47
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0070() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0070 "
		sSQL &= SQLNumber(txtServiceYear.Text) & COMMA 'ServiceYear, int, NOT NULL
		sSQL &= SQLMoney(txtQuickRate.Text) 'QuickRate, money, NOT NULL
        Return sSQL
    End Function

    Private Sub chkAuto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAuto.Click
        Dim sSQL As String
        Dim dt As DataTable
        If chkAuto.Checked Then
            If txtServiceYear.Text <> "" And txtQuickRate.Text <> "" Then
                sSQL = SQLStoreD02P0070()
                dt = ReturnDataTable(sSQL)
                LoadDataSource(tdbg, dt, gbUnicode)
                tdbg_FooterText()
                txtServiceYear.Enabled = False
                txtQuickRate.Enabled = False
            Else
                If txtServiceYear.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rl3("So_nam_khau_hao"))
                    txtServiceYear.Focus()
                    chkAuto.Checked = False
                    Exit Sub
                End If

                If txtServiceYear.Text.Trim <> "" Then
                    If CInt(txtServiceYear.Text) < 1 Or CInt(txtServiceYear.Text) > 300 Then
                        D99C0008.MsgL3(rl3("So_nam_khau_hao_phai") & Space(1) & ">=1" & Space(1) & rl3("_va_") & Space(1) & "<=300")
                        txtServiceYear.Focus()
                        chkAuto.Checked = False
                        Exit Sub
                    End If
                End If

                If txtQuickRate.Text.Trim = "" Then
                    D99C0008.MsgNotYetEnter(rl3("Ty_le_khau_hao_nhanh"))
                    txtQuickRate.Focus()
                    chkAuto.Checked = False
                    Exit Sub
                End If
                If txtQuickRate.Text.Trim <> "" Then
                    If CInt(txtQuickRate.Text) < 1 Or CInt(txtQuickRate.Text) > 100 Then
                        D99C0008.MsgL3(rl3("Ty_le_khau_hao_nhanh") & Space(1) & ">=1" & Space(1) & rL3("_va_") & Space(1) & "<=100")
                        txtQuickRate.Focus()
                        chkAuto.Checked = False
                        Exit Sub
                    End If
                End If
            End If
        Else
            txtServiceYear.Enabled = True
            txtQuickRate.Enabled = True
            txtServiceYear.Text = ""
            txtQuickRate.Text = ""
            '_deprTableID = ""
            LoadTDBGrid()
        End If
    End Sub

    Private Sub txtServiceYear_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServiceYear.Validated
        Dim i As Integer
        If txtServiceYear.Text <> "" Or txtQuickRate.Text <> "" Then
            chkAuto.Enabled = True
            If tdbg.RowCount > L3Int(txtServiceYear.Text) Then
                i = tdbg.RowCount - 1
                While i >= 0
                    tdbg.Delete()
                    i -= 1
                End While
                tdbg.AllowAddNew = True
            End If
        ElseIf txtServiceYear.Text = "" And txtQuickRate.Text = "" Then
            chkAuto.Enabled = False
        End If
        tdbg_FooterText()
    End Sub

    Private Sub tdbg_FooterText()
        tdbg.Columns(COL_Rate).FooterText = SQLNumber(Sum(COL_Rate, tdbg).ToString, DxxFormat.DefaultNumber2) & "%"
    End Sub

    Private Sub tdbg_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbg.AfterColUpdate
        Select Case e.ColIndex
            Case COL_YearNo
            Case COL_Rate
                If Sum(COL_Rate, tdbg) > 100 Then
                    D99C0008.MsgL3(rL3("Tong_ty_le_phai_bang_100"))
                    tdbg.Columns(COL_Rate).Text = CStr(IIf(dRateBeforeUpdate = 0, "", dRateBeforeUpdate.ToString))
                    tdbg.AllowAddNew = False
                    Exit Sub
                End If
                UpdateTDBGOrderNum(tdbg, COL_YearNo, COL_Rate)
                tdbg_FooterText()
        End Select
    End Sub

    Private Sub tdbg_BeforeColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColEditEventArgs) Handles tdbg.BeforeColEdit
        Select Case e.ColIndex
            Case COL_Rate
                If txtServiceYear.Text <> "" Then
                    If tdbg.Row > CInt(txtServiceYear.Text) - 1 Then
                        tdbg.Columns(COL_Rate).Text = ""
                        tdbg.AllowAddNew = False
                        e.Cancel = True
                    Else
                        tdbg.AllowAddNew = True
                        e.Cancel = False
                    End If
                End If
                If tdbg.Columns(COL_Rate).Text <> "" Then
                    dRateBeforeUpdate = CDbl(tdbg.Columns(COL_Rate).Text)
                End If
                UpdateTDBGOrderNum(tdbg, COL_YearNo, COL_Rate)
                tdbg_FooterText()
        End Select
    End Sub

    Private Sub tdbg_BeforeColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles tdbg.BeforeColUpdate
        Select Case e.ColIndex
            Case COL_YearNo
                If Not IsNumeric(tdbg.Columns(COL_YearNo).Text) Then e.Cancel = True
            Case COL_Rate
                If Not IsNumeric(tdbg.Columns(COL_Rate).Text) Then e.Cancel = True
        End Select
    End Sub

    Private Sub txtDescription_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.Validated
        If Microsoft.VisualBasic.Left(txtDescription.Text, 1) <> UCase(Microsoft.VisualBasic.Left(txtDescription.Text, 1)) Then
            txtDescription.Text = UCase(Microsoft.VisualBasic.Left(txtDescription.Text, 1)) + Microsoft.VisualBasic.Right(txtDescription.Text, Len(txtDescription.Text) - 1)
        End If
    End Sub
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0070
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 07/11/2007 11:52:26
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0070() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Insert Into D02T0070(")
        sSQL.Append("DeprTableID, DeprTableNameU, DescriptionU, ServiceYear, QuickRate, ")
        sSQL.Append("Auto, DivisionID, Disabled, CreateDate, CreateUserID, ")
        sSQL.Append("LastModifyDate, LastModifyUserID")
        sSQL.Append(") Values(")
		sSQL.Append(SQLString(txtDeprTableID.Text) & COMMA) 'DeprTableID [KEY], varchar[20], NOT NULL
        sSQL.Append(SQLStringUnicode(txtDeprTableName.Text, gbUnicode, True) & COMMA) 'DeprTableName, varchar[50], NULL
        sSQL.Append(SQLStringUnicode(txtDescription.Text, gbUnicode, True) & COMMA) 'Description, varchar[250], NULL
		sSQL.Append(SQLNumber(txtServiceYear.Text) & COMMA) 'ServiceYear, int, NULL
		sSQL.Append(SQLMoney(txtQuickRate.Text) & COMMA) 'QuickRate, money, NULL
		sSQL.Append(SQLNumber(chkAuto.Checked) & COMMA) 'Auto, tinyint, NULL
        sSQL.Append(SQLString(gsDivisionID) & COMMA) 'DivisionID, varchar[20], NULL
		sSQL.Append(SQLNumber(chkDisabled.Checked) & COMMA) 'Disabled, tinyint, NULL
        sSQL.Append("GetDate()" & COMMA) 'CreateDate, datetime, NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'CreateUserID, varchar[20], NULL
        sSQL.Append("GetDate()" & COMMA) 'LastModifyDate, datetime, NULL
        sSQL.Append(SQLString(gsUserID)) 'LastModifyUserID, varchar[20], NULL
        sSQL.Append(")")

        Return sSQL
    End Function
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0071s
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 07/11/2007 11:54:39
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0071s() As StringBuilder
        Dim sRet As New StringBuilder
        Dim sSQL As New StringBuilder
        For i As Integer = 0 To tdbg.RowCount - 1
            sSQL.Append("Insert Into D02T0071(")
            sSQL.Append("DeprTableID, YearNo, Rate")
            sSQL.Append(") Values(")
			sSQL.Append(SQLString(txtDeprTableID.Text) & COMMA) 'DeprTableID [KEY], varchar[20], NOT NULL
            sSQL.Append(SQLNumber(tdbg(i, COL_YearNo)) & COMMA) 'YearNo [KEY], int, NOT NULL
            sSQL.Append(SQLMoney(tdbg(i, COL_Rate))) 'Rate, money, NULL
            sSQL.Append(")")
            sRet.Append(sSQL.ToString & vbCrLf)
            sSQL.Remove(0, sSQL.Length)
        Next
        Return sRet
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLDeleteD02T0071
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 07/11/2007 11:58:45
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLDeleteD02T0071() As String
        Dim sSQL As String = ""
        sSQL &= "Delete From D02T0071"
        sSQL &= " Where "
        sSQL &= "DeprTableID = " & SQLString(txtDeprTableID.Text)
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0070
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 07/11/2007 11:59:08
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0070() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0070 Set ")
        sSQL.Append("DeprTableNameU = " & SQLStringUnicode(txtDeprTableName.Text, gbUnicode, True) & COMMA) 'varchar[50], NULL
        sSQL.Append("DescriptionU = " & SQLStringUnicode(txtDescription.Text, gbUnicode, True) & COMMA) 'varchar[250], NULL
		sSQL.Append("ServiceYear = " & SQLNumber(txtServiceYear.Text) & COMMA) 'int, NULL
		sSQL.Append("QuickRate = " & SQLMoney(txtQuickRate.Text) & COMMA) 'money, NULL
		sSQL.Append("Auto = " & SQLNumber(chkAuto.Checked) & COMMA) 'tinyint, NULL
        sSQL.Append("DivisionID = " & SQLString(gsDivisionID) & COMMA) 'varchar[20], NULL
		sSQL.Append("Disabled = " & SQLNumber(chkDisabled.Checked) & COMMA) 'tinyint, NULL
        sSQL.Append("LastModifyDate = GetDate()" & COMMA) 'datetime, NULL
        sSQL.Append("LastModifyUserID = " & SQLString(gsUserID)) 'varchar[20], NULL
        sSQL.Append(" Where ")
        sSQL.Append("DeprTableID = " & SQLString(txtDeprTableID.Text))

        Return sSQL
    End Function

    Private Sub tdbg_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbg.RowColChange
  If e IsNot Nothing AndAlso e.LastRow = -1 Then Exit Sub
        If bInserRow = True And tdbg.AddNewMode = C1.Win.C1TrueDBGrid.AddNewModeEnum.AddNewCurrent Then
            tdbg.Columns(COL_Rate).Text = "" ' Gán 1 cột bất kỳ ="" cho lưới
            bInserRow = False
        End If
    End Sub

End Class