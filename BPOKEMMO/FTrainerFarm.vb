Imports WindowsInput
Imports WindowsInput.Native

Public Class FTrainerFarm

    Public temps As Integer = 0

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






    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FMenu.Show()
        Me.Hide()

    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Await F_VC()

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        temps += 1

    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub FTrainerFarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FMenu.Location.X, FMenu.Location.Y)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Label11.Text = watch01.Elapsed.Hours.ToString("00") & ":" & watch01.Elapsed.Minutes.ToString("00") &
      ":" & watch01.Elapsed.Seconds.ToString("00") & ":" & watch01.Elapsed.Milliseconds.ToString("00")

        Label1.Text = temps

    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (Button2.Text = "Vermilion City ONLY") Then

            watch01.Start()
            Timer2.Start()

            Button2.Text = "Stop"

            For Each p As Process In Process.GetProcessesByName("javaw")

                AppActivate(p.Id)

                'YOUR CODE HERE

                Await F_OVC()

                'YOUR CODE HERE

            Next

            watch01.Stop()
            Timer2.Stop()

        Else

            Application.Restart()

        End If

    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (Button3.Text = "Fuchsia City ONLY") Then

            watch01.Start()
            Timer2.Start()

            Button3.Text = "Stop"

            For Each p As Process In Process.GetProcessesByName("javaw")

                AppActivate(p.Id)

                'YOUR CODE HERE
                Await F_OFC()
                'YOUR CODE HERE

            Next

            watch01.Stop()
            Timer2.Stop()

        Else

            Application.Restart()

        End If

    End Sub

    Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If (Button5.Text = "Lavender Town ONLY") Then

            watch01.Start()
            Timer2.Start()

            Button5.Text = "Stop"

            For Each p As Process In Process.GetProcessesByName("javaw")

                AppActivate(p.Id)

                'YOUR CODE HERE

                Await Task.Delay(2200)

                Await F_OLT()

                'YOUR CODE HERE

            Next

            watch01.Stop()
            Timer2.Stop()

        Else

            Application.Restart()

        End If

    End Sub

    Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If (Button6.Text = "AutoFarm=100s") Then

            watch01.Start()
            Timer2.Start()

            Button6.Text = "Stop"

            For Each p As Process In Process.GetProcessesByName("javaw")

                AppActivate(p.Id)

                'YOUR CODE HERE

                Await Task.Delay(2200)

                Await AUTOFIGHT()

                'YOUR CODE HERE

            Next

            watch01.Stop()
            Timer2.Stop()

        Else

            Application.Restart()

        End If

    End Sub
End Class