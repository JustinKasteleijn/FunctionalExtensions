Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class UnwrapOrResultTest
    <TestMethod>
    Public Sub UnwrapOrReturnsFallbackValueOnErr()
        Dim expected As Integer = 0
        Dim sut = Result(Of Integer, String).Err("SCARY!")
        Dim fallback As Integer = expected

        Assert.AreEqual(
            expected,
            sut.UnwrapOr(fallback)
        )
    End Sub

    <TestMethod>
    Public Sub UnwrapOrReturnValueOnOk()
        Dim expected As Integer = 1
        Dim sut = Result(Of Integer, String).Ok(expected)
        Dim fallback As Integer = -1

        Assert.AreEqual(
            expected,
            sut.UnwrapOr(fallback)
        )
    End Sub
End Class
