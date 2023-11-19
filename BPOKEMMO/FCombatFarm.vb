Imports System.Runtime.InteropServices
Imports WindowsInput
Imports WindowsInput.Native
Imports System.IO

Public Class FCombatFarm

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



    Dim simtest As New InputSimulator
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short

    Dim rdm As New Random()



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Label3.Text = "IP") Then

            CHEMIN_IP()

        ElseIf (Label3.Text = "FC") Then

            CHEMIN_FC()

        ElseIf (Label3.Text = "5I") Then

            CHEMIN_5I()

        ElseIf (Label3.Text = "7I") Then

            CHEMIN_7I()

        ElseIf (Label3.Text = "2I") Then

            CHEMIN_2I()

        ElseIf (Label3.Text = "BF") Then

            CHEMIN_BF()

        ElseIf (Label3.Text = "R114") Then

            CHEMIN_R114()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label11.Text = watch01.Elapsed.Hours.ToString("00") & ":" & watch01.Elapsed.Minutes.ToString("00") &
      ":" & watch01.Elapsed.Seconds.ToString("00") & ":" & watch01.Elapsed.Milliseconds.ToString("00")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FMenu.Location.X, FMenu.Location.Y)

        'Options.ini
        If (File.Exists("OPTIONS.ini")) Then

        Else

            'OPTIONS
            ini.WriteString("OPTIONS", "BestTime", "00:00:00:00")
            ini.WriteString("OPTIONS", "Location", "IP")
            ini.WriteString("OPTIONS", "Do_not_evolve", "0")

        End If

        Label13.Text = ini.GetString("OPTIONS", "BestTime", "")
        Label3.Text = ini.GetString("OPTIONS", "Location", "")

        If (ini.GetString("OPTIONS", "Do_not_evolve", "") = 0) Then

            CheckBox3.Checked = False

        Else

            CheckBox3.Checked = True

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        FOptions.Show()
        Me.Hide()

    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.Text = "Resumed"

        If (Button2.Text = "Resumed") Then

            Await calcul()

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FMenu.Show()
        Me.Hide()

    End Sub

    Private Sub FCombatFarm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        FMenu.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click

        If (CheckBox1.Checked = False) Then

            CheckBox2.Checked = False
            MsgBox("Select the box 'XP needed'", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        FCalcXP.Show()

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If (CheckBox3.Checked = True) Then

            ini.WriteString("OPTIONS", "Do_not_evolve", "1")

        Else

            ini.WriteString("OPTIONS", "Do_not_evolve", "0")

        End If

    End Sub
End Class
