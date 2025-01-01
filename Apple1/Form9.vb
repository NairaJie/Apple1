Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from produk"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "produk")
        dgvproduk.DataSource = ds.Tables("produk")
        kon.Close()
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvproduk.CellContentClick
        Try
            Dim i As Integer
            i = dgvproduk.CurrentRow.Index
            With dgvproduk.Rows.Item(i)
                FormDetailProduk.txtidproduk.Text = .Cells(0).Value
                FormDetailProduk.txtnamaproduk.Text = .Cells(1).Value
                FormDetailProduk.txtkategori.Text = .Cells(2).Value
                FormDetailProduk.txtstok.Text = .Cells(3).Value
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
        mda.Fill(datas, "produk")
        dgvproduk.DataSource = datas.Tables("produk")
        kon.Close()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from produk where namaproduk like '%" &
       txtcek.Text & "%' or idproduk like '%" & txtcek.Text & "%'")
    End Sub
End Class