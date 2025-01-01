Public Class FormProduk
    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from vproduk"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "vproduk")
        dgvproduk.DataSource = ds.Tables("vproduk")
        kon.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduk.CellContentClick
        Try
            Dim i As Integer
            i = dgvproduk.CurrentRow.Index
            With dgvproduk.Rows.Item(i)
                FormDetailTrans.txtidproduk.Text = .Cells(0).Value
                FormDetailTrans.txtnamaproduk.Text = .Cells(1).Value
                FormDetailTrans.txtharga.Text = .Cells(2).Value
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
        mda.Fill(datas, "vproduk")
        dgvproduk.DataSource = datas.Tables("vproduk")
        kon.Close()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from vproduk where namaproduk like '%" &
       txtcek.Text & "%' or idproduk like '%" & txtcek.Text & "%'")
    End Sub
End Class