Public Class FormTrans
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from vtrans"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "vtrans")
        dgvtrans.DataSource = ds.Tables("vtrans")
        kon.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvtrans.CellContentClick
        Try
            Dim i As Integer
            i = dgvtrans.CurrentRow.Index
            With dgvtrans.Rows.Item(i)
                FormDetailTrans.txtidtransaksi.Text = .Cells(0).Value
                FormDetailTrans.txttgl.Text = .Cells(1).Value
                FormDetailTrans.txtidcust.Text = .Cells(2).Value
                FormDetailTrans.txtnamacust.Text = .Cells(3).Value
                FormDetailTrans.txtstaff.Text = .Cells(4).Value
                FormDetailTrans.txtnamastaff.Text = .Cells(5).Value
                Me.Close()
            End With
        Catch ex As Exception
        End Try
    End Sub

    Sub tampiluser(ByVal sql As String)
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = sql
        mda.SelectCommand = perintah
        Dim datas As New DataSet
        mda.Fill(datas, "vtrans")
        dgvtrans.DataSource = datas.Tables("vtrans")
        kon.Close()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from vtrans where namacustomer like '%" &
       txtcek.Text & "%' or idtransaksi like '%" & txtcek.Text & "%'")
    End Sub
End Class