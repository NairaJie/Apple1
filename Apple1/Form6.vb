Imports System.Net.Mime.MediaTypeNames
Imports MySql.Data.MySqlClient

Public Class FormDetailTrans
    Dim totbay As Double

    Private Sub FormDetailTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from mauw"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "mauw")
        dgvdetail.DataSource = ds.Tables("mauw")
        kon.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If kon.State = ConnectionState.Open Then kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into detailtransaksi values('" & txtidtransaksi.Text & "','" & txtidproduk.Text & "','" & txtjumlah.Text & "', " &
        " '" & txttotal.Text & "', '" & txtstatus.Text & "', '" & cmbmetode.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub dgvtrans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdetail.CellContentClick
        txtidtransaksi.Enabled = False
        Try
            Dim i As Integer
            i = dgvdetail.CurrentRow.Index
            With dgvdetail.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidtransaksi.Text = .Cells(0).Value
                txttgl.Text = .Cells(1).Value
                txtidcust.Text = .Cells(2).Value
                txtnamacust.Text = .Cells(3).Value
                txtstaff.Text = .Cells(4).Value
                txtnamastaff.Text = .Cells(5).Value
                txtidproduk.Text = .Cells(6).Value
                txtnamaproduk.Text = .Cells(7).Value
                txtharga.Text = .Cells(9).Value
                txtjumlah.Text = .Cells(10).Value
                txttotal.Text = .Cells(11).Value
                txtstatus.Text = .Cells(12).Value
                cmbmetode.Text = .Cells(13).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If kon.State = ConnectionState.Open Then kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE detailtransaksi SET idproduk='" &
        txtidproduk.Text & "', jumlah='" & txtjumlah.Text & "', totalbayar ='" & txttotal.Text & "', statuspembayaran ='" & txtstatus.Text & "', metodepembayaran='" & cmbmetode.Text & "'  WHERE idtransaksi= '" &
        txtidtransaksi.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If kon.State = ConnectionState.Open Then kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from detailtransaksi where idtransaksi='" & txtidtransaksi.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub btntrans_Click(sender As Object, e As EventArgs) Handles btntrans.Click
        FormTrans.Show()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btnproduk_Click(sender As Object, e As EventArgs) Handles btnproduk.Click
        FormProduk.Show()
    End Sub

    Private Sub txtjumlah_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged
        If kon.State = ConnectionState.Open Then kon.Close()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from produk"
        cek = perintah.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            Dim stok As Integer = cek.Item("stok")
            If Val(txtjumlah.Text) > stok Then
                MsgBox("Pesanan Anda melebihi stok yang tersedia", MsgBoxStyle.Information, "Pesan")
            End If
        End If

        kon.Close()
        totbay = Val(txtharga.Text) * Val(txtjumlah.Text)
        txttotal.Text = totbay
    End Sub

End Class
