Public Class FCalcXP

    'MOUVE FORM WITH MOUSE'
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, LabelTITLE.MouseDown

        drag = True
        mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
        mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, LabelTITLE.MouseMove

        If drag Then

            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, LabelTITLE.MouseUp

        drag = False

    End Sub
    'MOUVE FORM WITH MOUSE'


    Private Sub Calculer_Click(sender As Object, e As EventArgs) Handles Calculer.Click

        If (ListBox1.SelectedIndex = -1) Then

            MsgBox("Veuillez selectionner une valeur.", MsgBoxStyle.Information)
            Exit Sub

        End If

        Dim resul As Double
        Dim p As Double
        Dim x As Double = Niveau.Text Mod 3

        If ListBox1.SelectedIndex = 0 Then

            resul = 0.8 * Niveau.Text ^ 3

        End If

        If ListBox1.SelectedIndex = 1 Then

            resul = Niveau.Text ^ 3

        End If


        If ListBox1.SelectedIndex = 2 Then

            resul = 1.2 * (Niveau.Text ^ 3) - 15 * (Niveau.Text ^ 2) + 100 * (Niveau.Text) - 140



        End If

        If ListBox1.SelectedIndex = 3 Then

            resul = 1.25 * (Niveau.Text ^ 3)


        End If

        If ListBox1.SelectedIndex = 4 Then

            If x = 0 Then

                p = 0





            End If

            If x = 1 Then

                p = 0.008

            End If

            If x = 2 Then

                p = 0.014

            End If

            If Niveau.Text <= 50 Then

                resul = (Niveau.Text ^ 3) * ((100 - Niveau.Text) / 50) 'si niveau entre 0 et 50 inclus

            ElseIf Niveau.Text >= 51 And Niveau.Text <= 68 Then

                resul = (Niveau.Text ^ 3) * ((150 - Niveau.Text) / 100) 'si niveau entre 51 et 68 inclus

            ElseIf Niveau.Text >= 69 And Niveau.Text <= 98 Then

                resul = (Niveau.Text ^ 3) * (1.274 - (1 / 50) * (Niveau.Text / 3) - p) 'si niveau entre 69 et 98 inclus

            ElseIf Niveau.Text >= 99 And Niveau.Text <= 100 Then

                resul = (Niveau.Text ^ 3) * ((160 - Niveau.Text) / 100) 'si niveau entre 99 et 100 inclus


            End If

        End If


        If ListBox1.SelectedIndex = 5 Then

            If Niveau.Text <= 15 Then

                resul = (Niveau.Text ^ 3) * ((24 + ((Niveau.Text + 1) / 3)) / 50) 'si niveau entre 0 et 15 inclus

            ElseIf Niveau.Text >= 16 And Niveau.Text <= 35 Then


                resul = (Niveau.Text ^ 3) * ((Niveau.Text + 14) / 50) 'si niveau entre 16 et 35 inclus   

            ElseIf Niveau.Text >= 36 And Niveau.Text <= 100 Then


                resul = (Niveau.Text ^ 3) * ((32 + (Niveau.Text / 2)) / 50) 'si niveau entre 36 et 100 inclus 

            End If


        End If

        LabelResultat.Text = Math.Truncate(resul) & " XP"

        resul = resul - TextBox1.Text

        resul = Math.Truncate(resul)

        Label3.Text = resul & " XP"

        FCombatFarm.TextBox1.Text = Label3.Text.Replace(" XP", "")

        FCombatFarm.CheckBox1.Checked = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Hide()

    End Sub

    Private Sub CalcXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FCombatFarm.Location.X, FCombatFarm.Location.Y)

    End Sub
End Class
