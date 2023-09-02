Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Threading

Public Class Form1

    Dim connectionString As String = "Data Source=DESKTOP-UHQ2N61\SQLEXPRESS;Initial Catalog=todolistDB;Integrated Security=True;"
    Dim connection As New SqlConnection(connectionString)
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radioDone.CheckedChanged

    End Sub

    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

        Dim taskTitle As String = txtTitle.Text
        Dim taskDescription As String = txtDescription.Text
        Dim taskStatus As Boolean

        taskStatus = radioDone.Checked ' Utiliza el valor Checked del RadioButton para el estado

        Try
            connection.Open()

            Dim query As String = "INSERT INTO Task (Title, Description, Status) VALUES (@Title, @Description, @Status)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Title", taskTitle)
            command.Parameters.AddWithValue("@Description", taskDescription)
            command.Parameters.AddWithValue("@Status", taskStatus)

            command.ExecuteNonQuery()

            MessageBox.Show("Task successfully added")
            LoadDataGrid()
        Catch ex As Exception
            MessageBox.Show("Error adding task: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadDataGrid()
        Dim query As String = "SELECT * FROM Task"
        Dim command As New SqlCommand(query, connection)
        Dim sqlDataAdapter As New SqlDataAdapter(command)
        Dim dataTable As New DataTable

        sqlDataAdapter.Fill(dataTable)
        DataGridTask.DataSource = dataTable
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataGrid()
    End Sub

    Private Sub btnEditTask_Click(sender As Object, e As EventArgs) Handles btnEditTask.Click
        Dim taskTitle As String = txtTitle.Text
        Dim taskDescription As String = txtDescription.Text
        Dim taskStatus As Boolean
        Dim taskID As Integer

        taskStatus = radioDone.Checked ' Utiliza el valor Checked del RadioButton para el estado

        ' Obtener el ID de la fila seleccionada en el DataGridView
        If DataGridTask.SelectedRows.Count > 0 Then
            taskID = Convert.ToInt32(DataGridTask.SelectedRows(0).Cells("taskId").Value)
        Else
            MessageBox.Show("Please select a task to edit.")
            Return
        End If

        Try
            connection.Open()

            Dim query As String = "UPDATE Task SET Title = @Title, Description = @Description, Status = @Status WHERE taskId = @TaskID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Title", taskTitle)
            command.Parameters.AddWithValue("@Description", taskDescription)
            command.Parameters.AddWithValue("@Status", taskStatus)
            command.Parameters.AddWithValue("@TaskID", taskID)

            command.ExecuteNonQuery()

            MessageBox.Show("Task successfully updated")
            LoadDataGrid()
        Catch ex As Exception
            MessageBox.Show("Error updating task: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click
        Dim taskID As Integer

        ' Obtener el ID de la fila seleccionada en el DataGridView
        If DataGridTask.SelectedRows.Count > 0 Then
            taskID = Convert.ToInt32(DataGridTask.SelectedRows(0).Cells("taskId").Value)
        Else
            MessageBox.Show("Please select a task to delete.")
            Return
        End If

        Try
            connection.Open()

            Dim query As String = "DELETE FROM Task WHERE taskId = @TaskID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@TaskID", taskID)

            command.ExecuteNonQuery()

            MessageBox.Show("Task successfully deleted")
            LoadDataGrid()
        Catch ex As Exception
            MessageBox.Show("Error deleting task: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub TitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region

End Class
