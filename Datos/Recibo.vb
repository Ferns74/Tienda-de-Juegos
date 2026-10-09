Imports Dominio
Public Class Recibo
    Dim tabla As DataSet1.dtJuegosDataTable = New DataSet1.dtJuegosDataTable
    Dim fila As DataSet1.dtJuegosRow
    Dim cAction As String

    Sub MySub(nfila As DataSet1.dtJuegosRow)
        fila = nfila
    End Sub

    Sub New(df As DataSet1.dtJuegosDataTable)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub
    Public Sub Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabla.Clear()
        If fila IsNot Nothing Then
            txtnombre.Text = fila.nombre
            txtGenero.Text = fila.genero
            txtPlataforma.Text = fila.plataforma
            txtPrecio.Text = fila.precio
            NUMCantidad.Value = fila.cantidad
            CBmetodopago.SelectedItem = fila.metodopago
        End If

        DataGridView1.DataSource = tabla
    End Sub

    Private Sub Nuevo()
        fila = tabla.NewdtJuegosRow
        fila.nombre = txtnombre.Text
        fila.cantidad = NUMCantidad.Value
        fila.genero = txtGenero.Text
        fila.plataforma = txtPlataforma.Text
        fila.precio = txtPrecio.Text
        fila.metodopago = CBmetodopago.SelectedItem.ToString()



        tabla.AdddtJuegosRow(fila)
        tabla.AcceptChanges()
    End Sub


    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        LimpiarCampos()
        Habilitar()
        cAction = "I"

        ButtonEditar.Enabled = False
        ButtonBorrar.Enabled = False
        ButtonGuardar.Enabled = True
        ButtonNuevo.Enabled = False
    End Sub

    Private Sub LimpiarCampos()
        txtnombre.Text = ""
        NUMCantidad.Value = 0
        txtGenero.Text = ""
        txtPlataforma.Text = ""
        txtPrecio.Text = ""
        CBmetodopago.SelectedItem = ""
    End Sub

    Private Sub Deshabilitar()
        txtnombre.Enabled = False
        NUMCantidad.Enabled = False
        txtPlataforma.Enabled = False
        txtGenero.Enabled = False
        txtPrecio.Enabled = False
        CBmetodopago.Enabled = False
    End Sub

    Private Sub Habilitar()
        txtnombre.Enabled = True
        NUMCantidad.Enabled = True
        txtPlataforma.Enabled = True
        txtGenero.Enabled = True
        txtPrecio.Enabled = True
        CBmetodopago.Enabled = True
    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        If cAction = "I" Then
            Nuevo()
            ButtonNuevo.Enabled = True
            ButtonEditar.Enabled = True
            ButtonBorrar.Enabled = True
            ButtonGuardar.Enabled = False

            Deshabilitar()
        End If
    End Sub

    Private Sub comboJuegos_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        cAction = "I"
        ButtonEditar.Enabled = False
        ButtonBorrar.Enabled = True
        ButtonGuardar.Enabled = True
        ButtonNuevo.Enabled = True
        Habilitar()
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
    Private Sub ValorTotal()
        Dim precioUNI As Decimal
        Dim cantidad As Integer = CInt(NUMCantidad.Value)

        If Decimal.TryParse(txtPrecio.Text, precioUNI) Then
            Dim precioTotal As Decimal = precioUNI * cantidad
            txtPrecio.Text = precioTotal.ToString("0.00")
        Else
            MessageBox.Show("Ingresa un numero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NUMCantidad_ValueChanged(sender As Object, e As EventArgs) Handles NUMCantidad.ValueChanged

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        ValorTotal()
    End Sub
End Class