Public Class Form1
    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim nama As String = txtnama.Text
        Dim nim As String = txtnim.Text
        Dim nilai As String = txtnilai.Text
        Dim grade As String = txtgrade.Text

        If nama = "" Then
            MessageBox.Show("Anda tidak memasukan Nama.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If nim = "" Then
                MessageBox.Show("Anda tidak memasukan NIM.", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If nilai = "" Then
                    MessageBox.Show("Anda tidak memasukan Nilai", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If nilai >= 80 And (nilai <= 100) Then
                        grade = "A"
                    ElseIf nilai >= 70 And (nilai <= 79) Then
                        grade = "B"
                    ElseIf nilai >= 60 And (nilai <= 69) Then
                        grade = "C"
                    ElseIf nilai >= 50 And (nilai <= 59) Then
                        grade = "D"
                    ElseIf nilai >= 0 And (nilai <= 49) Then
                        grade = "E"
                    Else
                        grade = "Wrong"
                    End If
                End If
            End If
        End If
        txtgrade.Text = grade
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        txtgrade.Clear()
        txtnama.Clear()
        txtnilai.Clear()
        txtnim.Clear()
    End Sub

    Private Sub btnkeluar_Click(sender As Object, e As EventArgs) Handles btnkeluar.Click
        End
    End Sub
End Class
