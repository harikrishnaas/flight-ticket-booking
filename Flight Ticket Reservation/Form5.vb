Imports MySql.Data.MySqlClient
Public Class Form5
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server = localhost;userid=root;password=Hari@123;database=flightreservation"
        Dim READER As MySqlDataReader
        Try
            mysqlconn.Open()
            Dim query As String
            query = "delete from flightreservation.booked_tickets where otp= '" & TextBox1.Text & "'and c_number='" & TextBox2.Text & "' and f_number='" & TextBox3.Text & "'"
            COMMAND = New MySqlCommand(query, mysqlconn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Flighta Cancelled successfully")

            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class