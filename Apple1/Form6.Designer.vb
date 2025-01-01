<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailTrans
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
        Me.trans = New System.Windows.Forms.Label()
        Me.txttgl = New System.Windows.Forms.Label()
        Me.idproduk = New System.Windows.Forms.Label()
        Me.namaproduk = New System.Windows.Forms.Label()
        Me.txtidtransaksi = New System.Windows.Forms.TextBox()
        Me.txtidproduk = New System.Windows.Forms.TextBox()
        Me.txtnamaproduk = New System.Windows.Forms.TextBox()
        Me.dtpdetailtrans = New System.Windows.Forms.DateTimePicker()
        Me.labelcust = New System.Windows.Forms.Label()
        Me.namacust = New System.Windows.Forms.Label()
        Me.txtidcust = New System.Windows.Forms.TextBox()
        Me.txtnamacust = New System.Windows.Forms.TextBox()
        Me.txtstaff = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnamastaff = New System.Windows.Forms.TextBox()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtmetode = New System.Windows.Forms.TextBox()
        Me.btntrans = New System.Windows.Forms.Button()
        Me.btnproduk = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.dgvdetail = New System.Windows.Forms.DataGridView()
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detail Transaksi"
        '
        'trans
        '
        Me.trans.AutoSize = True
        Me.trans.Location = New System.Drawing.Point(58, 131)
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(85, 20)
        Me.trans.TabIndex = 1
        Me.trans.Text = "idtransaksi"
        '
        'txttgl
        '
        Me.txttgl.AutoSize = True
        Me.txttgl.Location = New System.Drawing.Point(58, 186)
        Me.txttgl.Name = "txttgl"
        Me.txttgl.Size = New System.Drawing.Size(90, 20)
        Me.txttgl.TabIndex = 2
        Me.txttgl.Text = "tgltransaksi"
        '
        'idproduk
        '
        Me.idproduk.AutoSize = True
        Me.idproduk.Location = New System.Drawing.Point(707, 131)
        Me.idproduk.Name = "idproduk"
        Me.idproduk.Size = New System.Drawing.Size(70, 20)
        Me.idproduk.TabIndex = 3
        Me.idproduk.Text = "idproduk"
        '
        'namaproduk
        '
        Me.namaproduk.AutoSize = True
        Me.namaproduk.Location = New System.Drawing.Point(707, 189)
        Me.namaproduk.Name = "namaproduk"
        Me.namaproduk.Size = New System.Drawing.Size(105, 20)
        Me.namaproduk.TabIndex = 4
        Me.namaproduk.Text = "Nama Produk"
        '
        'txtidtransaksi
        '
        Me.txtidtransaksi.Location = New System.Drawing.Point(246, 131)
        Me.txtidtransaksi.Name = "txtidtransaksi"
        Me.txtidtransaksi.Size = New System.Drawing.Size(317, 26)
        Me.txtidtransaksi.TabIndex = 5
        '
        'txtidproduk
        '
        Me.txtidproduk.Location = New System.Drawing.Point(893, 131)
        Me.txtidproduk.Name = "txtidproduk"
        Me.txtidproduk.Size = New System.Drawing.Size(317, 26)
        Me.txtidproduk.TabIndex = 6
        '
        'txtnamaproduk
        '
        Me.txtnamaproduk.Location = New System.Drawing.Point(893, 192)
        Me.txtnamaproduk.Name = "txtnamaproduk"
        Me.txtnamaproduk.Size = New System.Drawing.Size(317, 26)
        Me.txtnamaproduk.TabIndex = 7
        '
        'dtpdetailtrans
        '
        Me.dtpdetailtrans.Location = New System.Drawing.Point(246, 186)
        Me.dtpdetailtrans.Name = "dtpdetailtrans"
        Me.dtpdetailtrans.Size = New System.Drawing.Size(285, 26)
        Me.dtpdetailtrans.TabIndex = 8
        '
        'labelcust
        '
        Me.labelcust.AutoSize = True
        Me.labelcust.Location = New System.Drawing.Point(58, 250)
        Me.labelcust.Name = "labelcust"
        Me.labelcust.Size = New System.Drawing.Size(87, 20)
        Me.labelcust.TabIndex = 9
        Me.labelcust.Text = "idcustomer"
        '
        'namacust
        '
        Me.namacust.AutoSize = True
        Me.namacust.Location = New System.Drawing.Point(58, 311)
        Me.namacust.Name = "namacust"
        Me.namacust.Size = New System.Drawing.Size(115, 20)
        Me.namacust.TabIndex = 10
        Me.namacust.Text = "namacustomer"
        '
        'txtidcust
        '
        Me.txtidcust.Location = New System.Drawing.Point(246, 250)
        Me.txtidcust.Name = "txtidcust"
        Me.txtidcust.Size = New System.Drawing.Size(317, 26)
        Me.txtidcust.TabIndex = 11
        '
        'txtnamacust
        '
        Me.txtnamacust.Location = New System.Drawing.Point(246, 311)
        Me.txtnamacust.Name = "txtnamacust"
        Me.txtnamacust.Size = New System.Drawing.Size(317, 26)
        Me.txtnamacust.TabIndex = 12
        '
        'txtstaff
        '
        Me.txtstaff.Location = New System.Drawing.Point(246, 379)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.Size = New System.Drawing.Size(317, 26)
        Me.txtstaff.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 379)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Idstaff"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 443)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "namastaff"
        '
        'txtnamastaff
        '
        Me.txtnamastaff.Location = New System.Drawing.Point(246, 443)
        Me.txtnamastaff.Name = "txtnamastaff"
        Me.txtnamastaff.Size = New System.Drawing.Size(317, 26)
        Me.txtnamastaff.TabIndex = 16
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(893, 250)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(317, 26)
        Me.txtharga.TabIndex = 17
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(893, 311)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(317, 26)
        Me.txtjumlah.TabIndex = 18
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(893, 379)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(317, 26)
        Me.txttotal.TabIndex = 19
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(893, 443)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(317, 26)
        Me.txtstatus.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(707, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(707, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "total bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(707, 443)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Status Pembayaran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(707, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Metode Pembayaran"
        '
        'txtmetode
        '
        Me.txtmetode.Location = New System.Drawing.Point(893, 503)
        Me.txtmetode.Name = "txtmetode"
        Me.txtmetode.Size = New System.Drawing.Size(317, 26)
        Me.txtmetode.TabIndex = 26
        '
        'btntrans
        '
        Me.btntrans.Location = New System.Drawing.Point(589, 126)
        Me.btntrans.Name = "btntrans"
        Me.btntrans.Size = New System.Drawing.Size(55, 37)
        Me.btntrans.TabIndex = 27
        Me.btntrans.Text = "+"
        Me.btntrans.UseVisualStyleBackColor = True
        '
        'btnproduk
        '
        Me.btnproduk.Location = New System.Drawing.Point(1247, 126)
        Me.btnproduk.Name = "btnproduk"
        Me.btnproduk.Size = New System.Drawing.Size(55, 37)
        Me.btnproduk.TabIndex = 28
        Me.btnproduk.Text = "+"
        Me.btnproduk.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(62, 595)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(250, 59)
        Me.btnsimpan.TabIndex = 29
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(380, 595)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(254, 59)
        Me.btnupdate.TabIndex = 30
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(667, 595)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(271, 59)
        Me.btnhapus.TabIndex = 31
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(1002, 595)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(300, 59)
        Me.btnkeluar.TabIndex = 32
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'dgvdetail
        '
        Me.dgvdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetail.Location = New System.Drawing.Point(62, 696)
        Me.dgvdetail.Name = "dgvdetail"
        Me.dgvdetail.RowHeadersWidth = 62
        Me.dgvdetail.RowTemplate.Height = 28
        Me.dgvdetail.Size = New System.Drawing.Size(1240, 309)
        Me.dgvdetail.TabIndex = 33
        '
        'FormDetailTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 1031)
        Me.Controls.Add(Me.dgvdetail)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnproduk)
        Me.Controls.Add(Me.btntrans)
        Me.Controls.Add(Me.txtmetode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.txtnamastaff)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtstaff)
        Me.Controls.Add(Me.txtnamacust)
        Me.Controls.Add(Me.txtidcust)
        Me.Controls.Add(Me.namacust)
        Me.Controls.Add(Me.labelcust)
        Me.Controls.Add(Me.dtpdetailtrans)
        Me.Controls.Add(Me.txtnamaproduk)
        Me.Controls.Add(Me.txtidproduk)
        Me.Controls.Add(Me.txtidtransaksi)
        Me.Controls.Add(Me.namaproduk)
        Me.Controls.Add(Me.idproduk)
        Me.Controls.Add(Me.txttgl)
        Me.Controls.Add(Me.trans)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDetailTrans"
        Me.Text = "Form Detail Transaksi"
        CType(Me.dgvdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents trans As Label
    Friend WithEvents txttgl As Label
    Friend WithEvents idproduk As Label
    Friend WithEvents namaproduk As Label
    Friend WithEvents txtidtransaksi As TextBox
    Friend WithEvents txtidproduk As TextBox
    Friend WithEvents txtnamaproduk As TextBox
    Friend WithEvents dtpdetailtrans As DateTimePicker
    Friend WithEvents labelcust As Label
    Friend WithEvents namacust As Label
    Friend WithEvents txtidcust As TextBox
    Friend WithEvents txtnamacust As TextBox
    Friend WithEvents txtstaff As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnamastaff As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtmetode As TextBox
    Friend WithEvents btntrans As Button
    Friend WithEvents btnproduk As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents dgvdetail As DataGridView
End Class
