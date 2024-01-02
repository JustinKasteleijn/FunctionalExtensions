﻿Imports System.Runtime.CompilerServices

Namespace Functional
    Public Module IsOkayAnd
        <Extension()>
        Public Function IsOkayAnd(Of T, K, E)(res As Result(Of T, E), predicate As Func(Of T, Boolean)) As Boolean
            If res.IsErr Then
                Return False
            End If

            If Not predicate(res.Unwrap()) Then
                Return False
            End If

            Return True
        End Function
    End Module
End Namespace