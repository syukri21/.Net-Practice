Public Class ManagementsReservations

    Private Sub ClientsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientsToolStripMenuItem.Click
        Me.Close()
        ManagementClients.Show()
    End Sub

    Private Sub RoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsToolStripMenuItem.Click
        Me.Close()
        ManagementClients.Show()
    End Sub

    Private Sub ManagementsReservations_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (Signin.Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Signin.Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class