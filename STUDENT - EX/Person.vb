Imports System.Globalization

Public Class Person
    Protected namevalue As String

    Public Property Name As String
            Get
                Return namevalue
            End Get
            Set(value As String)
                namevalue = value
            End Set
        End Property

        Protected mlastnamevalue As String

        Public Property MlastName As String
            Get
                Return mlastnamevalue
            End Get
            Set(value As String)
                mlastnamevalue = value
            End Set
        End Property

        Protected lastnamevalue As String

        Public Property LastName As String
            Get
                Return lastnamevalue
            End Get
            Set(value As String)
                lastnamevalue = value
            End Set
        End Property

        Protected birthdayvalue As String
        Public Property Birthday As DateTime?
            Get
                Return birthdayvalue
            End Get
            Set(value As DateTime?)
                birthdayvalue = value
            End Set
        End Property

        Public ReadOnly Property Age As Integer
            Get
                Dim day As Integer
                Dim month As Integer
                Dim agevalue As Integer
                agevalue = (DateTime.Now.Year - Birthday.Value.Year)
                month = (DateTime.Now.Month - Birthday.Value.Month)
                day = (DateTime.Now.Day - Birthday.Value.Day)

                If month >= 0 Then
                    If day < 0 Then
                        agevalue -= 1
                    End If
                End If

                If month < 0 Then
                    agevalue -= 1
                End If

                Return agevalue
            End Get
        End Property

        Public Sub New(name As String, lastname As String, mlastname As String, birthday As DateTime?)
            Me.Name = name
            Me.LastName = lastname
            Me.MlastName = mlastname
            Me.Birthday = birthday
        End Sub

        Public Sub New()
            Me.New(String.Empty, String.Empty, String.Empty, Nothing)
        End Sub

        Public Function ConcatName(name As String, lastname As String, mlastname As String) As String
            Dim fullName As String = name & " " & lastname & " " & mlastname
            Return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(fullName)
        End Function

        Public Overrides Function ToString() As String
            Return "||Age: " & Age
        End Function

    End Class
