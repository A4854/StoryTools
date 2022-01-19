Attribute VB_Name = "TimestampTools"
Option Explicit
Sub AutoFitTimestamp()
    Dim time_type, time_origin, time_finish, param1, param2, rowCount, columnCount as Integer
    Dim rng as Range
    
    'init sheet data
    Set rng = ActiveSheet.UsedRange
    rowCount = UBound(rng.rows.Value2, 1)
    columnCount = UBound(rng.rows.Value2, 2)
    'Debug.Print "AutoFitTimestamp::Active sheet has [" + CStr(rowCount) + "] used ROWS and [" + CStr(columnCount) + "] used COLUMNS!"
    
    'get columns
    time_type = GetColumn("time_type")
    time_origin = GetColumn("time_origin")
    time_finish =  GetColumn("time_finish")
    param1 =  GetColumn("param1")
    param2 =  GetColumn("param2")
    
    'main
    Dim currentRow as Integer
    For currentRow = GetDataStartPosition To rowCount
        Dim nType as Integer
        Dim arr as Variant
        nType = Cells(currentRow, time_type).Value
        Select Case nType
             Case 1
                Cells(currentRow, param1) =  DateToTimestamp(Cells(currentRow, time_origin))
                Cells(currentRow, param2) =  DateToTimestamp(Cells(currentRow, time_finish))
             Case 2
                Cells(currentRow, param1) = ""
                arr = Split(Cells(currentRow, time_finish).Text, "-")
                Cells(currentRow, param2) = arr(0) * 86400 + arr(1) * 3600 + arr(2) * 60 + arr(3)
             Case 3
                Cells(currentRow, param1) = Cells(currentRow, time_origin)
                Cells(currentRow, param2) = Cells(currentRow, time_finish)
            Case 4
                Cells(currentRow, param1) =  DateToTimestamp(Cells(currentRow, time_origin))
                arr = Split(Cells(currentRow, time_finish).Text, "-")
                Cells(currentRow, param2) = arr(0) * 86400 + arr(1) * 3600 + arr(2) * 60 + arr(3)
            Case 5
                Cells(currentRow, param1) =  DateToTimestamp(Cells(currentRow, time_origin))
                Cells(currentRow, param2) = ""
        End Select
    Next currentRow
End Sub
