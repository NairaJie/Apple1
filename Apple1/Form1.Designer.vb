<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btntransaksi = New System.Windows.Forms.Button()
        Me.btnproduk = New System.Windows.Forms.Button()
        Me.btncust = New System.Windows.Forms.Button()
        Me.btnstaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btntransaksi
        '
        Me.btntransaksi.Location = New System.Drawing.Point(295, 54)
        Me.btntransaksi.Margin = New System.Windows.Forms.Padding(4)
        Me.btntransaksi.Name = "btntransaksi"
        Me.btntransaksi.Size = New System.Drawing.Size(416, 115)
        Me.btntransaksi.TabIndex = 0
        Me.btntransaksi.Text = "Input Transaksi"
        Me.btntransaksi.UseVisualStyleBackColor = True
        '
        'btnproduk
        '
        Me.btnproduk.Location = New System.Drawing.Point(295, 230)
        Me.btnproduk.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproduk.Name = "btnproduk"
        Me.btnproduk.Size = New System.Drawing.Size(416, 115)
        Me.btnproduk.TabIndex = 1
        Me.btnproduk.Text = "Input Produk"
        Me.btnproduk.UseVisualStyleBackColor = True
        '
        'btncust
        '
        Me.btncust.Location = New System.Drawing.Point(295, 410)
        Me.btncust.Margin = New System.Windows.Forms.Padding(4)
        Me.btncust.Name = "btncust"
        Me.btncust.Size = New System.Drawing.Size(416, 115)
        Me.btncust.TabIndex = 2
        Me.btncust.Text = "Input Customer"
        Me.btncust.UseVisualStyleBackColor = True
        '
        'btnstaff
        '
        Me.btnstaff.Location = New System.Drawing.Point(295, 581)
        Me.btnstaff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnstaff.Name = "btnstaff"
        Me.btnstaff.Size = New System.Drawing.Size(416, 115)
        Me.btnstaff.TabIndex = 3
        Me.btnstaff.Text = "Input Staff"
        Me.btnstaff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 819)
        Me.Controls.Add(Me.btnstaff)
        Me.Controls.Add(Me.btncust)
        Me.Controls.Add(Me.btnproduk)
        Me.Controls.Add(Me.btntransaksi)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btntransaksi As Button
    Friend WithEvents btnproduk As Button
    Friend WithEvents btncust As Button
    Friend WithEvents btnstaff As Button
End Class
