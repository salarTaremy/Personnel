﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfo
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfo))
        Me.BtnOk = New Telerik.WinControls.UI.RadButton()
        Me.TxtMessage = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.BtnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnOk.Location = New System.Drawing.Point(40, 186)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(110, 24)
        Me.BtnOk.TabIndex = 0
        Me.BtnOk.Text = "تایید"
        '
        'TxtMessage
        '
        Me.TxtMessage.AutoSize = False
        Me.TxtMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtMessage.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtMessage.Location = New System.Drawing.Point(40, 45)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ReadOnly = True
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMessage.Size = New System.Drawing.Size(340, 135)
        Me.TxtMessage.TabIndex = 1
        Me.TxtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(507, 243)
        Me.Controls.Add(Me.TxtMessage)
        Me.Controls.Add(Me.BtnOk)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInfo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmInfo"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.BtnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMessage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOk As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtMessage As Telerik.WinControls.UI.RadTextBox
End Class
