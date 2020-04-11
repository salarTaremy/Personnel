<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectCmb
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectCmb))
        Me.Grd = New UserControls.RadGridView()
        Me.BtnSelect = New Telerik.WinControls.UI.RadButton()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grd
        '
        Me.Grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Grd.Location = New System.Drawing.Point(12, 12)
        '
        '
        '
        Me.Grd.MasterTemplate.AllowAddNewRow = False
        Me.Grd.MasterTemplate.EnableAlternatingRowColor = True
        Me.Grd.MasterTemplate.EnableFiltering = True
        Me.Grd.MasterTemplate.EnableGrouping = False
        Me.Grd.MasterTemplate.EnableSorting = False
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.ProgressBar = Nothing
        Me.Grd.ReadOnly = True
        Me.Grd.Size = New System.Drawing.Size(632, 308)
        Me.Grd.TabIndex = 0
        Me.Grd.ValidChar = Nothing
        '
        'BtnSelect
        '
        Me.BtnSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSelect.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnSelect.Image = CType(resources.GetObject("BtnSelect.Image"), System.Drawing.Image)
        Me.BtnSelect.Location = New System.Drawing.Point(12, 326)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(110, 31)
        Me.BtnSelect.TabIndex = 0
        Me.BtnSelect.Text = "تایید"
        CType(Me.BtnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnSelect.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "تایید"
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MinSize = New System.Drawing.Size(32, 32)
        CType(Me.BtnSelect.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).MaxSize = New System.Drawing.Size(32, 32)
        '
        'FrmSelectCmb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 369)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.Grd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelectCmb"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب"
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grd As UserControls.RadGridView
    Friend WithEvents BtnSelect As Telerik.WinControls.UI.RadButton
End Class
