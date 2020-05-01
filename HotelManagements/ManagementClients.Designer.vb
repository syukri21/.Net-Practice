<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementClients
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
        Me.components = New System.ComponentModel.Container
        Me.First_nameLabel = New System.Windows.Forms.Label
        Me.Last_nameLabel = New System.Windows.Forms.Label
        Me.PhoneLabel = New System.Windows.Forms.Label
        Me.EmailLabel = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ClientsTableDataGridView = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox
        Me.PhoneTextBox1 = New System.Windows.Forms.TextBox
        Me.Last_nameTextBox1 = New System.Windows.Forms.TextBox
        Me.First_nameTextBox1 = New System.Windows.Forms.TextBox
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.EditButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientsTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelsDataSet1 = New HotelManagements.hotelsDataSet
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ClientsTableAdapter = New HotelManagements.hotelsDataSetTableAdapters.ClientsTableTableAdapter
        Me.TableAdapterManager1 = New HotelManagements.hotelsDataSetTableAdapters.TableAdapterManager
        Me.Panel1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.ClientsTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ClientsTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'First_nameLabel
        '
        Me.First_nameLabel.AutoSize = True
        Me.First_nameLabel.Location = New System.Drawing.Point(25, 118)
        Me.First_nameLabel.Name = "First_nameLabel"
        Me.First_nameLabel.Size = New System.Drawing.Size(55, 13)
        Me.First_nameLabel.TabIndex = 3
        Me.First_nameLabel.Text = "first name:"
        '
        'Last_nameLabel
        '
        Me.Last_nameLabel.AutoSize = True
        Me.Last_nameLabel.Location = New System.Drawing.Point(25, 158)
        Me.Last_nameLabel.Name = "Last_nameLabel"
        Me.Last_nameLabel.Size = New System.Drawing.Size(55, 13)
        Me.Last_nameLabel.TabIndex = 5
        Me.Last_nameLabel.Text = "last name:"
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(40, 203)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(40, 13)
        Me.PhoneLabel.TabIndex = 7
        Me.PhoneLabel.Text = "phone:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(46, 246)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(34, 13)
        Me.EmailLabel.TabIndex = 9
        Me.EmailLabel.Text = "email:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStripContainer1)
        Me.Panel1.Location = New System.Drawing.Point(294, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(419, 445)
        Me.Panel1.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ClientsTableDataGridView)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(413, 439)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(413, 439)
        Me.ToolStripContainer1.TabIndex = 4
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.Control
        '
        'ClientsTableDataGridView
        '
        Me.ClientsTableDataGridView.AutoGenerateColumns = False
        Me.ClientsTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientsTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ClientsTableDataGridView.DataSource = Me.ClientsTableBindingSource1
        Me.ClientsTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ClientsTableDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ClientsTableDataGridView.Name = "ClientsTableDataGridView"
        Me.ClientsTableDataGridView.Size = New System.Drawing.Size(413, 439)
        Me.ClientsTableDataGridView.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.EmailLabel)
        Me.Panel2.Controls.Add(Me.EmailTextBox1)
        Me.Panel2.Controls.Add(Me.PhoneLabel)
        Me.Panel2.Controls.Add(Me.PhoneTextBox1)
        Me.Panel2.Controls.Add(Me.Last_nameLabel)
        Me.Panel2.Controls.Add(Me.Last_nameTextBox1)
        Me.Panel2.Controls.Add(Me.First_nameLabel)
        Me.Panel2.Controls.Add(Me.First_nameTextBox1)
        Me.Panel2.Controls.Add(Me.RemoveButton)
        Me.Panel2.Controls.Add(Me.EditButton)
        Me.Panel2.Controls.Add(Me.AddButton)
        Me.Panel2.Location = New System.Drawing.Point(0, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 445)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Management Clients"
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsTableBindingSource1, "email", True))
        Me.EmailTextBox1.Location = New System.Drawing.Point(86, 243)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(168, 20)
        Me.EmailTextBox1.TabIndex = 10
        '
        'PhoneTextBox1
        '
        Me.PhoneTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsTableBindingSource1, "phone", True))
        Me.PhoneTextBox1.Location = New System.Drawing.Point(86, 200)
        Me.PhoneTextBox1.Name = "PhoneTextBox1"
        Me.PhoneTextBox1.Size = New System.Drawing.Size(168, 20)
        Me.PhoneTextBox1.TabIndex = 8
        '
        'Last_nameTextBox1
        '
        Me.Last_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsTableBindingSource1, "last_name", True))
        Me.Last_nameTextBox1.Location = New System.Drawing.Point(86, 155)
        Me.Last_nameTextBox1.Name = "Last_nameTextBox1"
        Me.Last_nameTextBox1.Size = New System.Drawing.Size(168, 20)
        Me.Last_nameTextBox1.TabIndex = 6
        '
        'First_nameTextBox1
        '
        Me.First_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientsTableBindingSource1, "first_name", True))
        Me.First_nameTextBox1.Location = New System.Drawing.Point(86, 115)
        Me.First_nameTextBox1.Name = "First_nameTextBox1"
        Me.First_nameTextBox1.Size = New System.Drawing.Size(168, 20)
        Me.First_nameTextBox1.TabIndex = 4
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(183, 334)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(101, 335)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(20, 335)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "New"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientsToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.ReservationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(713, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ClientsToolStripMenuItem.Text = "Clients"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.ReservationsToolStripMenuItem.Text = "Reservations"
        '
        'ClientsTableBindingSource1
        '
        Me.ClientsTableBindingSource1.DataMember = "ClientsTable"
        Me.ClientsTableBindingSource1.DataSource = Me.HotelsDataSet1
        '
        'HotelsDataSet1
        '
        Me.HotelsDataSet1.DataSetName = "hotelsDataSet"
        Me.HotelsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "first_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "first_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "last_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "last_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "email"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ClientsTableAdapter
        '
        Me.ClientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = HotelManagements.hotelsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ManagementClients
        '
        Me.ClientSize = New System.Drawing.Size(713, 471)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ManagementClients"
        Me.Panel1.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.ClientsTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ClientsTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents HotelsDataSet As HotelManagements.hotelsDataSet
    Friend WithEvents ClientsTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As HotelManagements.hotelsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents HotelsDataSet1 As HotelManagements.hotelsDataSet
    Friend WithEvents ClientsTableBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ClientsTableAdapter As HotelManagements.hotelsDataSetTableAdapters.ClientsTableTableAdapter
    Friend WithEvents TableAdapterManager1 As HotelManagements.hotelsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientsTableDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents EmailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Last_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents First_nameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents First_nameLabel As System.Windows.Forms.Label
    Friend WithEvents Last_nameLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
