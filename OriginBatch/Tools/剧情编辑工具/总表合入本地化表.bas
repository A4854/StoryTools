Attribute VB_Name = "模块3"
Sub 保存本地化()
Dim fs As Object
Dim i, j, k, l, m, n, v, u, dizhi, w, b, shanchu
Dim arr(), arrx(), arry(), arr1(), arr2()
Dim x1, x2, x3, y1, y2
Dim d1, d2, d3

y = ActiveWorkbook.Path
'InStrRev从右边至左边
x = Left(y, InStrRev(y, "\") - 1)
d1 = Right(y, Len(y) - InStrRev(y, "\"))
dizhi = x & "\" & "本地化表" & ".xlsm"

u = 0

x1 = Range("B65536").End(xlUp).Row
x2 = Range("ZZ1").End(xlToLeft).Column

x3 = (x1 - 5) * 2

For i = 1 To 2
    For Each v In Range(Cells(6, 3 + (i - 1) * 2), Cells(x1, 3 + (i - 1) * 2))
        If v <> "" Then
        u = u + 1
        End If
    Next
Next

ReDim arry(1 To u, 1 To 3)

w = 1
For i = 1 To x3
    If i <= x1 - 5 Then
        If Range("C" & i + 5) <> "" Then
            arry(w, 1) = Range("C" & i + 5)
            arry(w, 2) = Range("D" & i + 5)
            arry(w, 3) = Range("D1")
            w = w + 1
        End If
    
    ElseIf i > x1 - 5 Then
        If Range("E" & i + 5 - x1 + 5) <> "" Then
            arry(w, 1) = Range("E" & i + 5 - x1 + 5)
            arry(w, 2) = Range("F" & i + 5 - x1 + 5)
            arry(w, 3) = Range("F1")
            w = w + 1
        End If
    End If
Next

Application.ScreenUpdating = False
Workbooks.Open Filename:=dizhi

Application.DisplayAlerts = False
Application.ScreenUpdating = False

y1 = Range("B65536").End(xlUp).Row
y2 = Range("ZZ4").End(xlToLeft).Column

z1 = y1

If y1 - 5 > 0 Then
    c = 5
    Do Until c >= z1
        c = c + 1
        
        If Range("B" & c) = d1 Then
        Rows(c).Select
        Selection.Delete Shift:=xlUp
        c = c - 1
        End If
        
        z1 = Range("B65536").End(xlUp).Row
    Loop
    
    
    
    z1 = Range("B65536").End(xlUp).Row
     
    For i = 1 To u
        Range("B" & i + z1) = d1
        Range("C" & i + z1) = arry(i, 1)
            For j = 1 To y2
                If Cells(1, j + 3) = arry(i, 3) Then
                    Cells(i + z1, j + 3) = arry(i, 2)
                End If
            Next
    Next
    


    
ElseIf y1 - 5 <= 0 Then
    For i = 1 To u
    Range("B" & i + 5) = d1
    Range("C" & i + 5) = arry(i, 1)
        For j = 1 To y2
            If Cells(1, j + 3) = arry(i, 3) Then
                Cells(i + 5, j + 3) = arry(i, 2)
            End If
        Next
    Next

End If

 z1 = Range("B65536").End(xlUp).Row

'重新排序
For i = 1 To z1 - 5
    Range("A" & i + 5) = i
Next
    
    ActiveWorkbook.SaveAs Filename:=dizhi, FileFormat:=xlOpenXMLWorkbookMacroEnabled
    Application.ScreenUpdating = False
    Application.DisplayAlerts = False
 
    ActiveWorkbook.Close

MsgBox "保存成功"

End Sub
