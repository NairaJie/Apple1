Public Class FormInputProduk
    Private Sub FormInputProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into produk values('" & txtidproduk.Text & "','" & txtnamaproduk.Text & "','" & txtkategori.Text & "', " &
        " '" & txtstok.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE produk SET namaproduk='" & txtnamaproduk.Text & "', kategori='" & txtkategori.Text & "',stok ='" & txtstok.Text & "' WHERE idproduk= '" &
        txtidproduk.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from produk where idproduk='" & txtidproduk.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub dgvproduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduk.CellContentClick
        txtidproduk.Enabled = False
        Try
            Dim i As Integer
            i = dgvproduk.CurrentRow.Index
            With dgvproduk.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidproduk.Text = .Cells(0).Value
                txtnamaproduk.Text = .Cells(1).Value
                txtkategori.Text = .Cells(2).Value
                txtstok.Text = .Cells(3).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btndetailproduk_Click(sender As Object, e As EventArgs) Handles btndetailproduk.Click
        FormDetailProduk.Show()
    End Sub
End Class