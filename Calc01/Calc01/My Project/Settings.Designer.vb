﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings 自動保存機能"
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
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ShowMenu() As Boolean
            Get
                Return CType(Me("ShowMenu"),Boolean)
            End Get
            Set
                Me("ShowMenu") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100, 100")>  _
        Public Property Location() As Global.System.Drawing.Point
            Get
                Return CType(Me("Location"),Global.System.Drawing.Point)
            End Get
            Set
                Me("Location") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("300, 100")>  _
        Public Property Size() As Global.System.Drawing.Size
            Get
                Return CType(Me("Size"),Global.System.Drawing.Size)
            End Get
            Set
                Me("Size") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MS UI Gothic, 20.25pt")>  _
        Public Property FontValue() As Global.System.Drawing.Font
            Get
                Return CType(Me("FontValue"),Global.System.Drawing.Font)
            End Get
            Set
                Me("FontValue") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("MS UI Gothic, 20.25pt")>  _
        Public Property FontButton() As Global.System.Drawing.Font
            Get
                Return CType(Me("FontButton"),Global.System.Drawing.Font)
            End Get
            Set
                Me("FontButton") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ControlLight")>  _
        Public Property ColorFormBack() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorFormBack"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorFormBack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ControlLightLight")>  _
        Public Property ColorValueBack() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorValueBack"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorValueBack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ControlText")>  _
        Public Property ColorValueFore() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorValueFore"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorValueFore") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ControlLight")>  _
        Public Property ColorButtonBack() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorButtonBack"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorButtonBack") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Cyan")>  _
        Public Property ColorButtonBackPressed() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorButtonBackPressed"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorButtonBackPressed") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ControlText")>  _
        Public Property ColorButtonFore() As Global.System.Drawing.Color
            Get
                Return CType(Me("ColorButtonFore"),Global.System.Drawing.Color)
            End Get
            Set
                Me("ColorButtonFore") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property CustomColors() As String
            Get
                Return CType(Me("CustomColors"),String)
            End Get
            Set
                Me("CustomColors") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Calc01.My.MySettings
            Get
                Return Global.Calc01.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
