Option Infer On
Option Strict On
Option Explicit On
Option Compare Binary
Imports System

Public Class Form1
	Const LoadTimeAmplifierRestistance As Double = 20
	Const LoadTimeSpeakerVoltage As Double = 40
	Const LoadTimeSpeakerResistance As Double = 8
	Const LoadTimeTurnRatio As Decimal = 0.01D
	Const Squared As Integer = 2

	Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
		Me.AmplifierResistanceText.Text = LoadTimeAmplifierRestistance.ToString
		Me.SpeakerVoltageText.Text = LoadTimeSpeakerVoltage.ToString
		Me.SpeakerResistanceText.Text = LoadTimeSpeakerResistance.ToString
		ResetButton.PerformClick()
	End Sub

	Private Sub CalculatePower(sender As Object, e As System.EventArgs)

		Dim amplifierResistance As Double = LoadTimeAmplifierRestistance
		Double.TryParse(Me.AmplifierResistanceText.Text, amplifierResistance)

		Dim speakerVoltage As Double = LoadTimeSpeakerVoltage
		Double.TryParse(Me.SpeakerVoltageText.Text, speakerVoltage)

		Dim speakerResistance As Double = LoadTimeSpeakerResistance
		Double.TryParse(Me.SpeakerResistanceText.Text, speakerResistance)

		Dim turnRatio As Double = TurnRatioUpDwn.Value

		Dim power As Double = speakerResistance * (turnRatio * speakerVoltage /
												   ((turnRatio ^ Squared) * amplifierResistance + speakerResistance)) ^ Squared
		Me.PowerLabel.Text = String.Format("The Power is {0}", System.Math.Round(power, Squared, System.MidpointRounding.AwayFromZero).ToString)

	End Sub

	Private Sub Reset_Click(sender As Object, e As System.EventArgs) Handles ResetButton.Click
		Me.TurnRatioUpDwn.Value = LoadTimeTurnRatio
		Me.AmplifierResistanceText.Text = LoadTimeAmplifierRestistance.ToString
		Me.SpeakerVoltageText.Text = LoadTimeSpeakerVoltage.ToString
		Me.SpeakerResistanceText.Text = LoadTimeSpeakerResistance.ToString
		Me.PowerLabel.Text = String.Empty
	End Sub

	Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
		CalculatePower(sender, e)
	End Sub
	Private Sub TurnRatioUpDwn_Changed(sender As Object, e As EventArgs) Handles TurnRatioUpDwn.ValueChanged
		CalculatePower(sender, e)
	End Sub
End Class
