<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSearchCust
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
        Me.txtcek = New System.Windows.Forms.TextBox()
        Me.dgvcust = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(61, 105)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(683, 26)
        Me.txtcek.TabIndex = 0
        '
        'dgvcust
        '
        Me.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcust.Location = New System.Drawing.Point(61, 177)
        Me.dgvcust.Name = "dgvcust"
        Me.dgvcust.RowHeadersWidth = 62
        Me.dgvcust.RowTemplate.Height = 28
        Me.dgvcust.Size = New System.Drawing.Size(683, 150)
        Me.dgvcust.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Customer"
        '
        'FormSearchCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvcust)
        Me.Controls.Add(Me.txtcek)
        Me.Name = "FormSearchCust"
        Me.Text = "Form Search Cust"
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcek As TextBox
    Friend WithEvents dgvcust As DataGridView
    Friend WithEvents Label1 As Label
End Class
