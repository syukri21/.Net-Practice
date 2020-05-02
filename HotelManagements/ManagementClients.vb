Public Class ManagementClients

    Private addButtonType As Boolean = False

    Private Sub fetch()
        Me.ClientsTableAdapter.Fill(Me.HotelsDataSet1.ClientsTable)
    End Sub

    Private Sub clearForm()
        First_nameTextBox1.Text = ""
        Last_nameTextBox1.Text = ""
        EmailTextBox1.Text = ""
        PhoneTextBox1.Text = ""
        AddButton.Text = "Add"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelsDataSet1.ClientsTable' table. You can move, or remove it, as needed.
        Me.Top = (Signin.Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Signin.Screen.Width \ 2) - (Me.Width \ 2)
        Me.fetch()
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If addButtonType Then
            Me.ClientsTableAdapter.InsertQuery(First_nameTextBox1.Text, Last_nameTextBox1.Text, PhoneTextBox1.Text, EmailTextBox1.Text)
            AddButton.Text = "New"
            addButtonType = False
            Me.fetch()
        Else
            Me.clearForm()
            AddButton.Text = "Add"
            addButtonType = True
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As String = Me.ClientsTableDataGridView.CurrentRow.Cells(0).Value
        Me.ClientsTableAdapter.DeleteQuery(id)
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Dim id As String = Me.ClientsTableDataGridView.CurrentRow.Cells(0).Value
        Me.ClientsTableAdapter.DeleteQuery(id)
        Me.fetch()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        Dim id As String = Me.ClientsTableDataGridView.CurrentRow.Cells(0).Value
        Me.ClientsTableAdapter.UpdateQuery(First_nameTextBox1.Text, Last_nameTextBox1.Text, PhoneTextBox1.Text, EmailTextBox1.Text, id)
        Me.fetch()
    End Sub


    Private Sub RoomsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomsToolStripMenuItem.Click
        Me.Close()
        ManagementRooms.Show()
    End Sub

    Private Sub ReservationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservationsToolStripMenuItem.Click
        Me.Close()
        ManagementsReservations.Show()

    End Sub
End Class
