' Proejct : Final Porject
' Name    : Argin, Yu-Min
' Date    : 3/22/2018


Public Class frmMain
    Dim answers As Integer()
    Dim correctAnswer As Integer
    Dim score As Integer = 0
    Dim numberOfQuestions As Integer = 0


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        gamePlay()

        Timer1.Enabled = True

    End Sub

    Sub gameplay()
        Dim Generator As New Random

        Dim intOperator As Integer = Generator.Next(0, 3)

        'If its 0, then its addition
        'If its 1, then its subtraction
        'If its 2, then its multiplication
        'If its 3, then its division

        If intOperator = 0 Then

            Dim x = Generator.Next(1, 50)
            Dim y = Generator.Next(1, 50)

            lblQuestion.Text = x & " + " & y

            correctAnswer = Generator.Next(0, 3)

            For i As Integer = 0 To 3

                If (i = correctAnswer) Then

                    answers(i) = x + y

                Else

                    Dim incorrectAnswer = Generator.Next(1, 100)

                    While incorrectAnswer = x + y ' Or answers.includes(incorrectAnswer)) {

                        incorrectAnswer = Generator.Next(1, 100)

                    End While

                    answers(i) = incorrectAnswer

                End If

            Next

            btn1.Text = answers(0)
            btn2.Text = answers(1)
            btn3.Text = answers(2)
            btn4.Text = answers(3)

        ElseIf (intOperator = 1) Then

            Dim x = Generator.Next(-50, 50)
            Dim y = Generator.Next(-50, 50)

            lblQuestion.Text = x & " - " & y

            correctAnswer = Generator.Next(0, 3)

            For i As Integer = 0 To 3

                If (i = correctAnswer) Then

                    answers(i) = x - y

                Else

                    Dim incorrectAnswer = Generator.Next(-50, 50)

                    While incorrectAnswer = x + y ' Or answers.includes(incorrectAnswer)) {

                        incorrectAnswer = Generator.Next(-50, 50)

                    End While

                    answers(i) = incorrectAnswer

                End If

            Next

            btn1.Text = answers(0)
            btn2.Text = answers(1)
            btn3.Text = answers(2)
            btn4.Text = answers(3)


        ElseIf (intOperator = 2) Then

            Dim x = Generator.Next(1, 30)
            Dim y = Generator.Next(1, 30)

            lblQuestion.Text = x & " * " & y

            correctAnswer = Generator.Next(0, 3)

            For i As Integer = 0 To 3

                If (i = correctAnswer) Then

                    answers(i) = x * y

                Else

                    Dim incorrectAnswer = Generator.Next(1, 30)

                    While incorrectAnswer = x * y ' Or answers.includes(incorrectAnswer)) {

                        incorrectAnswer = Generator.Next(1, 30)

                    End While

                    answers(i) = incorrectAnswer

                End If

            Next

            btn1.Text = answers(0)
            btn2.Text = answers(1)
            btn3.Text = answers(2)
            btn4.Text = answers(3)

        ElseIf (intOperator = 3) Then

            Dim x = Generator.Next(1, 20)
            Dim y = Generator.Next(1, 10)
            Dim multiplied As Integer = x * y

            lblQuestion.Text = multiplied & " / " & y

            correctAnswer = Generator.Next(0, 3)

            For i As Integer = 0 To 3

                If (i = correctAnswer) Then

                    answers(i) = multiplied / y

                Else

                    Dim incorrectAnswer = Generator.Next(1, 10)

                    While incorrectAnswer = multiplied * y ' Or answers.includes(incorrectAnswer)) {

                        incorrectAnswer = Generator.Next(1, 10)

                    End While

                    answers(i) = incorrectAnswer

                End If

            Next

            btn1.Text = answers(0)
            btn2.Text = answers(1)
            btn3.Text = answers(2)
            btn4.Text = answers(3)

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = Val(lblTimer.Text) - 1
        If lblTimer.Text = 0 Then Timer1.Enabled = False
    End Sub
End Class
