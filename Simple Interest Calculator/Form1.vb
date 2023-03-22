Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PV As Integer
        Dim i As Integer
        Dim FV As Double

        Dim n As Integer
        PV = TextBox1.Text
        i = TextBox3.Text
        n = TextBox2.Text
        FV = PV * (1 + i / 100) ^ n
        lblOutput.Text = FV

    End Sub
End Class
