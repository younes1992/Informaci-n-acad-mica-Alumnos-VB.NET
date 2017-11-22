Public Class FormPeticionDNI
    Public sqlModificar As String
    Dim dni As String
    Public dtModificar As New DataTable()
    Dim num As Integer
    Dim letra As String
    Dim resto As Integer
    Private Sub BotonAceptar_Click(sender As System.Object, e As System.EventArgs) Handles BotonAceptar.Click
        If TextBoxDNI.Text = "" Then
            MsgBox("El DNI no puede estar vacio", vbInformation, "Error")
            TextBoxDNI.Focus()
        ElseIf validDNI() = False Then
            MsgBox("El DNI es incorrecto", vbInformation, "Error")
            TextBoxDNI.Focus()
        Else
            'Pasa al formulario de añadir '1' para que el usuario pueda modificar datos
            modificar = 1

            FormularioAgregar.BotonAñadir.Text = "Modificar"
            dni = TextBoxDNI.Text

            sqlModificar = "Select * from Alumnos Where DNI ='" & dni & "'"
            dtModificar = consulta(sqlModificar)
            FormularioAgregar.Show()

            'Carga todos los datos en el formulario de añadir para que el usuario
            'pueda ver los datos y modificarlos
            FormularioAgregar.TextBoxDNI.Text = dtModificar.Rows(0)("DNI")
            FormularioAgregar.TextBoxNombre.Text = dtModificar.Rows(0)("Nombre")
            FormularioAgregar.TextBoxApellidos.Text = dtModificar.Rows(0)("Apellidos")
            FormularioAgregar.TextBoxTelefono.Text = dtModificar.Rows(0)("Telefono")
            FormularioAgregar.TextBoxEmail.Text = dtModificar.Rows(0)("Email")
            FormularioAgregar.TextBoxDireccion.Text = dtModificar.Rows(0)("Direccion")
            FormularioAgregar.TxtMate.Text = dtModificar.Rows(0)("Mate1")
            FormularioAgregar.TxtMate2.Text = dtModificar.Rows(0)("Mate2")
            FormularioAgregar.TxtMate3.Text = dtModificar.Rows(0)("Mate3")
            FormularioAgregar.TxtProg.Text = dtModificar.Rows(0)("Prog1")
            FormularioAgregar.TxtProg2.Text = dtModificar.Rows(0)("Prog2")
            FormularioAgregar.TxtProg3.Text = dtModificar.Rows(0)("Prog3")
            FormularioAgregar.TxtHistoria.Text = dtModificar.Rows(0)("Historia1")
            FormularioAgregar.TxtHistoria2.Text = dtModificar.Rows(0)("Historia2")
            FormularioAgregar.TxtHistoria3.Text = dtModificar.Rows(0)("Historia3")
            FormularioAgregar.TxtBiologia.Text = dtModificar.Rows(0)("Biologia1")
            FormularioAgregar.TxtBiologia2.Text = dtModificar.Rows(0)("Biologia2")
            FormularioAgregar.TxtBiologia3.Text = dtModificar.Rows(0)("Biologia3")
            FormularioAgregar.TextBoxDNI.Enabled = False
            FormularioAgregar.TextBoxNombre.Enabled = False
            FormularioAgregar.TextBoxApellidos.Enabled = False
            Me.Close()
        End If
    End Sub

    Private Sub TextBoxDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDNI.KeyPress
        If Len(TextBoxDNI.Text) < 8 Then
            If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = Chr(0)
            End If
        Else
            If InStr("TRWAGMYFPDXBNJZSQVHLCKE" & Chr(8), e.KeyChar) = 0 Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub
    Private Function validDNI()
        '+++++++++++++++Validacion del NIF+++++++++++++++++++++++++++++++
        Dim correcto As Boolean = False
        num = CInt(Mid(TextBoxDNI.Text, 1, 8)) 'Asignamos la parte numérica del nif a la variable "num"
        letra = UCase(Mid(TextBoxDNI.Text, 9, 1)) 'Asignamos la letra a la variable "letra" y la convertimos en mayus con UCase()
        resto = num Mod 23 'Asignamos el resto de dividir la variable "num" por 23 a la variable "resto"
        'Sacamos el resto y nos da un numero y debe de concidir con la posicion de la letra
        If letra <> Mid("TRWAGMYFPDXBNJZSQVHLCKE", resto + 1, 1) Then
            correcto = False
        Else
            correcto = True
        End If
        Return correcto
    End Function
End Class