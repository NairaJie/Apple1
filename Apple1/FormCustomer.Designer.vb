<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomer
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
        Me.dgvcust = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnamacust = New System.Windows.Forms.TextBox()
        Me.txtidcustomer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvcust
        '
        Me.dgvcust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcust.Location = New System.Drawing.Point(174, 639)
        Me.dgvcust.Name = "dgvcust"
        Me.dgvcust.RowHeadersWidth = 82
        Me.dgvcust.RowTemplate.Height = 33
        Me.dgvcust.Size = New System.Drawing.Size(781, 449)
        Me.dgvcust.TabIndex = 36
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(576, 499)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(167, 76)
        Me.btnhapus.TabIndex = 34
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(788, 499)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(167, 76)
        Me.btnkeluar.TabIndex = 33
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(371, 499)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(167, 76)
        Me.btnupdate.TabIndex = 32
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(174, 499)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(167, 76)
        Me.btnsimpan.TabIndex = 31
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtnohp
        '
        Me.txtnohp.Location = New System.Drawing.Point(424, 407)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(355, 31)
        Me.txtnohp.TabIndex = 30
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(424, 330)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(355, 31)
        Me.txtemail.TabIndex = 29
        '
        'txtnamacust
        '
        Me.txtnamacust.Location = New System.Drawing.Point(424, 256)
        Me.txtnamacust.Name = "txtnamacust"
        Me.txtnamacust.Size = New System.Drawing.Size(355, 31)
        Me.txtnamacust.TabIndex = 28
        '
        'txtidcustomer
        '
        Me.txtidcustomer.Location = New System.Drawing.Point(424, 185)
        Me.txtidcustomer.Name = "txtidcustomer"
        Me.txtidcustomer.Size = New System.Drawing.Size(355, 31)
        Me.txtidcustomer.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(178, 410)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "nohp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "namacustomer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "idcustomer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(417, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 42)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Input Customer"
        '
        'FormCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1128, 1142)
        Me.Controls.Add(Me.dgvcust)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnamacust)
        Me.Controls.Add(Me.txtidcustomer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCustomer"
        Me.Text = "FormCustomer"
        CType(Me.dgvcust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvcust As DataGridView
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnamacust As TextBox
    Friend WithEvents txtidcustomer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
