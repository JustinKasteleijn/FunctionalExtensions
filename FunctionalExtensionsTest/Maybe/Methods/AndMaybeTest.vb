Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class AndMaybeTest

    <TestMethod>
    Public Sub AndReturnsEarlyNone()
        Dim expected = Maybe(Of Integer).None()
        Dim x = Maybe(Of Integer).None()
        Dim y = Maybe(Of Integer).None()

        Assert.AreEqual(expected, x.And(y))
    End Sub

    <TestMethod>
    Public Sub AndReturnsLateNone()
        Dim testValue As Integer = 1
        Dim expected = Maybe(Of Integer).None()
        Dim x = Maybe(Of Integer).None()
        Dim y = Maybe(Of Integer).Some(testValue)

        Assert.AreEqual(expected, y.And(x))
    End Sub

    <TestMethod>
    Public Sub AndReturnsLateNoneForDoubleNone()
        Dim expected = Maybe(Of Integer).None()
        Dim x = Maybe(Of Integer).None()
        Dim y = Maybe(Of Integer).None()

        Assert.AreEqual(expected, y.And(x))
    End Sub

    <TestMethod>
    Public Sub AndReturnsLateSomeForDoubleSome()
        Dim testValue As Integer = 1
        Dim expected = Maybe(Of Integer).Some(testValue)
        Dim x = Maybe(Of Integer).Some(-1)
        Dim y = Maybe(Of Integer).Some(testValue)

        Assert.AreEqual(expected, x.And(y))
    End Sub
End Class
