Attribute VB_Name = "MakeLogSheet"
Option Explicit
Sub MakeLogSheetSub()
    Call MakeLogSheet
End Sub
Function MakeLogSheet()
    Dim hasLogSheet As Boolean
    Dim ws As Worksheet
    Dim Sheet
    For Each Sheet In ActiveWorkbook.Sheets
        If Sheet.name = "log" Then
            hasLogSheet = True
        End If
    Next Sheet
    If Not hasLogSheet Then
        ActiveWorkbook.Sheets.Add Before:=Worksheets(1)
        Set ws = ActiveSheet
        ws.name = "log"
        ActiveWindow.DisplayGridlines = False
        Cells.Select
        Range("A1").Select
        ActiveCell.FormulaR1C1 = "日期"
        Range("B1").Select
        ActiveCell.FormulaR1C1 = "修改人"
        Range("C1").Select
        ActiveCell.FormulaR1C1 = "修改内容"
        Range("A2").Select
        ActiveCell.FormulaR1C1 = Date
        Range("B2").Select
        ActiveCell.FormulaR1C1 = "黎　奇"
        Range("C2").Select
        ActiveCell.FormulaR1C1 = "创建文档"
        Columns("A:C").Select
        Selection.ColumnWidth = 43
        Cells.Select
        Selection.RowHeight = 24
        Range("A1:C12").Select
        With Selection
            .HorizontalAlignment = xlCenter
            .VerticalAlignment = xlCenter
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = xlContext
            .MergeCells = False
        End With
        With Selection.Font
            .Bold = False
            .name = "宋体"
            .Size = 14
            .Underline = xlUnderlineStyleNone
            .ThemeColor = xlThemeColorLight1
            .TintAndShade = 0
            .ThemeFont = xlThemeFontMinor
        End With
        Selection.Borders(xlDiagonalDown).LineStyle = xlNone
        Selection.Borders(xlDiagonalUp).LineStyle = xlNone
        With Selection.Borders(xlEdgeLeft)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        With Selection.Borders(xlEdgeTop)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        With Selection.Borders(xlEdgeBottom)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        With Selection.Borders(xlEdgeRight)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        With Selection.Borders(xlInsideVertical)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        With Selection.Borders(xlInsideHorizontal)
            .LineStyle = xlContinuous
            .ColorIndex = 0
            .TintAndShade = 0
            .Weight = xlThin
        End With
        Range("A1:C1").Select
        With Selection.Font
            .Bold = True
            .name = "宋体"
            .Size = 16
            .Shadow = False
            .Underline = xlUnderlineStyleNone
            .ThemeColor = xlThemeColorLight1
            .TintAndShade = 0
            .ThemeFont = xlThemeFontNone
        End With
    End If
End Function
