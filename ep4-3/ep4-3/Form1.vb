Public Class Form1
    Dim Numl, Num2, Resutf As Double
    Dim Resulf1 As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Numl = TextBox1.Text
        Num2 = TextBox2.Text
        Resutf = Numl * Num2
        Resulf1 = Resutf / 50
        Label5.Text = Resutf
        Label6.Text = Resulf1
    End Sub
End Class
