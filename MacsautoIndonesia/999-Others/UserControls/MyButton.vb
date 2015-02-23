Namespace UserControls
    Public Class MyButton
        Inherits Button

        Public Sub New()
            MyBase.New()

            FlatStyle = FlatStyle.Flat
        End Sub

        Protected Overrides Sub OnPaint(ByVal pevent As PaintEventArgs)
            MyBase.OnPaint(pevent)

            pevent.Graphics.DrawArc(Pens.Black, 0, 0, 100, 100, 45, 45)
        End Sub
    End Class
End Namespace