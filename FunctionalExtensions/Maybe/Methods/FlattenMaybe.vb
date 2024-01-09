Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module FlattenMaybe
        <Extension()>
        Public Function Flatten(Of T)(opt As Maybe(Of Maybe(Of T))) As Maybe(Of T)
            If opt.IsNone() Then
                Return Maybe(Of T).None
            End If

            Return opt.Unwrap()
        End Function
    End Module
End Namespace