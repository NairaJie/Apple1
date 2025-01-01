<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchStaff
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
        Me.dgvstaff = New System.Windows.Forms.DataGridView()
        Me.txtcek = New System.Windows.Forms.TextBox()
        CType(Me.dgvstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(334, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Search Staff"
        '
        'dgvstaff
        '
        Me.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstaff.Location = New System.Drawing.Point(65, 197)
        Me.dgvstaff.Name = "dgvstaff"
        Me.dgvstaff.RowHeadersWidth = 62
        Me.dgvstaff.RowTemplate.Height = 28
        Me.dgvstaff.Size = New System.Drawing.Size(683, 150)
        Me.dgvstaff.TabIndex = 4
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(65, 125)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(683, 26)
        Me.txtcek.TabIndex = 3
        '
        'FormSearchStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvstaff)
        Me.Controls.Add(Me.txtcek)
        Me.Name = "FormSearchStaff"
        Me.Text = "Form Search Staff"
        CType(Me.dgvstaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvstaff As DataGridView
    Friend WithEvents txtcek As TextBox
End Class
