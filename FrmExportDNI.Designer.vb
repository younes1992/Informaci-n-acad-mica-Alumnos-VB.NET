<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportDNI
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportDNI))
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BtnExportar.Location = New System.Drawing.Point(103, 165)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExportar.TabIndex = 9
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(48, 115)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(189, 20)
        Me.TextBoxDNI.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Introduzca el DNI del alumno, por favor."
        '
        'FrmExportDNI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExportDNI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents TextBoxDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
