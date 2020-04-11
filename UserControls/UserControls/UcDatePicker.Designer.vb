<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcDatePicker
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.sal = New Telerik.WinControls.UI.RadTextBox()
        Me.mah = New Telerik.WinControls.UI.RadTextBox()
        Me.roz = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(69, 2)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(10, 17)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "/"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel2.Location = New System.Drawing.Point(99, 2)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(10, 17)
        Me.RadLabel2.TabIndex = 8
        Me.RadLabel2.Text = "/"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'sal
        '
        Me.sal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sal.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.sal.Location = New System.Drawing.Point(0, 0)
        Me.sal.MaxLength = 4
        Me.sal.Name = "sal"
        Me.sal.Size = New System.Drawing.Size(71, 19)
        Me.sal.TabIndex = 2
        Me.sal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mah
        '
        Me.mah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mah.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.mah.Location = New System.Drawing.Point(76, 0)
        Me.mah.MaxLength = 2
        Me.mah.Name = "mah"
        Me.mah.Size = New System.Drawing.Size(25, 19)
        Me.mah.TabIndex = 1
        Me.mah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'roz
        '
        Me.roz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.roz.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.roz.Location = New System.Drawing.Point(106, 0)
        Me.roz.MaxLength = 2
        Me.roz.Name = "roz"
        Me.roz.Size = New System.Drawing.Size(25, 19)
        Me.roz.TabIndex = 0
        Me.roz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UcDatePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.roz)
        Me.Controls.Add(Me.mah)
        Me.Controls.Add(Me.sal)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "UcDatePicker"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(131, 19)
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents sal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents mah As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents roz As Telerik.WinControls.UI.RadTextBox

End Class
