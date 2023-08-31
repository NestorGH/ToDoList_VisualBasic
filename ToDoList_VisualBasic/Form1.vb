Imports System.Data.SqlClient

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
End Class
