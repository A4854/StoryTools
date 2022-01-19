Attribute VB_Name = "模块1"
Sub 保存拆开保存()
Dim fs As Object
Dim i, j, k, l, m, n, v, u, w, mingzi, b
Dim arr(), arrx(), arry(), arr1(), arr2()
Dim x1, x2, y1, y2

y = ActiveWorkbook.Path
'x = Left(y, InStrRev(y, "\") - 1)
w = 0
y1 = Range("B65536").End(xlUp).Row
y2 = Range("ZZ4").End(xlToLeft).Column

n = 1
m = 1

Set fs = CreateObject("Scripting.FileSystemObject")

Set f = fs.getfolder(y)

For Each fd In f.subfolders

n = n + 1

Next

ReDim arr(1 To n - 1)
ReDim arrx(1 To n - 1)

For Each fd In f.subfolders

arr(m) = fd.Name

m = m + 1

Next

Set f = Nothing

Set fs = Nothing

For i = 1 To n - 1
    arrx(i) = y & "\" & arr(i) & "\" & "总表" & ".xlsm"
    
Next

ReDim arry(1 To y2 - 1, 0 To y1 - 5)

For i = 1 To y2 - 1
    For j = 1 To y1 - 5
        
        arry(i, 0) = Cells(1, i + 1)
        arry(i, j) = Cells(5 + j, i + 1)
        
    Next
Next

For i = 1 To n - 1
    Application.ScreenUpdating = False
    Workbooks.Open Filename:=arrx(i)
    Application.DisplayAlerts = False
    Application.ScreenUpdating = False

    x1 = Range("B65536").End(xlUp).Row
    x2 = Range("ZZ1").End(xlToLeft).Column
    
    For j = 1 To y1 - 5
        w = 5
        For Each v In Range("C6", "C" & x1)
            w = w + 1
            If v = arry(2, j) Then
                b = Right(Range("D1"), Len(Range("D1")) - InStrRev(Range("D1"), "-"))
                Range("D" & w) = arry(3 + b - 1, j)
                
            End If
        Next
        w = 5
        For Each v In Range("E6", "E" & x1)
            w = w + 1
            If v = arry(2, j) Then
                b = Right(Range("D1"), Len(Range("D1")) - InStrRev(Range("D1"), "-"))
                Range("F" & w) = arry(3 + b - 1, j)
            End If
            
        Next
         
    Next
    
    ActiveWorkbook.SaveAs Filename:=arrx(i), FileFormat:=xlOpenXMLWorkbookMacroEnabled
    Application.DisplayAlerts = False
    Application.ScreenUpdating = False
    ActiveWorkbook.Close
Next

MsgBox ("保存成功")


End Sub
