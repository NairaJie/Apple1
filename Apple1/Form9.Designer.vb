<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvproduk = New System.Windows.Forms.DataGridView()
        Me.txtcek = New System.Windows.Forms.TextBox()
        CType(Me.dgvproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(486, 170)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search Prroduk"
        '
        'dgvproduk
        '
        Me.dgvproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduk.Location = New System.Drawing.Point(128, 330)
        Me.dgvproduk.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvproduk.Name = "dgvproduk"
        Me.dgvproduk.RowHeadersWidth = 62
        Me.dgvproduk.RowTemplate.Height = 28
        Me.dgvproduk.Size = New System.Drawing.Size(911, 188)
        Me.dgvproduk.TabIndex = 10
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(128, 240)
        Me.txtcek.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(909, 31)
        Me.txtcek.TabIndex = 9
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 619)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvproduk)
        Me.Controls.Add(Me.txtcek)
        Me.Name = "Form9"
        Me.Text = "Form9"
        CType(Me.dgvproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvproduk As DataGridView
    Friend WithEvents txtcek As TextBox
End Class
