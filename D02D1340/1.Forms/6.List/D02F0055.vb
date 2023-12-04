'#-------------------------------------------------------------------------------------
'# Created Date: 13/11/2007 3:35:18 PM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 13/11/2007 3:35:18 PM
'# Modify User: Trần Thị ÁiTrâm
'#-------------------------------------------------------------------------------------
Imports System.Text
Imports System

Public Class D02F0055
    Private _savedOK As Boolean
    Public ReadOnly Property SavedOK() As Boolean
        Get
            Return _savedOK
        End Get
    End Property

#Region "Const of tdbg"
    Private Const COL_VariableID As Integer = 0  ' VariableID
    Private Const COL_Description As Integer = 1 ' Description
#End Region

    Dim dtDepF1 As DataTable
    Dim dtDepF2 As DataTable

    Dim dtMinDepF1 As DataTable
    Dim dtMinDepF2 As DataTable

    Dim dtMaxDepF1 As DataTable
    Dim dtMaxDepF2 As DataTable

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

    Private _inheritNormID As String = ""
    Public Property InheritNormID() As String
        Get
            Return _inheritNormID
        End Get
        Set(ByVal value As String)
            _inheritNormID = value
        End Set
    End Property

    Dim bLoadFormState As Boolean = False
	Private _FormState As EnumFormState
    Public WriteOnly Property FormState() As EnumFormState
        Set(ByVal value As EnumFormState)
	bLoadFormState = True
	LoadInfoGeneral()
            _FormState = value
            LoadTDBCombo()
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
                Case EnumFormState.FormEditOther
                    btnSave.Enabled = True
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    LoadEditOther()
                Case EnumFormState.FormView
                    btnSave.Enabled = False
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    LoadEdit()
                Case EnumFormState.FormOther
                    btnSave.Enabled = True
                    btnNext.Visible = False
                    btnSave.Left = btnNext.Left
                    LoadInherit()
            End Select
        End Set
    End Property

    Private Sub D02F0055_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '12/10/2020, id 144622-Tài sản cố định_Lỗi chưa cảnh báo khi lưu
        If _FormState = EnumFormState.FormEdit Then
            If Not _savedOK Then
                If Not AskMsgBeforeClose() Then e.Cancel = True : Exit Sub
            End If
        ElseIf _FormState = EnumFormState.FormAdd Then
            If (txtNormNo.Text <> "" Or tdbcGroupTypeID.Text <> "") Then
                If Not _savedOK Then
                    If Not AskMsgBeforeClose() Then e.Cancel = True : Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub D02F0055_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If

        If e.KeyCode = Keys.F11 Then
            HotKeyF11(Me, tdbg)
        End If

        If e.KeyCode = Keys.Escape Then
            grpGuide.Visible = False
        End If
    End Sub

    Private Sub D02F0055_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	If bLoadFormState = False Then FormState = _formState
        Me.Cursor = Cursors.WaitCursor
        grpGuide.BringToFront()
        Loadlanguage()
        SetBackColorObligatory()
        LoadTDBGrid()
        CheckIdTextBox(txtNormNo)
        CheckIdTextBox(txtFormular, txtFormular.MaxLength, True)
        CheckIdTextBox(txtFormular1, txtFormular1.MaxLength, True)
        InputbyUnicode(Me, gbUnicode)
        SetResolutionForm(Me)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Thiet_lap_bo_dinh_muc_-_D02F0055") & UnicodeCaption(gbUnicode) 'ThiÕt lËp bè ¢Ünh m÷c - D02F0055
        '================================================================ 
        lblNormNo.Text = rl3("Ma_bo_dinh_muc") 'Mã bộ định mức
        lblteNormDate.Text = rl3("Ngay") 'Ngày
        lblNormCreatorID.Text = rl3("Nguoi_thiet_lap") 'Người thiết lập
        lblDescription.Text = rl3("Dien_giai") 'Diễn giải
        lblFormular.Text = rl3("Cong_thuc") 'Công thức
        lblDepFile01.Text = rl3("Muc_khau_hao") 'Mức khấu hao
        lblMinDepField01.Text = rl3("Muc_khau_hao_toi_thieu") 'Mức khấu hao tối thiểu
        lblMaxDepField01.Text = rl3("Muc_khau_hao_toi_da") 'Mức khấu hao tối đa
        lblGroupTypeID.Text = rl3("Tai_san_thuoc_nhom") 'Tài sản thuộc nhóm
        '================================================================ 
        btnSelect.Text = rl3("_Chon") '&Chọn
        btnSave.Text = rl3("_Luu") '&Lưu
        btnNext.Text = rl3("Nhap__tiep") 'Nhập &tiếp
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnGuide.Text = rl3("_Huong_dan") '&Hướng dẫn
        '================================================================ 
        chkUseFormular.Text = rl3("Thiet_lap_cong_thuc") 'Thiết lập công thức
        chkDisabled.Text = rl3("Khong_su_dung") 'Không sử dụng
        '================================================================ 
        grpValue.Text = rl3("Gia_tri_hang") 'Giá trị hằng
        '================================================================ 
        tdbcNormCreatorID.Columns("EmployeeID").Caption = rl3("Ma") 'Mã
        tdbcNormCreatorID.Columns("EmployeeName").Caption = rl3("Ten") 'Tên
        tdbcGroupTypeID.Columns("GroupTypeID").Caption = rl3("Ma") 'Mã
        tdbcGroupTypeID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
        tdbcMaxDepField02.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcMaxDepField02.Columns("Caption").Caption = rl3("Ten") 'Tên
        tdbcMaxDepField01.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcMaxDepField01.Columns("Caption").Caption = rl3("Ten") 'Tên
        tdbcMinDepField02.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcMinDepField02.Columns("Caption").Caption = rl3("Ten") 'Tên
        tdbcMinDepField01.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcMinDepField01.Columns("Caption").Caption = rl3("Ten") 'Tên
        tdbcDepField02.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcDepField02.Columns("Caption").Caption = rl3("Ten") 'Tên
        tdbcDepField01.Columns("FieldName").Caption = rl3("Ma") 'Mã
        tdbcDepField01.Columns("Caption").Caption = rl3("Ten") 'Tên
        '================================================================ 
    End Sub

    Private Sub SetBackColorObligatory()
        txtNormNo.BackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcGroupTypeID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
    End Sub

    Private Sub LoadAddNew()
        chkDisabled.Visible = False
        c1dateNormDate.Value = Date.Today
        cboDepOperator.Text = cboDepOperator.Items(3).ToString
        cboMinDepOperator.Text = cboMinDepOperator.Items(2).ToString
        cboMaxDepOperator.Text = cboMaxDepOperator.Items(2).ToString

        dtDepF1 = ReturnTableFilter(dtDepF1, "FieldName='CurrentCost'")
        dtDepF2 = ReturnTableFilter(dtDepF2, "FieldName='ServiceLife'")
        dtMaxDepF1 = ReturnTableFilter(dtMaxDepF1, "FieldName='CurrentCost'")
        dtMinDepF1 = ReturnTableFilter(dtMinDepF1, "FieldName='Zero'")
        dtMaxDepF2 = ReturnTableFilter(dtMaxDepF2, "FieldName='One'")
        dtMinDepF2 = ReturnTableFilter(dtMinDepF2, "FieldName='Zero'")

        tdbcDepField01.Text = dtDepF1.Rows(0).Item("Caption").ToString
        tdbcDepField02.Text = dtDepF2.Rows(0).Item("Caption").ToString
        tdbcMinDepField01.Text = dtMinDepF1.Rows(0).Item("Caption").ToString
        tdbcMinDepField02.Text = dtMinDepF2.Rows(0).Item("Caption").ToString

        tdbcMaxDepField01.Text = dtMaxDepF1.Rows(0).Item("Caption").ToString
        tdbcMaxDepField02.Text = dtMaxDepF2.Rows(0).Item("Caption").ToString
        txtNormNo.Focus()
    End Sub

    Private Sub LoadEdit()
        txtNormNo.Enabled = False
        LoadMaster()
    End Sub

    Private Sub LoadMaster()

        chkDisabled.Visible = True
        Dim sSQL As String = ""
        sSQL = SQLStoreD02P0054() '"Select * From D02V0054"
        Dim dtMaster As DataTable = ReturnDataTable(sSQL)
        If dtMaster.Rows.Count > 0 Then
            With dtMaster.Rows(0)
                txtNormNo.Text = .Item("NormNo").ToString
                c1dateNormDate.Value = .Item("NormDate")
                chkDisabled.Checked = L3Bool(.Item("Disabled"))
                tdbcNormCreatorID.Text = .Item("NormCreatorID").ToString
                txtDescription.Text = .Item("Description").ToString
                If IsDBNull(.Item("UseFormular")) Then
                    .Item("UseFormular") = 0
                End If
                chkUseFormular.Checked = L3Bool(.Item("UseFormular"))

                tdbcDepField01.Columns("FieldName").Text = .Item("DepField01").ToString
                tdbcDepField01.Columns("Caption").Text = .Item("DepFieldName01").ToString
                tdbcDepField01.Text = tdbcDepField01.Columns("Caption").Text

                cboDepOperator.Text = .Item("DepOperator").ToString
                tdbcDepField02.Columns("FieldName").Text = .Item("DepField02").ToString
                tdbcDepField02.Columns("Caption").Text = .Item("DepFieldName02").ToString
                tdbcDepField02.Text = tdbcDepField02.Columns("Caption").Text

                chkUseFormular_Click(Nothing, Nothing)

                txtFormular1.Text = .Item("Formular").ToString
                tdbcMinDepField01.Columns("FieldName").Text = .Item("MinDepField01").ToString
                tdbcMinDepField01.Columns("Caption").Text = .Item("MinDepFieldName01").ToString
                tdbcMinDepField01.Text = tdbcMinDepField01.Columns("Caption").Text
                cboMinDepOperator.Text = .Item("MinDepOperator").ToString
                tdbcMinDepField02.Columns("FieldName").Text = .Item("MinDepField02").ToString
                tdbcMinDepField02.Columns("Caption").Text = .Item("MinDepFieldName02").ToString
                tdbcMinDepField02.Text = tdbcMinDepField02.Columns("Caption").Text

                tdbcMaxDepField01.Columns("FieldName").Text = .Item("MaxDepField01").ToString
                tdbcMaxDepField01.Columns("Caption").Text = .Item("MaxDepFieldName01").ToString
                tdbcMaxDepField01.Text = tdbcMaxDepField01.Columns("Caption").Text
                cboMaxDepOperator.Text = .Item("MaxDepOperator").ToString
                tdbcMaxDepField02.Columns("FieldName").Text = .Item("MaxDepField02").ToString
                tdbcMaxDepField02.Columns("Caption").Text = .Item("MaxDepFieldName02").ToString
                tdbcMaxDepField02.Text = tdbcMaxDepField02.Columns("Caption").Text
                tdbcGroupTypeID.Text = .Item("GroupField").ToString
            End With
        End If

    End Sub

    Private Sub LoadInherit()
        LoadMaster()
        txtNormNo.Text = ""
        tdbcGroupTypeID.Enabled = False
        txtNormNo.Focus()
    End Sub

    Private Sub LoadEditOther()
        tdbcGroupTypeID.Enabled = True
        EnabledControl(False)
        chkDisabled.Enabled = True
        LoadMaster()
        chkDisabled.Focus()
    End Sub

    Private Sub EnabledControl(ByVal bFlag As Boolean)
        txtNormNo.Enabled = bFlag
        c1dateNormDate.Enabled = bFlag
        tdbcNormCreatorID.Enabled = bFlag
        txtDescription.Enabled = bFlag
        chkUseFormular.Enabled = bFlag
        txtFormular1.Enabled = bFlag
        tdbcMinDepField01.Enabled = bFlag
        cboMinDepOperator.Enabled = bFlag
        tdbcMinDepField02.Enabled = bFlag
        tdbcMaxDepField01.Enabled = bFlag
        cboMaxDepOperator.Enabled = bFlag
        tdbcMaxDepField02.Enabled = bFlag
        tdbcGroupTypeID.Enabled = bFlag
        tdbcDepField01.Enabled = bFlag
        cboDepOperator.Enabled = bFlag
        tdbcDepField02.Enabled = bFlag
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        btnSave.Enabled = True
        btnNext.Enabled = False
        txtNormNo.Text = ""
        tdbcNormCreatorID.Text = ""
        txtNormCreatorName.Text = ""
        txtDescription.Text = ""
        chkUseFormular.Checked = False
        chkUseFormular_Click(Nothing, Nothing)
        LoadAddNew()
        txtNormNo.Focus()
    End Sub

    Private Sub LoadTDBCombo()
        Dim sSQL As String = ""
        'Load tdbcNormCreatorID
        sSQL = "Select  ObjectID as EmployeeID, ObjectName" & UnicodeJoin(gbUnicode) & " As EmployeeName, ObjectTypeID, VATNo" & vbCrLf
        sSQL &= "From   Object WITH(NOLOCK) " & vbCrLf
        sSQL &= "Where  ObjectTypeID = 'NV'" & vbCrLf
        sSQL &= "Order By   ObjectID"
        LoadDataSource(tdbcNormCreatorID, sSQL, gbUnicode)

        'Load tdbcDepField01
        sSQL = "Select FieldName," & IIf(geLanguage = EnumLanguage.Vietnamese, "VieCaption", "EngCaption").ToString() & UnicodeJoin(gbUnicode) & " Caption " & vbCrLf
        sSQL &= "  From D02V2222 Order By Caption"
        dtDepF1 = ReturnDataTable(sSQL)
        LoadDataSource(tdbcDepField01, dtDepF1, gbUnicode)

        dtDepF2 = dtDepF1.Copy
        LoadDataSource(tdbcDepField02, dtDepF2, gbUnicode)
        dtMinDepF1 = dtDepF1.Copy
        LoadDataSource(tdbcMinDepField01, ReturnTableFilter(dtMinDepF1, " FieldName <> 'Constant'"), gbUnicode)
        dtMinDepF2 = dtDepF1.Copy
        LoadDataSource(tdbcMinDepField02, ReturnTableFilter(dtMinDepF2, " FieldName <> 'Constant'"), gbUnicode)
        dtMaxDepF1 = dtDepF1.Copy
        LoadDataSource(tdbcMaxDepField01, ReturnTableFilter(dtMaxDepF1, " FieldName <> 'Constant'"), gbUnicode)
        dtMaxDepF2 = dtDepF1.Copy
        LoadDataSource(tdbcMaxDepField02, ReturnTableFilter(dtMaxDepF2, " FieldName <> 'Constant'"), gbUnicode)

        'Load tdbcGroupTypeID
        sSQL = "Select GroupTypeID," & IIf(geLanguage = EnumLanguage.Vietnamese, "VieTypeCaption", "EngTypeCaption").ToString() & UnicodeJoin(gbUnicode) & " GroupCaption " & vbCrLf
        sSQL &= " From D02V3333 Order By GroupTypeID "
        LoadDataSource(tdbcGroupTypeID, sSQL, gbUnicode)
    End Sub

    Private Sub btnGuide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuide.Click
        If grpGuide.Visible = True Then
            grpGuide.Visible = False
        Else
            txtFormular.Text = ""
            grpGuide.Visible = True
        End If
    End Sub

    Private Sub btnCloseFrame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseFrame.Click
        grpGuide.Visible = False
    End Sub

#Region "Events tdbcNormCreatorID with txtNormCreatorName"

    Private Sub tdbcNormCreatorID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcNormCreatorID.Close
        If tdbcNormCreatorID.FindStringExact(tdbcNormCreatorID.Text) = -1 Then
            tdbcNormCreatorID.Text = ""
            txtNormCreatorName.Text = ""
        End If
    End Sub

    Private Sub tdbcNormCreatorID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcNormCreatorID.SelectedValueChanged
        txtNormCreatorName.Text = tdbcNormCreatorID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcNormCreatorID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcNormCreatorID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcNormCreatorID.Text = ""
            txtNormCreatorName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcGroupTypeID with txtGroupTypeName"

    Private Sub tdbcGroupTypeID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.Close
        If tdbcGroupTypeID.FindStringExact(tdbcGroupTypeID.Text) = -1 Then
            tdbcGroupTypeID.Text = ""
            txtGroupTypeName.Text = ""
        End If
    End Sub

    Private Sub tdbcGroupTypeID_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcGroupTypeID.SelectedValueChanged
        txtGroupTypeName.Text = tdbcGroupTypeID.Columns(1).Value.ToString
    End Sub

    Private Sub tdbcGroupTypeID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupTypeID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            tdbcGroupTypeID.Text = ""
            txtGroupTypeName.Text = ""
        End If
    End Sub

#End Region

#Region "Events tdbcDepField01"

    Private Sub tdbcDepField01_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDepField01.Close
        If tdbcDepField01.FindStringExact(tdbcDepField01.Text) = -1 Then tdbcDepField01.Text = ""
    End Sub

    Private Sub tdbcDepField01_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDepField01.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcDepField01.Text = ""
    End Sub

#End Region

#Region "Events tdbcDepField02"

    Private Sub tdbcDepField02_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcDepField02.Close
        If tdbcDepField02.FindStringExact(tdbcDepField02.Text) = -1 Then tdbcDepField02.Text = ""
    End Sub

    Private Sub tdbcDepField02_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcDepField02.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcDepField02.Text = ""
    End Sub

#End Region

#Region "Events tdbcMinDepField01"

    Private Sub tdbcMinDepField01_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMinDepField01.Close
        If tdbcMinDepField01.FindStringExact(tdbcMinDepField01.Text) = -1 Then tdbcMinDepField01.Text = ""
    End Sub

    Private Sub tdbcMinDepField01_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcMinDepField01.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcMinDepField01.Text = ""
    End Sub

#End Region

#Region "Events tdbcMinDepField02"

    Private Sub tdbcMinDepField02_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMinDepField02.Close
        If tdbcMinDepField02.FindStringExact(tdbcMinDepField02.Text) = -1 Then tdbcMinDepField02.Text = ""
    End Sub

    Private Sub tdbcMinDepField02_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcMinDepField02.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcMinDepField02.Text = ""
    End Sub

#End Region

#Region "Events tdbcMaxDepField01"

    Private Sub tdbcMaxDepField01_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMaxDepField01.Close
        If tdbcMaxDepField01.FindStringExact(tdbcMaxDepField01.Text) = -1 Then tdbcMaxDepField01.Text = ""
    End Sub

    Private Sub tdbcMaxDepField01_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcMaxDepField01.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcMaxDepField01.Text = ""
    End Sub

#End Region

#Region "Events tdbcMaxDepField02"

    Private Sub tdbcMaxDepField02_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcMaxDepField02.Close
        If tdbcMaxDepField02.FindStringExact(tdbcMaxDepField02.Text) = -1 Then tdbcMaxDepField02.Text = ""
    End Sub

    Private Sub tdbcMaxDepField02_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcMaxDepField02.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcMaxDepField02.Text = ""
    End Sub

#End Region

    Private Sub LoadTDBGrid()
        Dim sSQL As String
        sSQL = "Select VariableID, Description" & UnicodeJoin(gbUnicode) & " As Description" & vbCrLf
        sSQL &= "From D02V0055" & vbCrLf
        sSQL &= "Where Language =" & SQLString(gsLanguage) & vbCrLf
        sSQL &= "Order By OrderNum"
        Dim dtGrid As DataTable = ReturnDataTable(sSQL)
        LoadDataSource(tdbg, dtGrid, gbUnicode)
    End Sub

    Private Sub tdbg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbg.DoubleClick
        If tdbg.RowCount < 1 Then Exit Sub
        txtFormular.Text &= tdbg(tdbg.Bookmark, COL_VariableID).ToString
        txtFormular.SelectionStart = txtFormular.TextLength
        txtFormular.Focus()
    End Sub

    Private Sub chkUseFormular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseFormular.Click
        If chkUseFormular.Checked Then
            tdbcDepField01.Visible = False
            tdbcDepField02.Visible = False
            cboDepOperator.Visible = False
            txtFormular1.Visible = True
        Else
            tdbcDepField01.Visible = True
            tdbcDepField02.Visible = True
            cboDepOperator.Visible = True
            txtFormular1.Visible = False
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        If chkUseFormular.Checked = True Then
            txtFormular1.Text = txtFormular.Text
        End If
        grpGuide.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If AskSave() = Windows.Forms.DialogResult.No Then Exit Sub
        If Not AllowSave() Then Exit Sub
        btnSave.Enabled = False
        btnClose.Enabled = False
        _savedOK = False
        Me.Cursor = Cursors.WaitCursor
        Dim sSQL As New StringBuilder
        Select Case _FormState
            Case EnumFormState.FormAdd
                sSQL.Append(SQLInsertD02T0054)

            Case EnumFormState.FormOther 'Trường hợp kế thừa
                sSQL.Append(SQLInsertD02T0054)
                sSQL.Append(vbCrLf)
                sSQL.Append(SQLStoreD02P0058)

            Case EnumFormState.FormEdit
                sSQL.Append(SQLUpdateD02T0054_Edit)
            Case EnumFormState.FormEditOther
                sSQL.Append(SQLUpdateD02T0054_EditOther)
        End Select

        Dim bRunSQL As Boolean = ExecuteSQL(sSQL.ToString)
        Me.Cursor = Cursors.Default

        If bRunSQL Then
            SaveOK()
            _savedOK = True
            btnClose.Enabled = True
            Select Case _FormState
                Case EnumFormState.FormAdd
                    _normNo = txtNormNo.Text
                    btnNext.Enabled = True
                    btnNext.Focus()
                Case EnumFormState.FormEdit
                    btnSave.Enabled = True
                    btnClose.Focus()
                Case EnumFormState.FormEditOther
                    btnSave.Enabled = True
                    btnClose.Focus()
                Case EnumFormState.FormOther 'Trường hợp kế thừa
                    _normNo = txtNormNo.Text
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
        If txtNormNo.Text.Trim = "" Then
            D99C0008.MsgNotYetEnter(rL3("Ma_bo_dinh_muc"))
            txtNormNo.Focus()
            Return False
        End If
        If tdbcGroupTypeID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rL3("Tai_san_thuoc_nhom"))
            tdbcGroupTypeID.Focus()
            Return False
        End If
        If _FormState = EnumFormState.FormAdd Then
            If IsExistKey("D02T0054", "NormNo", txtNormNo.Text) Then
                D99C0008.MsgDuplicatePKey()
                txtNormNo.Focus()
                Return False
            End If
        End If
        Return True
    End Function
    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLInsertD02T0054
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 02:30:15
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLInsertD02T0054() As StringBuilder
        Dim sSQL As New StringBuilder
        _normID = CreateIGE("D02T0054", "NormID", "02", "NO", gsStringKey)

        sSQL.Append("Insert Into D02T0054(")
        sSQL.Append("NormID, DivisionID, NormNo, NormDate, NormCreatorID, ")
        sSQL.Append("DescriptionU, DepField01, DepOperator, DepField02, MinDepField01, ")
        sSQL.Append("MinDepOperator, MinDepField02, MaxDepField01, MaxDepOperator, MaxDepField02, ")
        sSQL.Append("GroupField, Disabled, CreateUserID, CreateDate, LastModifyUserID, ")
        sSQL.Append("LastModifyDate, Constant, UseFormular, Formular")
        sSQL.Append(") Values(")
        sSQL.Append(SQLString(_normID) & COMMA) 'NormID [KEY], varchar[20], NOT NULL
        sSQL.Append(SQLString(gsDivisionID) & COMMA) 'DivisionID, varchar[20], NOT NULL
        sSQL.Append(SQLString(txtNormNo.Text) & COMMA) 'NormNo, varchar[20], NULL
        sSQL.Append(SQLDateSave(c1dateNormDate.Value) & COMMA) 'NormDate, datetime, NULL
        sSQL.Append(SQLString(tdbcNormCreatorID.Text) & COMMA) 'NormCreatorID, varchar[20], NULL
        sSQL.Append(SQLStringUnicode(txtDescription, True) & COMMA) 'Description, varchar[150], NULL
        sSQL.Append(SQLString(tdbcDepField01.Columns("FieldName").Value) & COMMA) 'DepField01, varchar[50], NULL
        sSQL.Append(SQLString(cboDepOperator.Text) & COMMA) 'DepOperator, varchar[1], NULL
        sSQL.Append(SQLString(tdbcDepField02.Columns("FieldName").Value) & COMMA) 'DepField02, varchar[50], NULL
        sSQL.Append(SQLString(tdbcMinDepField01.Columns("FieldName").Value) & COMMA) 'MinDepField01, varchar[50], NULL
        sSQL.Append(SQLString(cboMinDepOperator.Text) & COMMA) 'MinDepOperator, varchar[1], NULL
        sSQL.Append(SQLString(tdbcMinDepField02.Columns("FieldName").Value) & COMMA) 'MinDepField02, varchar[50], NULL
        sSQL.Append(SQLString(tdbcMaxDepField01.Columns("FieldName").Value) & COMMA) 'MaxDepField01, varchar[50], NULL
        sSQL.Append(SQLString(cboMaxDepOperator.Text) & COMMA) 'MaxDepOperator, varchar[1], NULL
        sSQL.Append(SQLString(tdbcMaxDepField02.Columns("FieldName").Value) & COMMA) 'MaxDepField02, varchar[50], NULL
        sSQL.Append(SQLString(tdbcGroupTypeID.Text) & COMMA) 'GroupField, varchar[20], NULL
        sSQL.Append(SQLNumber(chkDisabled.Checked) & COMMA) 'Disabled, tinyint, NOT NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'CreateUserID, varchar[20], NULL
        sSQL.Append("GetDate()" & COMMA) 'CreateDate, datetime, NULL
        sSQL.Append(SQLString(gsUserID) & COMMA) 'LastModifyUserID, varchar[20], NULL
        sSQL.Append("GetDate()" & COMMA) 'LastModifyDate, datetime, NULL
        sSQL.Append(SQLNumber("") & COMMA) 'Constant, int, NULL
        sSQL.Append(SQLNumber(chkUseFormular.Checked) & COMMA) 'UseFormular, tinyint, NULL
        sSQL.Append(SQLString(txtFormular1.Text)) 'Formular, varchar[100], NOT NULL
        sSQL.Append(")")

        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0058
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 02:51:17
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0058() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0058 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(_inheritNormID) & COMMA 'InheritedNormID, varchar[20], NOT NULL
        sSQL &= SQLString(_normID) 'NewNormID, varchar[20], NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0054
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 03:00:34
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0054_Edit() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0054 Set ")
        sSQL.Append("NormDate = " & SQLDateSave(c1dateNormDate.Value) & COMMA) 'datetime, NULL
        sSQL.Append("NormCreatorID = " & SQLString(tdbcNormCreatorID.Text) & COMMA) 'varchar[20], NULL
        sSQL.Append("DescriptionU = " & SQLStringUnicode(txtDescription, True) & COMMA) 'varchar[150], NULL
        sSQL.Append("DepField01 = " & SQLString(tdbcDepField01.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("DepOperator = " & SQLString(cboDepOperator.Text) & COMMA) 'varchar[1], NULL
        sSQL.Append("DepField02 = " & SQLString(tdbcDepField02.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("MinDepField01 = " & SQLString(tdbcMinDepField01.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("MinDepOperator = " & SQLString(cboMinDepOperator.Text) & COMMA) 'varchar[1], NULL
        sSQL.Append("MinDepField02 = " & SQLString(tdbcMinDepField02.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("MaxDepField01 = " & SQLString(tdbcMaxDepField01.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("MaxDepOperator = " & SQLString(cboMaxDepOperator.Text) & COMMA) 'varchar[1], NULL
        sSQL.Append("MaxDepField02 = " & SQLString(tdbcMaxDepField02.Columns("FieldName").Value) & COMMA) 'varchar[50], NULL
        sSQL.Append("GroupField = " & SQLString(tdbcGroupTypeID.Text) & COMMA) 'varchar[20], NULL
        sSQL.Append("Disabled = " & SQLNumber(chkDisabled.Checked) & COMMA) 'tinyint, NOT NULL
        sSQL.Append("LastModifyUserID = " & SQLString(gsUserID) & COMMA) 'varchar[20], NULL
        sSQL.Append("LastModifyDate = GetDate()" & COMMA) 'datetime, NULL
        sSQL.Append("Constant = " & SQLNumber("") & COMMA) 'int, NULL
        sSQL.Append("UseFormular = " & SQLNumber(chkUseFormular.Checked) & COMMA) 'tinyint, NULL
        sSQL.Append("Formular = " & SQLString(txtFormular1.Text)) 'varchar[100], NOT NULL
        sSQL.Append(" Where ")
        sSQL.Append("NormID = " & SQLString(_normID))

        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0054
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 03:01:14
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0054_EditOther() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0054 Set ")
        sSQL.Append("Disabled = " & SQLNumber(chkDisabled.Checked)) 'tinyint, NOT NULL
        sSQL.Append(" Where ")
        sSQL.Append("NormID = " & SQLString(_normID))
        Return sSQL
    End Function

    Private Sub tdbg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case tdbg.Col
                Case COL_VariableID
                    tdbg_DoubleClick(sender, Nothing)
                Case COL_Description
                    HotKeyEnterGrid(tdbg, COL_VariableID, e)
            End Select
        End If
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0054
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 14/11/2006 02:15:01
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0054() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0054 "
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(IIf(_FormState = EnumFormState.FormOther, _inheritNormID, _normID).ToString) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(gsLanguage) & COMMA '& COMMA 'Language, smallint, NOT NULL
        sSQL &= SQLNumber(gbUnicode) 'CodeTable, tinyint, NOT NULL
        Return sSQL
    End Function

End Class