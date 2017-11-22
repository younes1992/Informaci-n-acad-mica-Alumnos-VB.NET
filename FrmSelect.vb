Public Class FrmSelect
    Private Sub BtnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Private Sub BtnAlumno_Click(sender As System.Object, e As System.EventArgs) Handles BtnAlumno.Click
        FrmExportDNI.Show()
        Me.Close()
    End Sub
    Private Sub BtnVarios_Click(sender As System.Object, e As System.EventArgs) Handles BtnVarios.Click
        FrmExportar.Show()
        Me.Close()
    End Sub
End Class