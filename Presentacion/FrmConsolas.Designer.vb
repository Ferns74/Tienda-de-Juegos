<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsolas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsolas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonComprar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonComprar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 361)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PlayStation 5 Pro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Precio: 600$"
        '
        'ButtonComprar
        '
        Me.ButtonComprar.BackColor = System.Drawing.Color.Blue
        Me.ButtonComprar.Location = New System.Drawing.Point(16, 292)
        Me.ButtonComprar.Name = "ButtonComprar"
        Me.ButtonComprar.Size = New System.Drawing.Size(342, 33)
        Me.ButtonComprar.TabIndex = 1
        Me.ButtonComprar.Text = "Comprar"
        Me.ButtonComprar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(342, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(420, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(330, 361)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Xbox Series X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Precio: 500$"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(16, 292)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(294, 33)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Comprar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(294, 255)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.PictureBox3)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(766, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 361)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nintendo Switch"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio: 320$"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.Location = New System.Drawing.Point(16, 292)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(321, 33)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Comprar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(321, 255)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'FrmConsolas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1121, 603)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "FrmConsolas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolas Disponibles!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonComprar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
End Class
