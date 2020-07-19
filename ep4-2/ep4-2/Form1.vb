Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัสผ่านของคุณ")
        If Username = "เมย์" And Password = "1111" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chantarat Saikajang\All_Images\kid01.jpg")
        ElseIf Username = "แมว" And Password = "2222" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chantarat Saikajang\All_Images\photo01.jpg")
        ElseIf Username = "กุ้ง" And Password = "3333" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\chantarat Saikajang\All_Images\user_nooknet.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
