Attribute VB_Name = "模块1"
Sub 保存()
Dim i, j, k, l, m, n, u, e1, e2, a, b, d, c, e, f
Dim x, y, z, w, dizhi, AK, m1, n1
Dim arrx(), arry(), arrz()
m = Range("B65536").End(xlUp).Row
n = Range("ZZ4").End(xlToLeft).Column
w = 0
y = ActiveWorkbook.Path
x = Left(ActiveWorkbook.Name, InStrRev(ThisWorkbook.Name, ".") - 1)

dizhi = y & "\" & "总表" & ".xlsm"

ReDim arrx(1 To m - 5, 1 To n)
ReDim arry(1 To n)

For i = 1 To m - 5
    For j = 1 To n

        arrx(i, j) = Cells(i + 5, j)

        
        arry(j) = Cells(4, j)
    Next

Next

Application.ScreenUpdating = False
Workbooks.Open Filename:=dizhi

Application.DisplayAlerts = False
Application.ScreenUpdating = False

m1 = Range("B65536").End(xlUp).Row
n1 = Range("ZZ4").End(xlToLeft).Column

For i = 1 To m1
    If Range("A" & i) = x Then
     w = i
    GoTo jieshu
    End If
    
Next

jieshu:

If w = 0 Then

    Range("A" & m1 + 1) = x
    For i = 1 To m - 5
        For j = 1 To n
            u = 0
            For Each v In Range(Cells(4, 1), Cells(4, n1))
                u = u + 1
                If v = arry(j) Then
                Cells(m1 + i, u) = arrx(i, j)
                End If
                
            Next
        Next
    Next

ElseIf w > 0 Then
    '总表中这个对话的行数
    For i = w + 1 To m1
        If Range("A" & i) <> "" Then
            If Range("A" & i) <> x Then
            e = i
            GoTo jieshu2
            End If
        End If
    
    Next
    
jieshu2:

    If e - w > m - 5 Then
        c = e - w - (m - 5)
        Rows(c & ":" & e - 1).Select
        Rows(c & ":" & e - 1).Delete
    
    ElseIf e - w < m - 5 Then
        c = m - 5 - (e - w)
        Rows(e & ":" & m1).Select
        Selection.Cut
        Rows(e + c & ":" & m1 + c).Select
        ActiveSheet.Paste
    
    End If

    For i = 1 To m - 5
        For j = 1 To n
            u = 0
            For Each v In Range(Cells(4, 1), Cells(4, n1))
                u = u + 1
                If v = arry(j) Then
                Cells(w + i - 1, u) = arrx(i, j)
                End If
                
            Next
        Next
    Next
    

End If

ActiveWorkbook.SaveAs Filename:=dizhi, FileFormat:=xlOpenXMLWorkbookMacroEnabled
Application.ScreenUpdating = False
Application.DisplayAlerts = False

ActiveWorkbook.Close
MsgBox ("保存成功")

End Sub
