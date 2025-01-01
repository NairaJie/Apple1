Public Class FormStaffvb
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into staff values('" & txtidstaff.Text & "','" & txtnamastaff.Text & "','" & txtalamat.Text & "', " &
        " '" & txtjenkel.Text & "', '" & txttelp.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE staff SET namastaff='" &
        txtnamastaff.Text & "', alamat='" & txtalamat.Text & "',jenkel ='" & txtjenkel.Text & "', telepon = '" & txttelp.Text & "' WHERE idstaff = '" &
        txtidstaff.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from staff where idstaff='" & txtidstaff.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub

    Private Sub dgvstaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstaff.CellContentClick
        txtidstaff.Enabled = False
        Try
            Dim i As Integer
            i = dgvstaff.CurrentRow.Index
            With dgvstaff.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidstaff.Text = .Cells(0).Value
                txtnamastaff.Text = .Cells(1).Value
                txtalamat.Text = .Cells(2).Value
                txtjenkel.Text = .Cells(3).Value
                txttelp.Text = .Cells(4).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormStaffvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub
    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from staff"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "staff")
        dgvstaff.DataSource = ds.Tables("staff")
        kon.Close()
    End Sub
End Class