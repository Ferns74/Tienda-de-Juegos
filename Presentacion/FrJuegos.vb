Imports Datos
Imports Dominio
Public Class FrJuegos

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrJuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonComprar_Click(sender As Object, e As EventArgs) Handles ButtonComprar.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Buttonjuegoss_Click(sender As Object, e As EventArgs) Handles Buttonjuegoss.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub
End Class