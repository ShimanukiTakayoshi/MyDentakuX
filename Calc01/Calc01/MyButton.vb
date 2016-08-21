Public Class MyButton
  Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
    pe.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
    MyBase.OnPaint(pe)
  End Sub
End Class
