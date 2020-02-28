Partial Class GhostAntiProcess
    Dim X1 As Integer
    Dim Y1 As Integer
    Dim WR As Rectangle

    'Handle the elements that you can use to click and drag the window, and also handles snapping to the edges of the main screen and top and bottom of the other screens.
    Function MouseDownEvents(ByVal e As MouseEventArgs) As MouseEventArgs 'When the mouse is down...
        X1 = e.X
        Y1 = e.Y
        WR = Screen.GetWorkingArea(Me)
        Return e
    End Function

    Function MouseMoveEvents(ByVal e As MouseEventArgs) As MouseEventArgs 'When the mouse moves...
        If Not e.Button = Windows.Forms.MouseButtons.Left Then Return e
        Dim NewX As Integer = Me.Left + (e.X - X1)
        Dim NewY As Integer = Me.Top + (e.Y - Y1)
        Dim W As Integer = Me.Width
        Dim H As Integer = Me.Height
        If NewY >= WR.Top - 15 And NewY <= WR.Top + 15 Then
            Me.Top = WR.Top
        ElseIf NewY + H > WR.Bottom - 15 And NewY + H < WR.Bottom + 15 Then
            Me.Top = WR.Bottom - H
        Else
            Me.Top = NewY
        End If
        If NewX >= WR.Left - 15 And NewX <= WR.Left + 15 Then
            Me.Left = WR.Left
        ElseIf NewX + W > WR.Right - 15 And NewX + W < WR.Right + 15 Then
            Me.Left = WR.Right - W
        Else
            Me.Left = NewX
        End If
        Return e
    End Function

    'Give the borders a curve by a set amount, passed when calling the function
    Function CurveBorder(ByVal curve As Integer) As Integer
        Dim p As New Drawing2D.GraphicsPath
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, curve, curve), 180, 90)
        p.AddLine(curve, 0, Width - curve, 0)
        p.AddArc(New Rectangle(Width - curve, 0, curve, curve), -90, 90)
        p.AddLine(Width, curve, Width, Height - curve)
        p.AddArc(New Rectangle(Width - curve, Height - curve, curve, curve), 0, 90)
        p.AddLine(Width - curve, Height, curve, Height)
        p.AddArc(New Rectangle(0, Height - curve, curve, curve), 90, 90)
        p.CloseFigure()
        Region = New Region(p)
        Return True
    End Function

    Private Sub HideShowLogButton_Click(sender As Object, e As EventArgs) Handles HideShowLogButton.Click
        If HideShowLogButton.Text = "Hide Log" Then
            ShrinkForm(283)
        ElseIf HideShowLogButton.Text = "Show Log" Then
            GrowForm(594)
        Else
            ConsoleLog("Critical error: showing/hiding the log. Button state mismatch?")
        End If
    End Sub

    Function GrowForm(ByVal NewWidth As Integer) As Integer
        Do Until Width = NewWidth
            Size = New Size(Width + 1, Height)
            HideShowLogButton.Enabled = False
        Loop
        CurveBorder(20)
        HideShowLogButton.Text = "Hide Log"
        HideShowLogButton.Enabled = True
        ConsoleLog("Log Revealed!")
        Return Width
    End Function

    Function ShrinkForm(ByVal NewWidth As Integer) As Integer
        Do Until Width = NewWidth
            Size = New Size(Width - 1, Height)
            HideShowLogButton.Enabled = False
        Loop
        CurveBorder(20)
        HideShowLogButton.Text = "Show Log"
        HideShowLogButton.Enabled = True
        ConsoleLog("Log Hidden!")
        Return Width
    End Function

    '=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=

    Private Sub DevLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DevLink.LinkClicked
        Process.Start("https://LazySmurf.net")
    End Sub

    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        My.Settings.IsHidden = "Yes"
        Hide()
    End Sub

    Private Sub TrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        If e.Button = MouseButtons.Right Then
            Close()
        Else
            My.Settings.IsHidden = "No"
            Show()
        End If
    End Sub

    Private Sub TopMostCheck_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostCheck.CheckedChanged
        If TopMostCheck.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    'Handle the minimize and exit buttons in a borderless form
    Private Sub ExitNormal_MouseEnter(sender As Object, e As EventArgs) Handles ExitNormal.MouseEnter
        ExitNormal.Visible = False
        ExitHover.Visible = True
    End Sub

    Private Sub ExitHover_MouseLeave(sender As Object, e As EventArgs) Handles ExitHover.MouseLeave
        ExitNormal.Visible = True
        ExitHover.Visible = False
    End Sub

    Private Sub ExitHover_Click(sender As Object, e As EventArgs) Handles ExitHover.Click
        Close()
    End Sub

    Private Sub MinNormal_MouseEnter(sender As Object, e As EventArgs) Handles MinNormal.MouseEnter
        MinNormal.Visible = False
        MinHover.Visible = True
    End Sub

    Private Sub MinHover_MouseLeave(sender As Object, e As EventArgs) Handles MinHover.MouseLeave
        MinNormal.Visible = True
        MinHover.Visible = False
    End Sub

    Private Sub MinHover_Click(sender As Object, e As EventArgs) Handles MinHover.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class