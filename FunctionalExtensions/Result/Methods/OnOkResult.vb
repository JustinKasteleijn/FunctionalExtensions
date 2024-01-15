Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OnOkResult
        <Extension()>
        Public Function OnOk(Of T, E)(res As Result(Of T, E), action As Action(Of T)) As Result(Of T, E)
            If res.IsOk() Then
                action(res.Unwrap())
            End If

            Return res
        End Function
    End Module
End Namespace