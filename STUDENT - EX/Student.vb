Public Class Student
    Inherits PersonName

    Protected finalgradevalue As Double

    Public Property FinalGrade As Double
        Get
            Return finalgradevalue
        End Get
        Set(value As Double)
            finalgradevalue = value
        End Set
    End Property

    Protected idvalue As String

    Public Property Id As String
        Get
            Return Idvalue
        End Get
        Set(value As String)
            idvalue = value
        End Set
    End Property

    Protected careervalue As String

    Public Property Career As String
        Get
            Return careervalue
        End Get
        Set(value As String)
            careervalue = value
        End Set
    End Property

    Public Sub New()
        id = String.Empty
        career = String.Empty
        finalgrade = 0
    End Sub

    Public Sub New(id As String, career As String, finalgrade As Double)
        Me.id = id
        Me.career = career
        Me.finalgrade = finalgrade
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & "||ID: " & id.ToUpper() & "||Grade: " & finalgrade & "||Career: " & career
    End Function
End Class
