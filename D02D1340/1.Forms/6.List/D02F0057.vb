'#-------------------------------------------------------------------------------------
'# Created Date: 15/11/2007 4:07:24 PM
'# Created User: Trần Thị ÁiTrâm
'# Modify Date: 15/11/2007 4:07:24 PM
'# Modify User: Trần Thị ÁiTrâm
'#-------------------------------------------------------------------------------------
Imports System.Text
Imports System

Public Class D02F0057

    Private _savedOK As Boolean
    Public ReadOnly Property SavedOK() As Boolean
        Get
            Return _savedOK
        End Get
    End Property

    Private dtAssetFrm As DataTable
    Private dtAssetTo As DataTable

    Private _assetID As String = ""
    Public Property AssetID() As String
        Get
            Return _assetID
        End Get
        Set(ByVal value As String)
            _assetID = value
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
            End Select
        End Set
    End Property

    Private Sub LoadAddNew()
        txtAmount.Visible = False
        lblAmount.Visible = False
        txtMinDep.Visible = False
        lblMinDep.Visible = False
        txtMaxDep.Visible = False
        lblMaxDep.Visible = False

        Me.Height = 175 '156
        Me.Width = 556
        btnSave.Left = 304
        btnSave.Top = 120 '97
        btnNext.Left = 386
        btnNext.Top = 120 '97
        btnClose.Left = 468
        btnClose.Top = 120 '97
        grp1.Height = 110 '82
        grp1.Width = 538
        LoadDefault()
    End Sub

    Private Sub LoadDefault()
        tdbcPeriodFr.Text = giTranMonth.ToString("00") & "/" & giTranYear
        tdbcPeriodTo.Text = giTranMonth.ToString("00") & "/" & giTranYear
    End Sub

    Private Sub LoadEdit()
        tdbcGroupID.Enabled = False
        tdbcFromAssetID.Enabled = False
        tdbcToAssetID.Enabled = False
        '==============================
        'di chuyen muc khau hao toi da, toi thieu
        lblMinDep.Location = lblAmount.Location
        txtMinDep.Location = txtAmount.Location
        lblMaxDep.Top = lblMinDep.Top
        txtMaxDep.Top = txtMinDep.Top
        '=DI chuyen muc khau hao
        lblAmount.Location = lblFromAssetID.Location
        txtAmount.Location = tdbcFromAssetID.Location
        '==di chuyen tai san
        tdbcFromAssetID.Location = tdbcPeriodFr.Location
        tdbcToAssetID.Location = tdbcPeriodTo.Location
        lblFromAssetID.Location = lblPeriodFr.Location
        'an ky
        lblToAssetID.Visible = False
        tdbcPeriodFr.Visible = False
        tdbcPeriodTo.Visible = False
        '==============================
        txtAmount.Visible = True
        lblAmount.Visible = True
        txtMinDep.Visible = True
        lblMinDep.Visible = True
        txtMaxDep.Visible = True
        lblMaxDep.Visible = True

        grp1.Height = 145 '163 '
        grp1.Width = 538
        Me.Height = 210 '230 '
        Me.Width = 556
        btnSave.Left = 386
        btnSave.Top = 156 '175 '

        btnClose.Left = 468
        btnClose.Top = 156 '175 '156
        LoadMaster()
        txt_NumberFormat()
        txtAmount.Focus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub D02F0057_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            UseEnterAsTab(Me)
        End If
    End Sub

    Private Sub D02F0057_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
	If bLoadFormState = False Then FormState = _formState
        Loadlanguage()
        SetBackColorObligatory()
        ExecuteSQL(SQLStoreD02P0055)
        InputbyUnicode(Me, gbUnicode)
        SetResolutionForm(Me)
    End Sub

    Private Sub LoadTDBCombo()
        Dim sUnicode As String = ""
        Dim sLanguage As String = ""
        UnicodeAllString(sUnicode, sLanguage, gbUnicode)

        Dim sSQL As String = ""
        'Load tdbcGroupID
        sSQL = "Select 0 as DisplayOrder,'%' As GroupID, " & sLanguage & " As GroupCaption" & vbCrLf
        sSQL &= "Union " & vbCrLf
        sSQL &= "Select 1 as DisplayOrder,ACodeID As GroupID, Description" & sUnicode & " As GroupCaption" & vbCrLf
        sSQL &= "From D02V4444" & vbCrLf
        sSQL &= "Where TypeCodeID In (" & vbCrLf
        sSQL &= "                       Select GroupField From D02T0054 WITH(NOLOCK) " & vbCrLf
        sSQL &= "                       Where NormID =" & SQLString(_normID) & vbCrLf
        sSQL &= "                   )" & vbCrLf
        sSQL &= "Order By  DisplayOrder,GroupID" & vbCrLf
        LoadDataSource(tdbcGroupID, sSQL, gbUnicode)

        'Load Period
        LoadCboPeriodReport(tdbcPeriodFr, tdbcPeriodTo, D02)

    End Sub

    Private Sub LoadtdbcAssetID(ByVal ID As String)
        Dim sSQL As String
        sSQL = SQLStoreD02P0059(ID)
        dtAssetFrm = ReturnDataTable(sSQL)
        LoadDataSource(tdbcFromAssetID, dtAssetFrm.Copy, gbUnicode)
        LoadDataSource(tdbcToAssetID, dtAssetFrm.Copy, gbUnicode)
        dtAssetFrm = Nothing
    End Sub

    Private Sub LoadMaster()
        Dim sSQL As String
        sSQL = SQLStoreD02P0056()
        Dim dtMaster As DataTable = ReturnDataTable(sSQL)
        If dtMaster.Rows.Count > 0 Then
            With dtMaster.Rows(0)
                tdbcGroupID.Text = .Item("GroupID").ToString
                tdbcFromAssetID.Text = .Item("AssetID").ToString
                tdbcToAssetID.Text = .Item("AssetID").ToString
                txtAmount.Text = .Item("Amount").ToString
                txtMinDep.Text = .Item("MinDep").ToString
                txtMaxDep.Text = .Item("MaxDep").ToString
            End With
        End If
    End Sub

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0059
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 15/11/2007 04:51:04
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0059(ByVal sGroupID As String) As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0059 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(sGroupID) & COMMA  'GroupID, varchar[20], NOT NULL
        If tdbcPeriodFr.Text <> "" Then
            sSQL &= SQLNumber(tdbcPeriodFr.Columns("TranMonth").Text) & COMMA  'TranMonth, int, NOT NULL
            sSQL &= SQLNumber(tdbcPeriodFr.Columns("TranYear").Text) & COMMA  'TranYear, int, NOT NULL
        Else
            sSQL &= SQLNumber("0") & COMMA  'TranMonth, int, NOT NULL
            sSQL &= SQLNumber("0") & COMMA  'TranYear, int, NOT NULL
        End If
        If tdbcPeriodTo.Text <> "" Then
            sSQL &= SQLNumber(tdbcPeriodTo.Columns("TranMonth").Text) & COMMA  'TranMonth, int, NOT NULL
            sSQL &= SQLNumber(tdbcPeriodTo.Columns("TranYear").Text) & COMMA 'TranYear, int, NOT NULL
        Else
            sSQL &= SQLNumber("0") & COMMA  'TranMonth, int, NOT NULL
            sSQL &= SQLNumber("0") & COMMA 'TranYear, int, NOT NULL
        End If
        sSQL &= SQLNumber(gbUnicode) 'CodeTable, tinyint, NOT NULL
        Return sSQL
    End Function

    Private Sub SetBackColorObligatory()
        tdbcGroupID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcFromAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
        tdbcToAssetID.EditorBackColor = COLOR_BACKCOLOROBLIGATORY
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
                sSQL.Append(SQLStoreD02P0053)
                sSQL.Append(vbCrLf)
                sSQL.Append(SQLStoreD02P0055)
            Case EnumFormState.FormEdit
                sSQL.Append(SQLUpdateD02T0055)
        End Select

        Dim bRunSQL As Boolean = ExecuteSQL(sSQL.ToString)
        Me.Cursor = Cursors.Default

        If bRunSQL Then
            SaveOK()
            _savedOK = True
            btnClose.Enabled = True
            Select Case _FormState
                Case EnumFormState.FormAdd
                    _assetID = tdbcFromAssetID.Text
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
        If tdbcGroupID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Nhom_tai_san"))
            tdbcGroupID.Focus()
            Return False
        End If
        If tdbcFromAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Tu_tai_san"))
            tdbcFromAssetID.Focus()
            Return False
        End If
        If tdbcToAssetID.Text.Trim = "" Then
            D99C0008.MsgNotYetChoose(rl3("Den_tai_san"))
            tdbcToAssetID.Focus()
            Return False
        End If
        If txtAmount.Text.Trim <> "" Then
            If CDbl(txtAmount.Text.Trim) > MaxMoney Then
                D99C0008.MsgL3(rl3("So_qua_lon"))
                txtAmount.Focus()
                Return False
            End If
        End If
        If txtMinDep.Text.Trim <> "" Then
            If CDbl(txtMinDep.Text.Trim) > MaxMoney Then
                D99C0008.MsgL3(rl3("So_qua_lon"))
                txtMinDep.Focus()
                Return False
            End If
        End If
        If txtMaxDep.Text.Trim <> "" Then
            If CDbl(txtMaxDep.Text.Trim) > MaxMoney Then
                D99C0008.MsgL3(rl3("So_qua_lon"))
                txtMaxDep.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0056
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 07:58:26
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0056() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0056 "
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(_assetID) & COMMA 'AssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(gsLanguage) 'gnLanguage, int, NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0055
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 07:58:46
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0055() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0055 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, int, NOT NULL
        sSQL &= SQLNumber(giTranYear) & COMMA 'TranYear, int, NOT NULL
        sSQL &= SQLNumber(gbUnicode) 'CodeTable, tinyint, NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLStoreD02P0053
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 08:58:54
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLStoreD02P0053() As String
        Dim sSQL As String = ""
        sSQL &= "Exec D02P0053 "
        sSQL &= SQLString(gsUserID) & COMMA 'UserID, varchar[20], NOT NULL
        sSQL &= SQLString(gsDivisionID) & COMMA 'DivisionID, varchar[20], NOT NULL
        sSQL &= SQLString(_normID) & COMMA 'NormID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcGroupID.Text) & COMMA 'GroupID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcFromAssetID.Text) & COMMA 'FromAssetID, varchar[20], NOT NULL
        sSQL &= SQLString(tdbcToAssetID.Text) & COMMA 'ToAssetID, varchar[20], NOT NULL
        sSQL &= SQLNumber(giTranMonth) & COMMA 'TranMonth, int, NOT NULL
        sSQL &= SQLNumber(giTranYear) 'TranYear, int, NOT NULL
        Return sSQL
    End Function

    '#---------------------------------------------------------------------------------------------------
    '# Title: SQLUpdateD02T0055
    '# Created User: Trần Thị ÁiTrâm
    '# Created Date: 16/11/2007 09:00:20
    '# Modified User: 
    '# Modified Date: 
    '# Description: 
    '#---------------------------------------------------------------------------------------------------
    Private Function SQLUpdateD02T0055() As StringBuilder
        Dim sSQL As New StringBuilder
        sSQL.Append("Update D02T0055 Set ")
        sSQL.Append("Amount = " & SQLMoney(txtAmount.Text) & COMMA) 'money, NOT NULL
        sSQL.Append("MinDep = " & SQLMoney(txtMinDep.Text) & COMMA) 'money, NULL
        sSQL.Append("MaxDep = " & SQLMoney(txtMaxDep.Text)) 'money, NULL
        sSQL.Append(" Where ")
        sSQL.Append("NormID = " & SQLString(_normID) & " And ")
        sSQL.Append("AssetID = " & SQLString(_assetID))

        Return sSQL
    End Function

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
    End Sub

    Private Sub txtMaxDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxDep.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
    End Sub

    Private Sub txtMinDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMinDep.KeyPress
        e.Handled = CheckKeyPress(e.KeyChar, EnumKey.NumberDot)
    End Sub

    Private Sub txtAmount_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmount.Validated
        txtAmount.Text = SQLNumber(txtAmount.Text, DxxFormat.DecimalPlaces)
    End Sub

    Private Sub txt_NumberFormat()
        txtAmount.Text = SQLNumber(txtAmount.Text, DxxFormat.DecimalPlaces)
        txtMinDep.Text = SQLNumber(txtMinDep.Text, DxxFormat.DecimalPlaces)
        txtMaxDep.Text = SQLNumber(txtMaxDep.Text, DxxFormat.DecimalPlaces)
    End Sub

    Private Sub txtMinDep_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMinDep.Validated
        txtMinDep.Text = SQLNumber(txtMinDep.Text, DxxFormat.DecimalPlaces)
    End Sub

    Private Sub txtMaxDep_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaxDep.Validated
        txtMaxDep.Text = SQLNumber(txtMaxDep.Text, DxxFormat.DecimalPlaces)
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click

        btnNext.Enabled = False
        btnSave.Enabled = True
        LoadAddNew()
        tdbcGroupID.Text = ""
        tdbcFromAssetID.Text = ""
        tdbcToAssetID.Text = ""

        tdbcGroupID.Focus()
    End Sub

    Private Sub Loadlanguage()
        '================================================================ 
        Me.Text = rl3("Dinh_muc_khau_hao_-_D02F0057") & UnicodeCaption(gbUnicode) '˜Ünh m÷c khÊu hao - D02F0057
        '================================================================ 
        'lblFrom.Text = rl3("Tu") 'Từ
        lblPeriodFr.Text = rl3("Ky")
        lblGroupID.Text = rl3("Nhom_tai_san") 'Nhóm tài sản
        lblFromAssetID.Text = rl3("Tai_san") 'Tài sản
        'lblToAssetID.Text = rl3("Den") 'Đến
        lblAmount.Text = rl3("Muc_khau_hao") 'Mức khấu hao
        lblMinDep.Text = rl3("Muc_khau_hao_toi_thieu") 'Mức khấu hao tối thiểu
        lblMaxDep.Text = rl3("Muc_khau_hao_toi_da") 'Mức khấu hao tối đa
        '================================================================ 
        btnSave.Text = rl3("_Luu") '&Lưu
        btnClose.Text = rl3("Do_ng") 'Đó&ng
        btnNext.Text = rl3("Nhap__tiep") 'Nhập &tiếp
        '================================================================ 
        tdbcToAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcToAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcFromAssetID.Columns("AssetID").Caption = rl3("Ma") 'Mã
        tdbcFromAssetID.Columns("AssetName").Caption = rl3("Ten") 'Tên
        tdbcGroupID.Columns("GroupID").Caption = rl3("Ma") 'Mã
        tdbcGroupID.Columns("GroupCaption").Caption = rl3("Ten") 'Tên
    End Sub

#Region "Events tdbcGroupID with txtGroupName load tdbcFromAssetID"

    Private Sub tdbcGroupID_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupID.Close
        If tdbcGroupID.FindStringExact(tdbcGroupID.Text) = -1 Then
            txtGroupCaption.Text = ""
        End If
    End Sub

    Private Sub tdbcGroupID_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcGroupID.SelectedValueChanged
        If Not (tdbcGroupID.Tag Is Nothing OrElse tdbcGroupID.Tag.ToString = "") Then
            tdbcGroupID.Tag = ""
            Exit Sub
        End If
        If tdbcGroupID.SelectedValue Is Nothing Then
            LoadtdbcAssetID("-1")
            Exit Sub
        End If
        txtGroupCaption.Text = tdbcGroupID.Columns(1).Text
        LoadtdbcAssetID(tdbcGroupID.SelectedValue.ToString())
        'ExecuteSQL(SQLStoreD02P0055)
    End Sub

    Private Sub tdbcGroupID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcGroupID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then
            txtGroupCaption.Text = ""
        End If
    End Sub

    Private Sub tdbcFromAssetID_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcFromAssetID.Close
        If tdbcFromAssetID.FindStringExact(tdbcFromAssetID.Text) = -1 Then tdbcFromAssetID.Text = ""
    End Sub

    Private Sub tdbcFromAssetID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcFromAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcFromAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcToAssetID"

    Private Sub tdbcToAssetID_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbcToAssetID.Close
        If tdbcToAssetID.FindStringExact(tdbcToAssetID.Text) = -1 Then tdbcToAssetID.Text = ""
    End Sub

    Private Sub tdbcToAssetID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbcToAssetID.KeyDown
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Back Then tdbcToAssetID.Text = ""
    End Sub

#End Region

#Region "Events tdbcPeriodFr load tdbcFromAssetID"

    Private Sub tdbcPeriodFr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodFr.GotFocus
        'Dùng phím Enter
        tdbcPeriodFr.Tag = tdbcPeriodFr.Text
    End Sub

    Private Sub tdbcPeriodFr_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbcPeriodFr.MouseDown
        'Di chuyển chuột
        tdbcPeriodFr.Tag = tdbcPeriodFr.Text
    End Sub

    Private Sub tdbcPeriodFr_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodFr.SelectedValueChanged
        tdbcFromAssetID.Text = ""
        tdbcToAssetID.Text = ""
    End Sub

    Private Sub tdbcPeriodFr_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodFr.LostFocus

        If tdbcPeriodFr.Tag.ToString = "" And tdbcPeriodFr.Text = "" Then Exit Sub
        If tdbcPeriodFr.Tag.ToString = tdbcPeriodFr.Text And tdbcPeriodFr.SelectedValue IsNot Nothing Then Exit Sub
        If tdbcPeriodFr.FindStringExact(tdbcPeriodFr.Text) = -1 Then
            tdbcPeriodFr.Text = ""
            LoadtdbcAssetID(tdbcGroupID.Text)
            'tdbcFromAssetID.Text = ""
            'tdbcToAssetID.Text = ""
            Exit Sub
        End If
        LoadtdbcAssetID(tdbcGroupID.Text)
    End Sub
#End Region

#Region "Events tdbcPeriodTo load tdbcFromAssetID"

    Private Sub tdbcPeriodTo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodTo.GotFocus
        'Dùng phím Enter
        tdbcPeriodTo.Tag = tdbcPeriodTo.Text
    End Sub

    Private Sub tdbcPeriodTo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbcPeriodTo.MouseDown
        'Di chuyển chuột
        tdbcPeriodTo.Tag = tdbcPeriodTo.Text
    End Sub

    Private Sub tdbcPeriodTo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodTo.SelectedValueChanged
        tdbcFromAssetID.Text = ""
        tdbcToAssetID.Text = ""
    End Sub

    Private Sub tdbcPeriodTo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tdbcPeriodTo.LostFocus
        If tdbcPeriodTo.Tag.ToString = "" And tdbcPeriodTo.Text = "" Then Exit Sub
        If tdbcPeriodTo.Tag.ToString = tdbcPeriodTo.Text And tdbcPeriodTo.SelectedValue IsNot Nothing Then Exit Sub
        If tdbcPeriodTo.FindStringExact(tdbcPeriodTo.Text) = -1 Then
            tdbcPeriodTo.Text = ""
            LoadtdbcAssetID(tdbcGroupID.Text)
            'tdbcFromAssetID.Text = ""
            'tdbcToAssetID.Text = ""
            Exit Sub
        End If
        LoadtdbcAssetID(tdbcGroupID.Text)
    End Sub

#End Region

End Class