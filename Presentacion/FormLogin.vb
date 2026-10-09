Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormLogin
    Dim conexion As New SqlConnection("Data Source=;Initial Catalog=inicio_sesion;Integrated Security=True;Encrypt=False")

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click
        Try
            conexion.Open()
            Dim comando As New SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Password = @password", conexion)
            comando.Parameters.AddWithValue("@usuario", txtUsuario.Text)
            comando.Parameters.AddWithValue("@password", txtPassword.Text)

            Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())

            If resultado > 0 Then
                MessageBox.Show("Bienvenido :v", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                FormPrincipal.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        txtUsuario.Text = ""
        txtPassword.Text = ""
    End Sub
End Class