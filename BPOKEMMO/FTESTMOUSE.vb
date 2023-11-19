Public Class FTESTMOUSE

    Private Sub TEST_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        'Create rectangle objects
        Dim rt01 As New Rectangle(745, 380, 50, 50)
        Dim rt02 As New Rectangle(745, 310, 50, 50)
        Dim rt03 As New Rectangle(820, 440, 30, 30)
        Dim rt04 As New Rectangle(855, 525, 30, 30)
        'Draw rectangles
        e.Graphics.DrawRectangle(Pens.Bisque, rt01)
        e.Graphics.DrawRectangle(Pens.Bisque, rt02)
        e.Graphics.DrawRectangle(Pens.Bisque, rt03)
        e.Graphics.DrawRectangle(Pens.Bisque, rt04)

    End Sub

End Class