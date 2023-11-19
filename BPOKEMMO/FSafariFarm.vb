Public Class FSafariFarm

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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        FMenu.Show()

    End Sub

    Private Async Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Await FARM31()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label11.Text = watch01.Elapsed.Hours.ToString("00") & ":" & watch01.Elapsed.Minutes.ToString("00") &
      ":" & watch01.Elapsed.Seconds.ToString("00") & ":" & watch01.Elapsed.Milliseconds.ToString("00")

    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Await VENTEFARM()


    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If FTESTMOUSE.IsHandleCreated = True Then

        Else

            FTESTMOUSE.Show()

        End If


        Await TESTSOURISFARM()

    End Sub


    Private Sub Form_Click(sender As Object, e As EventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub FSafariFarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FMenu.Location.X, FMenu.Location.Y)

    End Sub

End Class