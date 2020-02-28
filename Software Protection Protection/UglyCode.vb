'Ghost Anti-Process
'Repetitive Code/Form Functions

Partial Class GhostAntiProcess
    Private Sub PowerModeChanged(ByVal sender As System.Object, ByVal e As Microsoft.Win32.PowerModeChangedEventArgs)
        Select Case e.Mode
            Case Microsoft.Win32.PowerModes.Suspend 'Windows is going to sleep
                ConsoleLog("Going to sleep... Goodnight!")
            Case Microsoft.Win32.PowerModes.Resume 'Windows is resuming from sleep
                ConsoleLog(DateTime.Now.ToString("dddd, MMMM d, yyyy"))
                ConsoleLog("Waking up from sleep! Good Morning!")
        End Select
    End Sub

    Private Sub SessionEnding(ByVal sender As System.Object, ByVal e As Microsoft.Win32.SessionEndingEventArgs)
        Select Case e.Reason
            Case Microsoft.Win32.SessionEndReasons.Logoff 'Windows is logging off curr user
                ConsoleLog("User Logoff. Goodbye!")
                Close()
            Case Microsoft.Win32.SessionEndReasons.SystemShutdown 'Windows is shutting down
                ConsoleLog("System Shutdown. Goodbye!")
                Close()
        End Select
    End Sub

    Private Sub SettingCheck_Tick(sender As Object, e As EventArgs) Handles SettingCheck.Tick
        If My.Settings.IsHidden = "Yes" Then
            Hide()
            ConsoleLog("Hiding to tray...")
        End If
        SettingCheck.Stop()
    End Sub

    Private Sub MSPPProtector_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MouseDownEvents(e)
    End Sub

    Private Sub MSPPProtector_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseMoveEvents(e)
    End Sub

    Private Sub MainParagraph_MouseDown(sender As Object, e As MouseEventArgs) Handles MainParagraph.MouseDown
        MouseDownEvents(e)
    End Sub

    Private Sub MainParagraph_MouseMove(sender As Object, e As MouseEventArgs) Handles MainParagraph.MouseMove
        MouseMoveEvents(e)
    End Sub

    Private Sub Header_MouseDown(sender As Object, e As MouseEventArgs) Handles Header.MouseDown
        MouseDownEvents(e)
    End Sub

    Private Sub Header_MouseMove(sender As Object, e As MouseEventArgs) Handles Header.MouseMove
        MouseMoveEvents(e)
    End Sub

    Private Sub LogGroupBox_MouseDown(sender As Object, e As MouseEventArgs) Handles LogGroupBox.MouseDown
        MouseDownEvents(e)
    End Sub

    Private Sub LogGroupBox_MouseMove(sender As Object, e As MouseEventArgs) Handles LogGroupBox.MouseMove
        MouseMoveEvents(e)
    End Sub
End Class