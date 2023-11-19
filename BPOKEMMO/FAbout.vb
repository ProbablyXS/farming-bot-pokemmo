Public Class FAbout

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

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        Label6.Text = "THANKS YOU <3"
        Label6.Padding = New Padding(40, 0, 0, 0)
        Label6.ForeColor = Drawing.Color.Green
        Process.Start("https://www.paypal.me/HRTMTEAM")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        FMenu.Show()
        Me.Hide()

    End Sub

    Private Sub Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub FAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Location = New Point(FMenu.Location.X, FMenu.Location.Y)

    End Sub

End Class