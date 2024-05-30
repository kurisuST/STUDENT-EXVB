Public Class Form2
    Private txtBox As TextBox
    Private Sub Form2(txtBox As TextBox)
        Me.txtBox = txtBox
        InitializeComponent()
        AddHandler txtBoxPU1.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPU2.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPU3.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPU4.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxMU1.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxMU2.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxMU3.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxMU4.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPhU1.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPhU2.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPhU3.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxPhU4.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxSU1.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxSU2.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxSU3.KeyPress, AddressOf txtBox_KeyPress
        AddHandler txtBoxSU4.KeyPress, AddressOf txtBox_KeyPress
    End Sub
    Private Sub txtBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            Return
        End If
        Dim currentText As String = CType(sender, TextBox).Text
        Dim newText As String = currentText.Insert(CType(sender, TextBox).SelectionStart, e.KeyChar.ToString())
        Dim result As Integer
        If Integer.TryParse(newText, result) Then
            If result > 100 Then
                e.Handled = True
            End If
        Else
            e.Handled = True
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

            GradeSetter.Sendtxtinfo(oopF, mthF, phsF, spF, txtBox)
        Catch ex As Exception
            MessageBox.Show("Please insert all numbers.")
            Return
        End Try
    End Sub
End Class