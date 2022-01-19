Attribute VB_Name = "模块3"
Sub 更新备注()
Dim gzb, i, j, k, l, v, A, B, p
Dim arrx()
'
' 宏3 宏
'
gzb = Worksheets.Count - 2
'
ReDim arrx(1 To gzb)

For i = 1 To gzb
arrx(i) = Sheets(i).name
n = Sheets(i).Range("ZZ3").End(xlToLeft).Column
Sheets(arrx(i)).Select

 For j = 1 To n
    If Cells(1, j) = "选项" Then
    
    Range(Cells(8, j), Cells(999, j)).Select
         B = Cells(2, j)
         A = "=备注!$" & B & "$2:$" & B & "$20"
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
    
    Range(Cells(3, j), Cells(999, j)).Select
    Selection.Font.Bold = True
    Selection.Font.Italic = True
    Selection.Font.Underline = xlUnderlineStyleSingle
    With Selection.Font
        .Color = -16777024
        .TintAndShade = 0
    End With
    
    ElseIf Cells(1, j) = "选项(需转换)" Then
    
        Range(Cells(8, j), Cells(999, j)).Select
        
         p = InStr(Cells(2, j), ";")
         B = Mid(Cells(2, j), 1, p - 1)
         A = "=备注!$" & B & "$2:$" & B & "$20"
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
    
    Range(Cells(3, j), Cells(999, j)).Select
    Selection.Font.Bold = True
    Selection.Font.Italic = True
    Selection.Font.Underline = xlUnderlineStyleSingle
    With Selection.Font
        .Color = -16777024
        .TintAndShade = 0
    End With
    
    ElseIf Cells(1, j) = "" Then
    
    Range(Cells(3, j), Cells(999, j)).Select
    With Selection.Validation
        .Delete
        .Add Type:=xlValidateInputOnly, AlertStyle:=xlValidAlertStop, Operator _
        :=xlBetween
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
    Selection.Font.Underline = xlUnderlineStyleNone
    Selection.Font.Italic = False
    Selection.Font.Bold = False
    With Selection.Font
        .ThemeColor = xlThemeColorLight1
        .TintAndShade = 0
    End With
    
    
    End If
    
  Next
  
Sheets(arrx(i)).Range("A1").Select
  
Next
     
Sheets("备注").Select

End Sub


