﻿Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module OkResult
        <Extension()>
        Public Function Ok(Of T, E)(res As Result(Of T, E)) As Maybe(Of T)
            If res.IsOk Then
                Return Maybe(Of T).None()
            End If

            Return Maybe(Of T).Some(res.Unwrap())
        End Function
    End Module
End Namespace