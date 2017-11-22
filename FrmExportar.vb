Imports Microsoft.Office.Interop
Imports System.IO
Public Class FrmExportar
    Dim ExcelApp As Application
    Dim ExcelSheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim ExcelLibro As Microsoft.Office.Interop.Excel.Workbook
    Dim dtTotal As New DataTable()
    Dim dt As New DataTable()
    Dim sql As String
    Dim dtAgregar As New DataTable()
    Dim contador As Integer
    Dim dni As String
   
    Private Sub btnAvance_Click(sender As System.Object, e As System.EventArgs) Handles btnAvance.Click
        LblCheckeado.Visible = False
        contador += 1
        If contador >= dtTotal.Rows.Count Then
            MsgBox("Has llegado al último registro.", vbInformation, "Aviso")
            contador -= 1
        Else
            sql = "Select DNI, nombre, apellidos from Alumnos"
            dtTotal = consulta(sql)
            TextBoxDNI.Text = dtTotal.Rows(contador)("DNI")
            TextBoxNombre.Text = dtTotal.Rows(contador)("Nombre")
            TextBoxApellidos.Text = dtTotal.Rows(contador)("Apellidos")
            lblRegistro.Text = contador + 1 & "/" & dtTotal.Rows.Count
            checkedProcess()
        End If
        CheckAgregar.Checked = False
    End Sub

    Private Sub FrmExportar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LblCheckeado.Visible = False
        contador = 0
        sql = "Select DNI, nombre, apellidos from Alumnos"
        dtTotal = consulta(sql)
        lblRegistro.Text = contador + 1 & "/" & dtTotal.Rows.Count
        TextBoxDNI.Text = dtTotal.Rows(contador)("DNI")
        TextBoxNombre.Text = dtTotal.Rows(contador)("Nombre")
        TextBoxApellidos.Text = dtTotal.Rows(contador)("Apellidos")
    End Sub
    Private Sub btnAtras_Click(sender As System.Object, e As System.EventArgs) Handles btnAtras.Click
        LblCheckeado.Visible = False
        If contador <= 0 Then
            MsgBox("Has llegado al último registro.", vbInformation, "Aviso")
        Else
            contador -= 1
            sql = "Select DNI, nombre, apellidos from Alumnos"
            dtTotal = consulta(sql)
            TextBoxDNI.Text = dtTotal.Rows(contador)("DNI")
            TextBoxNombre.Text = dtTotal.Rows(contador)("Nombre")
            TextBoxApellidos.Text = dtTotal.Rows(contador)("Apellidos")
            lblRegistro.Text = contador + 1 & "/" & dtTotal.Rows.Count
            checkedProcess()
        End If
        CheckAgregar.Checked = False
    End Sub
    Private Sub BotonSalir_Click(sender As System.Object, e As System.EventArgs) Handles BotonSalir.Click
        sql = "Delete tblTemporal "
        consulta(sql)
        Me.Close()
    End Sub
    Private Sub CheckAgregar_Click(sender As Object, e As System.EventArgs) Handles CheckAgregar.Click
        LblCheckeado.Visible = True
        Dim repe As Boolean = False
        sql = "Select * from tblTemporal "
        dt = consulta(sql)
        Dim cont As Integer
        If dt.Rows.Count <> 0 Then
            While cont < dt.Rows.Count
                If TextBoxDNI.Text = dt.Rows(cont)("DNI") Then
                    repe = True
                End If
                cont = cont + 1
            End While
            If repe = True Then
                MsgBox("El alumno ya ha sido añadido al Excel.", vbCritical, "Error")
            Else
                sql = "Insert into tblTemporal (DNI, nombre, apellidos,Checqueado) VALUES ('" & TextBoxDNI.Text & "', '" & TextBoxNombre.Text & "', '" & TextBoxApellidos.Text & "','Checked')"
                consulta(sql)
            End If
        Else
            sql = "Insert into tblTemporal (DNI, nombre, apellidos,Checqueado) VALUES ('" & TextBoxDNI.Text & "', '" & TextBoxNombre.Text & "', '" & TextBoxApellidos.Text & "','Checked')"
            consulta(sql)
        End If
    End Sub

    Private Sub BtnExportar_Click(sender As System.Object, e As System.EventArgs) Handles BtnExportar.Click
        CrearExcelVarios()
        sql = "Delete tblTemporal "
        consulta(sql)
        Me.Close()
    End Sub
    Private Sub checkedProcess()
        sql = "select Checqueado from tblTemporal where DNI='" & TextBoxDNI.Text & "'"
        dtAgregar = consulta(sql)
        If dtAgregar.Rows.Count <> 0 Then
            If dtAgregar.Rows(0)("Checqueado") <> "NULL" Then
                LblCheckeado.Visible = True
            End If
        Else
            LblCheckeado.Visible = False
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
End Class