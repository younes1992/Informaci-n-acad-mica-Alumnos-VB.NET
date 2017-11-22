<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonExportar = New System.Windows.Forms.Button()
        Me.BotonModificar = New System.Windows.Forms.Button()
        Me.BotonAñadir = New System.Windows.Forms.Button()
        Me.btnModiFaltas = New System.Windows.Forms.Button()
        Me.btnExplorador = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(166, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BotonExportar
        '
        Me.BotonExportar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BotonExportar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonExportar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BotonExportar.Location = New System.Drawing.Point(26, 131)
        Me.BotonExportar.Name = "BotonExportar"
        Me.BotonExportar.Size = New System.Drawing.Size(102, 37)
        Me.BotonExportar.TabIndex = 10
        Me.BotonExportar.Text = "Exportar"
        Me.BotonExportar.UseVisualStyleBackColor = False
        '
        'BotonModificar
        '
        Me.BotonModificar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BotonModificar.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonModificar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BotonModificar.Location = New System.Drawing.Point(166, 23)
        Me.BotonModificar.Name = "BotonModificar"
        Me.BotonModificar.Size = New System.Drawing.Size(103, 37)
        Me.BotonModificar.TabIndex = 8
        Me.BotonModificar.Text = "Modificar"
        Me.BotonModificar.UseVisualStyleBackColor = False
        '
        'BotonAñadir
        '
        Me.BotonAñadir.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BotonAñadir.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAñadir.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BotonAñadir.Location = New System.Drawing.Point(26, 23)
        Me.BotonAñadir.Name = "BotonAñadir"
        Me.BotonAñadir.Size = New System.Drawing.Size(103, 37)
        Me.BotonAñadir.TabIndex = 7
        Me.BotonAñadir.Text = "Añadir"
        Me.BotonAñadir.UseVisualStyleBackColor = False
        '
        'btnModiFaltas
        '
        Me.btnModiFaltas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnModiFaltas.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModiFaltas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnModiFaltas.Location = New System.Drawing.Point(25, 77)
        Me.btnModiFaltas.Name = "btnModiFaltas"
        Me.btnModiFaltas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnModiFaltas.Size = New System.Drawing.Size(103, 37)
        Me.btnModiFaltas.TabIndex = 12
        Me.btnModiFaltas.Text = "Modificar faltas"
        Me.btnModiFaltas.UseVisualStyleBackColor = False
        '
        'btnExplorador
        '
        Me.btnExplorador.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnExplorador.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExplorador.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExplorador.Location = New System.Drawing.Point(166, 77)
        Me.btnExplorador.Name = "btnExplorador"
        Me.btnExplorador.Size = New System.Drawing.Size(103, 37)
        Me.btnExplorador.TabIndex = 13
        Me.btnExplorador.Text = "Explorador"
        Me.btnExplorador.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(166, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 37)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(294, 187)
        Me.Controls.Add(Me.btnExplorador)
        Me.Controls.Add(Me.btnModiFaltas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotonExportar)
        Me.Controls.Add(Me.BotonModificar)
        Me.Controls.Add(Me.BotonAñadir)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BotonExportar As System.Windows.Forms.Button
    Friend WithEvents BotonModificar As System.Windows.Forms.Button
    Friend WithEvents BotonAñadir As System.Windows.Forms.Button
    Friend WithEvents btnModiFaltas As System.Windows.Forms.Button
    Friend WithEvents btnExplorador As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
