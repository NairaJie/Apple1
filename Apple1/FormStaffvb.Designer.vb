<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaffvb
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
        Me.dgvstaff = New System.Windows.Forms.DataGridView()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.txtjenkel = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnamastaff = New System.Windows.Forms.TextBox()
        Me.txtidstaff = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttelp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvstaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvstaff
        '
        Me.dgvstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstaff.Location = New System.Drawing.Point(167, 702)
        Me.dgvstaff.Name = "dgvstaff"
        Me.dgvstaff.RowHeadersWidth = 82
        Me.dgvstaff.RowTemplate.Height = 33
        Me.dgvstaff.Size = New System.Drawing.Size(781, 449)
        Me.dgvstaff.TabIndex = 50
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(569, 562)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(167, 76)
        Me.btnhapus.TabIndex = 49
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(781, 562)
        Me.btnkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(167, 76)
        Me.btnkeluar.TabIndex = 48
        Me.btnkeluar.Text = "keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(364, 562)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(167, 76)
        Me.btnupdate.TabIndex = 47
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(167, 562)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(167, 76)
        Me.btnsimpan.TabIndex = 46
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'txtjenkel
        '
        Me.txtjenkel.Location = New System.Drawing.Point(419, 384)
        Me.txtjenkel.Name = "txtjenkel"
        Me.txtjenkel.Size = New System.Drawing.Size(355, 31)
        Me.txtjenkel.TabIndex = 45
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(419, 307)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(355, 31)
        Me.txtalamat.TabIndex = 44
        '
        'txtnamastaff
        '
        Me.txtnamastaff.Location = New System.Drawing.Point(419, 233)
        Me.txtnamastaff.Name = "txtnamastaff"
        Me.txtnamastaff.Size = New System.Drawing.Size(355, 31)
        Me.txtnamastaff.TabIndex = 43
        '
        'txtidstaff
        '
        Me.txtidstaff.AcceptsTab = True
        Me.txtidstaff.Location = New System.Drawing.Point(419, 162)
        Me.txtidstaff.Name = "txtidstaff"
        Me.txtidstaff.Size = New System.Drawing.Size(355, 31)
        Me.txtidstaff.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(173, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 25)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "jenkel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "namastaff"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "idstaff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(448, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 42)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Input Staff"
        '
        'txttelp
        '
        Me.txttelp.Location = New System.Drawing.Point(419, 463)
        Me.txttelp.Name = "txttelp"
        Me.txttelp.Size = New System.Drawing.Size(355, 31)
        Me.txttelp.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 469)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Telp"
        '
        'FormStaffvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 1096)
        Me.Controls.Add(Me.txttelp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvstaff)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtjenkel)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.txtnamastaff)
        Me.Controls.Add(Me.txtidstaff)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormStaffvb"
        Me.Text = "FormStaffvb"
        CType(Me.dgvstaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvstaff As DataGridView
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtjenkel As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtnamastaff As TextBox
    Friend WithEvents txtidstaff As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelp As TextBox
    Friend WithEvents Label6 As Label
End Class
