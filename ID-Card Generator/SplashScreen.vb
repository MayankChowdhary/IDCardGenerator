Imports System.Deployment.Application
Imports Microsoft.Win32
Imports System.IO

Public Class SplashScreen

    Private Sub SplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Version.Text = "Version   " + My.Application.Info.Version.ToString
        Me.CenterToScreen()
        Timer1.Enabled = True
       
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            SetAddRemoveProgramsIcon()
        End If
        Label3.Left = 354

    End Sub
    Sub SetAddRemoveProgramsIcon()
        Try
            'only run if deployed 
            If ApplicationDeployment.IsNetworkDeployed And ApplicationDeployment.CurrentDeployment.IsFirstRun Then

                Dim iconSourcePath As String = System.IO.Path.Combine(Application.StartupPath, "User.ico")

                If Not File.Exists(iconSourcePath) Then
                    Return
                End If

                Dim myUninstallKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Uninstall")
                Dim mySubKeyNames As String() = myUninstallKey.GetSubKeyNames()

                Dim i As Integer
                For i = 0 To mySubKeyNames.Length

                    Dim myKey As RegistryKey = myUninstallKey.OpenSubKey(mySubKeyNames(i), True)
                    Dim registryAppName As Object = myKey.GetValue("DisplayName")
                    Dim registryAppVersion As Object = myKey.GetValue("DisplayVersion")
                    If registryAppName <> Nothing And registryAppVersion <> Nothing And
                        registryAppName.ToString().StartsWith(Application.ProductName) And
                        registryAppVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() Then

                        myKey.SetValue("DisplayIcon", iconSourcePath)
                        Exit For

                    End If
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Function Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Delegate Sub SetProgressBarDelegate(ByVal max As Integer)
    Public Delegate Sub UpdateProgressBarDelegate(ByVal value As Integer)
    Public Delegate Sub SetLabelStatusDelegate(ByVal status As String)
    Public Delegate Sub SetProgressColorDelegate(ByVal color As String)
    Public Sub BarLong(ByVal MemCount As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New SetProgressBarDelegate(AddressOf BarLong), MemCount)
        Else
            Me.ProgressBar1.Maximum = MemCount
        End If
    End Sub

    Public Sub ShowBar(ByVal SoFar As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New UpdateProgressBarDelegate(AddressOf ShowBar), SoFar)
        Else
            Me.ProgressBar1.Value = SoFar
        End If
    End Sub

    Public Sub SetStatus(ByVal status As String)
        If Me.InvokeRequired Then
            Me.Invoke(New SetLabelStatusDelegate(AddressOf SetStatus), status)
        Else
            Me.Label2.Text = status
        End If
    End Sub

    Public Sub SetColor(ByVal color As String)
        If Me.InvokeRequired Then
            Me.Invoke(New SetProgressColorDelegate(AddressOf SetColor), color)
        Else
            Me.ProgressBar1.ForeColor = Drawing.Color.FromName(color)
        End If
    End Sub

    
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1

        Label3.Left = Label3.Left - 2
        If Label3.Left < 0 - Label3.Width Then
            Label3.Left = Me.Width
        End If

    End Sub

End Class