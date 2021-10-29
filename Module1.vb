Imports Newtonsoft.Json.Linq
Imports System.IO
Module SpinFunctions

    Function Gen(_lower As Integer, _higher As Integer)
        Dim Random As New Random()
        Dim Result
        Result = Random.Next(_lower, _higher)
        Return Result
    End Function

    Function WinCheck(Val1 As Integer, Val2 As Integer, Val3 As Integer) As Boolean
        If Val1 = Val2 And Val3 = Val1 And Val3 Then
            'Val1 == Val2 && Val3 == Val1 && Val4
            Return True
        Else
            Return False
        End If
    End Function

    Function WinRate(_tryes As Short, _wins As Short) As String
        Dim Percent As Single
        Percent = _wins / _tryes
        Return Format(Percent, "0.0%")
    End Function

End Module
