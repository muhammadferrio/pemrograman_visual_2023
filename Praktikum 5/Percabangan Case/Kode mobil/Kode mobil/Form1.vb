Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Select Case txtKodeMobil.Text
            Case "INV" : txtKeterangan.Text = "Inova"

            Case "XNA" : txtKeterangan.Text = "Xenia"

            Case "PJR" : txtKeterangan.Text = "Pajero"

            Case Else : txtKeterangan.Text = "Kode Mobil tidak ditemukan"
        End Select
    End Sub
End Class
