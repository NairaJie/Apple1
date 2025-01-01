Public Class FormDetailProduk


    Private Sub FormDetailProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from vdproduk"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "vdproduk")
        dgvdproduk.DataSource = ds.Tables("vdproduk")
        kon.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE detailproduk SET penyimpanan='" & txtpenyimpanan.Text & "', warna='" & txtwarna.Text & "', chipset ='" & txtchipset.Text & "', harga = '" & txtharga.Text & "' WHERE idproduk= '" &
        txtidproduk.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnproduk_Click(sender As Object, e As EventArgs) Handles btnproduk.Click
        Form9.Show()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into detailproduk values('" & txtidproduk.Text & "','" & txtpenyimpanan.Text & "','" & txtwarna.Text & "', " &
        " '" & txtchipset.Text & "', '" & txtharga.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from detailproduk where idproduk='" & txtidproduk.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub dgvdproduk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdproduk.CellContentClick
        txtidproduk.Enabled = False
        Try
            Dim i As Integer
            i = dgvdproduk.CurrentRow.Index
            With dgvdproduk.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidproduk.Text = .Cells(0).Value
                txtnamaproduk.Text = .Cells(1).Value
                txtkategori.Text = .Cells(2).Value
                txtstok.Text = .Cells(7).Value
                txtpenyimpanan.Text = .Cells(3).Value
                txtwarna.Text = .Cells(4).Value
                txtchipset.Text = .Cells(5).Value
                txtharga.Text = .Cells(6).Value
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class