Attribute VB_Name = "ģ��4"
Sub �½�ҳǩ()
Dim i, j, k, l, m, n
Dim A, B

A = Sheets("��ע").Range("B1")
B = Sheets("��ע").Range("B2")
C = Sheets("��ע").Range("B3")
Sheets.Add After:=ActiveSheet
ActiveSheet.name = Sheets("��ע").Range("B1")

    Sheets(C).Select
    Cells.Select
    Selection.Copy
    Sheets(A).Select
    Cells.Select
    ActiveSheet.Paste
    
ActiveSheet.Range("A6", "ZZ3000") = ""
Sheets(A).Move Before:=Sheets(B)
End Sub
