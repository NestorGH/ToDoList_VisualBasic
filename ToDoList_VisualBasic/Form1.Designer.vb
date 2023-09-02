<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.DataGridTask = New System.Windows.Forms.DataGridView()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnEditTask = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.radioDone = New System.Windows.Forms.RadioButton()
        Me.radioNotDone = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(224, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ToDoList"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(6, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(6, 57)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(256, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtDescription.ForeColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(6, 110)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(256, 44)
        Me.txtDescription.TabIndex = 4
        '
        'DataGridTask
        '
        Me.DataGridTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridTask.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DataGridTask.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTask.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridTask.ColumnHeadersHeight = 30
        Me.DataGridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridTask.EnableHeadersVisualStyles = False
        Me.DataGridTask.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridTask.Location = New System.Drawing.Point(12, 145)
        Me.DataGridTask.Name = "DataGridTask"
        Me.DataGridTask.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridTask.RowHeadersDefaultCellStyle = DataGridViewCellStyle23
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridTask.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridTask.Size = New System.Drawing.Size(776, 355)
        Me.DataGridTask.TabIndex = 5
        '
        'btnAddTask
        '
        Me.btnAddTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnAddTask.FlatAppearance.BorderSize = 0
        Me.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTask.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.ForeColor = System.Drawing.Color.White
        Me.btnAddTask.Location = New System.Drawing.Point(6, 217)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(187, 40)
        Me.btnAddTask.TabIndex = 6
        Me.btnAddTask.Text = "Add"
        Me.btnAddTask.UseVisualStyleBackColor = False
        '
        'btnEditTask
        '
        Me.btnEditTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnEditTask.FlatAppearance.BorderSize = 0
        Me.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTask.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTask.ForeColor = System.Drawing.Color.White
        Me.btnEditTask.Location = New System.Drawing.Point(6, 263)
        Me.btnEditTask.Name = "btnEditTask"
        Me.btnEditTask.Size = New System.Drawing.Size(187, 40)
        Me.btnEditTask.TabIndex = 7
        Me.btnEditTask.Text = "Edit"
        Me.btnEditTask.UseVisualStyleBackColor = False
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.btnDeleteTask.FlatAppearance.BorderSize = 0
        Me.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTask.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTask.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTask.Location = New System.Drawing.Point(6, 309)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(187, 40)
        Me.btnDeleteTask.TabIndex = 8
        Me.btnDeleteTask.Text = "Delete"
        Me.btnDeleteTask.UseVisualStyleBackColor = False
        '
        'radioDone
        '
        Me.radioDone.AutoSize = True
        Me.radioDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioDone.Location = New System.Drawing.Point(24, 32)
        Me.radioDone.Name = "radioDone"
        Me.radioDone.Size = New System.Drawing.Size(51, 17)
        Me.radioDone.TabIndex = 10
        Me.radioDone.Text = "Done"
        Me.radioDone.UseVisualStyleBackColor = True
        '
        'radioNotDone
        '
        Me.radioNotDone.AutoSize = True
        Me.radioNotDone.Checked = True
        Me.radioNotDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radioNotDone.Location = New System.Drawing.Point(24, 55)
        Me.radioNotDone.Name = "radioNotDone"
        Me.radioNotDone.Size = New System.Drawing.Size(71, 17)
        Me.radioNotDone.TabIndex = 11
        Me.radioNotDone.TabStop = True
        Me.radioNotDone.Text = "Not Done"
        Me.radioNotDone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioDone)
        Me.GroupBox1.Controls.Add(Me.radioNotDone)
        Me.GroupBox1.Location = New System.Drawing.Point(211, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 86)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTitle)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.btnDeleteTask)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnAddTask)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnEditTask)
        Me.GroupBox2.Location = New System.Drawing.Point(824, 145)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 355)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TitleBar.Controls.Add(Me.PictureBox2)
        Me.TitleBar.Controls.Add(Me.PictureBox1)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(1224, 42)
        Me.TitleBar.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ToDoList_VisualBasic.My.Resources.Resources.icons8_macos_minimize_48
        Me.PictureBox2.Location = New System.Drawing.Point(1133, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ToDoList_VisualBasic.My.Resources.Resources.icons8_x_48
        Me.PictureBox1.Location = New System.Drawing.Point(1190, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1224, 510)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridTask)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TitleBar.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents DataGridTask As DataGridView
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnEditTask As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents radioDone As RadioButton
    Friend WithEvents radioNotDone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TitleBar As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
