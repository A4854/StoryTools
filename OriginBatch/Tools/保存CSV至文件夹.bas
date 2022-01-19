Attribute VB_Name = "模块2"
Sub 保存()
Dim i, j, k, l, m, n, A, p
Dim x1, x2, y1, y2
Dim gzb
Dim x, y, z
Dim arr()
Dim name

'On Error Resume Next



If Worksheets.Count > 2 Then
    ActiveSheet.Range("A6", "ZZ3000") = ""
    gzb = Worksheets.Count - 2

ReDim arr(1 To gzb)
ReDim arrx(1 To gzb)

k = 5

For v = 1 To gzb
arr(v) = Sheets(v).Range("A65536").End(xlUp).Row - 7
n = Sheets(v).Range("ZZ3").End(xlToLeft).Column

arrx(v) = Sheets(v).name

    For i = 1 To arr(v)
    
        For j = 1 To n
        
            If Sheets(v).Cells(1, j) = "选项(需转换)" Then
                
                p = InStr(Sheets(v).Cells(2, j), ";")
                x1 = Mid(Sheets(v).Cells(2, j), 1, p - 1)
                x2 = Mid(Sheets(v).Cells(2, j), p + 1, Len(Sheets(v).Cells(2, j)))
                
                If Sheets(arrx(v)).Cells(i + 7, j) = "" Then
                ActiveSheet.Cells(k + i, j) = Sheets(arrx(v)).Cells(i + 7, j)
                ElseIf Sheets(arrx(v)).Cells(i + 7, j) <> "" Then
                y1 = x1 & 2
                y2 = x2 & 99
                ActiveSheet.Cells(k + i, j) = Application.WorksheetFunction.VLookup(Sheets(arrx(v)).Cells(i + 7, j), Sheets("备注").Range(y1, y2), 2, False)
                End If
            
            Else:
    
            ActiveSheet.Cells(k + i, j) = Sheets(arrx(v)).Cells(i + 7, j)
            
            End If
            
        
        Next
    Next

k = k + arr(v)
Next

A = ActiveSheet.name

ElseIf Worksheets.Count <= 2 Then
    
A = ActiveSheet.name

End If

y = ThisWorkbook.Path

For i = 1 To 4

y = Left(y, InStrRev(y, "\") - 1)

Next

name = y & "\numeric\zh-cn\data\" & A & ".csv"

ActiveSheet.Select
ActiveSheet.Copy

ActiveWorkbook.SaveAs Filename:=name, FileFormat:=xlCSV
 
ActiveWorkbook.Close


MsgBox "保存成功"

End Sub

