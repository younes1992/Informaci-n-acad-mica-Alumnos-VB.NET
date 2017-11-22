
Public Class FrmExportDNI
    Dim dni As String
    Dim num As Integer
    Dim letra As String
    Dim resto As Integer
    '-------------------
    Private Sub BtnExportar_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportar.Click
        If TextBoxDNI.Text = "" Then
            MsgBox("El DNI no puede estar vacio", vbInformation, "Error")
            TextBoxDNI.Focus()
        ElseIf validDNI() = False Then
            MsgBox("El DNI es incorrecto", vbInformation, "Error")
            TextBoxDNI.Focus()
        Else
            CrearExcel()
            MsgBox("Los datos del alumnos se han exportado al Excel.")
            CierraSesionExcel()
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