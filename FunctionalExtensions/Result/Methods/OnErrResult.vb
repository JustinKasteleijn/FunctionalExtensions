Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OnErrResult
        <Extension()>
        Public Function OnErr(Of T, E)(res As Result(Of T, E), action As Action(Of E)) As Result(Of T, E)
            If res.IsErr() Then
                action(res.Err)
            End If

            Return res
        End Function
    End Module
End Namespace