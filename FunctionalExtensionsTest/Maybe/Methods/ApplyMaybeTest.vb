Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class ApplyMaybeTest
    <TestMethod>
    Public Sub ApplyMaybeReturnsIdenticalValues()
        Dim expected As Integer = 5
        Dim sut = Maybe(Of Integer).Some(expected)

        Assert.AreEqual(expected, sut.Apply(Sub(x) Math.Sqrt(x)).Unwrap())
    End Sub

    <TestMethod>
    Public Sub ApplyMaybeInvokesMethod()
        Dim testvalue As String = "works!"
        Dim _global As String = "test "
        Dim expected As String = _global & testvalue
        Dim sut = Maybe(Of String).Some(testvalue)

        sut.Apply(Sub(x)
                      _global &= x
                  End Sub)

        Assert.AreEqual(expected, _global)
    End Sub

    <TestMethod>
    Public Sub ApplyMaybeIgnoresApplyForNone()
        Dim expected As Integer = 5
        Dim testvalue As String = "works!"
        Dim _global As String = "test "
        Dim sut = Maybe(Of String).None()

        sut.Apply(Sub(x) _global.Append(x))

        Assert.AreNotEqual(expected, _global)
    End Sub
End Class
