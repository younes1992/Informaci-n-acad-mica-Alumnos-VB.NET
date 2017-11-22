Public Class FrmFaltas
    Dim fecha As String
    Dim asignatura As String
    Dim faltas As Integer
    Dim sql As String
    Dim dtComprobar As New DataTable
    Dim dt As New DataTable
    Dim sqlCompr As String
    Dim numFaltas As Integer
    Private Sub BtnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BtnAñadir.Click
        sqlCompr = "Select Dni from Alumnos where dni =   '" & TextBoxDNI.Text & "' "
        If (ComboAsig.Text = "Matemáticas") Then
            asignatura = "Mate"
        ElseIf (ComboAsig.Text = "Programación") Then
            asignatura = "Prog"
        ElseIf (ComboAsig.Text = "Historia") Then
            asignatura = "Historia"
        ElseIf (ComboAsig.Text = "Biología") Then
            asignatura = "Biologia"
        End If
        faltas = TxtHoras.Text
        dt = consulta(sqlCompr)
        If (dt.Rows.Count = 1) Then
                sql = "Insert into Faltas (DNI, " & asignatura & ",fecha) VALUES ('" & TextBoxDNI.Text & "', " & TxtHoras.Text & ",  Getdate() )"
                consulta(sql)
                MsgBox("Las faltas se han introducido")
            sql = "select sum(" & asignatura & ") as Faltas from faltas where dni= '" & TextBoxDNI.Text & "'"
            dtComprobar = consulta(sql)
            numFaltas = dtComprobar.Rows(0)("Faltas")

            If (numFaltas >= 25) Then
                MsgBox("Este alumno ya ha llegado al límite de faltas.", vbInformation, "Aviso")
            End If
        Else
            MsgBox("El alumno no existe.")
        End If
        ComboAsig.SelectedIndex = -1
        TxtHoras.Clear()
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
End Class