<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtBoxName = New TextBox()
        txtBoxLName = New TextBox()
        Label2 = New Label()
        txtBoxMLName = New TextBox()
        Label3 = New Label()
        txtBoxCareer = New TextBox()
        Label4 = New Label()
        txtBoxID = New TextBox()
        Label5 = New Label()
        txtBoxFGrade = New TextBox()
        Label6 = New Label()
        dtpBirthday = New DateTimePicker()
        Label7 = New Label()
        btnAddStudents = New Button()
        btnSetGrades = New Button()
        dgvData = New DataGridView()
        clmnName = New DataGridViewTextBoxColumn()
        clmnAge = New DataGridViewTextBoxColumn()
        clmnID = New DataGridViewTextBoxColumn()
        clmnGrade = New DataGridViewTextBoxColumn()
        clmnCareer = New DataGridViewTextBoxColumn()
        MenuStrip1 = New MenuStrip()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        XSLXToolStripMenuItem = New ToolStripMenuItem()
        DOCXToolStripMenuItem = New ToolStripMenuItem()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name(´s)"
        ' 
        ' txtBoxName
        ' 
        txtBoxName.Location = New Point(69, 60)
        txtBoxName.Name = "txtBoxName"
        txtBoxName.Size = New Size(100, 23)
        txtBoxName.TabIndex = 1
        ' 
        ' txtBoxLName
        ' 
        txtBoxLName.Location = New Point(248, 60)
        txtBoxLName.Name = "txtBoxLName"
        txtBoxLName.Size = New Size(100, 23)
        txtBoxLName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(265, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 2
        Label2.Text = "Last Name"
        ' 
        ' txtBoxMLName
        ' 
        txtBoxMLName.Location = New Point(432, 60)
        txtBoxMLName.Name = "txtBoxMLName"
        txtBoxMLName.Size = New Size(100, 23)
        txtBoxMLName.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(422, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 15)
        Label3.TabIndex = 4
        Label3.Text = "Mother´s Last Name"
        ' 
        ' txtBoxCareer
        ' 
        txtBoxCareer.Location = New Point(616, 60)
        txtBoxCareer.Name = "txtBoxCareer"
        txtBoxCareer.Size = New Size(100, 23)
        txtBoxCareer.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(641, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 6
        Label4.Text = "Career"
        ' 
        ' txtBoxID
        ' 
        txtBoxID.Location = New Point(248, 131)
        txtBoxID.Name = "txtBoxID"
        txtBoxID.Size = New Size(100, 23)
        txtBoxID.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(290, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(18, 15)
        Label5.TabIndex = 8
        Label5.Text = "ID"
        ' 
        ' txtBoxFGrade
        ' 
        txtBoxFGrade.Location = New Point(432, 131)
        txtBoxFGrade.Name = "txtBoxFGrade"
        txtBoxFGrade.ReadOnly = True
        txtBoxFGrade.Size = New Size(100, 23)
        txtBoxFGrade.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(448, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 15)
        Label6.TabIndex = 10
        Label6.Text = "Final Grade"
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Format = DateTimePickerFormat.Short
        dtpBirthday.Location = New Point(60, 131)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(120, 23)
        dtpBirthday.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(94, 113)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 15)
        Label7.TabIndex = 13
        Label7.Text = "Birthday"
        ' 
        ' btnAddStudents
        ' 
        btnAddStudents.Location = New Point(573, 100)
        btnAddStudents.Name = "btnAddStudents"
        btnAddStudents.Size = New Size(200, 40)
        btnAddStudents.TabIndex = 14
        btnAddStudents.Text = "Add Students"
        btnAddStudents.UseVisualStyleBackColor = True
        ' 
        ' btnSetGrades
        ' 
        btnSetGrades.Location = New Point(573, 157)
        btnSetGrades.Name = "btnSetGrades"
        btnSetGrades.Size = New Size(200, 40)
        btnSetGrades.TabIndex = 15
        btnSetGrades.Text = "Set Grades"
        btnSetGrades.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {clmnName, clmnAge, clmnID, clmnGrade, clmnCareer})
        dgvData.Location = New Point(60, 211)
        dgvData.Name = "dgvData"
        dgvData.Size = New Size(685, 203)
        dgvData.TabIndex = 16
        ' 
        ' clmnName
        ' 
        clmnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        clmnName.HeaderText = "Name"
        clmnName.Name = "clmnName"
        clmnName.Width = 64
        ' 
        ' clmnAge
        ' 
        clmnAge.HeaderText = "Age"
        clmnAge.Name = "clmnAge"
        ' 
        ' clmnID
        ' 
        clmnID.HeaderText = "ID"
        clmnID.Name = "clmnID"
        ' 
        ' clmnGrade
        ' 
        clmnGrade.HeaderText = "Grade"
        clmnGrade.Name = "clmnGrade"
        ' 
        ' clmnCareer
        ' 
        clmnCareer.HeaderText = "Career"
        clmnCareer.Name = "clmnCareer"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ExportToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {XSLXToolStripMenuItem, DOCXToolStripMenuItem})
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(53, 20)
        ExportToolStripMenuItem.Text = "Export"
        ' 
        ' XSLXToolStripMenuItem
        ' 
        XSLXToolStripMenuItem.Name = "XSLXToolStripMenuItem"
        XSLXToolStripMenuItem.Size = New Size(180, 22)
        XSLXToolStripMenuItem.Text = "XSLX"
        ' 
        ' DOCXToolStripMenuItem
        ' 
        DOCXToolStripMenuItem.Name = "DOCXToolStripMenuItem"
        DOCXToolStripMenuItem.Size = New Size(180, 22)
        DOCXToolStripMenuItem.Text = "DOCX"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvData)
        Controls.Add(btnSetGrades)
        Controls.Add(btnAddStudents)
        Controls.Add(Label7)
        Controls.Add(dtpBirthday)
        Controls.Add(txtBoxFGrade)
        Controls.Add(Label6)
        Controls.Add(txtBoxID)
        Controls.Add(Label5)
        Controls.Add(txtBoxCareer)
        Controls.Add(Label4)
        Controls.Add(txtBoxMLName)
        Controls.Add(Label3)
        Controls.Add(txtBoxLName)
        Controls.Add(Label2)
        Controls.Add(txtBoxName)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents txtBoxLName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxMLName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxCareer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBoxFGrade As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddStudents As Button
    Friend WithEvents btnSetGrades As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents clmnName As DataGridViewTextBoxColumn
    Friend WithEvents clmnAge As DataGridViewTextBoxColumn
    Friend WithEvents clmnID As DataGridViewTextBoxColumn
    Friend WithEvents clmnGrade As DataGridViewTextBoxColumn
    Friend WithEvents clmnCareer As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XSLXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DOCXToolStripMenuItem As ToolStripMenuItem

End Class
