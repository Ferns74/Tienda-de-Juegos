Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
'CBArticulos.Items.Add("PlayStation 5 Pro")'
'CBArticulos.Items.Add("Xbox Series X")'
Public Class FrmRecibo
    Public Conexion As New SqlConnection("Data Source=;Initial Catalog=Productos;Integrated Security=True;Encrypt=False")
    Public Sub AbrirConexion()
        If Conexion.State = ConnectionState.Closed Then
            Conexion.Open()
        End If
    End Sub

    Public Sub CerrarConexion()
        If Conexion.State = ConnectionState.Open Then
            Conexion.Close()
        End If
    End Sub
    Private Sub FrmRecibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            AbrirConexion()

            Dim query As String = "SELECT Nombre FROM Consolas"
            Dim cmd As New SqlCommand(query, Conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                CBArticulos.Items.Add(reader("Nombre").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            CerrarConexion()
        End Try

        CargarDatosEnDataGrid()
    End Sub

    Private Sub CBArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBArticulos.SelectedIndexChanged
        Try
            ' Abre la conexión
            AbrirConexion()

            Dim query As String = "SELECT Fabricante,Precio, Lanzamiento FROM Consolas WHERE Nombre = @Nombre"
            Dim cmd As New SqlCommand(query, Conexion)
            cmd.Parameters.AddWithValue("@Nombre", CBArticulos.SelectedItem.ToString())
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtFabricante.Text = reader("Fabricante").ToString()
                txtPrecio.Text = reader("Precio").ToString()
                txtLanzamiento.Text = Convert.ToDateTime(reader("Lanzamiento")).ToString("dd/MM/yyyy")
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub CargarDatosEnDataGrid()
        Try
            AbrirConexion()
            Dim query As String = "SELECT ID, Nombre, Fabricante, Precio, Lanzamiento FROM Consolas"

            Dim adapter As New SqlDataAdapter(query, Conexion)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            DataGridView1.DataSource = dataTable

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        Finally
            ' Cierra la conexión
            CerrarConexion()
        End Try
    End Sub


    Private Sub ValorTotal()
        Dim precio As Decimal
        Decimal.TryParse(txtPrecio.Text, precio)

        Dim cantidad As Integer = NUMCantidad.Value
        Dim total As Decimal = precio * cantidad
        txtTotal.Text = total.ToString("C2")
    End Sub

    Private Sub NUMCantidad_ValueChanged(sender As Object, e As EventArgs) Handles NUMCantidad.ValueChanged
        ValorTotal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtFabricante.Text = filaSeleccionada.Cells("Fabricante").Value.ToString()
            txtLanzamiento.Text = Convert.ToDateTime(filaSeleccionada.Cells("Lanzamiento").Value).ToString("dd/MM/yyyy")
            txtPrecio.Text = filaSeleccionada.Cells("Precio").Value.ToString()
        End If

    End Sub

    Private Sub ButtonComprar_Click(sender As Object, e As EventArgs) Handles ButtonComprar.Click
        Dim form As Recibo = New Recibo(Nothing)
        form.ShowDialog()
    End Sub
End Class