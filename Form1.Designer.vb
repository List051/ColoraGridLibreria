<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FatturaDataGrid = New System.Windows.Forms.DataGridView()
        Me.OrdiniDataGrid = New System.Windows.Forms.DataGridView()
        Me.ClientiDataGrid = New System.Windows.Forms.DataGridView()
        Me.RjBtnCerca = New RJCodeAdvance.RJControls.RJButton()
        Me.RjBtnRicarica = New RJCodeAdvance.RJControls.RJButton()
        Me.TxtTutti = New System.Windows.Forms.TextBox()
        Me.TxtEvidenzia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.FatturaDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FatturaDataGrid
        '
        Me.FatturaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FatturaDataGrid.Location = New System.Drawing.Point(50, 153)
        Me.FatturaDataGrid.Name = "FatturaDataGrid"
        Me.FatturaDataGrid.RowHeadersWidth = 51
        Me.FatturaDataGrid.RowTemplate.Height = 24
        Me.FatturaDataGrid.Size = New System.Drawing.Size(1306, 244)
        Me.FatturaDataGrid.TabIndex = 0
        '
        'OrdiniDataGrid
        '
        Me.OrdiniDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdiniDataGrid.Location = New System.Drawing.Point(50, 424)
        Me.OrdiniDataGrid.Name = "OrdiniDataGrid"
        Me.OrdiniDataGrid.RowHeadersWidth = 51
        Me.OrdiniDataGrid.RowTemplate.Height = 24
        Me.OrdiniDataGrid.Size = New System.Drawing.Size(1306, 273)
        Me.OrdiniDataGrid.TabIndex = 1
        '
        'ClientiDataGrid
        '
        Me.ClientiDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientiDataGrid.Location = New System.Drawing.Point(50, 726)
        Me.ClientiDataGrid.Name = "ClientiDataGrid"
        Me.ClientiDataGrid.RowHeadersWidth = 51
        Me.ClientiDataGrid.RowTemplate.Height = 24
        Me.ClientiDataGrid.Size = New System.Drawing.Size(1306, 285)
        Me.ClientiDataGrid.TabIndex = 2
        '
        'RjBtnCerca
        '
        Me.RjBtnCerca.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnCerca.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnCerca.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnCerca.BorderRadius = 0
        Me.RjBtnCerca.BorderSize = 0
        Me.RjBtnCerca.FlatAppearance.BorderSize = 0
        Me.RjBtnCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnCerca.ForeColor = System.Drawing.Color.White
        Me.RjBtnCerca.Location = New System.Drawing.Point(784, 82)
        Me.RjBtnCerca.Name = "RjBtnCerca"
        Me.RjBtnCerca.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnCerca.TabIndex = 3
        Me.RjBtnCerca.Text = "Cerca"
        Me.RjBtnCerca.TextColor = System.Drawing.Color.White
        Me.RjBtnCerca.UseVisualStyleBackColor = False
        '
        'RjBtnRicarica
        '
        Me.RjBtnRicarica.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnRicarica.BackgroundColor = System.Drawing.Color.MediumSlateBlue
        Me.RjBtnRicarica.BorderColor = System.Drawing.Color.PaleVioletRed
        Me.RjBtnRicarica.BorderRadius = 0
        Me.RjBtnRicarica.BorderSize = 0
        Me.RjBtnRicarica.FlatAppearance.BorderSize = 0
        Me.RjBtnRicarica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RjBtnRicarica.ForeColor = System.Drawing.Color.White
        Me.RjBtnRicarica.Location = New System.Drawing.Point(61, 82)
        Me.RjBtnRicarica.Name = "RjBtnRicarica"
        Me.RjBtnRicarica.Size = New System.Drawing.Size(150, 40)
        Me.RjBtnRicarica.TabIndex = 4
        Me.RjBtnRicarica.Text = "Ricarica"
        Me.RjBtnRicarica.TextColor = System.Drawing.Color.White
        Me.RjBtnRicarica.UseVisualStyleBackColor = False
        '
        'TxtTutti
        '
        Me.TxtTutti.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTutti.Location = New System.Drawing.Point(361, 94)
        Me.TxtTutti.Name = "TxtTutti"
        Me.TxtTutti.Size = New System.Drawing.Size(142, 34)
        Me.TxtTutti.TabIndex = 5
        '
        'TxtEvidenzia
        '
        Me.TxtEvidenzia.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEvidenzia.Location = New System.Drawing.Point(1197, 88)
        Me.TxtEvidenzia.Name = "TxtEvidenzia"
        Me.TxtEvidenzia.Size = New System.Drawing.Size(159, 34)
        Me.TxtEvidenzia.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Trova"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(957, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Trova ed Evidenzia"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1778, 1055)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEvidenzia)
        Me.Controls.Add(Me.TxtTutti)
        Me.Controls.Add(Me.RjBtnRicarica)
        Me.Controls.Add(Me.RjBtnCerca)
        Me.Controls.Add(Me.ClientiDataGrid)
        Me.Controls.Add(Me.OrdiniDataGrid)
        Me.Controls.Add(Me.FatturaDataGrid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.FatturaDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdiniDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientiDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FatturaDataGrid As DataGridView
    Friend WithEvents OrdiniDataGrid As DataGridView
    Friend WithEvents ClientiDataGrid As DataGridView
    Friend WithEvents RjBtnCerca As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents RjBtnRicarica As RJCodeAdvance.RJControls.RJButton
    Friend WithEvents TxtTutti As TextBox
    Friend WithEvents TxtEvidenzia As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
