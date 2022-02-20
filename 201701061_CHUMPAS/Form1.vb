Imports System.Math
Public Class Form1
    Private Sub BCalcular_Click(sender As Object, e As EventArgs) Handles BCalcular.Click
        If RBSMALL.Checked = False And RBMEDIUM.Checked = False And RBLARGE.Checked = False Then
            MsgBox("Porfavor elija una talla")
        End If

        If RBlona.Checked = False And RBALGODON.Checked = False And RBSEDA.Checked = False Then
            MsgBox("Porfavor elija un material")
        End If

        If TextBCantidad.Text = "" Then
            TextBCantidad.Text = 1
        End If

        'Declaración de de variables 

        Dim CantidadYardas As Double = 0
        Dim PrecioUnidad As Double = 0
        Dim PrecioCosto As Double = 0
        Dim PrecioVenta As Double = 0

        CantidadYardas = TextBCantidad.Text
        PrecioUnidad = Val(TextBox1.Text)
        PrecioCosto = Val(TextBox2.Text)
        PrecioVenta = Val(TextBox3.Text)

        ' se procede a calcular el precio de unidad 

        If RBSMALL.Checked = True And RBALGODON.Checked = True Then
            TextBox1.Text = Round(Val((PS * TextBCantidad.Text) + (PrecioAlgodon * yardasS * TextBCantidad.Text)), 2)
        ElseIf RBSMALL.Checked = True And RBSEDA.Checked = True Then
            TextBox1.Text = Round(Val((PS * TextBCantidad.Text) + (PrecioSeda * yardasS * TextBCantidad.Text)), 2)
        ElseIf RBSMALL.Checked = True And RBLONA.Checked = True Then
            TextBox1.Text = Round(Val((PS * TextBCantidad.Text) + (PrecioLona * yardasS * TextBCantidad.Text)), 2)


        ElseIf RBMEDIUM.Checked = True And RBALGODON.Checked = True Then
            TextBox1.Text = Round(Val((PM * TextBCantidad.Text) + (PrecioAlgodon * yardasM * TextBCantidad.Text)), 2)
        ElseIf RBMEDIUM.Checked = True And RBSEDA.Checked = True Then
            TextBox1.Text = Round(Val((PM * TextBCantidad.Text) + (PrecioSeda * yardasM * TextBCantidad.Text)), 2)
        ElseIf RBMEDIUM.Checked = True And RBlona.Checked = True Then
            TextBox1.Text = Round(Val((PM * TextBCantidad.Text) + (PrecioLona * yardasM * TextBCantidad.Text)), 2)


        ElseIf RBLARGE.Checked = True And RBALGODON.Checked = True Then
            TextBox1.Text = Round(Val((Pl * TextBCantidad.Text) + (PrecioAlgodon * yardasL * TextBCantidad.Text)), 2)
        ElseIf RBLARGE.Checked = True And RBSEDA.Checked = True Then
            TextBox1.Text = Round(Val((Pl * TextBCantidad.Text) + (PrecioSeda * yardasL * TextBCantidad.Text)), 2)
        ElseIf RBLARGE.Checked = True And RBlona.Checked = True Then
            TextBox1.Text = Round(Val((Pl * TextBCantidad.Text) + (PrecioLona * yardasL * TextBCantidad.Text)), 2)


            PrecioCosto = (TextBox1.Text / TextBCantidad.Text)
            TextBox2.Text = Round(Val(PrecioCosto), 2)

            PrecioVenta = (TextBox1.Text * 0.65) + TextBox1.Text
            TextBox3.Text = Round(Val(PrecioVenta), 2)


        End If





    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE SALIDA") = vbYes) Then
            End
        Else
            Limpiar()
        End If
    End Sub
End Class
