Attribute VB_Name = "模块4"
Sub 新建页签()
Dim i, j, k, l, m, n
Dim A, B

A = Sheets("备注").Range("B1")
B = Sheets("备注").Range("B2")
C = Sheets("备注").Range("B3")
Sheets.Add After:=ActiveSheet
ActiveSheet.name = Sheets("备注").Range("B1")

    Sheets(C).Select
    Cells.Select
    Selection.Copy
    Sheets(A).Select
    Cells.Select
    ActiveSheet.Paste
    
ActiveSheet.Range("A6", "ZZ3000") = ""
Sheets(A).Move Before:=Sheets(B)
End Sub
