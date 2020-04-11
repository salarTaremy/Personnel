
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStiDesigner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStiDesigner))
        Me.Designer = New Stimulsoft.Report.Design.StiDesignerControl()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.BtnExit = New Telerik.WinControls.UI.RadButton()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Designer
        '
        Me.Designer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Designer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Designer.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Designer.Location = New System.Drawing.Point(0, 0)
        Me.Designer.Name = "Designer"
        Me.Designer.Size = New System.Drawing.Size(1177, 670)
        Me.Designer.TabIndex = 0
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Location = New System.Drawing.Point(126, 676)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(108, 24)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "ذخیره در دیتابیس"
        Me.BtnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnSave.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ذخیره در دیتابیس"
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnExit.Location = New System.Drawing.Point(12, 676)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(108, 24)
        Me.BtnExit.TabIndex = 10
        Me.BtnExit.Text = "خروج"
        Me.BtnExit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnExit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "خروج"
        CType(Me.BtnExit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnExit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        '
        'FrmStiDesigner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1177, 701)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Designer)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "FrmStiDesigner"
        Me.Text = "طراحی گزارش"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Designer As Stimulsoft.Report.Design.StiDesignerControl
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnExit As Telerik.WinControls.UI.RadButton
End Class
