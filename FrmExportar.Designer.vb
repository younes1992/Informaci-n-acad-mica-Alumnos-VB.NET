<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportar))
        Me.LblCheckeado = New System.Windows.Forms.Label()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.CheckAgregar = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBDespla = New System.Windows.Forms.GroupBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnAvance = New System.Windows.Forms.Button()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonSalir = New System.Windows.Forms.Button()
        Me.TextBoxApellidos = New System.Windows.Forms.TextBox()
        Me.LabelApellidos = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxDNI = New System.Windows.Forms.TextBox()
        Me.LabelDNI = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GBDespla.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblCheckeado
        '
        Me.LblCheckeado.AutoSize = True
        Me.LblCheckeado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckeado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LblCheckeado.Location = New System.Drawing.Point(214, 109)
        Me.LblCheckeado.Name = "LblCheckeado"
        Me.LblCheckeado.Size = New System.Drawing.Size(57, 13)
        Me.LblCheckeado.TabIndex = 44
        Me.LblCheckeado.Text = "Checked"
        '
        'BtnExportar
        '
        Me.BtnExportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BtnExportar.Location = New System.Drawing.Point(267, 25)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(75, 23)
        Me.BtnExportar.TabIndex = 43
        Me.BtnExportar.Text = "Exportar"
        Me.BtnExportar.UseVisualStyleBackColor = False
        '
        'CheckAgregar
        '
        Me.CheckAgregar.AutoSize = True
        Me.CheckAgregar.Location = New System.Drawing.Point(51, 109)
        Me.CheckAgregar.Name = "CheckAgregar"
        Me.CheckAgregar.Size = New System.Drawing.Size(103, 17)
        Me.CheckAgregar.TabIndex = 42
        Me.CheckAgregar.Text = "Agregar al Excel"
        Me.CheckAgregar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GBDespla)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 67)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GBDespla
        '
        Me.GBDespla.Controls.Add(Me.btnAtras)
        Me.GBDespla.Controls.Add(Me.btnAvance)
        Me.GBDespla.Controls.Add(Me.lblRegistro)
        Me.GBDespla.Location = New System.Drawing.Point(-4, 0)
        Me.GBDespla.Name = "GBDespla"
        Me.GBDespla.Size = New System.Drawing.Size(286, 66)
        Me.GBDespla.TabIndex = 54
        Me.GBDespla.TabStop = False
        Me.GBDespla.Text = "Desplazamiento"
        '
        'btnAtras
        '
        Me.btnAtras.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAtras.Location = New System.Drawing.Point(69, 19)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(29, 29)
        Me.btnAtras.TabIndex = 43
        Me.btnAtras.Text = "<"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'btnAvance
        '
        Me.btnAvance.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.btnAvance.Location = New System.Drawing.Point(122, 19)
        Me.btnAvance.Name = "btnAvance"
        Me.btnAvance.Size = New System.Drawing.Size(29, 29)
        Me.btnAvance.TabIndex = 44
        Me.btnAvance.Text = ">"
        Me.btnAvance.UseVisualStyleBackColor = False
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Location = New System.Drawing.Point(207, 27)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(49, 13)
        Me.lblRegistro.TabIndex = 48
        Me.lblRegistro.Text = "Registro "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(45, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonSalir
        '
        Me.BotonSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.BotonSalir.Location = New System.Drawing.Point(267, 67)
        Me.BotonSalir.Name = "BotonSalir"
        Me.BotonSalir.Size = New System.Drawing.Size(75, 23)
        Me.BotonSalir.TabIndex = 40
        Me.BotonSalir.Text = "Salir"
        Me.BotonSalir.UseVisualStyleBackColor = False
        '
        'TextBoxApellidos
        '
        Me.TextBoxApellidos.Location = New System.Drawing.Point(74, 74)
        Me.TextBoxApellidos.Name = "TextBoxApellidos"
        Me.TextBoxApellidos.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxApellidos.TabIndex = 39
        '
        'LabelApellidos
        '
        Me.LabelApellidos.AutoSize = True
        Me.LabelApellidos.Location = New System.Drawing.Point(12, 77)
        Me.LabelApellidos.Name = "LabelApellidos"
        Me.LabelApellidos.Size = New System.Drawing.Size(56, 13)
        Me.LabelApellidos.TabIndex = 38
        Me.LabelApellidos.Text = "*Apellidos:"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(74, 48)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxNombre.TabIndex = 37
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(17, 51)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(51, 13)
        Me.LabelNombre.TabIndex = 36
        Me.LabelNombre.Text = "*Nombre:"
        '
        'TextBoxDNI
        '
        Me.TextBoxDNI.Location = New System.Drawing.Point(74, 22)
        Me.TextBoxDNI.Name = "TextBoxDNI"
        Me.TextBoxDNI.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxDNI.TabIndex = 35
        '
        'LabelDNI
        '
        Me.LabelDNI.AutoSize = True
        Me.LabelDNI.Location = New System.Drawing.Point(35, 25)
        Me.LabelDNI.Name = "LabelDNI"
        Me.LabelDNI.Size = New System.Drawing.Size(33, 13)
        Me.LabelDNI.TabIndex = 34
        Me.LabelDNI.Text = "*DNI:"
        '
        'FrmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 243)
        Me.Controls.Add(Me.LblCheckeado)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.CheckAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BotonSalir)
        Me.Controls.Add(Me.TextBoxApellidos)
        Me.Controls.Add(Me.LabelApellidos)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.TextBoxDNI)
        Me.Controls.Add(Me.LabelDNI)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmExportar"
        Me.Text = "Exportar Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GBDespla.ResumeLayout(False)
        Me.GBDespla.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblCheckeado As System.Windows.Forms.Label
    Friend WithEvents BtnExportar As System.Windows.Forms.Button
    Friend WithEvents CheckAgregar As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBDespla As System.Windows.Forms.GroupBox
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents btnAvance As System.Windows.Forms.Button
    Friend WithEvents lblRegistro As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BotonSalir As System.Windows.Forms.Button
    Friend WithEvents TextBoxApellidos As System.Windows.Forms.TextBox
    Friend WithEvents LabelApellidos As System.Windows.Forms.Label
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LabelNombre As System.Windows.Forms.Label
    Friend WithEvents TextBoxDNI As System.Windows.Forms.TextBox
    Friend WithEvents LabelDNI As System.Windows.Forms.Label
End Class
