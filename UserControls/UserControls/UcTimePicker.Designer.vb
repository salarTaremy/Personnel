<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcTimePicker
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
        Me.Ap = New Telerik.WinControls.UI.RadTextBox()
        Me.HH = New Telerik.WinControls.UI.RadTextBox()
        Me.MM = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Ap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ap
        '
        Me.Ap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ap.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Ap.Location = New System.Drawing.Point(0, 0)
        Me.Ap.MaxLength = 2
        Me.Ap.Name = "Ap"
        Me.Ap.ReadOnly = True
        Me.Ap.Size = New System.Drawing.Size(27, 19)
        Me.Ap.TabIndex = 12
        Me.Ap.TabStop = False
        Me.Ap.Text = "AM"
        Me.Ap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HH
        '
        Me.HH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.HH.Location = New System.Drawing.Point(29, 0)
        Me.HH.MaxLength = 2
        Me.HH.Name = "HH"
        Me.HH.Size = New System.Drawing.Size(27, 19)
        Me.HH.TabIndex = 13
        Me.HH.Text = "00"
        Me.HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MM
        '
        Me.MM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MM.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.MM.Location = New System.Drawing.Point(62, 0)
        Me.MM.MaxLength = 2
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(27, 19)
        Me.MM.TabIndex = 14
        Me.MM.Text = "00"
        Me.MM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.RadLabel1.Location = New System.Drawing.Point(54, 0)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(10, 17)
        Me.RadLabel1.TabIndex = 15
        Me.RadLabel1.Text = ":"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UserControls.My.Resources.Resources.Ok
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'UcTimePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.HH)
        Me.Controls.Add(Me.Ap)
        Me.Controls.Add(Me.RadLabel1)
        Me.MaximumSize = New System.Drawing.Size(500, 19)
        Me.MinimumSize = New System.Drawing.Size(84, 19)
        Me.Name = "UcTimePicker"
        Me.Size = New System.Drawing.Size(89, 19)
        CType(Me.Ap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ap As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents HH As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents MM As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
