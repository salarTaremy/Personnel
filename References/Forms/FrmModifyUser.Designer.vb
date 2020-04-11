<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifyUser
    Inherits ClsMyForms

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModifyUser))
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.TxtOldPass = New UserControls.RadTextBoxLimited()
        Me.TxtNewPass = New UserControls.RadTextBoxLimited()
        Me.TxtNewPass2 = New UserControls.RadTextBoxLimited()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOldPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewPass2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(289, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(57, 17)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "رمز فعلی :"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel3.Location = New System.Drawing.Point(289, 63)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(51, 17)
        Me.RadLabel3.TabIndex = 7
        Me.RadLabel3.Text = "رمز جدید:"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel4.Location = New System.Drawing.Point(289, 38)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(49, 17)
        Me.RadLabel4.TabIndex = 8
        Me.RadLabel4.Text = "تکرار رمز:"
        Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.Location = New System.Drawing.Point(12, 91)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(110, 31)
        Me.BtnSave.TabIndex = 9
        Me.BtnSave.Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'TxtOldPass
        '
        Me.TxtOldPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOldPass.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtOldPass.Location = New System.Drawing.Point(12, 12)
        Me.TxtOldPass.Name = "TxtOldPass"
        Me.TxtOldPass.NextObject = Me.TxtNewPass
        Me.TxtOldPass.NullText = "فقط عدد"
        Me.TxtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOldPass.Size = New System.Drawing.Size(271, 19)
        Me.TxtOldPass.TabIndex = 0
        Me.TxtOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOldPass.ValidCharacters = "0123456789"
        '
        'TxtNewPass
        '
        Me.TxtNewPass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNewPass.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNewPass.Location = New System.Drawing.Point(12, 37)
        Me.TxtNewPass.Name = "TxtNewPass"
        Me.TxtNewPass.NextObject = Me.TxtNewPass2
        Me.TxtNewPass.NullText = "فقط عدد"
        Me.TxtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPass.Size = New System.Drawing.Size(271, 19)
        Me.TxtNewPass.TabIndex = 1
        Me.TxtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNewPass.ValidCharacters = "0123456789"
        '
        'TxtNewPass2
        '
        Me.TxtNewPass2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNewPass2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNewPass2.Location = New System.Drawing.Point(12, 62)
        Me.TxtNewPass2.Name = "TxtNewPass2"
        Me.TxtNewPass2.NextObject = Nothing
        Me.TxtNewPass2.NullText = "فقط عدد"
        Me.TxtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPass2.Size = New System.Drawing.Size(271, 19)
        Me.TxtNewPass2.TabIndex = 2
        Me.TxtNewPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNewPass2.ValidCharacters = "0123456789"
        '
        'FrmModifyUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(362, 130)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.TxtOldPass)
        Me.Controls.Add(Me.TxtNewPass2)
        Me.Controls.Add(Me.TxtNewPass)
        Me.DefaultTextBox = Me.TxtOldPass
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModifyUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تغییر رمز عبور"
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOldPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewPass2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNewPass As UserControls.RadTextBoxLimited
    Friend WithEvents TxtNewPass2 As UserControls.RadTextBoxLimited
    Friend WithEvents TxtOldPass As UserControls.RadTextBoxLimited
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
End Class
