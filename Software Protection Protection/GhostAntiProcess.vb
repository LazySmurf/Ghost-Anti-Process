Imports System.ComponentModel
Imports System.IO

Public Class GhostAntiProcess
    Private Sub GhostAntiProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsoleLog(DateTime.Now.ToString("dddd, MMMM d, yyyy"))
        SettingCheck.Start()
        CurveBorder(20)
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)

        'Check for Logs folder, and if there isn't one, create it.
        If Not Directory.Exists(Directory.GetCurrentDirectory.ToString & "\Logs") Then
            ConsoleLog("Attempting to create directory for log files...")
            ConsoleLog("Creating: " & Directory.GetCurrentDirectory.ToString & "\Logs\")
            Directory.CreateDirectory(Directory.GetCurrentDirectory.ToString & "\Logs")
            ConsoleLog("Done! Begin logging...")
        Else
            ConsoleLog("Logging to " & Directory.GetCurrentDirectory.ToString & "\Logs\")
        End If


        ConsoleLog("Process Kill Interval: " & SearchAndDestroy.Interval.ToString & "ms")
        ConsoleLog("Loading Complete!")

        AddHandler Microsoft.Win32.SystemEvents.PowerModeChanged, AddressOf PowerModeChanged 'Handle going to sleep and waking up
        AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf SessionEnding 'Handle logging off and shutting down

        If My.Settings.SearchIndex = True Then
            SearchIndexCheck.Checked = True
        End If
        If My.Settings.SearchFilterHost = True Then
            SearchFilterHostCheck.Checked = True
        End If
        If My.Settings.SearchUI = True Then
            SearchUICheck.Checked = True
        End If
        If My.Settings.SystemSettings = True Then
            SettingsCheck.Checked = True
        End If
        If My.Settings.KMSService = True Then
            KMSCheck.Checked = True
        End If
        If My.Settings.PhotosApp = True Then
            PhotosCheck.Checked = True
        End If
    End Sub

    Private Sub GhostAntiProcess_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ConsoleLog("Closing! Saving log...")
        File.WriteAllText(Directory.GetCurrentDirectory.ToString & "\Logs\" & DateTime.Now.ToString("dddd, MMMM d, yyyy \a\t h-mm-ss tt") & ".txt", LogBox.Text.ToString)
        TrayIcon.Dispose()
        My.Settings.Save()
    End Sub

    Private Sub SearchAndDestroy_Tick(sender As Object, e As EventArgs) Handles SearchAndDestroy.Tick
        Dim CurrProc As String = ""
        Try 'Start searching and destroying
            For Each Target As Process In Process.GetProcesses

                If Target.ProcessName = "sppsvc" Then 'If Microsoft Software Protection Platform -- Always kill this evil process.
                    CurrProc = "sppsvc.exe"
                    Target.Kill()
                    ConsoleLog("sppsvc.exe killed!")
                End If

                If SearchIndexCheck.Checked = True Then
                    If Target.ProcessName = "SearchIndexer" Then 'If Windows Search Indexer
                        CurrProc = "SearchIndexer.exe"
                        Target.Kill()
                        ConsoleLog("SearchIndexer.exe killed!")
                    End If
                    My.Settings.SearchIndex = True
                Else
                    My.Settings.SearchIndex = False
                End If

                If SearchFilterHostCheck.Checked = True Then
                    If Target.ProcessName = "SearchFilterHost" Then 'If Windows Search Filter Host
                        CurrProc = "SearchFilterHost.exe"
                        Target.Kill()
                        ConsoleLog("SearchFilterHost.exe killed!")
                    End If
                    My.Settings.SearchFilterHost = True
                Else
                    My.Settings.SearchFilterHost = False
                End If

                If SettingsCheck.Checked = True Then
                    If Target.ProcessName = "SystemSettings" Then 'If System Settings App
                        CurrProc = "SystemSettings.exe"
                        Target.Kill()
                        ConsoleLog("SystemSettings.exe killed!")
                    End If
                    My.Settings.SystemSettings = True
                Else
                    My.Settings.SystemSettings = False
                End If

                If SearchUICheck.Checked = True Then
                    If Target.ProcessName = "SearchUI" Then 'If Cortana process
                        CurrProc = "SearchUI.exe"
                        Target.Kill()
                        ConsoleLog("SearchUI.exe killed!")
                    End If
                    My.Settings.SearchUI = True
                Else
                    My.Settings.SearchUI = False
                End If

                If PhotosCheck.Checked = True Then
                    If Target.ProcessName = "Microsoft.Photos" Then 'If some unnecessary service
                        CurrProc = "Microsoft.Photos.exe"
                        Target.Kill()
                        ConsoleLog("Microsoft.Photos.exe killed!")
                    End If
                    My.Settings.PhotosApp = True
                Else
                    My.Settings.PhotosApp = False
                End If

                If KMSCheck.Checked = True Then
                    If Target.ProcessName = "KMS Server Service" Then 'If KMS Service
                        CurrProc = "KMS Server Service.exe"
                        Target.Kill()
                        ConsoleLog("KMS Server Service.exe killed!")
                    End If
                    My.Settings.KMSService = True
                Else
                    My.Settings.KMSService = False
                End If

                '```````````````````````````````````````````````````````````````````````'

                If Target.ProcessName = "YourPhone" Then 'If Windows Your Phone Mobile service
                    CurrProc = "YourPhone.exe"
                    Target.Kill()
                    ConsoleLog("YourPhone.exe killed!")
                End If

                If Target.ProcessName = "ZeroConfigService" Then 'If Windows PnP Zero Configuration Service
                    CurrProc = "ZeroConfigService.exe"
                    Target.Kill()
                    ConsoleLog("ZeroConfigService.exe killed!")
                End If

                If Target.ProcessName = "WmiPrvSE" Then 'If Windows Management Instrumentation Provider Service that performs "essential error reporting and monitoring functions"
                    CurrProc = "WmiPrvSE.exe"
                    Target.Kill()
                    ConsoleLog("WmiPrvSE.exe killed!")
                End If

                If Target.ProcessName = "ctfmon" Then 'If some unnecessary service for Office Suite toolbars lmao what
                    CurrProc = "ctfmon.exe"
                    Target.Kill()
                    ConsoleLog("ctfmon.exe killed!")
                End If

                If Target.ProcessName = "SettingSyncHost" Then 'If some unnecessary service to sync settings that most people don't use
                    CurrProc = "SettingSyncHost.exe"
                    Target.Kill()
                    ConsoleLog("SettingSyncHost.exe killed!")
                End If

                If Target.ProcessName = "backgroundTaskHost" Then 'If some unnecessary Windows service
                    CurrProc = "backgroundTaskHost.exe"
                    Target.Kill()
                    ConsoleLog("backgroundTaskHost.exe killed!")
                End If

                If Target.ProcessName = "LogiRegistryService" Then 'If logitech gaming driver registry service
                    CurrProc = "LogiRegistryService.exe"
                    Target.Kill()
                    ConsoleLog("LogiRegistryService.exe killed!")
                End If

                If Target.ProcessName = "GameBar" Then 'If Windows Game Bar (Game Mode)
                    CurrProc = "GameBar.exe"
                    Target.Kill()
                    ConsoleLog("GameBar.exe killed!")
                End If

                If Target.ProcessName = "AAM Updates Notifier" Then 'If Adobe Updates Notifier
                    CurrProc = "AAM Updates Notifier.exe"
                    Target.Kill()
                    ConsoleLog("AAM Updates Notifier.exe killed!")
                End If

            Next
        Catch ex As Exception
            ConsoleLog("Failed to end task: " & CurrProc)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Close()
    End Sub

    'Handles logging application events to the log window
    Function ConsoleLog(ByVal Message As String) As String
        If LogBox.TextLength = 0 Then
            LogBox.AppendText(DateTime.Now.ToString("[h:mm:ss tt] ") & Message)
        Else
            LogBox.AppendText(vbNewLine & DateTime.Now.ToString("[h:mm:ss tt] ") & Message)
        End If
        Return True
    End Function

    Private Sub CheckTime_Tick(sender As Object, e As EventArgs) Handles CheckTime.Tick
        If Now.ToLongTimeString.ToString() = "12:00:00 AM" Then
            ConsoleLog(DateTime.Now.ToString("dddd, MMMM d, yyyy"))
        End If
    End Sub
End Class