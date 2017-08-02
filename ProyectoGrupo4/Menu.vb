Public Class Menu

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Dim t_proveedor = New DataSet1.ProveedorDataTable()
        Dim adapter = New DataSet1TableAdapters.ProveedorTableAdapter()
        adapter.Insert(txtNombre.Text, txtCedulaJuridica.Text, txtFecha.Text, txtTel1.Text, txtTel2.Text, txtDireccion.Text, txtSitioWeb.Text, txtEmail.Text, txtPersonaContacto.Text, txtComentario.Text)
        lblSuccess.Visible = True
    End Sub
End Class