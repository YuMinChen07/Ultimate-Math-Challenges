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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn0.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(287, 196)
        Me.btn0.Margin = New System.Windows.Forms.Padding(4)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(147, 113)
        Me.btn0.TabIndex = 0
        Me.btn0.TabStop = False
        Me.btn0.Tag = "0"
        Me.btn0.Text = "1"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn1.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(287, 342)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(147, 113)
        Me.btn1.TabIndex = 1
        Me.btn1.TabStop = False
        Me.btn1.Tag = "1"
        Me.btn1.Text = "3"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn2.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(468, 196)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(147, 113)
        Me.btn2.TabIndex = 2
        Me.btn2.TabStop = False
        Me.btn2.Tag = "2"
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn3.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(468, 342)
        Me.btn3.Margin = New System.Windows.Forms.Padding(4)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(147, 113)
        Me.btn3.TabIndex = 3
        Me.btn3.TabStop = False
        Me.btn3.Tag = "3"
        Me.btn3.Text = "4"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LawnGreen
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatAppearance.BorderSize = 0
        Me.btnStart.Font = New System.Drawing.Font("Agency FB", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(16, 506)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(203, 124)
        Me.btnStart.TabIndex = 4
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.Color.DarkOrange
        Me.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestart.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(520, 587)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(116, 43)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.TabStop = False
        Me.btnRestart.Text = "&Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Gold
        Me.btnPause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPause.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPause.Location = New System.Drawing.Point(644, 587)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(116, 43)
        Me.btnPause.TabIndex = 6
        Me.btnPause.TabStop = False
        Me.btnPause.Text = "&Pause"
        Me.btnPause.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(768, 587)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 43)
        Me.btnExit.TabIndex = 7
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Azure
        Me.lblTimer.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.Location = New System.Drawing.Point(13, 110)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(94, 49)
        Me.lblTimer.TabIndex = 8
        Me.lblTimer.Text = "0:30"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Azure
        Me.lblScore.Font = New System.Drawing.Font("Agency FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(768, 110)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(116, 57)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0 / 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer
        '
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.White
        Me.lblQuestion.Font = New System.Drawing.Font("Agency FB", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblQuestion.Location = New System.Drawing.Point(154, 9)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(606, 71)
        Me.lblQuestion.TabIndex = 10
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(897, 643)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn0)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ultimate Math Challenges"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn0 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents timer As Timer
    Friend WithEvents lblQuestion As Label
End Class
