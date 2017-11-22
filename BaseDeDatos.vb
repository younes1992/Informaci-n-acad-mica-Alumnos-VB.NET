Imports System.Data.SqlClient

Module BaseDeDatos
    Public conexion As SqlConnection = New SqlConnection("Data Source = nombreDelServidor; Initial Catalog = NotasAlumnado; Integrated Security = True;")
    'Dim sql As String
    Public modificar As Integer
    Public Sub Abrir()
        conexion.Open()
    End Sub
    Public Function consulta(sql As String)
        Dim cmd As New SqlCommand(sql, conexion)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable() 'Acá tendrás los datos de la consulta SQL
        da.Fill(dt)
        Return dt
    End Function
    Public Sub Cerrar_BD()
        conexion.Close()
    End Sub
End Module
