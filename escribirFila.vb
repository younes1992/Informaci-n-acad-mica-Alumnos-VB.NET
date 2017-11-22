Imports Microsoft.Office

Module escribirFila

    Public Sub EscribirFilaBoletin()
        ExcelSheet.Cells(5, 1).Value = dtExportar.Rows(0)("DNI")
        ExcelSheet.Cells(5, 2).Value = dtExportar.Rows(0)("Nombre")
        ExcelSheet.Cells(5, 3).Value = dtExportar.Rows(0)("Apellidos")
        ExcelSheet.Cells(6, 4).Value = dtExportar.Rows(0)("Mate1")
        ExcelSheet.Cells(6, 6).Value = dtExportar.Rows(0)("Mate2")
        ExcelSheet.Cells(6, 8).Value = dtExportar.Rows(0)("Mate3")
        ExcelSheet.Cells(7, 4).Value = dtExportar.Rows(0)("Prog1")
        ExcelSheet.Cells(7, 6).Value = dtExportar.Rows(0)("Prog2")
        ExcelSheet.Cells(7, 8).Value = dtExportar.Rows(0)("Prog3")
        ExcelSheet.Cells(8, 4).Value = dtExportar.Rows(0)("Historia1")
        ExcelSheet.Cells(8, 6).Value = dtExportar.Rows(0)("Historia2")
        ExcelSheet.Cells(8, 8).Value = dtExportar.Rows(0)("Historia3")
        ExcelSheet.Cells(9, 4).Value = dtExportar.Rows(0)("Biologia1")
        ExcelSheet.Cells(9, 6).Value = dtExportar.Rows(0)("Biologia2")
        ExcelSheet.Cells(9, 8).Value = dtExportar.Rows(0)("Biologia3")
    End Sub
    Public Sub EscribirFilaConjunto(Fila As Integer)
        ExcelSheet.Cells(Fila, 1).Value = dtOri.Rows(0)("dni")
        ExcelSheet.Cells(Fila, 2).Value = dtOri.Rows(0)("nombre")
        ExcelSheet.Cells(Fila, 3).Value = dtOri.Rows(0)("apellidos")
        ExcelSheet.Cells(Fila, 4).Value = dtOri.Rows(0)("Mate1")
        ExcelSheet.Cells(Fila, 5).Value = dtOri.Rows(0)("Prog1")
        ExcelSheet.Cells(Fila, 6).Value = dtOri.Rows(0)("Historia1")
        ExcelSheet.Cells(Fila, 7).Value = dtOri.Rows(0)("Biologia1")
        ExcelSheet.Cells(Fila, 8).Value = dtOri.Rows(0)("Mate2")
        ExcelSheet.Cells(Fila, 9).Value = dtOri.Rows(0)("Prog2")
        ExcelSheet.Cells(Fila, 10).Value = dtOri.Rows(0)("Historia2")
        ExcelSheet.Cells(Fila, 11).Value = dtOri.Rows(0)("Biologia2")
        ExcelSheet.Cells(Fila, 12).Value = dtOri.Rows(0)("Mate3")
        ExcelSheet.Cells(Fila, 13).Value = dtOri.Rows(0)("Prog3")
        ExcelSheet.Cells(Fila, 14).Value = dtOri.Rows(0)("Historia3")
        ExcelSheet.Cells(Fila, 15).Value = dtOri.Rows(0)("Biologia3")
        ExcelSheet.Cells(Fila, 16).Value = media
    End Sub
End Module
