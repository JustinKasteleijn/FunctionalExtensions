Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module UnwrapOrResult
        <Extension()>
        Public Function UnwrapOr(Of T, E)(res As Result(Of T, E), fallback As T) As T
            If res.IsErr() Then
                Return fallback
            End If

            Return res.Unwrap()
        End Function
    End Module
End Namespace