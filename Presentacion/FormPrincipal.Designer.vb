<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.JuegosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PS4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsolasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedesSocialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacebookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstagramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.RoyalBlue
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegosToolStripMenuItem, Me.RedesSocialesToolStripMenuItem, Me.ToolsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1002, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'JuegosToolStripMenuItem
        '
        Me.JuegosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PS4ToolStripMenuItem, Me.ConsolasToolStripMenuItem, Me.AccesoriosToolStripMenuItem})
        Me.JuegosToolStripMenuItem.Name = "JuegosToolStripMenuItem"
        Me.JuegosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.JuegosToolStripMenuItem.Text = "Catalogo"
        '
        'PS4ToolStripMenuItem
        '
        Me.PS4ToolStripMenuItem.Name = "PS4ToolStripMenuItem"
        Me.PS4ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PS4ToolStripMenuItem.Text = "Juegos"
        '
        'ConsolasToolStripMenuItem
        '
        Me.ConsolasToolStripMenuItem.Name = "ConsolasToolStripMenuItem"
        Me.ConsolasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsolasToolStripMenuItem.Text = "Consolas"
        '
        'AccesoriosToolStripMenuItem
        '
        Me.AccesoriosToolStripMenuItem.Name = "AccesoriosToolStripMenuItem"
        Me.AccesoriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccesoriosToolStripMenuItem.Text = "Accesorios"
        '
        'RedesSocialesToolStripMenuItem
        '
        Me.RedesSocialesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacebookToolStripMenuItem, Me.InstagramToolStripMenuItem})
        Me.RedesSocialesToolStripMenuItem.Name = "RedesSocialesToolStripMenuItem"
        Me.RedesSocialesToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.RedesSocialesToolStripMenuItem.Text = "Contacto"
        '
        'FacebookToolStripMenuItem
        '
        Me.FacebookToolStripMenuItem.Name = "FacebookToolStripMenuItem"
        Me.FacebookToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FacebookToolStripMenuItem.Text = "Facebook"
        '
        'InstagramToolStripMenuItem
        '
        Me.InstagramToolStripMenuItem.Name = "InstagramToolStripMenuItem"
        Me.InstagramToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.InstagramToolStripMenuItem.Text = "Instagram"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(69, 20)
        Me.ToolsMenu.Text = "Opciones"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.OptionsToolStripMenuItem.Text = "Salir"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1002, 532)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido a Tienda Kirby!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JuegosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PS4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsolasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedesSocialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacebookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstagramToolStripMenuItem As ToolStripMenuItem
End Class
