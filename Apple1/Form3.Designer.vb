<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.txtidtrans = New System.Windows.Forms.TextBox()
        Me.dtptrans = New System.Windows.Forms.DateTimePicker()
        Me.txtcust = New System.Windows.Forms.TextBox()
        Me.txtstaff = New System.Windows.Forms.TextBox()
        Me.btncust = New System.Windows.Forms.Button()
        Me.btnstaff = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btndetailtrans = New System.Windows.Forms.Button()
        Me.dgvtrans = New System.Windows.Forms.DataGridView()
        CType(Me.dgvtrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idtransaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "tgltransaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "idcustomer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "idstaff"
        '
        'txtidtrans
        '
        Me.txtidtrans.Location = New System.Drawing.Point(219, 105)
        Me.txtidtrans.Name = "txtidtrans"
        Me.txtidtrans.Size = New System.Drawing.Size(225, 26)
        Me.txtidtrans.TabIndex = 5
        '
        'dtptrans
        '
        Me.dtptrans.Location = New System.Drawing.Point(219, 161)
        Me.dtptrans.Name = "dtptrans"
        Me.dtptrans.Size = New System.Drawing.Size(200, 26)
        Me.dtptrans.TabIndex = 6
        '
        'txtcust
        '
        Me.txtcust.Location = New System.Drawing.Point(219, 223)
        Me.txtcust.Name = "txtcust"
        Me.txtcust.Size = New System.Drawing.Size(225, 26)
        Me.txtcust.TabIndex = 7
        '
        'txtstaff
        '
        Me.txtstaff.Location = New System.Drawing.Point(219, 279)
        Me.txtstaff.Name = "txtstaff"
        Me.txtstaff.Size = New System.Drawing.Size(225, 26)
        Me.txtstaff.TabIndex = 8
        '
        'btncust
        '
        Me.btncust.Location = New System.Drawing.Point(469, 217)
        Me.btncust.Name = "btncust"
        Me.btncust.Size = New System.Drawing.Size(75, 39)
        Me.btncust.TabIndex = 9
        Me.btncust.Text = "+"
        Me.btncust.UseVisualStyleBackColor = True
        '
        'btnstaff
        '
        Me.btnstaff.Location = New System.Drawing.Point(469, 266)
        Me.btnstaff.Name = "btnstaff"
        Me.btnstaff.Size = New System.Drawing.Size(75, 39)
        Me.btnstaff.TabIndex = 10
        Me.btnstaff.Text = "+"
        Me.btnstaff.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(56, 343)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(125, 61)
        Me.btnsimpan.TabIndex = 11
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(204, 343)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(125, 61)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(658, 343)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(125, 61)
        Me.btnkeluar.TabIndex = 13
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(358, 343)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(125, 61)
        Me.btnhapus.TabIndex = 14
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btndetailtrans
        '
        Me.btndetailtrans.Location = New System.Drawing.Point(508, 343)
        Me.btndetailtrans.Name = "btndetailtrans"
        Me.btndetailtrans.Size = New System.Drawing.Size(125, 61)
        Me.btndetailtrans.TabIndex = 15
        Me.btndetailtrans.Text = "Detail Transaksi"
        Me.btndetailtrans.UseVisualStyleBackColor = True
        '
        'dgvtrans
        '
        Me.dgvtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtrans.Location = New System.Drawing.Point(56, 443)
        Me.dgvtrans.Name = "dgvtrans"
        Me.dgvtrans.RowHeadersWidth = 62
        Me.dgvtrans.RowTemplate.Height = 28
        Me.dgvtrans.Size = New System.Drawing.Size(727, 150)
        Me.dgvtrans.TabIndex = 16
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 666)
        Me.Controls.Add(Me.dgvtrans)
        Me.Controls.Add(Me.btndetailtrans)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnstaff)
        Me.Controls.Add(Me.btncust)
        Me.Controls.Add(Me.txtstaff)
        Me.Controls.Add(Me.txtcust)
        Me.Controls.Add(Me.dtptrans)
        Me.Controls.Add(Me.txtidtrans)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.dgvtrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtidtrans As TextBox
    Friend WithEvents dtptrans As DateTimePicker
    Friend WithEvents txtcust As TextBox
    Friend WithEvents txtstaff As TextBox
    Friend WithEvents btncust As Button
    Friend WithEvents btnstaff As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btndetailtrans As Button
    Friend WithEvents dgvtrans As DataGridView
End Class
