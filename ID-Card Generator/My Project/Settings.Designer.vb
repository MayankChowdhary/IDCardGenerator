﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS\SQLEXPRESS;AttachDbFilename=|DataDirectory|\IdCard_DB.md"& _ 
            "f;Integrated Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString() As String
            Get
                Return CType(Me("IdCard_DBConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS\SQLEXPRESS;AttachDbFilename=D:\IDcard_Generator\IdCard_D"& _ 
            "B.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString1() As String
            Get
                Return CType(Me("IdCard_DBConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS\MSSQLSERVER2;AttachDbFilename=|DataDirectory|\IdCard_DB."& _ 
            "mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString2() As String
            Get
                Return CType(Me("IdCard_DBConnectionString2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS\MYSQL_SERVER;AttachDbFilename=|DataDirectory|\IdCard_DB."& _ 
            "mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString3() As String
            Get
                Return CType(Me("IdCard_DBConnectionString3"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\IDcard_Generator\IdCard_DB.mdf;Integ"& _ 
            "rated Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString4() As String
            Get
                Return CType(Me("IdCard_DBConnectionString4"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\IdCard_DB.mdf;Integrate"& _ 
            "d Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IdCard_DBConnectionString5() As String
            Get
                Return CType(Me("IdCard_DBConnectionString5"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\ID_Card_DBN.mdf;Integra"& _ 
            "ted Security=True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property ID_Card_DBNConnectionString() As String
            Get
                Return CType(Me("ID_Card_DBNConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=.;AttachDbFilename=|DataDirectory|\IDCard_DB.mdf;Integrated Security="& _ 
            "True;Connect Timeout=30;User Instance=True")>  _
        Public ReadOnly Property IDCard_DBConnectionString6() As String
            Get
                Return CType(Me("IDCard_DBConnectionString6"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WindowsApplication1.My.MySettings
            Get
                Return Global.WindowsApplication1.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace