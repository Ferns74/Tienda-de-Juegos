Imports Datos

Public Class FrmAccesorios
    Private Sub FrmAccesorios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonComprar_Click(sender As Object, e As EventArgs) Handles ButtonComprar.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
End Class