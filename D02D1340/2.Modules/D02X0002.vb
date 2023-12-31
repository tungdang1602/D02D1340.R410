''' <summary>
''' Module này dùng để khai báo các Sub và Function toàn cục
''' </summary>
''' <remarks>Các khai báo Sub và Function ở đây không được trùng với các khai báo
''' ở các module D99Xxxxx
''' </remarks>
Module D02X0002

    '''' <summary>
    '''' Trả về là quyền của màn hình truyền vào
    '''' </summary>
    '''' <param name="FormName">Màn hình cần lấy quyền</param>
    '<DebuggerStepThrough()> _
    'Public Function ReturnPermission(ByVal FormName As String) As Integer
    '    Return D00D0041.D00C0001.GetScreenPermission(gsUserID, gsCompanyID, D02, FormName)
    'End Function

    ''' <summary>
    ''' Cập nhật số thứ tự cho lưới
    ''' </summary>
    Public Sub UpdateOrderNum(ByVal TDBGrid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal iCol As Integer)
        For i As Integer = 0 To TDBGrid.RowCount - 1
            TDBGrid(i, iCol) = i + 1
        Next
    End Sub

    ''' <summary>
    ''' Tính tổng cho 1 cột tương ứng trên lưới
    ''' </summary>
    ''' <param name="ipCol"></param>
    ''' <param name="C1Grid"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>

    Public Function Sum(ByVal ipCol As Integer, ByVal C1Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid) As Double
        Dim lSum As Double = 0
        For i As Integer = 0 To C1Grid.RowCount - 1
            If C1Grid(i, ipCol) Is Nothing OrElse TypeOf (C1Grid(i, ipCol)) Is DBNull Or C1Grid(i, ipCol).ToString = "" Then Continue For
            lSum += Convert.ToDouble(C1Grid(i, ipCol))
        Next
        Return lSum
    End Function
End Module
