<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.AmplifierResistanceText = New System.Windows.Forms.TextBox()
		Me.SpeakerVoltageText = New System.Windows.Forms.TextBox()
		Me.SpeakerResistanceText = New System.Windows.Forms.TextBox()
		Me.TurnRatioUpDwn = New System.Windows.Forms.NumericUpDown()
		Me.PowerLabel = New System.Windows.Forms.Label()
		Me.ResetButton = New System.Windows.Forms.Button()
		Me.MaxAmplifierResistanceLabel = New System.Windows.Forms.Label()
		Me.MaxSpeakerVoltageLabel = New System.Windows.Forms.Label()
		Me.MaxSpeakerResistanceLabel = New System.Windows.Forms.Label()
		Me.MaxPowerLabel = New System.Windows.Forms.Label()
		Me.CalculateButton = New System.Windows.Forms.Button()
		CType(Me.TurnRatioUpDwn, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'AmplifierResistanceText
		'
		Me.AmplifierResistanceText.Location = New System.Drawing.Point(72, 12)
		Me.AmplifierResistanceText.Name = "AmplifierResistanceText"
		Me.AmplifierResistanceText.Size = New System.Drawing.Size(100, 20)
		Me.AmplifierResistanceText.TabIndex = 0
		'
		'SpeakerVoltageText
		'
		Me.SpeakerVoltageText.Location = New System.Drawing.Point(72, 42)
		Me.SpeakerVoltageText.Name = "SpeakerVoltageText"
		Me.SpeakerVoltageText.Size = New System.Drawing.Size(100, 20)
		Me.SpeakerVoltageText.TabIndex = 1
		'
		'SpeakerResistanceText
		'
		Me.SpeakerResistanceText.Location = New System.Drawing.Point(72, 72)
		Me.SpeakerResistanceText.Name = "SpeakerResistanceText"
		Me.SpeakerResistanceText.Size = New System.Drawing.Size(100, 20)
		Me.SpeakerResistanceText.TabIndex = 2
		'
		'TurnRatioUpDwn
		'
		Me.TurnRatioUpDwn.DecimalPlaces = 2
		Me.TurnRatioUpDwn.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.TurnRatioUpDwn.Location = New System.Drawing.Point(162, 131)
		Me.TurnRatioUpDwn.Maximum = New Decimal(New Integer() {20, 0, 0, 65536})
		Me.TurnRatioUpDwn.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.TurnRatioUpDwn.Name = "TurnRatioUpDwn"
		Me.TurnRatioUpDwn.Size = New System.Drawing.Size(48, 20)
		Me.TurnRatioUpDwn.TabIndex = 3
		Me.TurnRatioUpDwn.Value = New Decimal(New Integer() {1, 0, 0, 131072})
		'
		'PowerLabel
		'
		Me.PowerLabel.AutoSize = True
		Me.PowerLabel.Location = New System.Drawing.Point(69, 100)
		Me.PowerLabel.Name = "PowerLabel"
		Me.PowerLabel.Size = New System.Drawing.Size(0, 13)
		Me.PowerLabel.TabIndex = 4
		'
		'ResetButton
		'
		Me.ResetButton.Location = New System.Drawing.Point(72, 131)
		Me.ResetButton.Name = "ResetButton"
		Me.ResetButton.Size = New System.Drawing.Size(75, 25)
		Me.ResetButton.TabIndex = 6
		Me.ResetButton.Text = "Reset"
		Me.ResetButton.UseVisualStyleBackColor = True
		'
		'MaxAmplifierResistanceLabel
		'
		Me.MaxAmplifierResistanceLabel.AutoSize = True
		Me.MaxAmplifierResistanceLabel.Location = New System.Drawing.Point(178, 12)
		Me.MaxAmplifierResistanceLabel.Name = "MaxAmplifierResistanceLabel"
		Me.MaxAmplifierResistanceLabel.Size = New System.Drawing.Size(102, 13)
		Me.MaxAmplifierResistanceLabel.TabIndex = 7
		Me.MaxAmplifierResistanceLabel.Text = "Amplifier Resistance"
		'
		'MaxSpeakerVoltageLabel
		'
		Me.MaxSpeakerVoltageLabel.AutoSize = True
		Me.MaxSpeakerVoltageLabel.Location = New System.Drawing.Point(178, 42)
		Me.MaxSpeakerVoltageLabel.Name = "MaxSpeakerVoltageLabel"
		Me.MaxSpeakerVoltageLabel.Size = New System.Drawing.Size(86, 13)
		Me.MaxSpeakerVoltageLabel.TabIndex = 8
		Me.MaxSpeakerVoltageLabel.Text = "Speaker Voltage"
		'
		'MaxSpeakerResistanceLabel
		'
		Me.MaxSpeakerResistanceLabel.AutoSize = True
		Me.MaxSpeakerResistanceLabel.Location = New System.Drawing.Point(178, 72)
		Me.MaxSpeakerResistanceLabel.Name = "MaxSpeakerResistanceLabel"
		Me.MaxSpeakerResistanceLabel.Size = New System.Drawing.Size(103, 13)
		Me.MaxSpeakerResistanceLabel.TabIndex = 9
		Me.MaxSpeakerResistanceLabel.Text = "Speaker Resistance"
		'
		'MaxPowerLabel
		'
		Me.MaxPowerLabel.AutoSize = True
		Me.MaxPowerLabel.Location = New System.Drawing.Point(200, 100)
		Me.MaxPowerLabel.Name = "MaxPowerLabel"
		Me.MaxPowerLabel.Size = New System.Drawing.Size(0, 13)
		Me.MaxPowerLabel.TabIndex = 10
		'
		'CalculateButton
		'
		Me.CalculateButton.Location = New System.Drawing.Point(221, 131)
		Me.CalculateButton.Name = "CalculateButton"
		Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
		Me.CalculateButton.TabIndex = 11
		Me.CalculateButton.Text = "Calculate"
		Me.CalculateButton.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AcceptButton = Me.CalculateButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(378, 184)
		Me.Controls.Add(Me.CalculateButton)
		Me.Controls.Add(Me.MaxPowerLabel)
		Me.Controls.Add(Me.MaxSpeakerResistanceLabel)
		Me.Controls.Add(Me.MaxSpeakerVoltageLabel)
		Me.Controls.Add(Me.MaxAmplifierResistanceLabel)
		Me.Controls.Add(Me.ResetButton)
		Me.Controls.Add(Me.PowerLabel)
		Me.Controls.Add(Me.TurnRatioUpDwn)
		Me.Controls.Add(Me.SpeakerResistanceText)
		Me.Controls.Add(Me.SpeakerVoltageText)
		Me.Controls.Add(Me.AmplifierResistanceText)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Max Power Calculater"
		CType(Me.TurnRatioUpDwn, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents AmplifierResistanceText As System.Windows.Forms.TextBox
    Friend WithEvents SpeakerVoltageText As System.Windows.Forms.TextBox
    Friend WithEvents SpeakerResistanceText As System.Windows.Forms.TextBox
    Friend WithEvents TurnRatioUpDwn As System.Windows.Forms.NumericUpDown
    Friend WithEvents PowerLabel As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents MaxAmplifierResistanceLabel As System.Windows.Forms.Label
    Friend WithEvents MaxSpeakerVoltageLabel As System.Windows.Forms.Label
    Friend WithEvents MaxSpeakerResistanceLabel As System.Windows.Forms.Label
    Friend WithEvents MaxPowerLabel As System.Windows.Forms.Label
	Friend WithEvents CalculateButton As System.Windows.Forms.Button
End Class
