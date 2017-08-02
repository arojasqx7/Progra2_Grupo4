Public Class Menu
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles lblSabor.Click

    End Sub

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim t_proveedor = New DataSet1.ProveedorDataTable()
        Dim adapter = New DataSet1TableAdapters.ProveedorTableAdapter()
        adapter.Insert(txtNombre.Text, txtCedulaJuridica.Text, txtFecha.Text, txtTel1.Text, txtTel2.Text, txtDireccion.Text, txtSitioWeb.Text, txtEmail.Text, txtPersonaContacto.Text, txtComentario.Text)
        lblSuccess.Visible = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim t_productos = New DataSet1.ProveedorDataTable()
        Dim adapter = New DataSet1TableAdapters.ProductoTableAdapter()
        adapter.Insert(txtNombre.Text, cbxProveedor.Text, txtVencimiento.Text, txtCantidad.Text, txtSabor.Text, txtTipoHelado.Text, txtColor.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, txtDescripcion.Text)
        lblSuccess.Visible = True
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim t_buscar = New DataSet1.ProductoDataTable()
        Dim adapter = New DataSet1TableAdapters.ProductoTableAdapter()
        adapter.GetData(txtNombre.Text, cbxProveedor.Text, txtVencimiento.Text, txtCantidad.Text, txtSabor.Text, txtTipoHelado.Text, txtColor.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, txtDescripcion.Text)
        lblSuccess.Visible = True
    End Sub

End Class