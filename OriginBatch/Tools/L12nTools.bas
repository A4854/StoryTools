Attribute VB_Name = "L12nTools"
Option Explicit
Sub ConvertInvalidSpace()
    Dim item
    For Each item In ActiveSheet.UsedRange
        item.Value = Replace(item.Value, Chr(10), "\n")
    Next item
End Sub
