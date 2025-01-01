Public Class FormSearchStaff
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

    Private Sub FormSearchStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
    End Sub

    Private Sub dgvstaff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvstaff.CellContentClick
        Try
            Dim i As Integer
            i = dgvstaff.CurrentRow.Index
            With dgvstaff.Rows.Item(i)
                FormTransaksi.txtstaff.Text = .Cells(0).Value
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
        mda.Fill(datas, "staff")
        dgvstaff.DataSource = datas.Tables("staff")
        kon.Close()
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcek.TextChanged
        tampiluser("select * from staff where namastaff like '%" &
       txtcek.Text & "%' or idstaff like '%" & txtcek.Text & "%'")
    End Sub
End Class