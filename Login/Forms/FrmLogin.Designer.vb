<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BtnEnter = New Telerik.WinControls.UI.RadButton()
        Me.BtnCancell = New Telerik.WinControls.UI.RadButton()
        Me.TxtPass = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtUser = New Telerik.WinControls.UI.RadTextBox()
        Me.LblLanguage = New Telerik.WinControls.UI.RadLabel()
        CType(Me.BtnEnter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCancell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEnter
        '
        Me.BtnEnter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEnter.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEnter.Image = CType(resources.GetObject("BtnEnter.Image"), System.Drawing.Image)
        Me.BtnEnter.Location = New System.Drawing.Point(21, 168)
        Me.BtnEnter.Name = "BtnEnter"
        Me.BtnEnter.Size = New System.Drawing.Size(114, 31)
        Me.BtnEnter.TabIndex = 2
        Me.BtnEnter.Text = "ورود به سیستم "
        Me.BtnEnter.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnEnter.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnEnter.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnEnter.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ورود به سیستم "
        CType(Me.BtnEnter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEnter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEnter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnEnter.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'BtnCancell
        '
        Me.BtnCancell.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnCancell.Image = CType(resources.GetObject("BtnCancell.Image"), System.Drawing.Image)
        Me.BtnCancell.Location = New System.Drawing.Point(151, 168)
        Me.BtnCancell.Name = "BtnCancell"
        Me.BtnCancell.Size = New System.Drawing.Size(114, 31)
        Me.BtnCancell.TabIndex = 3
        Me.BtnCancell.Text = "    انصراف (Esc)"
        CType(Me.BtnCancell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnCancell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnCancell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "    انصراف (Esc)"
        CType(Me.BtnCancell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnCancell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnCancell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnCancell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'TxtPass
        '
        Me.TxtPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPass.BackColor = System.Drawing.Color.Transparent
        Me.TxtPass.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.ForeColor = System.Drawing.Color.Red
        Me.TxtPass.Location = New System.Drawing.Point(21, 132)
        Me.TxtPass.MaxLength = 30
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(244, 20)
        Me.TxtPass.TabIndex = 1
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
        CType(Me.TxtPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
        CType(Me.TxtPass.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
        CType(Me.TxtPass.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        '
        'TxtUser
        '
        Me.TxtUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUser.BackColor = System.Drawing.Color.Transparent
        Me.TxtUser.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.ForeColor = System.Drawing.Color.Blue
        Me.TxtUser.Location = New System.Drawing.Point(21, 85)
        Me.TxtUser.MaxLength = 30
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(244, 20)
        Me.TxtUser.TabIndex = 0
        Me.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        CType(Me.TxtUser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.White
        '
        'LblLanguage
        '
        Me.LblLanguage.BackColor = System.Drawing.Color.CornflowerBlue
        Me.LblLanguage.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblLanguage.Location = New System.Drawing.Point(21, 61)
        Me.LblLanguage.Name = "LblLanguage"
        Me.LblLanguage.Size = New System.Drawing.Size(19, 18)
        Me.LblLanguage.TabIndex = 29
        Me.LblLanguage.Text = "FA"
        Me.LblLanguage.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(416, 222)
        Me.Controls.Add(Me.LblLanguage)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.BtnCancell)
        Me.Controls.Add(Me.BtnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Opacity = 0.9R
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLogin"
        Me.TopMost = True
        CType(Me.BtnEnter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCancell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEnter As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnCancell As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtPass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtUser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblLanguage As Telerik.WinControls.UI.RadLabel
End Class
