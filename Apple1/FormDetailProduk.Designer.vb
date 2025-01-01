<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailProduk
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
        Me.dgvdproduk = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.txtkategori = New System.Windows.Forms.TextBox()
        Me.txtnamaproduk = New System.Windows.Forms.TextBox()
        Me.txtidproduk = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnproduk = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpenyimpanan = New System.Windows.Forms.TextBox()
        Me.txtwarna = New System.Windows.Forms.TextBox()
        Me.txtchipset = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        CType(Me.dgvdproduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdproduk
        '
        Me.dgvdproduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdproduk.Location = New System.Drawing.Point(159, 629)
        Me.dgvdproduk.Name = "dgvdproduk"
        Me.dgvdproduk.RowHeadersWidth = 82
        Me.dgvdproduk.RowTemplate.Height = 33
        Me.dgvdproduk.Size = New System.Drawing.Size(1362, 449)
        Me.dgvdproduk.TabIndex = 36
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(849, 505)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(319, 76)
        Me.btnhapus.TabIndex = 34
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(1197, 505)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(313, 76)
        Me.btnkeluar.TabIndex = 33
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(490, 505)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(326, 76)
        Me.btnupdate.TabIndex = 32
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(159, 505)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(304, 76)
        Me.btnsimpan.TabIndex = 31
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(400, 393)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(355, 31)
        Me.txtstok.TabIndex = 30
        '
        'txtkategori
        '
        Me.txtkategori.Location = New System.Drawing.Point(400, 312)
        Me.txtkategori.Name = "txtkategori"
        Me.txtkategori.Size = New System.Drawing.Size(355, 31)
        Me.txtkategori.TabIndex = 29
        '
        'txtnamaproduk
        '
        Me.txtnamaproduk.Location = New System.Drawing.Point(400, 238)
        Me.txtnamaproduk.Name = "txtnamaproduk"
        Me.txtnamaproduk.Size = New System.Drawing.Size(355, 31)
        Me.txtnamaproduk.TabIndex = 28
        '
        'txtidproduk
        '
        Me.txtidproduk.Location = New System.Drawing.Point(400, 167)
        Me.txtidproduk.Name = "txtidproduk"
        Me.txtidproduk.Size = New System.Drawing.Size(355, 31)
        Me.txtidproduk.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "stok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "namaproduk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "idproduk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(648, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 42)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Input Detail Produk"
        '
        'btnproduk
        '
        Me.btnproduk.Location = New System.Drawing.Point(775, 163)
        Me.btnproduk.Name = "btnproduk"
        Me.btnproduk.Size = New System.Drawing.Size(75, 38)
        Me.btnproduk.TabIndex = 37
        Me.btnproduk.Text = "+"
        Me.btnproduk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(909, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "penyimpanan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(909, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "warna"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(909, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "chipset"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(915, 411)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "harga"
        '
        'txtpenyimpanan
        '
        Me.txtpenyimpanan.Location = New System.Drawing.Point(1155, 161)
        Me.txtpenyimpanan.Name = "txtpenyimpanan"
        Me.txtpenyimpanan.Size = New System.Drawing.Size(355, 31)
        Me.txtpenyimpanan.TabIndex = 42
        '
        'txtwarna
        '
        Me.txtwarna.Location = New System.Drawing.Point(1155, 245)
        Me.txtwarna.Name = "txtwarna"
        Me.txtwarna.Size = New System.Drawing.Size(355, 31)
        Me.txtwarna.TabIndex = 43
        '
        'txtchipset
        '
        Me.txtchipset.Location = New System.Drawing.Point(1155, 325)
        Me.txtchipset.Name = "txtchipset"
        Me.txtchipset.Size = New System.Drawing.Size(355, 31)
        Me.txtchipset.TabIndex = 44
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(1155, 408)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(355, 31)
        Me.txtharga.TabIndex = 45
        '
        'FormDetailProduk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1629, 1309)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtchipset)
        Me.Controls.Add(Me.txtwarna)
        Me.Controls.Add(Me.txtpenyimpanan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnproduk)
        Me.Controls.Add(Me.dgvdproduk)
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
        Me.Name = "FormDetailProduk"
        Me.Text = "FormDetailProduk"
        CType(Me.dgvdproduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvdproduk As DataGridView
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtstok As TextBox
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents txtnamaproduk As TextBox
    Friend WithEvents txtidproduk As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnproduk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpenyimpanan As TextBox
    Friend WithEvents txtwarna As TextBox
    Friend WithEvents txtchipset As TextBox
    Friend WithEvents txtharga As TextBox
End Class
