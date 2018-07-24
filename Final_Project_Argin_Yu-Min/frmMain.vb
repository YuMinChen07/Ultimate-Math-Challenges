' Proejct : Final Porject
' Name    : Argin, Yu-Min
' Date    : 3/22/2018

Public Class frmMain

    Dim answers(4) As Integer
    Dim correctAnswer As Integer
    Dim score As Integer
    Dim numberOfQuestions As Integer

    'A counter for timer. 30 represents the amount of time ONE GAME will last. 
    Dim intTimerCounter = 30

    'This boolean is used to toggle between pause and resume
    Dim paused As Boolean = True

    'Start Button
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        'Reset all the values (score, numberOfQuestions, intTimerCounter) and update score label.
        score = 0
        numberOfQuestions = 0
        intTimerCounter = 30
        lblScore.Text = score.ToString & " / " & numberOfQuestions.ToString

        'Disable the Start button after it was pressed
        btnStart.Enabled = False

        'Enable all the relevant buttons.
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btnPause.Enabled = True
        btnRestart.Enabled = True

        'Call gameplay() to display question and answers
        gameplay()

        'Set timer interval and start timer. (1100 is chosen for more accuracy.)
        timer.Interval = 1100
        timer.Start()

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        intTimerCounter = intTimerCounter - 1
        If intTimerCounter < 10 Then
            lblTimer.Text = "0:0" & intTimerCounter.ToString
        Else
            lblTimer.Text = "0:" & intTimerCounter.ToString
        End If

        'When timer reaches zero...
        If intTimerCounter = 0 Then
            'Stop timer and reset it back to 30
            timer.Stop()

            'Alert the user that the game is finished.
            MsgBox("Your final score for this round was " & score.ToString & " out of " & numberOfQuestions.ToString & ".", MsgBoxStyle.Exclamation, "Game Over!")

            'Enable Start Button again.
            btnStart.Enabled = True

            'Disable all the buttons because the game is stopped now.
            btn0.Enabled = False
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            btnPause.Enabled = False
            btnRestart.Enabled = False

        End If

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

            btn0.Text = answers(0)
            btn1.Text = answers(1)
            btn2.Text = answers(2)
            btn3.Text = answers(3)

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

            btn0.Text = answers(0)
            btn1.Text = answers(1)
            btn2.Text = answers(2)
            btn3.Text = answers(3)


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

            btn0.Text = answers(0)
            btn1.Text = answers(1)
            btn2.Text = answers(2)
            btn3.Text = answers(3)

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

            btn0.Text = answers(0)
            btn1.Text = answers(1)
            btn2.Text = answers(2)
            btn3.Text = answers(3)

        End If

    End Sub

    'Exit the program.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'Check the answer the user selected
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click

        If CType(sender, Button).Tag = correctAnswer Then
            'Correct answer was chosen
            score = score + 1
        End If

        'Update the score label.
        numberOfQuestions = numberOfQuestions + 1
        lblScore.Text = score.ToString & " / " & numberOfQuestions.ToString

        'Recall gameplay() for the game to continue.
        gameplay()

    End Sub

    'When the form loads....
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable all the buttons because the game has not yet begun.
        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btnPause.Enabled = False
        btnRestart.Enabled = False
    End Sub

    'Pause Button
    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click

        'Check if the game is in 'paused' mode.
        If paused Then
            'If it is being paused, disable the buttons, stop timer, change button text, and update pause to False.
            btn0.Enabled = False
            btn1.Enabled = False
            btn2.Enabled = False
            btn3.Enabled = False
            timer.Stop()
            btnPause.Text = "Resume"
            paused = False
        Else
            'If it is paused and now will resume, enable the buttons, start the timer again, change buttons text, and update paused variable to True.
            btn0.Enabled = True
            btn1.Enabled = True
            btn2.Enabled = True
            btn3.Enabled = True
            timer.Start()
            btnPause.Text = "Pause"
            paused = True
        End If

    End Sub

    'Restart Button
    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        'Stop the timer
        timer.Stop()

        'Alert the user that the game will restart
        MsgBox("This game will end and a new game will begin.", MsgBoxStyle.Information, "Game will restart.")

        'Restart all the values (score, numberOfQuestions, intTimerCounter) and update score label.
        score = 0
        numberOfQuestions = 0
        intTimerCounter = 30
        lblScore.Text = score.ToString & " / " & numberOfQuestions.ToString

        'Call gameplay() and start the timer again to restart.
        gameplay()
        timer.Interval = 1100
        timer.Start()

    End Sub
End Class
