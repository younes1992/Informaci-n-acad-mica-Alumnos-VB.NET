Public Class MenuPrincipal
    Dim i As Integer
    Dim sql As String
    Public numero As Integer
    Private Sub BotonAñadir_Click(sender As System.Object, e As System.EventArgs) Handles BotonAñadir.Click
        'Abre el formulario de añadir para agregar un usuario, por eso le pasa 0
        modificar = 0
        FormularioAgregar.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub BotonModificar_Click(sender As System.Object, e As System.EventArgs) Handles BotonModificar.Click
        FormPeticionDNI.ShowDialog()
    End Sub
    Private Sub BotonExportar_Click(sender As System.Object, e As System.EventArgs) Handles BotonExportar.Click
        Dim sql As String
        'Necesitamos limpiar la tabla temporal donde se guardan los datos para asegurarnos
        'que ningún dato se exporta de más
        sql = "Delete tblTemporal "
        consulta(sql)

        FrmSelect.ShowDialog()
    End Sub
    Private Sub btnModiFaltas_Click(sender As System.Object, e As System.EventArgs) Handles btnModiFaltas.Click
        FrmFaltas.ShowDialog()
    End Sub
    Public Sub CierraSesionExcel()
        'Todos los procesos Excel se eliminan para que no puedan dar problemas, ya que
        'cerrar la aplicación no mata el proceso
        Dim procesos As Process() = Process.GetProcessesByName("Excel")
        If procesos.Length > 0 Then
            For Me.i = procesos.Length - 1 To 0 Step -1
                procesos(i).Kill()
            Next
        End If
    End Sub
    Private Sub MenuPrincipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CierraSesionExcel()
    End Sub
    Private Sub btnExplorador_Click(sender As System.Object, e As System.EventArgs) Handles btnExplorador.Click
        'Dim rutaInfo As String = "informes\"
        Shell("explorer.exe " & System.AppDomain.CurrentDomain.BaseDirectory & "boletines", AppWinStyle.NormalFocus) 'abrir el explorador de archivos con la carpeta informes
    End Sub
End Class
