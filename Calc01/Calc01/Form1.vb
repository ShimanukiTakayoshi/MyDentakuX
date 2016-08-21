Public Class Form1

  Private Property ShowMenu As Boolean
    Get
      Return My.Settings.ShowMenu
    End Get
    Set(ByVal value As Boolean)
      My.Settings.ShowMenu = value
      ToolStripMenuItemSettingShowMenu.Checked = value
      MenuStrip1.Visible = value
    End Set
  End Property

  Private Enum Operations
    None
    Add
    Substract
    Multiply
    Divide
  End Enum
  Private Operation As Operations

  Private DisplayValueVslue, HiddenValue As Double
  Private Property DisplayValue As Double
    Get
      Return DisplayValueVslue
    End Get
    Set(value As Double)
      DisplayValueVslue = value
      If Not (LabelMain.Text.Contains(".") AndAlso
          LabelMain.Text.EndsWith("0")) Then
        Try
          LabelMain.Text = CDec(value).ToString
        Catch ex As Exception
          LabelMain.Text = value.ToString
        End Try
      End If
    End Set
  End Property

  Private IsNewValue As Boolean
  Private Memory As Double = 0
  Private Const ButtonText = "789+C456-R123*M0±./="


  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Text = Application.ProductName
    Me.KeyPreview = True
    'Me.MinimumSize = New Drawing.Size(300, 100)
    'Me.Size = My.Settings.Size
    'ShowMenu = My.Settings.ShowMenu
    ShowMenu = True
    ToolStripMenuItemSetting.Visible = False

    Me.Location = My.Settings.Location
    If Me.Left < Screen.GetWorkingArea(Me).Left OrElse
       Me.Left >= Screen.GetWorkingArea(Me).Right Then
      Me.Left = 100
    End If
    If Me.Top < Screen.GetWorkingArea(Me).Left OrElse
       Me.Left >= Screen.GetWorkingArea(Me).Right Then
      Me.Left = 100
    End If
    LabelMain.TextAlign = ContentAlignment.MiddleRight
    Initialize()
  End Sub

  Private Sub Initialize()
    HiddenValue = 0
    DisplayValue = 0
    IsNewValue = True
    Operation = Operations.None
  End Sub







  Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.Alt Then MenuStrip1.Visible = True
  End Sub

  Private Sub ToolStripMenuItemFileExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemFileExit.Click
    Application.Exit()
  End Sub

  Private Sub MenuStrip1_MenuDeactivate(sender As Object, e As EventArgs) Handles MenuStrip1.MenuDeactivate
    If Not ShowMenu Then MenuStrip1.Visible = False
  End Sub

  Private Sub ToolStripMenuItemSettingShowMenu_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingShowMenu.Click
    ShowMenu = Not ShowMenu
  End Sub

  Private Sub ToolStripMenuItemHelpReadme_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpReadme.Click
    Dim s = IO.Path.GetDirectoryName(Application.ExecutablePath)
    s = IO.Path.Combine(s, "readme.txt")
    If IO.File.Exists(s) Then
      Process.Start(s)
    Else
      MessageBox.Show(s & "が見つかりません", "エラー")
    End If
  End Sub

  Private Sub ToolStripMenuItemHelpWeb_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpWeb.Click
    Process.Start("http://www.yahoo.co.jp")
  End Sub

  Private Sub ToolStripMenuItemHelpVersion_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpVersion.Click
    Dim s = ""
    s = Application.ProductName & " " & Application.ProductVersion & " (2016/02/22)" + Environment.NewLine
    Dim fileVersionInfo = Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Dim copyright = fileVersionInfo.LegalCopyright
    s &= copyright & Environment.NewLine & Environment.NewLine
    s &= "実行ファイル：" & Environment.NewLine & Application.ExecutablePath & Environment.NewLine & "("
    If Environment.Is64BitProcess Then
      s &= "64"
    Else
      s &= "32"
    End If
    s &= "ビット・プロセスとして稼働）" & Environment.NewLine & Environment.NewLine
    Dim c = New Devices.Computer
    s &= "オペレーティングシステム：" &
      Environment.NewLine & c.Info.OSFullName & " " & c.Info.OSVersion & " "
    If Environment.Is64BitOperatingSystem Then
      s &= "64"
    Else
      s &= "32"
    End If
    s &= "ビット"
    MessageBox.Show(s, "バージョン情報")
  End Sub

  Private Overloads Sub Button_Click(sender As Object, e As EventArgs)
    Button_Click(CType(sender, Button).Text)
  End Sub


  Private Overloads Sub Button_Click(c As Char)
    c = UCase(c)
    Select Case c
      Case "+"c
        UpDateValues()
        Operation = Operations.Add
      Case "-"c
        UpDateValues()
        Operation = Operations.Substract
      Case "*"c
        UpDateValues()
        Operation = Operations.Multiply
      Case "/"c
        UpDateValues()
        Operation = Operations.Divide
      Case "="c
        UpDateValues()
        Operation = Operations.None
      Case "C"c
        Initialize()
        UpDateValues()
      Case "±"c, "P"c
        If Not IsNewValue Then
          If LabelMain.Text.StartsWith("-") Then
            LabelMain.Text = Microsoft.VisualBasic.Right(LabelMain.Text, LabelMain.Text.Length - 1)
          Else
            LabelMain.Text = "-" & LabelMain.Text
          End If
          SetDisplayValueFromText()
        End If
      Case "."c
        If IsNewValue Then LabelMain.Text = "0"
        If Not LabelMain.Text.Contains(".") Then
          LabelMain.Text &= c
          IsNewValue = False
        End If
      Case "0"c To "9"c
        If IsNewValue Then LabelMain.Text = ""
        LabelMain.Text &= c
        SetDisplayValueFromText()
        IsNewValue = False
      Case "M"c
        Memory = DisplayValue
      Case "R"c
        DisplayValue = Memory
        IsNewValue = False
      Case "B"c
        LabelMain.Text = Microsoft.VisualBasic.Left(LabelMain.Text, LabelMain.Text.Length - 1)
        If LabelMain.Text = "" Then LabelMain.Text = "0"
        SetDisplayValueFromText()
        IsNewValue = False
    End Select
  End Sub

  Private Sub UpDateValues()
    If Not IsNewValue Then
      Select Case Operation
        Case Operations.None
          HiddenValue = DisplayValue
        Case Operations.Add
          HiddenValue = HiddenValue + DisplayValue
        Case Operations.Substract
          HiddenValue = HiddenValue - DisplayValue
        Case Operations.Multiply
          HiddenValue = HiddenValue * DisplayValue
        Case Operations.Divide
          HiddenValue = HiddenValue / DisplayValue
      End Select
      IsNewValue = True
      DisplayValue = HiddenValue
    End If
  End Sub

  Private Sub SetDisplayValueFromText()
    Try
      DisplayValue = Double.Parse(LabelMain.Text)
    Catch ex As Exception
      DisplayValue = 0
    End Try
  End Sub

  Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
    Button_Click(e.KeyChar)
  End Sub

  Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Me.WindowState = FormWindowState.Normal
    My.Settings.Location = Me.Location
    My.Settings.Size = Me.Size
  End Sub

  Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
    Select Case keyData And Keys.KeyCode
      Case Keys.Enter
        Button_Click("="c)
      Case Keys.Back
        Button_Click("B"c)
      Case Keys.Escape
        Button_Click("C"c)
      Case Else
        Return MyBase.ProcessDialogKey(keyData)
    End Select
    Return True
  End Function


End Class
