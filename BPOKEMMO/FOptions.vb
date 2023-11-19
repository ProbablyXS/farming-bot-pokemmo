Imports System.IO

Public Class FOptions

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


    Dim Foptions As String = "Options.txt"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        FCombatFarm.Label3.Text = "IP"
        ini.WriteString("OPTIONS", "Location", "IP")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        FCombatFarm.Label3.Text = "FC"
        ini.WriteString("OPTIONS", "Location", "FC")

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FCombatFarm.Label3.Text = "5I"
        ini.WriteString("OPTIONS", "Location", "5I")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        FCombatFarm.Label3.Text = "7I"
        ini.WriteString("OPTIONS", "Location", "7I")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        FCombatFarm.Label3.Text = "2I"
        ini.WriteString("OPTIONS", "Location", "2I")

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        FCombatFarm.Label3.Text = "BF"
        ini.WriteString("OPTIONS", "Location", "BF")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        FCombatFarm.Label3.Text = "R114"
        ini.WriteString("OPTIONS", "Location", "R114")

    End Sub

    Private Sub FOptions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        FCombatFarm.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        FCombatFarm.Show()
        Me.Hide()

    End Sub

    Private Sub FOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FCombatFarm.Location.X, FCombatFarm.Location.Y)

    End Sub
End Class