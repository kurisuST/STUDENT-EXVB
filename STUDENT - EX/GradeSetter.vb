Imports System.Globalization

Public Class GradeSetter
    Inherits Student

    Public Shared Function Average(a As Double, b As Double, c As Double, d As Double) As Double
        Return (a + b + c + d) / 4
    End Function

    Public Shared Sub Sendtxtinfo(a As Double, b As Double, c As Double, d As Double, txtBox As TextBox)
        Dim faverage As Double = (a + b + c + d) / 4.0
        txtBox.Text = faverage.ToString()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
