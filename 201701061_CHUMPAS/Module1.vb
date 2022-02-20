Module Module1
    Public Const PS = 65.5
    Public Const PM = 85.99
    Public Const Pl = 99.99

    Public Const PrecioLona = 30.99
    Public Const PrecioAlgodon = 15
    Public Const PrecioSeda = 23.99

    Public Const yardasS = 2
    Public Const yardasM = 2.5
    Public Const yardasL = 3

    Sub Limpiar()
        'procedimiento que limpia los objetos de ingreso de datos y selección de opciones
        Form1.TextBCantidad.Clear()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.RBALGODON.Checked = False
        Form1.RBLARGE.Checked = False
        Form1.RBlona.Checked = False
        Form1.RBMEDIUM.Checked = False
        Form1.RBSEDA.Checked = False
        Form1.RBSMALL.Checked = False

    End Sub

End Module