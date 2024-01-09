Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module AndMaybe
        <Extension()>
        Public Function [And](Of T, K)(opt As Maybe(Of T), other As Maybe(Of K)) As Maybe(Of K)
            If opt.IsNone() Then
                Return Maybe(Of K).None()
            End If

            Return other
        End Function
    End Module
End Namespace