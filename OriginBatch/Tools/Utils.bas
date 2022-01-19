Attribute VB_Name = "Utils"
Option Explicit
Function DateToTimestamp(d As Date) As Long
    If IsNull(d) Or IsEmpty(d) Or d = "00:00:00" Then
        DateToTimestamp = 0
        Exit Function
    End If
    If d < UNIX_DATE Then
        MsgBox ("DateToTimestamp::Please enter a date after [" + CStr(UNIX_DATE) + "]!")
        DateToTimestamp = 0
        Exit Function
    End If
    DateToTimestamp = DateDiff("s", UNIX_DATE, d)
End Function
Function TimestampToDate(timestamp As Long) As Date
    If IsNull(timestamp) Or timestamp < 0 Or IsEmpty(timestamp) Or timestamp = "0" Then
        TimestampToDate = "00:00:00"
        Exit Function
    End If
    TimestampToDate = DateAdd("s", timestamp, UNIX_DATE)
End Function
Function GetColumn(argName As String) As Integer
    Dim arr As Variant
    arr = Split(TITLE_ARRAY, ",")
    If IsNull(argName) Or IsEmpty(argName) Then
        MsgBox ("GetColumn::Name of arg can not be null or empty!")
    End If
    Dim currentColumn
    For currentColumn = 1 To ActiveSheet.UsedRange.Columns.count
        If Cells(GetDataStartPosition - Application.WorksheetFunction.Match(TITLE_ARRAY_NAME, arr), currentColumn).Text = argName Then
            GetColumn = currentColumn
            Exit For
        End If
    Next currentColumn
    If IsNull(GetColumn) Or IsEmpty(GetColumn) Or GetColumn = 0 Then
        MsgBox ("GetColumn::There is no type with name [" + argName + "] in active sheet!")
    End If
End Function
Function GetDataStartPosition() As Integer
    'match arr1 in arr2
    Dim arr1, arr2 As Variant
    Dim regex, result As Object
    Dim arr1Str, arr2Str As String
    'set arr1
    'arr1 = Split(arr1Str, ",")
    arr1Str = TITLE_ARRAY
    'get arr2
    arr2 = ActiveSheet.Range(TITLE_MATCH_RANGE).Value2
    arr2Str = Join(Application.WorksheetFunction.Transpose(Application.WorksheetFunction.Index(arr2, 0, 1)), ",")
    'init regex
    Set regex = CreateObject("vbscript.regexp")
    With regex
        .Global = True
        .pattern = arr1Str + "(.*?)"
        Set result = .Execute(arr2Str)
    End With
    'get last index of arr2 where match arr1
    Dim k, v As Integer '
    k = 1
    v = 0
    If result.count = 0 Then
        Exit Function
    End If
    Do Until v = result.item(0).FirstIndex + result.item(0).Length + 1
        v = v + Len(arr2(k, 1)) + 1
        k = k + 1
    Loop
    GetDataStartPosition = k
End Function
Function GetCharLen(s As String) As Integer
    Dim arr() As Byte
    Dim i, chineseCount
    arr = s
    chineseCount = 0
    For i = 0 To UBound(arr) Step 2
        If Not arr(i + 1) = 0 Then
            chineseCount = chineseCount + 1
        End If
    Next i
    GetCharLen = chineseCount * 3 + (Len(s) - chineseCount) * 2
End Function
