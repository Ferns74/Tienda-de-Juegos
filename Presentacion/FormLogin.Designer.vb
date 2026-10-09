<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(455, 195)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(167, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(455, 264)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(167, 20)
        Me.txtPassword.TabIndex = 1
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIngresar.Location = New System.Drawing.Point(455, 339)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(113, 44)
        Me.ButtonIngresar.TabIndex = 2
        Me.ButtonIngresar.Text = "Ingresar"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLimpiar.Location = New System.Drawing.Point(593, 339)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(113, 44)
        Me.ButtonLimpiar.TabIndex = 3
        Me.ButtonLimpiar.Text = "Borrar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(776, 450)
        Me.Controls.Add(Me.ButtonLimpiar)
        Me.Controls.Add(Me.ButtonIngresar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsuario)
        Me.DoubleBuffered = True
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents ButtonLimpiar As Button
End Class
