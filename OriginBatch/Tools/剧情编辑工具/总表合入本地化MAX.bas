Attribute VB_Name = "模块3"
Sub 保存本地化()
Dim fs As Object
Dim i, j, k, l, m, n, v, u, dizhi, w, b, shanchu, linshi
Dim arr(), arrx(), arry(), arr1(), arr2(), arr3(), arr4()
Dim x1, x2, x3, y1, y2
Dim d1, d2, d3, k1, k2, j1, j2, u1, u2
Dim f1 As Object, f2 As Object

y = ActiveWorkbook.Path
'InStrRev从右边至左边
x = Left(y, InStrRev(y, "\") - 1)
d1 = Right(y, Len(y) - InStrRev(y, "\"))
dizhi = x & "\" & "本地化表" & ".xlsm"

u = 0

x1 = Range("B65536").End(xlUp).Row
x2 = Range("ZZ1").End(xlToLeft).Column

x3 = (x1 - 5) * 2

'去重复
Set f1 = CreateObject("scripting.dictionary")
Set f2 = CreateObject("scripting.dictionary")
'Set d3 = CreateObject("scripting.dictionary")
'Set d4 = CreateObject("scripting.dictionary")
For i = 6 To x1
   f1(Cells(i, 3).Text) = 1
   f2(Cells(i, 5).Text) = 1
Next

k1 = f1.Count
k2 = f2.Count

arr1() = f1.keys()
arr2() = f2.keys()

ReDim arr3(1 To UBound(arr1()) + 1)

ReDim arr4(1 To UBound(arr2()) + 1)

j1 = 0
j2 = 0
For i = 0 To UBound(arr1())
    If arr1(i) <> "" Then
        j1 = j1 + 1
        arr3(j1) = arr1(i)
        arr3(j1) = arr1(i)
    End If

Next

ReDim Preserve arr3(1 To j1)

For i = 0 To UBound(arr2())
    If arr2(i) <> "" Then
        j2 = j2 + 1
        arr4(j2) = arr2(i)
    End If

Next

ReDim Preserve arr4(1 To j2)



k3 = j1 + j2

ReDim arry(1 To k3, 1 To 2)

For i = 1 To k3
    If i <= j1 Then
        arry(i, 1) = Application.WorksheetFunction.VLookup(arr3(i), Range("C6", "D" & x1), 2, False)
        arry(i, 2) = Range("D1")
    ElseIf i > j1 Then
        arry(i, 1) = Application.WorksheetFunction.VLookup(arr4(i - j1), Range("E6", "F" & x1), 2, False)
        arry(i, 2) = Range("F1")
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

    '删除重复字段算法
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
     
    For i = 1 To k3
    Range("B" & i + z1) = d1
        If i <= j1 Then
            Range("C" & i + z1) = arr3(i)
            
        ElseIf i > j1 Then
            Range("C" & i + z1) = arr4(i - j1)
        End If
        
        For j = 3 To y2
            linshi = Right(arry(i, 2), Len(arry(i, 2)) - InStrRev(arry(i, 2), "-"))
            If Cells(1, j + linshi) = arry(i, 2) Then
                Cells(i + z1, j + linshi) = arry(i, 1)
            End If
        Next
        
    Next
    


    
ElseIf y1 - 5 <= 0 Then
    For i = 1 To k3
    Range("B" & i + 5) = d1
        If i <= j1 Then
            Range("C" & i + 5) = arr3(i)
            
        ElseIf i > j1 Then
            Range("C" & i + 5) = arr4(i - j1)
        End If
        
        For j = 3 To y2
            linshi = Right(arry(i, 2), Len(arry(i, 2)) - InStrRev(arry(i, 2), "-"))
            If Cells(1, j + linshi) = arry(i, 2) Then
                Cells(i + z1, j + linshi) = arry(i, 1)
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
