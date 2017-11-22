Imports Microsoft.Office.Interop
Module mExcel_mExcel
    Public sqlOri As String
    Public dtOri As New DataTable
    Public dtMedia As New DataTable
    Public media As Decimal
    Public dt As New DataTable()
    Public i As Integer
    Public ExcelApp As New Excel.Application
    Public ExcelSheet As Excel.Worksheet
    Public ExcelLibro As Excel.Workbook
    Dim NumeroRegistros As Integer
    Dim Valor As Integer
    Public dtZonaNum As New DataTable()
    Public dtContador As New DataTable()
    Public dtCambia As New DataTable()
    Dim contador As Integer
    Dim InicioGenerado As Integer
    Dim FicheroPlantilla As String
    Dim fichero As String
    Public sqlExportar As String
    Dim dni As String
    Public dtExportar As New DataTable()
    Dim num As Integer
    Dim letra As String
    Dim resto As Integer
    Public Sub CrearExcel()
        FicheroPlantilla = "\plantillas\plantillaBoletin.xlsx"
        ExcelLibro = ExcelApp.Workbooks.Open(System.AppDomain.CurrentDomain.BaseDirectory & FicheroPlantilla)
        ExcelSheet = ExcelLibro.Worksheets(1)
        ExcelLibro.Application.Range("A1:B2").Select()
        insertaImagen()
        ExcelLibro.ActiveSheet.Pictures.Insert(System.AppDomain.CurrentDomain.BaseDirectory & "/logo/XuntaGalRedim.jpg").Select()
        dni = FrmExportDNI.TextBoxDNI.Text
        ExcelLibro.Worksheets(1).Name = "Boletín"
        sqlExportar = "Select * from Alumnos where dni = '" & dni & "' "
        dtExportar = consulta(sqlExportar)
        fichero = System.Windows.Forms.Application.StartupPath & "\boletines\" & "boletin_" & dtExportar.Rows(0)("nombre") & "_" & Trim(dtExportar.Rows(0)("Apellidos")) & ".xls"
        ExcelSheet.Cells(3, 1).Value = DateTime.Today
        EscribirFilaBoletin()

        ExcelLibro.SaveAs(fichero)
        ExcelLibro.Close()
        ExcelApp.Quit()
        ExcelSheet = Nothing
        ExcelLibro = Nothing
        ExcelApp = Nothing
    End Sub
    Public Sub CrearExcelVarios()
        Dim fila As Integer = 6
        Dim Sql As String = "select * from tblTemporal"
        Dim sqlMedia As String
        dt = consulta(Sql)
        Dim contador As Integer
        Dim x As Integer = 0
        Dim j As Integer
        Dim fichero As String
        Dim Valor As Integer
        Dim InicioGenerado As Integer
        Dim i As Integer = 0
        FicheroPlantilla = "\plantillas\plantillaBoletinConjunto.xlsx"
        ExcelLibro = ExcelApp.Workbooks.Open(System.AppDomain.CurrentDomain.BaseDirectory & FicheroPlantilla)
        ExcelSheet = ExcelLibro.Worksheets(1)
        ExcelLibro.Application.Range("A1:B2").Select()
        insertaImagen()
        ExcelLibro.ActiveSheet.Pictures.Insert(System.AppDomain.CurrentDomain.BaseDirectory & "/logo/XuntaGalRedim.jpg").Select()
        ExcelLibro.Worksheets(1).Name = "Registros"
        ExcelSheet.Cells(3, 1).Value = DateTime.Today
        'Introduce tantas filas como necesite en el Excel
        Dim numeroRegistros = dt.Rows.Count
        InicioGenerado = 6
        ExcelLibro.Worksheets(1).Select()
        ExcelLibro.Worksheets(1).Range("A6:P6").Select()
        ExcelApp.Selection.Copy()
        x = 1
        For x = 1 To numeroRegistros - 1
            '****va agregando las filas el excel segun la cantidad de registros que tiene que escribir****************
            Application.DoEvents()
            Valor = InicioGenerado + x
            ExcelLibro.Worksheets(1).Range("A" & Valor).Select()
            ExcelApp.Selection.Insert()
            ExcelLibro.Worksheets(1).Range("A6:P6").Select()
            ExcelApp.Selection().Copy()
            '***************************************************************************************************************
        Next
        While contador < dt.Rows.Count
            dni = dt.Rows(contador)("dni")
            sqlOri = "Select * from Alumnos where dni = '" & dni & "'"
            sqlMedia = "Select sum(Mate1 + Mate2 + Mate3 + Prog1 + Prog2 + Prog3 + Historia1 + Historia2 + Historia3 + Biologia1 + Biologia2 + Biologia3) as Media from Alumnos Where dni = '" & dni & "'"
            dtMedia = consulta(sqlMedia)
            media = dtMedia.Rows(0)("Media") / 12
            dtOri = consulta(sqlOri)
            Dim contadorEscritura As Integer = 0
            While contadorEscritura < dtOri.Rows.Count
                EscribirFilaConjunto(fila)
                contadorEscritura += 1
            End While
            contador += 1
            fila += 1
        End While
        fichero = System.Windows.Forms.Application.StartupPath & "\boletines\" & "boletin_Total.xls"
        ExcelLibro.SaveAs(fichero)
        ExcelLibro.Close()
        ExcelApp.Quit()
        ExcelSheet = Nothing
        ExcelLibro = Nothing
        ExcelApp = Nothing
        CierraSesionExcel()
    End Sub
    Public Sub insertaImagen()
        Dim imagenOriginal As Bitmap 'para redemsionar la imagen
        Dim imagenRedimensionada As Bitmap
        'Carga de la imagen original
        imagenOriginal = New Bitmap(System.AppDomain.CurrentDomain.BaseDirectory & "\logo\XuntaGalicia.jpg")
        'creamos una imagen con las dimensiones que se desean
        'en este caso la creamos de 100x100 pixels
        imagenRedimensionada = New Bitmap(273, 63)
        'creamos un objeto graphics desde la nueva imagen
        Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
            'en la nueva imagen "pintamos" la antigua imagen con las dimensiones de la nueva imagen
            gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
        End Using
        'se guarda la nueva imagen
        imagenRedimensionada.Save(System.AppDomain.CurrentDomain.BaseDirectory & "\logo\XuntaGalRedim.jpg")
    End Sub
    Public Sub CierraSesionExcel()
        '***********************Cerrar tareas excel**************************************************************
        Dim procesos As Process() = Process.GetProcessesByName("Excel")
        If procesos.Length > 0 Then
            For mExcel_mExcel.i = procesos.Length - 1 To 0 Step -1
                procesos(i).Kill()
            Next
        End If
        '**************************************************************************************
    End Sub
End Module

