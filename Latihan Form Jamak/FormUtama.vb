Public Class FormUtama

    Private Sub tombolTampilkanForm_Click(sender As Object, e As EventArgs) Handles tombolTampilkanForm.Click
        'Menciptakan sebuah instansi dari FormPesan
        Dim frmPesan As New FormPesan

        'Menampilkan form dengan gaya modal
        frmPesan.ShowDialog()
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'Menutup form
        Me.Close()
    End Sub
End Class
