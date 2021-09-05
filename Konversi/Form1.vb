Public Class Form1
    Dim Jawaban As String
    Public Function Convert(ByVal Input As Integer) As String
        While Input > 0
            Jawaban &= Input Mod 2
            Input \= 2
        End While
        Return StrReverse(Jawaban)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label3.Text = "Biner :"
        ElseIf TextBox1.Text = 0 Then
            Label3.Text = "Biner : 0"
        Else
            Convert(TextBox1.Text)
            Label3.Text = "Biner : " + Jawaban
            Jawaban = ""
        End If
    End Sub

End Class