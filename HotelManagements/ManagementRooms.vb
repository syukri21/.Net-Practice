Public Class ManagementRooms

    Dim Reserved As Integer = 0




    Private Sub ManagementRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelsDataSet.RoomsTable' table. You can move, or remove it, as needed.
        Me.RoomsTableTableAdapter.Fill(Me.HotelsDataSet.RoomsTable)
        Me.Top = (Signin.Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Signin.Screen.Width \ 2) - (Me.Width \ 2)
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
        Me.Close()
        ManagementClients.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Reserved = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Reserved = 0
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim number = TextBox1.Text
        Dim phone = TextBox3.Text
        Dim reserved = Me.Reserved
        Dim type

        Dim typeValue = ComboBox1.SelectedItem

        If typeValue.Equals("Single") Then
            type = 1
        Else
            type = 2
        End If
        Me.RoomsTableTableAdapter.InsertQuery(number, type, phone, reserved)
        Me.RoomsTableTableAdapter.Fill(Me.HotelsDataSet.RoomsTable)
    End Sub
End Class