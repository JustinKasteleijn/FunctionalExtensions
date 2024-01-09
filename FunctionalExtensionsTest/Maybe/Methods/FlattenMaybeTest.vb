Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class FlattenMaybeTest

    <TestMethod>
    Public Sub FlattensSingleLayerSome()
        Dim expected = Maybe(Of Maybe(Of Integer)).
            Some(Maybe(Of Integer).
            Some(1))
        Dim sut = Maybe(Of Maybe(Of Maybe(Of Integer))).
            Some(Maybe(Of Maybe(Of Integer)).
            Some(Maybe(Of Integer).
            Some(1)))
        Assert.AreEqual(
            expected,
            sut.Flatten()
        )
    End Sub

    <TestMethod>
    Public Sub FlattensDoubleLayerSome()
        Dim expected = Maybe(Of Integer).Some(1)
        Dim sut = Maybe(Of Maybe(Of Maybe(Of Integer))).
            Some(Maybe(Of Maybe(Of Integer)).
            Some(Maybe(Of Integer).
            Some(1)))
        Assert.AreEqual(
            expected,
            sut.Flatten().Flatten()
        )
    End Sub

    <TestMethod>
    Public Sub FlattensSingleLayerNone()
        Dim expected = Maybe(Of Maybe(Of Integer)).None()
        Dim sut = Maybe(Of Maybe(Of Maybe(Of Integer))).None()
        Assert.AreEqual(
            expected,
            sut.Flatten()
        )
    End Sub

    <TestMethod>
    Public Sub FlattensDoubleLayerNone()
        Dim expected = Maybe(Of Integer).None()
        Dim sut = Maybe(Of Maybe(Of Maybe(Of Integer))).None()
        Assert.AreEqual(
            expected,
            sut.Flatten().Flatten()
        )
    End Sub
End Class
