Public Class MainWnd

  Private Declare Function SetThreadExecutionState Lib "kernel32" (ByVal esFlags As Integer) As Long

  Enum EXECUTION_STATE As Integer
    ES_AWAYMODE_REQUIRED = &H40
    ES_CONTINUOUS = &H80000000
    ES_DISPLAY_REQUIRED = &H2
    ES_SYSTEM_REQUIRED = &H1
  End Enum


  Private Sub btnOn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOn.Click
    btnOn.Enabled = False
    btnOff.Enabled = True
    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS)
  End Sub

  Private Sub btnOff_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOff.Click
    btnOn.Enabled = True
    btnOff.Enabled = False
    SetThreadExecutionState(EXECUTION_STATE.ES_DISPLAY_REQUIRED Or EXECUTION_STATE.ES_CONTINUOUS)
  End Sub

End Class
