Imports System.Runtime.Remoting.Lifetime

Public Class FormTransaksi
    Private Sub btncust_Click(sender As Object, e As EventArgs) Handles btncust.Click
        FormSearchCust.Show()
    End Sub

    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        FormSearchStaff.Show()
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from transaksi"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "transaksi")
        dgvtrans.DataSource = ds.Tables("transaksi")
        kon.Close()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from transaksi"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "transaksi")
        dgvtrans.DataSource = ds.Tables("transaksi")
        kon.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into transaksi values('" & txtidtrans.Text & "','" & Format(dtptrans.Value, "yyyy-MM-dd") & "','" & txtcust.Text & "', " &
        " '" & txtstaff.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub dgvtrans_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtrans.CellContentClick
        txtidtrans.Enabled = False
        Try
            Dim i As Integer
            i = dgvtrans.CurrentRow.Index
            With dgvtrans.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidtrans.Text = .Cells(0).Value
                dtptrans.Text = .Cells(1).Value
                txtcust.Text = .Cells(2).Value
                txtstaff.Text = .Cells(3).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE transaksi SET tgltransaksi='" &
        Format(dtptrans.Value, "yyyy-MM-dd") & "', idcustomer='" & txtcust.Text & "',idstaff ='" & txtstaff.Text & "' WHERE idtransaksi= '" &
        txtidtrans.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from transaksi where idtransaksi='" & txtidtrans.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub btndetailtrans_Click(sender As Object, e As EventArgs) Handles btndetailtrans.Click
        FormDetailTrans.Show()
    End Sub
End Class