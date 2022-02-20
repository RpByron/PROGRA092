<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBlona = New System.Windows.Forms.RadioButton()
        Me.RBSEDA = New System.Windows.Forms.RadioButton()
        Me.RBALGODON = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBSMALL = New System.Windows.Forms.RadioButton()
        Me.RBMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RBLARGE = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BCalcular = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.RBlona)
        Me.GroupBox1.Controls.Add(Me.RBSEDA)
        Me.GroupBox1.Controls.Add(Me.RBALGODON)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el Tipo de Material "
        '
        'RBlona
        '
        Me.RBlona.AutoSize = True
        Me.RBlona.Location = New System.Drawing.Point(509, 32)
        Me.RBlona.Name = "RBlona"
        Me.RBlona.Size = New System.Drawing.Size(66, 24)
        Me.RBlona.TabIndex = 2
        Me.RBlona.TabStop = True
        Me.RBlona.Text = "Lona "
        Me.RBlona.UseVisualStyleBackColor = True
        '
        'RBSEDA
        '
        Me.RBSEDA.AutoSize = True
        Me.RBSEDA.Location = New System.Drawing.Point(276, 32)
        Me.RBSEDA.Name = "RBSEDA"
        Me.RBSEDA.Size = New System.Drawing.Size(67, 24)
        Me.RBSEDA.TabIndex = 1
        Me.RBSEDA.TabStop = True
        Me.RBSEDA.Text = "Seda "
        Me.RBSEDA.UseVisualStyleBackColor = True
        '
        'RBALGODON
        '
        Me.RBALGODON.AutoSize = True
        Me.RBALGODON.Location = New System.Drawing.Point(53, 32)
        Me.RBALGODON.Name = "RBALGODON"
        Me.RBALGODON.Size = New System.Drawing.Size(92, 24)
        Me.RBALGODON.TabIndex = 0
        Me.RBALGODON.TabStop = True
        Me.RBALGODON.Text = "Algodon "
        Me.RBALGODON.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.RBSMALL)
        Me.GroupBox2.Controls.Add(Me.RBMEDIUM)
        Me.GroupBox2.Controls.Add(Me.RBLARGE)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(703, 77)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione la Talla "
        '
        'RBSMALL
        '
        Me.RBSMALL.AutoSize = True
        Me.RBSMALL.Location = New System.Drawing.Point(53, 26)
        Me.RBSMALL.Name = "RBSMALL"
        Me.RBSMALL.Size = New System.Drawing.Size(71, 24)
        Me.RBSMALL.TabIndex = 3
        Me.RBSMALL.TabStop = True
        Me.RBSMALL.Text = "Small "
        Me.RBSMALL.UseVisualStyleBackColor = True
        '
        'RBMEDIUM
        '
        Me.RBMEDIUM.AutoSize = True
        Me.RBMEDIUM.Location = New System.Drawing.Point(276, 26)
        Me.RBMEDIUM.Name = "RBMEDIUM"
        Me.RBMEDIUM.Size = New System.Drawing.Size(89, 24)
        Me.RBMEDIUM.TabIndex = 4
        Me.RBMEDIUM.TabStop = True
        Me.RBMEDIUM.Text = "Medium "
        Me.RBMEDIUM.UseVisualStyleBackColor = True
        '
        'RBLARGE
        '
        Me.RBLARGE.AutoSize = True
        Me.RBLARGE.Location = New System.Drawing.Point(509, 26)
        Me.RBLARGE.Name = "RBLARGE"
        Me.RBLARGE.Size = New System.Drawing.Size(71, 24)
        Me.RBLARGE.TabIndex = 5
        Me.RBLARGE.TabStop = True
        Me.RBLARGE.Text = "Large "
        Me.RBLARGE.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.TextBCantidad)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(703, 68)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coloque la cantidad de chumpas que desea "
        '
        'TextBCantidad
        '
        Me.TextBCantidad.Location = New System.Drawing.Point(232, 26)
        Me.TextBCantidad.Name = "TextBCantidad"
        Me.TextBCantidad.Size = New System.Drawing.Size(238, 27)
        Me.TextBCantidad.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox4.Controls.Add(Me.TextBox3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(36, 257)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(371, 181)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Precios "
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(154, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 27)
        Me.TextBox3.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(154, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 27)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 27)
        Me.TextBox1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Venta "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio Costo "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio Unidad "
        '
        'BCalcular
        '
        Me.BCalcular.Location = New System.Drawing.Point(529, 281)
        Me.BCalcular.Name = "BCalcular"
        Me.BCalcular.Size = New System.Drawing.Size(125, 28)
        Me.BCalcular.TabIndex = 4
        Me.BCalcular.Text = "Calcular "
        Me.BCalcular.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(529, 335)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(125, 28)
        Me.BLimpiar.TabIndex = 5
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'BSalir
        '
        Me.BSalir.Location = New System.Drawing.Point(529, 383)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Size = New System.Drawing.Size(125, 28)
        Me.BSalir.TabIndex = 6
        Me.BSalir.Text = "Salir"
        Me.BSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BSalir)
        Me.Controls.Add(Me.BLimpiar)
        Me.Controls.Add(Me.BCalcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBlona As RadioButton
    Friend WithEvents RBSEDA As RadioButton
    Friend WithEvents RBALGODON As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBSMALL As RadioButton
    Friend WithEvents RBMEDIUM As RadioButton
    Friend WithEvents RBLARGE As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBCantidad As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BCalcular As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents BSalir As Button
End Class
