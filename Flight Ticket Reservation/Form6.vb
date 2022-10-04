Imports MySql.Data.MySqlClient
Public Class Form6
    Dim mysqlconn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection


        mysqlconn.ConnectionString = "server = localhost;userid=root;password=Hari@123;database=flightreservation"
        Dim READER As MySqlDataReader
        Try
            mysqlconn.Open()
            Dim query As String
            query = "Insert into flightreservation.booked_tickets(f_name,l_name,f_number,c_number,otp) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "') "
            COMMAND = New MySqlCommand(query, mysqlconn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Ticket Booked Successfully")

            mysqlconn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class