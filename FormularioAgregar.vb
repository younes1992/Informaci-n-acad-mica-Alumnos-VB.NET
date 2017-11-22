Public Class FormularioAgregar
    Dim num As Integer
    Dim letra As String
    Dim resto As Integer
    Dim dni As String
    Dim nombre As String
    Dim apellidos As String
    Dim telefono As String
    Dim email As String
    Dim direccion As String
    Dim Mate1S As String
    Dim Mate1 As String
    Dim Mate2 As String
    Dim Mate3 As String
    Dim Prog1 As String
    Dim Prog2 As String
    Dim Prog3 As String
    Dim Historia1 As String
    Dim Historia2 As String
    Dim Historia3 As String
    Dim Biologia1 As String
    Dim Biologia2 As String
    Dim Biologia3 As String
    Dim sql As String
    Dim dt As New DataTable()
    Private Sub BotonSalir_Click(sender As System.Object, e As System.EventArgs) Handles BotonSalir.Click
        modificar = Nothing
        Me.Close()

    End Sub

    

    Private Sub BotonAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BotonAñadir.Click
        Select Case modificar
            'Cuando modificar llega al formulario como '0' significa que el usuario 
            'quiere añadir un alumno
            Case 0
                If (TextBoxDNI.Text = "" Or TextBoxNombre.Text = "" Or TextBoxApellidos.Text = "") Then
                    MsgBox("Es necesario cubrir los datos básicos para introducir a un alumno en la base de datos")
                Else
                    dni = TextBoxDNI.Text
                    nombre = TextBoxNombre.Text
                    apellidos = TextBoxApellidos.Text
                    telefono = TextBoxTelefono.Text
                    email = TextBoxEmail.Text
                    direccion = TextBoxDireccion.Text

                    Mate1 = TxtMate.Text
                    Mate2 = TxtMate2.Text
                    Mate3 = TxtMate3.Text
                    Prog1 = TxtProg.Text
                    Prog2 = TxtProg2.Text
                    Prog3 = TxtProg3.Text
                    Historia1 = TxtHistoria.Text
                    Historia2 = TxtHistoria2.Text
                    Historia3 = TxtHistoria3.Text
                    Biologia1 = TxtBiologia.Text
                    Biologia2 = TxtBiologia2.Text
                    Biologia3 = TxtBiologia3.Text

                    sql = "Insert into Alumnos (DNI, Nombre, Apellidos, Telefono, Email, Direccion, Mate1, Mate2, Mate3," & _
                        "Prog1, Prog2, Prog3, Historia1, Historia2, Historia3, Biologia1, Biologia2, Biologia3)" & _
                     "VALUES('" & dni & "','" & nombre & "','" & apellidos & "','" & telefono & "','" & _
                         email & "','" & direccion & "'," & Mate1 & "," & Mate2 & "," & Mate3 & "," & Prog1 & "," & Prog2 & "," & Prog3 & "," & _
                          Historia1 & "," & Historia2 & "," & Historia3 & "," & Biologia1 & "," & Biologia2 & "," & Biologia3 & ");"

                    dt = consulta(sql)

                    MsgBox("Se ha introducido el alumno correctamente")

                    'Limpiamos el contenido de todos los campos y devolvemos el focus al primer campo de texto
                    limpiar()
                    TextBoxDNI.Focus()
                    TextBoxDNI.SelectAll()
                End If
            Case 1
                dni = TextBoxDNI.Text
                nombre = TextBoxNombre.Text
                apellidos = TextBoxApellidos.Text
                telefono = TextBoxTelefono.Text
                email = TextBoxEmail.Text
                direccion = TextBoxDireccion.Text

                Mate1 = TxtMate.Text
                Mate1 = Replace(Mate1, ",", ".")
                Mate2 = TxtMate2.Text
                Mate2 = Replace(Mate2, ",", ".")
                Mate3 = TxtMate3.Text
                Mate3 = Replace(Mate3, ",", ".")
                Prog1 = TxtProg.Text
                Prog1 = Replace(Prog1, ",", ".")
                Prog2 = TxtProg2.Text
                Prog2 = Replace(Prog2, ",", ".")
                Prog3 = TxtProg3.Text
                Prog3 = Replace(Prog3, ",", ".")
                Historia1 = TxtHistoria.Text
                Historia1 = Replace(Historia1, ",", ".")
                Historia2 = TxtHistoria2.Text
                Historia2 = Replace(Historia2, ",", ".")
                Historia3 = TxtHistoria3.Text
                Historia3 = Replace(Historia3, ",", ".")
                Biologia1 = TxtBiologia.Text
                Biologia1 = Replace(Biologia1, ",", ".")
                Biologia2 = TxtBiologia2.Text
                Biologia2 = Replace(Biologia2, ",", ".")
                Biologia3 = TxtBiologia3.Text
                Biologia3 = Replace(Biologia3, ",", ".")
                sql = "Update Alumnos set Dni = '" & dni & "', nombre = '" & nombre & "', apellidos = '" & apellidos & "', " & _
                    "Telefono = '" & telefono & "', Email = '" & email & "', Direccion = '" & direccion & "', Mate1 = '" & Mate1 & "', " & _
                "Mate2 = '" & Mate2 & "', Mate3 = '" & Mate3 & "', Prog1 = '" & Prog1 & "', Prog2 = '" & Prog2 & "', Prog3 = '" & Prog3 & "', " & _
                "Historia1 = '" & Historia1 & "', Historia2 = '" & Historia2 & "', Historia3 = '" & Historia3 & "', Biologia1 = '" & Biologia1 & "', " & _
                "Biologia2 = '" & Biologia2 & "', Biologia3 = '" & Biologia3 & "' Where DNI = '" & dni & "' "


                dt = consulta(sql)

                MsgBox("Se ha modificado el registro correctamente")
                Me.Close()


        End Select


    End Sub

    Private Sub limpiar()
        TextBoxDNI.Clear()
        TextBoxNombre.Clear()
        TextBoxApellidos.Clear()
        TextBoxTelefono.Clear()
        TextBoxEmail.Clear()
        TextBoxDireccion.Clear()
        TxtMate.Clear()
        TxtMate2.Clear()
        TxtMate3.Clear()
        TxtProg.Clear()
        TxtProg2.Clear()
        TxtProg3.Clear()
        TxtHistoria.Clear()
        TxtHistoria2.Clear()
        TxtHistoria3.Clear()
        TxtBiologia.Clear()
        TxtBiologia2.Clear()
        TxtBiologia3.Clear()
    End Sub

    Private Sub TextBoxTelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTelefono.KeyPress

        'Controla los números en la caja de texto del teléfono
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub TextBoxNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNombre.KeyPress
        'Controla que no se introduzcan números en la caja de texto del nombre
        If InStr("0123456789", e.KeyChar) <> 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub TextBoxApellidos_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxApellidos.KeyPress
        'Controla que no se introduzcan números en la caja de texto de apellidos
        If InStr("0123456789", e.KeyChar) <> 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub
    Private Sub TextBoxDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxDNI.KeyPress
        'Controla que no se puedan introducir DNI's no válidos
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
        'Validacion del DNI
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

  
    Private Sub FormularioAgregar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class