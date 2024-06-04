Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OfficeOpenXml
Imports Xceed.Words.NET
Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private list As New List(Of Student)(capacity:=20)
    Private x As Student
    Private datalist As String
    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        x = New Student()
        x.Name = txtBoxName.Text
        x.LastName = txtBoxLName.Text
        x.MlastName = txtBoxMLName.Text
        x.Birthday = Convert.ToDateTime(dtpBirthday.Text)
        x.Id = txtBoxID.Text
        x.Career = txtBoxCareer.Text
        Try
            x.FinalGrade = Integer.Parse(txtBoxFGrade.Text)
        Catch ex As Exception
            txtBoxFGrade.Text = "0"
            Return
        End Try
        txtBoxName.Clear()
        txtBoxLName.Clear()
        txtBoxMLName.Clear()
        dtpBirthday.Text = "01/01/2000"
        txtBoxID.Clear()
        txtBoxCareer.Clear()
        txtBoxFGrade.Clear()
        list.Add(x)
        dgvData.Rows.Clear()
        For Each ac As Student In list
            datalist = ac.ToString()
            Dim datalistfilter As String = datalist.Replace("Grade: ", "").Replace("ID: ", "").Replace("Name: ", "").Replace("Career: ", "").Replace("Age: ", "")
            dgvData.Rows.Add(datalistfilter.Split("||"))
        Next
    End Sub

    Private Sub XSLXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XSLXToolStripMenuItem.Click
        Using sfd As New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial
                    Using package As New ExcelPackage()
                        Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")

                        For i As Integer = 0 To dgvData.Columns.Count - 1
                            worksheet.Cells(1, i + 1).Value = dgvData.Columns(i).HeaderText
                        Next

                        For i As Integer = 0 To dgvData.Rows.Count - 1
                            For j As Integer = 0 To dgvData.Columns.Count - 1
                                worksheet.Cells(i + 2, j + 1).Value = dgvData.Rows(i).Cells(j).Value?.ToString()
                            Next
                        Next
                        package.SaveAs(sfd.FileName)
                    End Using
                    MessageBox.Show("Successful export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Oops an unexpected error has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub DOCXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DOCXToolStripMenuItem.Click
        Using sfd As New SaveFileDialog() With {.Filter = "WORD DOCUMENT|*.docx"}
            If sfd.ShowDialog() = DialogResult.OK Then
                Try
                    Using doc As DocX = DocX.Create(sfd.FileName)
                        For i As Integer = 0 To dgvData.Rows.Count - 1
                            For j As Integer = 0 To dgvData.Columns.Count - 1
                                Dim k As Integer = 1
                                k += 1
                                doc.InsertParagraph("Student " & k & x.Name & ": " & dgvData.Rows(i).Cells(j).Value?.ToString())
                            Next
                        Next
                        doc.Save()
                    End Using
                    MessageBox.Show("Successful export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Oops an unexpected error has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub btnSetGrades_Click(sender As Object, e As EventArgs) Handles btnSetGrades.Click
        Dim frm As New Form2()
        Form2.txtBoxFGrade = Me.txtBoxFGrade
        frm.Show()
    End Sub
End Class
