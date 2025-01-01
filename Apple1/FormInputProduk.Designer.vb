<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputProduk
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidproduk = New System.Windows.Forms.TextBox()
        Me.txtnamaproduk = New System.Windows.Forms.TextBox()
        Me.txtkategori = New System.Windows.Forms.TextBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.btndetailproduk = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.dgvproduk = New System.Windows.Forms.DataGridView()
        CType(Me.dgvproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Produk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idproduk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "namaproduk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 339)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "kategori"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "stok"
        '
        'txtidproduk
        '
        Me.txtidproduk.Location = New System.Drawing.Point(337, 188)
        Me.txtidproduk.Name = "txtidproduk"
        Me.txtidproduk.Size = New System.Drawing.Size(355, 31)
        Me.txtidproduk.TabIndex = 5
        '
        'txtnamaproduk
        '
        Me.txtnamaproduk.Location = New System.Drawing.Point(337, 259)
        Me.txtnamaproduk.Name = "txtnamaproduk"
        Me.txtnamaproduk.Size = New System.Drawing.Size(355, 31)
        Me.txtnamaproduk.TabIndex = 6
        '
        'txtkategori
        '
        Me.txtkategori.Location = New System.Drawing.Point(337, 333)
        Me.txtkategori.Name = "txtkategori"
        Me.txtkategori.Size = New System.Drawing.Size(355, 31)
        Me.txtkategori.TabIndex = 7
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(337, 410)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(355, 31)
        Me.txtstok.TabIndex = 8
        '
        'btndetailproduk
        '
        Me.btndetailproduk.Location = New System.Drawing.Point(689, 502)
        Me.btndetailproduk.Margin = New System.Windows.Forms.Padding(4)
        Me.btndetailproduk.Name = "btndetailproduk"
        Me.btndetailproduk.Size = New System.Drawing.Size(167, 76)
        Me.btndetailproduk.TabIndex = 20
        Me.btndetailproduk.Text = "Detail Produk"
        Me.btndetailproduk.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(489, 502)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(167, 76)
        Me.btnhapus.TabIndex = 19
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(889, 502)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(167, 76)
        Me.btnkeluar.TabIndex = 18
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(284, 502)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(167, 76)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(87, 502)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(167, 76)
        Me.btnsimpan.TabIndex = 16
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'dgvproduk
        '
        Me.dgvproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduk.Location = New System.Drawing.Point(87, 642)
        Me.dgvproduk.Name = "dgvproduk"
        Me.dgvproduk.RowHeadersWidth = 82
        Me.dgvproduk.RowTemplate.Height = 33
        Me.dgvproduk.Size = New System.Drawing.Size(969, 449)
        Me.dgvproduk.TabIndex = 21
        '
        'FormInputProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 1142)
        Me.Controls.Add(Me.dgvproduk)
        Me.Controls.Add(Me.btndetailproduk)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.txtkategori)
        Me.Controls.Add(Me.txtnamaproduk)
        Me.Controls.Add(Me.txtidproduk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInputProduk"
        Me.Text = "FormInputProduk"
        CType(Me.dgvproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidproduk As TextBox
    Friend WithEvents txtnamaproduk As TextBox
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents txtstok As TextBox
    Friend WithEvents btndetailproduk As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents dgvproduk As DataGridView
End Class
