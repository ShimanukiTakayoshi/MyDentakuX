<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Windows フォーム デザイナーで必要です。
  Private components As System.ComponentModel.IContainer

  'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
  'Windows フォーム デザイナーを使用して変更できます。  
  'コード エディターを使って変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemFileExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSetting = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingShowMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingFont = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingFontValue = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingFontButton = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpReadme = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpWeb = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpVersion = New System.Windows.Forms.ToolStripMenuItem()
    Me.FontDialog1 = New System.Windows.Forms.FontDialog()
    Me.LabelMain = New Calc01.MyLabel()
    Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
    Me.ToolStripMenuItemSettingColor = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorFromBack = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorValueBack = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorValueFore = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorButtonBack = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorButtonBackPressed = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingColorButtonFore = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStripContainer1
    '
    Me.ToolStripContainer1.BottomToolStripPanelVisible = False
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.LabelMain)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(284, 237)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.LeftToolStripPanelVisible = False
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.RightToolStripPanelVisible = False
    Me.ToolStripContainer1.Size = New System.Drawing.Size(284, 261)
    Me.ToolStripContainer1.TabIndex = 0
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItemFile, Me.ToolStripMenuItemSetting, Me.ToolStripMenuItemHelp})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FToolStripMenuItemFile
    '
    Me.FToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFileExit})
    Me.FToolStripMenuItemFile.Name = "FToolStripMenuItemFile"
    Me.FToolStripMenuItemFile.Size = New System.Drawing.Size(66, 20)
    Me.FToolStripMenuItemFile.Text = "ファイル(&F)"
    '
    'ToolStripMenuItemFileExit
    '
    Me.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit"
    Me.ToolStripMenuItemFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
    Me.ToolStripMenuItemFileExit.Size = New System.Drawing.Size(155, 22)
    Me.ToolStripMenuItemFileExit.Text = "終了(&X)"
    '
    'ToolStripMenuItemSetting
    '
    Me.ToolStripMenuItemSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSettingShowMenu, Me.ToolStripMenuItemSettingFont, Me.ToolStripMenuItemSettingColor})
    Me.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting"
    Me.ToolStripMenuItemSetting.Size = New System.Drawing.Size(57, 20)
    Me.ToolStripMenuItemSetting.Text = "設定(&S)"
    '
    'ToolStripMenuItemSettingShowMenu
    '
    Me.ToolStripMenuItemSettingShowMenu.Name = "ToolStripMenuItemSettingShowMenu"
    Me.ToolStripMenuItemSettingShowMenu.Size = New System.Drawing.Size(190, 22)
    Me.ToolStripMenuItemSettingShowMenu.Text = "常にﾒﾆｭｰを表示する(&M)"
    '
    'ToolStripMenuItemSettingFont
    '
    Me.ToolStripMenuItemSettingFont.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSettingFontValue, Me.ToolStripMenuItemSettingFontButton})
    Me.ToolStripMenuItemSettingFont.Name = "ToolStripMenuItemSettingFont"
    Me.ToolStripMenuItemSettingFont.Size = New System.Drawing.Size(190, 22)
    Me.ToolStripMenuItemSettingFont.Text = "フォント(&F)"
    '
    'ToolStripMenuItemSettingFontValue
    '
    Me.ToolStripMenuItemSettingFontValue.Name = "ToolStripMenuItemSettingFontValue"
    Me.ToolStripMenuItemSettingFontValue.Size = New System.Drawing.Size(125, 22)
    Me.ToolStripMenuItemSettingFontValue.Text = "値表示(&V)"
    '
    'ToolStripMenuItemSettingFontButton
    '
    Me.ToolStripMenuItemSettingFontButton.Name = "ToolStripMenuItemSettingFontButton"
    Me.ToolStripMenuItemSettingFontButton.Size = New System.Drawing.Size(125, 22)
    Me.ToolStripMenuItemSettingFontButton.Text = "ボタン(&B)"
    '
    'ToolStripMenuItemHelp
    '
    Me.ToolStripMenuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemHelpReadme, Me.ToolStripMenuItemHelpWeb, Me.ToolStripMenuItemHelpVersion})
    Me.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp"
    Me.ToolStripMenuItemHelp.Size = New System.Drawing.Size(65, 20)
    Me.ToolStripMenuItemHelp.Text = "ヘルプ(&H)"
    '
    'ToolStripMenuItemHelpReadme
    '
    Me.ToolStripMenuItemHelpReadme.Name = "ToolStripMenuItemHelpReadme"
    Me.ToolStripMenuItemHelpReadme.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpReadme.Text = "ReadMe.txtを表示(&R)"
    '
    'ToolStripMenuItemHelpWeb
    '
    Me.ToolStripMenuItemHelpWeb.Name = "ToolStripMenuItemHelpWeb"
    Me.ToolStripMenuItemHelpWeb.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpWeb.Text = "Webサイトを表示(&W)"
    '
    'ToolStripMenuItemHelpVersion
    '
    Me.ToolStripMenuItemHelpVersion.Name = "ToolStripMenuItemHelpVersion"
    Me.ToolStripMenuItemHelpVersion.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpVersion.Text = "バージョン情報(&V)"
    '
    'LabelMain
    '
    Me.LabelMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.LabelMain.Location = New System.Drawing.Point(27, 16)
    Me.LabelMain.Name = "LabelMain"
    Me.LabelMain.Size = New System.Drawing.Size(206, 21)
    Me.LabelMain.TabIndex = 0
    '
    'ToolStripMenuItemSettingColor
    '
    Me.ToolStripMenuItemSettingColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSettingColorFromBack, Me.ToolStripMenuItemSettingColorValueBack, Me.ToolStripMenuItemSettingColorValueFore, Me.ToolStripMenuItemSettingColorButtonBack, Me.ToolStripMenuItemSettingColorButtonBackPressed, Me.ToolStripMenuItemSettingColorButtonFore})
    Me.ToolStripMenuItemSettingColor.Name = "ToolStripMenuItemSettingColor"
    Me.ToolStripMenuItemSettingColor.Size = New System.Drawing.Size(190, 22)
    Me.ToolStripMenuItemSettingColor.Text = "色(&C)"
    '
    'ToolStripMenuItemSettingColorFromBack
    '
    Me.ToolStripMenuItemSettingColorFromBack.Name = "ToolStripMenuItemSettingColorFromBack"
    Me.ToolStripMenuItemSettingColorFromBack.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorFromBack.Text = "背景..."
    '
    'ToolStripMenuItemSettingColorValueBack
    '
    Me.ToolStripMenuItemSettingColorValueBack.Name = "ToolStripMenuItemSettingColorValueBack"
    Me.ToolStripMenuItemSettingColorValueBack.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorValueBack.Text = "値の背景..."
    '
    'ToolStripMenuItemSettingColorValueFore
    '
    Me.ToolStripMenuItemSettingColorValueFore.Name = "ToolStripMenuItemSettingColorValueFore"
    Me.ToolStripMenuItemSettingColorValueFore.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorValueFore.Text = "値の文字..."
    '
    'ToolStripMenuItemSettingColorButtonBack
    '
    Me.ToolStripMenuItemSettingColorButtonBack.Name = "ToolStripMenuItemSettingColorButtonBack"
    Me.ToolStripMenuItemSettingColorButtonBack.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorButtonBack.Text = "ボタンの背景..."
    '
    'ToolStripMenuItemSettingColorButtonBackPressed
    '
    Me.ToolStripMenuItemSettingColorButtonBackPressed.Name = "ToolStripMenuItemSettingColorButtonBackPressed"
    Me.ToolStripMenuItemSettingColorButtonBackPressed.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorButtonBackPressed.Text = "ボタンの背景(押された時)..."
    '
    'ToolStripMenuItemSettingColorButtonFore
    '
    Me.ToolStripMenuItemSettingColorButtonFore.Name = "ToolStripMenuItemSettingColorButtonFore"
    Me.ToolStripMenuItemSettingColorButtonFore.Size = New System.Drawing.Size(205, 22)
    Me.ToolStripMenuItemSettingColorButtonFore.Text = "ボタンの文字..."
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents ToolStripContainer1 As ToolStripContainer
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FToolStripMenuItemFile As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemFileExit As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSetting As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingShowMenu As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelp As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpReadme As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpWeb As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpVersion As ToolStripMenuItem
  Friend WithEvents FontDialog1 As FontDialog
  Friend WithEvents ToolStripMenuItemSettingFont As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingFontValue As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingFontButton As ToolStripMenuItem
  Friend WithEvents LabelMain As MyLabel
  Friend WithEvents ToolStripMenuItemSettingColor As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorFromBack As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorValueBack As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorValueFore As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorButtonBack As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorButtonBackPressed As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingColorButtonFore As ToolStripMenuItem
  Friend WithEvents ColorDialog1 As ColorDialog
End Class
