Attribute VB_Name = "模块1"
Sub 拆分表()
Dim i, j, k, l, m, n, u, e1, e2, a, b, d, c, e, f
Dim arr(), arrx(), arrv(), arrz(), arro(), arrcs() As String
Dim x, y, z, w
Dim dizhi, canshu, name, canshu2
Dim mydic

Set mydic = CreateObject("Scripting.Dictionary")
cishu = 0
m = Range("B65536").End(xlUp).Row - 5
n = Range("ZZ4").End(xlToLeft).Column
canshu = ThisWorkbook.Path
u = 0
For i = 1 To m
    '第一次记录个数
    If u = 0 Then
        If Range("A" & 5 + i) <> "" Then
            u = 1
            e1 = Range("A" & 5 + i)
            e2 = Range("A" & 5 + i).Row
            mydic.Add e1, e2
        End If
    
    ElseIf u > 0 Then
        If Range("A" & 5 + i) <> "" Then
            If Range("A" & 5 + i) <> e Then
                u = u + 1
                e1 = Range("A" & 5 + i)
                e2 = Range("A" & 5 + i).Row
                '数组加入新的数据
                mydic.Add e1, e2
            End If
        End If
    End If

Next

x = mydic.Count
ReDim arr(1 To x)
ReDim arrv(1 To x)
ReDim arro(1 To x)

arr() = mydic.keys
arrv() = mydic.items

'记录几个数据的大小
For i = 1 To x
    If i < x Then
    arro(i) = arrv(i) - arrv(i - 1)
    ElseIf i = x Then
    arro(i) = m - arrv(i - 1) + 5 + 1
    End If
Next
'=============================================================================================
'开始循环记录数据
For j = 1 To x
    z = arr(j - 1)
    a = 0
    '表头确立
    For w = 1 To n
        If Cells(2, w) = Left(z, 2) Then
            a = a + 1
        ElseIf Cells(2, w) = "全部" Then
            a = a + 1
        End If
    Next
    
    ReDim arrx(1 To a, 1 To 5)
    ReDim arrz(1 To a)

    b = 1
    '记录表头内容
    For w = 1 To n
        If Cells(2, w) = Left(z, 2) Then
            arrx(b, 1) = Cells(1, w)
            arrx(b, 2) = Cells(2, w)
            arrx(b, 3) = Cells(3, w)
            arrx(b, 4) = Cells(4, w)
            arrx(b, 5) = Cells(5, w)
            arrz(b) = w
            b = b + 1
        ElseIf Cells(2, w) = "全部" Then
            arrx(b, 1) = Cells(1, w)
            arrx(b, 2) = Cells(2, w)
            arrx(b, 3) = Cells(3, w)
            arrx(b, 4) = Cells(4, w)
            arrx(b, 5) = Cells(5, w)
            arrz(b) = w
            b = b + 1
            
        End If
    
    Next
    c = 1
    
    ReDim arry(1 To arro(j))
    
    For c = 1 To arro(j)
        For f = 1 To a
        
            If f = 1 Then
            arry(c) = Cells(arrv(cishu), arrz(f))
            
            ElseIf f > 1 Then
            canshu2 = arrv(cishu) + c - 1
            arry(c) = arry(c) & ";" & Cells(canshu2, arrz(f))
            
            End If
            
        Next
        
    Next
    
    cishu = cishu + 1
    
    Workbooks.Add
    Application.DisplayAlerts = False
    Application.ScreenUpdating = False
    Range("A1", "ZZ999") = ""
    
    '录入表头
    For w = 1 To a
        For u = 1 To 5
            Cells(u, w) = arrx(w, u)
        Next
    
    Next
    
    '录入对应数据
    For w = 1 To arro(j)
        arrcs() = Split(arry(w), ";")
        For f = 1 To a
           Cells(5 + w, f) = arrcs(f - 1)
        Next
    Next
    
    
    'ActiveWorkbook.SaveAs ThisWorkbook.Path & "\" & z & ".xls"
    
 
   ' ActiveWorkbook.Close True
    

    'dizhi = Left(canshu, InStrRev(canshu, "\") - 1)
    dizhi = canshu

    name = dizhi & "\" & z & ".xlsm"

    ActiveWorkbook.SaveAs Filename:=name, FileFormat:=xlOpenXMLWorkbookMacroEnabled
    Application.ScreenUpdating = False
    Application.DisplayAlerts = False
 
    ActiveWorkbook.Close
      
Next

MsgBox "保存成功"

End Sub
