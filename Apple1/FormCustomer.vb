Public Class FormCustomer
    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Sub tampildata()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from customer"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "customer")
        dgvcust.DataSource = ds.Tables("customer")
        kon.Close()
    End Sub

    Private Sub dgvcust_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcust.CellContentClick
        txtidcustomer.Enabled = False
        Try
            Dim i As Integer
            i = dgvcust.CurrentRow.Index
            With dgvcust.Rows.Item(i)
                btnsimpan.Enabled = False
                btnupdate.Enabled = True
                txtidcustomer.Text = .Cells(0).Value
                txtnamacust.Text = .Cells(1).Value
                txtemail.Text = .Cells(2).Value
                txtnohp.Text = .Cells(3).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into customer values('" & txtidcustomer.Text & "','" & txtnamacust.Text & "','" & txtemail.Text & "', " &
        " '" & txtnohp.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "UPDATE customer SET namacustomer='" &
        txtnamacust.Text & "', email='" & txtemail.Text & "', nohpcustomer ='" & txtnohp.Text & "' WHERE idcustomer = '" & txtidcustomer.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampildata()
        MsgBox("Data Berhasil Disimpan...", MsgBoxStyle.Information, "Konfirmasi")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from customer where idcustomer='" & txtidcustomer.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("Data Terpilih Sudah Terhapus", MsgBoxStyle.Information, "Pesan")
        tampildata()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class