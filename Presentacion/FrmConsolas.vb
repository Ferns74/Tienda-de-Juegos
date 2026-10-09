Imports Datos
Public Class FrmConsolas
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonComprar_Click(sender As Object, e As EventArgs) Handles ButtonComprar.Click
        Dim recibo As New FrmRecibo
        recibo.ShowDialog()
    End Sub

    Private Sub FrmConsolas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim recibo As New FrmRecibo
        recibo.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim recibo As New FrmRecibo
        recibo.ShowDialog()
    End Sub
End Class