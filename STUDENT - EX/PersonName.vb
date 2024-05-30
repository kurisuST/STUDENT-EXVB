Public Class PersonName
    Inherits Person

    Public Overrides Function ToString() As String
        Return "Name: " & ConcatName(Name, LastName, MlastName) & MyBase.ToString() & " "
    End Function
End Class
