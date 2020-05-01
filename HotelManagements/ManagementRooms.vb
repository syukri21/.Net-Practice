Public Class ManagementRooms



    Private Sub ManagementRooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelsDataSet.RoomsTable' table. You can move, or remove it, as needed.
        Me.RoomsTableTableAdapter.Fill(Me.HotelsDataSet.RoomsTable)
        Me.Top = (Signin.Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Signin.Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub ClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
        Me.Close()
        ManagementClients.Show()
    End Sub
End Class