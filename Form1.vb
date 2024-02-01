Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.pb.Value = pb.Value + 3
        If pb.Value >= 100 Then
            Timer1.Stop()
            main_Form.Show()
            Me.Hide()
        End If
    End Sub
End Class
