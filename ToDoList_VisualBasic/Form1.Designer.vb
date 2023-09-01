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
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
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
        Me.Label2.Location = New System.Drawing.Point(16, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(12, 78)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(542, 20)
        Me.txtTitle.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(12, 132)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(542, 20)
        Me.txtDescription.TabIndex = 4
        '
        'DataGridTask
        '
        Me.DataGridTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridTask.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridTask.Location = New System.Drawing.Point(12, 214)
        Me.DataGridTask.Name = "DataGridTask"
        Me.DataGridTask.Size = New System.Drawing.Size(776, 298)
        Me.DataGridTask.TabIndex = 5
        '
        'btnAddTask
        '
        Me.btnAddTask.Location = New System.Drawing.Point(12, 168)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(187, 40)
        Me.btnAddTask.TabIndex = 6
        Me.btnAddTask.Text = "Add"
        Me.btnAddTask.UseVisualStyleBackColor = True
        '
        'btnEditTask
        '
        Me.btnEditTask.Location = New System.Drawing.Point(208, 168)
        Me.btnEditTask.Name = "btnEditTask"
        Me.btnEditTask.Size = New System.Drawing.Size(187, 40)
        Me.btnEditTask.TabIndex = 7
        Me.btnEditTask.Text = "Edit"
        Me.btnEditTask.UseVisualStyleBackColor = True
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.Location = New System.Drawing.Point(401, 168)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(187, 40)
        Me.btnDeleteTask.TabIndex = 8
        Me.btnDeleteTask.Text = "Delete"
        Me.btnDeleteTask.UseVisualStyleBackColor = True
        '
        'radioDone
        '
        Me.radioDone.AutoSize = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(611, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 86)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDeleteTask)
        Me.Controls.Add(Me.btnEditTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.DataGridTask)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
