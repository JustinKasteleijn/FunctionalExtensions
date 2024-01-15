Imports FunctionalExtensions.Functional
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class OnOkResultTest
    <TestMethod>
    Public Sub OnOkDoesCallActionOnOk()
        Dim _global = 0
        Dim testValue = 5
        Dim expected = _global + testValue
        Dim sut = Result(Of Integer, String).Ok(-1)

        sut.OnOk(Sub(err)
                     _global += testValue
                 End Sub)

        Assert.AreEqual(
            expected,
            _global
        )
    End Sub

    <TestMethod>
    Public Sub OnOkDoesNotCallActionOnErr()
        Dim _global = 0
        Dim testValue = 5
        Dim expected = _global
        Dim sut = Result(Of Integer, String).Err("What!")

        sut.OnOk(Sub(err)
                     _global += testValue
                 End Sub)

        Assert.AreEqual(
            expected,
            _global
        )
    End Sub

End Class
