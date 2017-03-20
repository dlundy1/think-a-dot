<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Left_Button = New System.Windows.Forms.Button()
        Me.Middle_Button = New System.Windows.Forms.Button()
        Me.Right_Button = New System.Windows.Forms.Button()
        Me.Reset_Button = New System.Windows.Forms.Button()
        Me.Flipper1 = New My_Think_a_Dot.Flipper()
        Me.Flipper2 = New My_Think_a_Dot.Flipper()
        Me.Flipper3 = New My_Think_a_Dot.Flipper()
        Me.Flipper4 = New My_Think_a_Dot.Flipper()
        Me.Flipper5 = New My_Think_a_Dot.Flipper()
        Me.Flipper7 = New My_Think_a_Dot.Flipper()
        Me.Flipper8 = New My_Think_a_Dot.Flipper()
        Me.Flipper6 = New My_Think_a_Dot.Flipper()
        Me.SuspendLayout()
        '
        'Left_Button
        '
        Me.Left_Button.Location = New System.Drawing.Point(118, 36)
        Me.Left_Button.Name = "Left_Button"
        Me.Left_Button.Size = New System.Drawing.Size(62, 22)
        Me.Left_Button.TabIndex = 0
        Me.Left_Button.Text = "Left"
        Me.Left_Button.UseVisualStyleBackColor = True
        '
        'Middle_Button
        '
        Me.Middle_Button.Location = New System.Drawing.Point(239, 36)
        Me.Middle_Button.Name = "Middle_Button"
        Me.Middle_Button.Size = New System.Drawing.Size(62, 22)
        Me.Middle_Button.TabIndex = 1
        Me.Middle_Button.Text = "Middle"
        Me.Middle_Button.UseVisualStyleBackColor = True
        '
        'Right_Button
        '
        Me.Right_Button.Location = New System.Drawing.Point(357, 36)
        Me.Right_Button.Name = "Right_Button"
        Me.Right_Button.Size = New System.Drawing.Size(62, 22)
        Me.Right_Button.TabIndex = 2
        Me.Right_Button.Text = "Right"
        Me.Right_Button.UseVisualStyleBackColor = True
        '
        'Reset_Button
        '
        Me.Reset_Button.Location = New System.Drawing.Point(234, 351)
        Me.Reset_Button.Name = "Reset_Button"
        Me.Reset_Button.Size = New System.Drawing.Size(62, 22)
        Me.Reset_Button.TabIndex = 3
        Me.Reset_Button.Text = "RESET"
        Me.Reset_Button.UseVisualStyleBackColor = True
        '
        'Flipper1
        '
        Me.Flipper1.BackColor = System.Drawing.Color.Transparent
        Me.Flipper1.Location = New System.Drawing.Point(118, 85)
        Me.Flipper1.Name = "Flipper1"
        Me.Flipper1.Size = New System.Drawing.Size(34, 34)
        Me.Flipper1.TabIndex = 4
        '
        'Flipper2
        '
        Me.Flipper2.BackColor = System.Drawing.Color.Transparent
        Me.Flipper2.Location = New System.Drawing.Point(245, 85)
        Me.Flipper2.Name = "Flipper2"
        Me.Flipper2.Size = New System.Drawing.Size(34, 34)
        Me.Flipper2.TabIndex = 5
        '
        'Flipper3
        '
        Me.Flipper3.BackColor = System.Drawing.Color.Transparent
        Me.Flipper3.Location = New System.Drawing.Point(371, 85)
        Me.Flipper3.Name = "Flipper3"
        Me.Flipper3.Size = New System.Drawing.Size(34, 34)
        Me.Flipper3.TabIndex = 6
        '
        'Flipper4
        '
        Me.Flipper4.BackColor = System.Drawing.Color.Transparent
        Me.Flipper4.Location = New System.Drawing.Point(181, 168)
        Me.Flipper4.Name = "Flipper4"
        Me.Flipper4.Size = New System.Drawing.Size(34, 34)
        Me.Flipper4.TabIndex = 9
        '
        'Flipper5
        '
        Me.Flipper5.BackColor = System.Drawing.Color.Transparent
        Me.Flipper5.Location = New System.Drawing.Point(308, 168)
        Me.Flipper5.Name = "Flipper5"
        Me.Flipper5.Size = New System.Drawing.Size(34, 34)
        Me.Flipper5.TabIndex = 8
        '
        'Flipper7
        '
        Me.Flipper7.BackColor = System.Drawing.Color.Transparent
        Me.Flipper7.Location = New System.Drawing.Point(245, 249)
        Me.Flipper7.Name = "Flipper7"
        Me.Flipper7.Size = New System.Drawing.Size(34, 34)
        Me.Flipper7.TabIndex = 12
        '
        'Flipper8
        '
        Me.Flipper8.BackColor = System.Drawing.Color.Transparent
        Me.Flipper8.Location = New System.Drawing.Point(371, 249)
        Me.Flipper8.Name = "Flipper8"
        Me.Flipper8.Size = New System.Drawing.Size(34, 34)
        Me.Flipper8.TabIndex = 11
        '
        'Flipper6
        '
        Me.Flipper6.BackColor = System.Drawing.Color.Transparent
        Me.Flipper6.Location = New System.Drawing.Point(118, 249)
        Me.Flipper6.Name = "Flipper6"
        Me.Flipper6.Size = New System.Drawing.Size(34, 34)
        Me.Flipper6.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 442)
        Me.Controls.Add(Me.Flipper7)
        Me.Controls.Add(Me.Flipper8)
        Me.Controls.Add(Me.Flipper6)
        Me.Controls.Add(Me.Flipper4)
        Me.Controls.Add(Me.Flipper5)
        Me.Controls.Add(Me.Flipper3)
        Me.Controls.Add(Me.Flipper2)
        Me.Controls.Add(Me.Flipper1)
        Me.Controls.Add(Me.Reset_Button)
        Me.Controls.Add(Me.Right_Button)
        Me.Controls.Add(Me.Middle_Button)
        Me.Controls.Add(Me.Left_Button)
        Me.Name = "Form1"
        Me.Text = "ThinkADot"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Left_Button As Button
    Friend WithEvents Middle_Button As Button
    Friend WithEvents Right_Button As Button
    Friend WithEvents Reset_Button As Button
    Friend WithEvents Flipper1 As Flipper
    Friend WithEvents Flipper2 As Flipper
    Friend WithEvents Flipper3 As Flipper
    Friend WithEvents Flipper4 As Flipper
    Friend WithEvents Flipper5 As Flipper
    Friend WithEvents Flipper7 As Flipper
    Friend WithEvents Flipper8 As Flipper
    Friend WithEvents Flipper6 As Flipper
End Class
