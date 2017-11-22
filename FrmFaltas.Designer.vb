<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFaltas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFaltas))
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHoras = New System.Windows.Forms.TextBox()
        Me.ComboAsig = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAñadir
        '
        Me.BtnAñadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BtnAñadir.Location = New System.Drawing.Point(96, 101)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(75, 23)
        Me.BtnAñadir.TabIndex = 0
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Horas faltadas:"
        '
        'TxtHoras
        '
        Me.TxtHoras.Location = New System.Drawing.Point(96, 62)
        Me.TxtHoras.Name = "TxtHoras"
        Me.TxtHoras.Size = New System.Drawing.Size(29, 20)
        Me.TxtHoras.TabIndex = 2
        '
        'ComboAsig
        '
        Me.ComboAsig.FormattingEnabled = True
        Me.ComboAsig.Items.AddRange(New Object() {"Matemáticas", "Programación", "Historia", "Biología"})
        Me.ComboAsig.Location = New System.Drawing.Point(96, 35)
        Me.ComboAsig.Name = "ComboAsig"
        Me.ComboAsig.Size = New System.Drawing.Size(129, 21)
        Me.ComboAsig.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Asignatura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DNI:"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(96, 10)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(129, 20)
        Me.TextBoxDNI.TabIndex = 6
        '
        'FrmFaltas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(259, 138)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboAsig)
        Me.Controls.Add(Me.TxtHoras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmFaltas"
        Me.Text = "Faltas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAñadir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtHoras As System.Windows.Forms.TextBox
    Friend WithEvents ComboAsig As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDNI As System.Windows.Forms.TextBox
End Class
