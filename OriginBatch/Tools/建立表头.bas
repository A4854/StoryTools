Attribute VB_Name = "ģ��5"
Sub ������ͷ()
Dim i, j, k, l, m, n
Dim x, y, z, u
Dim A, B, C
Dim arrx()
x = Sheets("��ע").Range("B9")


If x <> "ȫ��" Then
n = Sheets(x).Range("ZZ3").End(xlToLeft).Column
    Sheets(x).Select
    Range(Cells(1, 1), Cells(1, n)).Select
         B = "B"
         A = "=��ע!$" & B & "$10:$" & B & "$12"
    Application.CutCopyMode = False
    With Selection.Validation
        .Delete
        .Add Type:=xlValidateList, AlertStyle:=xlValidAlertStop, Operator:= _
        xlBetween, Formula1:=A
        .IgnoreBlank = True
        .InCellDropdown = True
        .InputTitle = ""
        .ErrorTitle = ""
        .InputMessage = ""
        .ErrorMessage = ""
        .IMEMode = xlIMEModeNoControl
        .ShowInput = True
        .ShowError = True
        
    End With
ElseIf x = "ȫ��" Then
    gzb = Worksheets.Count - 2
    ReDim arrx(1 To gzb)
    
    For i = 1 To gzb
        arrx(i) = Sheets(i).name
        Sheets(arrx(i)).Select
        n = Sheets(arrx(i)).Range("ZZ3").End(xlToLeft).Column
    Range(Cells(1, 1), Cells(1, n)).Select
         B = "B"
         A = "=��ע!$" & B & "$10:$" & B & "$12"
    Application.CutCopyMode = False
    With Selection.Validation
        .Delete
        .Add Type:=xlValidateList, AlertStyle:=xlValidAlertStop, Operator:= _
        xlBetween, Formula1:=A
        .IgnoreBlank = True
        .InCellDropdown = True
        .InputTitle = ""
        .ErrorTitle = ""
        .InputMessage = ""
        .ErrorMessage = ""
        .IMEMode = xlIMEModeNoControl
        .ShowInput = True
        .ShowError = True
        
    End With
    
    Next
    
End If
Sheets("��ע").Select


End Sub
