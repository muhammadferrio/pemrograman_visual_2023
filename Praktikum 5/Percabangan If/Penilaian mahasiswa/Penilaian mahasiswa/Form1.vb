Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (Val(txtNilaiMahasiswa.Text) >= 80) Then
            txtKeterangan.Text = "Cumlaude"

        ElseIf (txtNilaiMahasiswa.Text >= 70) Then
            txtKeterangan.Text = "Sangat Memuaskan"

        ElseIf (txtNilaiMahasiswa.Text >= 60) Then
            txtKeterangan.Text = "Baik"

        ElseIf (txtNilaiMahasiswa.Text >= 50) Then
            txtKeterangan.Text = "Cukup"

        Else
            txtKeterangan.Text = "Maaf anda tidak layak lulus"
        End If
    End Sub
End Class
