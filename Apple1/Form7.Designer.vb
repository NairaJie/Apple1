﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTrans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvtrans = New System.Windows.Forms.DataGridView()
        Me.txtcek = New System.Windows.Forms.TextBox()
        CType(Me.dgvtrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search Transaksi"
        '
        'dgvtrans
        '
        Me.dgvtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtrans.Location = New System.Drawing.Point(59, 211)
        Me.dgvtrans.Name = "dgvtrans"
        Me.dgvtrans.RowHeadersWidth = 62
        Me.dgvtrans.RowTemplate.Height = 28
        Me.dgvtrans.Size = New System.Drawing.Size(683, 150)
        Me.dgvtrans.TabIndex = 7
        '
        'txtcek
        '
        Me.txtcek.Location = New System.Drawing.Point(59, 139)
        Me.txtcek.Name = "txtcek"
        Me.txtcek.Size = New System.Drawing.Size(683, 26)
        Me.txtcek.TabIndex = 6
        '
        'FormTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvtrans)
        Me.Controls.Add(Me.txtcek)
        Me.Name = "FormTrans"
        Me.Text = "Form7"
        CType(Me.dgvtrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvtrans As DataGridView
    Friend WithEvents txtcek As TextBox
End Class
