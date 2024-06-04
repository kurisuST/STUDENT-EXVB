Public Class Form2
    Public Property txtBoxFGrade As TextBox

    Private Sub Form2()
        InitializeComponent()
    End Sub
    Private Sub txtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxMU1.KeyPress, txtBoxMU2.KeyPress, txtBoxMU3.KeyPress, txtBoxMU4.KeyPress,
        txtBoxPhU1.KeyPress, txtBoxPhU2.KeyPress, txtBoxPhU3.KeyPress, txtBoxPhU4.KeyPress, txtBoxPU1.KeyPress, txtBoxPU2.KeyPress, txtBoxPU3.KeyPress,
        txtBoxPU4.KeyPress, txtBoxSU1.KeyPress, txtBoxSU2.KeyPress, txtBoxSU3.KeyPress, txtBoxSU4.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            Return
        End If
        Dim currentText As String = CType(sender, TextBox).Text
        Dim newText As String = currentText.Insert(CType(sender, TextBox).SelectionStart, e.KeyChar.ToString())
        Dim result As Double
        If Double.TryParse(newText, result) AndAlso result Then
            If result > 100 Then
                e.Handled = True
            End If
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        Try
            Dim oop1 As Double = Integer.Parse(txtBoxPU1.Text)
            Dim oop2 As Double = Integer.Parse(txtBoxPU2.Text)
            Dim oop3 As Double = Integer.Parse(txtBoxPU3.Text)
            Dim oop4 As Double = Integer.Parse(txtBoxPU4.Text)
            Dim mth1 As Double = Integer.Parse(txtBoxMU1.Text)
            Dim mth2 As Double = Integer.Parse(txtBoxMU2.Text)
            Dim mth3 As Double = Integer.Parse(txtBoxMU3.Text)
            Dim mth4 As Double = Integer.Parse(txtBoxMU4.Text)
            Dim phs1 As Double = Integer.Parse(txtBoxPhU1.Text)
            Dim phs2 As Double = Integer.Parse(txtBoxPhU2.Text)
            Dim phs3 As Double = Integer.Parse(txtBoxPhU3.Text)
            Dim phs4 As Double = Integer.Parse(txtBoxPhU4.Text)
            Dim sp1 As Double = Integer.Parse(txtBoxSU1.Text)
            Dim sp2 As Double = Integer.Parse(txtBoxSU2.Text)
            Dim sp3 As Double = Integer.Parse(txtBoxSU3.Text)
            Dim sp4 As Double = Integer.Parse(txtBoxSU4.Text)

            Dim oopF As Double = GradeSetter.Average(oop1, oop2, oop3, oop4)
            Dim mthF As Double = GradeSetter.Average(mth1, mth2, mth3, mth4)
            Dim phsF As Double = GradeSetter.Average(phs1, phs2, phs3, phs4)
            Dim spF As Double = GradeSetter.Average(sp1, sp2, sp3, sp4)
            Dim finalgrade As Double = GradeSetter.Average(spF, phsF, mthF, oopF)

            GradeSetter.Sendtxtinfo(oopF, mthF, phsF, spF, txtBoxFGrade)
        Catch ex As Exception
            MessageBox.Show("Please insert all numbers.")
            Return
        End Try
    End Sub
End Class