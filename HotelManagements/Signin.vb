Public Class Signin

    Public Screen As System.Drawing.Rectangle = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()

    Private Sub Signin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'HotelsDataSet.UsersTable' table. You can move, or remove it, as needed.

        Me.Top = (Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
   
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim data = Me.UsersTableAdapter.Login(username, password)
        If CStr(data) = "1" Then
            Me.Hide()
            ManagementClients.Show()
        Else
            MessageBox.Show("Username atau Password anda salah.", "Login Gagal!", MessageBoxButtons.OK)
        End If
    End Sub

  
   
   
End Class