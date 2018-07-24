<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(121, 103)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(97, 78)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(121, 199)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(97, 78)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(240, 103)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(97, 78)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Button3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(240, 199)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(97, 78)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "Button4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(14, 336)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 35)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(120, 336)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(87, 35)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "&Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(239, 336)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(87, 35)
        Me.btnPause.TabIndex = 6
        Me.btnPause.Text = "&Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(341, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 35)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(22, 40)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(39, 13)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "Label1"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(389, 40)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(39, 13)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "Label2"
        '
        'Timer1
        '
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(168, 51)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(18, 13)
        Me.lblQuestion.TabIndex = 10
        Me.lblQuestion.Text = "Q:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 393)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "frmMain"
        Me.Text = "Ultimate Math Challenges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblQuestion As Label
End Class
