Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module ApplyMaybe
        <Extension()>
        Public Function Apply(Of T)(opt As Maybe(Of T), func As Action(Of T)) As Maybe(Of T)
            If opt.IsNone() Then
                Return opt
            Else
                func.Invoke(opt.Unwrap())
            End If

            Return opt
        End Function
    End Module
End Namespace