Public Class Form1
    Private Sub btntransaksi_Click(sender As Object, e As EventArgs) Handles btntransaksi.Click
        FormTransaksi.Show()
    End Sub

    Private Sub btnproduk_Click(sender As Object, e As EventArgs) Handles btnproduk.Click
        FormInputProduk.Show()
    End Sub

    Private Sub btnstaff_Click(sender As Object, e As EventArgs) Handles btnstaff.Click
        FormStaffvb.Show()
    End Sub

    Private Sub btncust_Click(sender As Object, e As EventArgs) Handles btncust.Click
        FormCustomer.Show()
    End Sub
End Class
