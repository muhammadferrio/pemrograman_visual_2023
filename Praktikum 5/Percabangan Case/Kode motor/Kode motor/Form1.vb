Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeMotor.Text
            Case "HND" : txtKeterangan.Text = "Honda"

            Case "YMH" : txtKeterangan.Text = "Yamaha"

            Case "SZK" : txtKeterangan.Text = "Suzuki"

            Case Else : txtKeterangan.Text = "Kode Motor tidak ditemukan"
        End Select
    End Sub
End Class
