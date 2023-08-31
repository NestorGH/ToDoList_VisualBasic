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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DataGridTask = New System.Windows.Forms.DataGridView()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnEditTask = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.btnSaveTask = New System.Windows.Forms.Button()
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(542, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(542, 20)
        Me.TextBox2.TabIndex = 4
        '
        'DataGridTask
        '
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
        'btnSaveTask
        '
        Me.btnSaveTask.Location = New System.Drawing.Point(594, 168)
        Me.btnSaveTask.Name = "btnSaveTask"
        Me.btnSaveTask.Size = New System.Drawing.Size(187, 40)
        Me.btnSaveTask.TabIndex = 9
        Me.btnSaveTask.Text = "Save"
        Me.btnSaveTask.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(800, 524)
        Me.Controls.Add(Me.btnSaveTask)
        Me.Controls.Add(Me.btnDeleteTask)
        Me.Controls.Add(Me.btnEditTask)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.DataGridTask)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridTask As DataGridView
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnEditTask As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents btnSaveTask As Button
End Class
