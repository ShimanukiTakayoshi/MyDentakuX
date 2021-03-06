﻿Public Class Form1

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
  Private Const ButtonX = 5
  Private Const ButtonY = 4
  Private Button(ButtonX * ButtonY - 1) As MyButton
  Private ColorButtonBackPressed As Color

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Text = Application.ProductName
    Me.KeyPreview = True
    Me.MinimumSize = New Drawing.Size(260, 260)
    Me.Size = My.Settings.Size
    Me.BackColor = My.Settings.ColorFormBack
    ShowMenu = My.Settings.ShowMenu
    LabelMain.Font = My.Settings.FontValue
    LabelMain.BackColor = My.Settings.ColorValueBack
    LabelMain.ForeColor = My.Settings.ColorValueFore

    If Me.Left < Screen.GetWorkingArea(Me).Left Or
       Me.Left >= Screen.GetWorkingArea(Me).Right Then
      Me.Left = 100
    End If
    If Me.Top < Screen.GetWorkingArea(Me).Top Or
       Me.Top >= Screen.GetWorkingArea(Me).Bottom Then
      Me.Top = 100
    End If
    LabelMain.TextAlign = ContentAlignment.MiddleRight

    For i = 0 To ButtonY - 1
      For j = 0 To ButtonX - 1
        Dim k = i * ButtonX + j
        Button(k) = New MyButton
        Button(k).Text = Mid(ButtonText, k + 1, 1)
        Button(k).Font = My.Settings.FontButton
        Button(k).BackColor = My.Settings.ColorButtonBack
        Button(k).ForeColor = My.Settings.ColorButtonFore
        AddHandler Button(k).Click, AddressOf Button_Click
        ToolStripContainer1.ContentPanel.Controls.Add(Button(k))
      Next
    Next
    Form1_Resize(Me, e)

    If My.Settings.CustomColors <> "" Then
      Dim customColorString() As String
      customColorString = My.Settings.CustomColors.Split(vbTab)
      Dim customColors(customColorString.GetUpperBound(0)) As Integer
      For i = 0 To customColorString.GetUpperBound(0)
        customColors(i) = Integer.Parse(customColorString(i))
      Next
      ColorDialog1.CustomColors = customColors
    End If
    ColorButtonBackPressed = My.Settings.ColorButtonBackPressed
    Initialize()
  End Sub

  Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    If Not Button(0) Is Nothing Then SetControls
  End Sub

  Private Sub SetControls()
    Dim clientWidth = ToolStripContainer1.ContentPanel.ClientSize.Width
    Dim clientHeight = ToolStripContainer1.ContentPanel.ClientSize.Height
    Dim margin = New Point(clientWidth \ 50, clientHeight \ 50)
    LabelMain.Location = margin
    LabelMain.Width = clientWidth - margin.X * 2
    LabelMain.Height = (clientHeight - margin.Y) \ (ButtonY + 1)
    Dim labelLow = LabelMain.Location.Y + LabelMain.Height
    Dim buttonWidth = (clientWidth - margin.X) \ ButtonX - margin.X
    Dim buttonHeight = (clientHeight - labelLow - margin.Y) \ ButtonY - margin.Y

    For i = 0 To ButtonY - 1
      For j = 0 To ButtonX - 1
        Button(i * ButtonX + j).Size = New Size(buttonWidth, buttonHeight)
        Button(i * ButtonX + j).Location = New Point(margin.X + (buttonWidth + margin.X) * j, margin.Y + labelLow + (buttonHeight + margin.Y) * i)
      Next
    Next
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
    Form1_Resize(Me, e)
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
    If c = "P"c Then c = "±"c
    ButtonBlink(c, True)
    Me.Refresh()

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

    Threading.Thread.Sleep(50)
    ButtonBlink(c, False)
  End Sub

  Private Sub ButtonBlink(c As Char, active As Boolean)
    Dim i = InStr(ButtonText, c) - 1
    If i >= Button.GetLowerBound(0) AndAlso i <= Button.GetUpperBound(0) Then
      If active Then
        Button(i).BackColor = ColorButtonBackPressed
      Else
        If i + 1 > Button.GetUpperBound(0) Then
          Button(i).BackColor = Button(i - 1).BackColor
        Else
          Button(i).BackColor = Button(i + 1).BackColor
        End If
      End If
    End If
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
    My.Settings.FontValue = LabelMain.Font
    My.Settings.FontButton = Button(0).Font
    My.Settings.ColorFormBack = Me.BackColor
    My.Settings.ColorValueBack = LabelMain.BackColor
    My.Settings.ColorValueFore = LabelMain.ForeColor
    My.Settings.ColorButtonBack = Button(0).BackColor
    My.Settings.ColorButtonFore = Button(0).ForeColor
    My.Settings.ColorButtonBackPressed = ColorButtonBackPressed

    Dim s As String = ""
    For i = 0 To ColorDialog1.CustomColors.GetUpperBound(0)
      s &= ColorDialog1.CustomColors(i)
      If i < ColorDialog1.CustomColors.GetUpperBound(0) Then
        s &= vbTab
      End If
    Next
    My.Settings.CustomColors = s

    With FontDialog1
      .AllowVerticalFonts = False
      .ScriptsOnly = True
      .ShowEffects = False
    End With
  End Sub

  Private Sub ToolStripMenuItemSettingFontValue_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingFontValue.Click
    LabelMain.Font = SetFont(LabelMain.Font)
  End Sub

  Private Function SetFont(target As Font) As Font
    FontDialog1.Font = target
    If FontDialog1.ShowDialog Then target = FontDialog1.Font
    Return target
  End Function

  Private Sub ToolStripMenuItemSettingFontButton_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingFontButton.Click
    Dim f = SetFont(Button(0).Font)
    For i = 0 To ButtonX * ButtonY - 1
      Button(i).Font = f
    Next
  End Sub

  Private Sub ToolStripMenuItemEdit_DropDownOpening(sender As Object, e As EventArgs) Handles ToolStripMenuItemEdit.DropDownOpening
    ToolStripMenuItemEditPaste.Enabled =
      My.Computer.Clipboard.ContainsText AndAlso
      My.Computer.Clipboard.GetText() <> ""
  End Sub

  Private Sub ToolStripMenuItemEditCopy_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditCopy.Click
    My.Computer.Clipboard.SetText(LabelMain.Text)
  End Sub

  Private Sub ToolStripMenuItemEditPaste_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditPaste.Click
    Dim s = My.Computer.Clipboard.GetText
    s = StrConv(s, VbStrConv.Narrow)
    Try
      Dim d = Double.Parse(s)
      LabelMain.Text = Str(d)
    Catch ex As Exception
      MessageBox.Show("｢" & s & "｣は数値ではありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
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
