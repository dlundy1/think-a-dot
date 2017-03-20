' Think-a-Dot program by Deon L.

Public Class Form1
    'Declares counter variables for each button
    Private count_left = 0, count_mid = 0, count_right = 0


    Private Sub Left_Button_Click(sender As Object, e As EventArgs) Handles Left_Button.Click
        ' If clicked once, Highlight 1,4,7 // if twice Highlight 1,4,6 // 1,6
        ' Create counter to keep track

        If count_left = 0 Then
            Reset()
            Flipper1.flip()
            Flipper4.flip()
            Flipper7.flip()
            count_left = count_left + 1
        ElseIf count_left = 1 Then
            Reset()
            Flipper1.flip()
            Flipper4.flip()
            Flipper6.flip()
            count_left = count_left + 1
        ElseIf count_left = 2 Then
            Reset()
            Flipper1.flip()
            Flipper6.flip()
            count_left = 0
        End If


    End Sub

    Private Sub Middle_Button_Click(sender As Object, e As EventArgs) Handles Middle_Button.Click
        ' Possible Combinations
        '- 2,4,6 |2,5,8 |2,4,7|2,5,7|2,7

        If count_mid = 0 Then
            Reset()
            Flipper2.flip()
            Flipper4.flip()
            Flipper6.flip()
            count_mid = count_mid + 1
        ElseIf count_mid = 1 Then
            Reset()
            Flipper2.flip()
            Flipper5.flip()
            Flipper8.flip()
            count_mid = count_mid + 1
        ElseIf count_mid = 2 Then
            Reset()
            Flipper2.flip()
            Flipper4.flip()
            Flipper7.flip()
            count_mid = count_mid + 1
        ElseIf count_mid = 3 Then
            Reset()
            Flipper2.flip()
            Flipper5.flip()
            Flipper7.flip()
            count_mid = count_mid + 1
        ElseIf count_mid = 4 Then
            Reset()
            Flipper2.flip()
            Flipper7.flip()
            count_mid = 0
        End If
    End Sub

    Private Sub Right_Button_Click(sender As Object, e As EventArgs) Handles Right_Button.Click
        ' Possible Combinations
        ' - 3,5,7 | 3,5,8|3,8
        If count_right = 0 Then
            Reset()
            Flipper3.flip()
            Flipper5.flip()
            Flipper7.flip()
            count_right = count_right + 1
        ElseIf count_right = 1 Then
            Reset()
            Flipper3.flip()
            Flipper8.flip()
            count_right = count_right + 1
        ElseIf count_right = 2 Then
            Reset()
            Flipper3.flip()
            Flipper5.flip()
            Flipper8.flip()
            count_right = 0
        End If
    End Sub

    Private Sub Reset_Button_Click(sender As Object, e As EventArgs) Handles Reset_Button.Click
        ' Sets color of all dots back to default
        Reset()
    End Sub
    Private Sub Reset()
        Flipper1.reset()
        Flipper2.reset()
        Flipper3.reset()
        Flipper4.reset()
        Flipper5.reset()
        Flipper6.reset()
        Flipper7.reset()
        Flipper8.reset()
    End Sub
End Class