<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmError
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmError))
        Me.TxtMessage = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnOk = New Telerik.WinControls.UI.RadButton()
        Me.PageView = New Telerik.WinControls.UI.RadPageView()
        Me.Page1 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.Page2 = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TxtMore = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.TxtMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnOk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageView.SuspendLayout()
        Me.Page1.SuspendLayout()
        Me.Page2.SuspendLayout()
        CType(Me.TxtMore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtMessage
        '
        Me.TxtMessage.AutoSize = False
        Me.TxtMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtMessage.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessage.Location = New System.Drawing.Point(3, 3)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ReadOnly = True
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMessage.Size = New System.Drawing.Size(330, 98)
        Me.TxtMessage.TabIndex = 3
        Me.TxtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnOk.Location = New System.Drawing.Point(42, 184)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(110, 24)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "تایید"
        '
        'PageView
        '
        Me.PageView.Controls.Add(Me.Page1)
        Me.PageView.Controls.Add(Me.Page2)
        Me.PageView.DefaultPage = Me.Page1
        Me.PageView.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.PageView.Location = New System.Drawing.Point(32, 34)
        Me.PageView.Name = "PageView"
        Me.PageView.SelectedPage = Me.Page1
        Me.PageView.Size = New System.Drawing.Size(357, 152)
        Me.PageView.TabIndex = 4
        Me.PageView.Text = "توضیحات بیشتر"
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Top
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemDragMode = Telerik.WinControls.UI.PageViewItemDragMode.None
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight
        CType(Me.PageView.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.[Auto]
        '
        'Page1
        '
        Me.Page1.Controls.Add(Me.TxtMessage)
        Me.Page1.ItemSize = New System.Drawing.SizeF(85.0!, 27.0!)
        Me.Page1.Location = New System.Drawing.Point(10, 36)
        Me.Page1.Name = "Page1"
        Me.Page1.Size = New System.Drawing.Size(336, 105)
        Me.Page1.Tag = ""
        Me.Page1.Text = "خطا در عملیات"
        '
        'Page2
        '
        Me.Page2.Controls.Add(Me.TxtMore)
        Me.Page2.ItemSize = New System.Drawing.SizeF(89.0!, 27.0!)
        Me.Page2.Location = New System.Drawing.Point(10, 37)
        Me.Page2.Name = "Page2"
        Me.Page2.Size = New System.Drawing.Size(336, 104)
        Me.Page2.Text = "توضیحات بیشتر"
        '
        'TxtMore
        '
        Me.TxtMore.AutoSize = False
        Me.TxtMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TxtMore.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMore.Location = New System.Drawing.Point(3, 3)
        Me.TxtMore.Multiline = True
        Me.TxtMore.Name = "TxtMore"
        Me.TxtMore.ReadOnly = True
        Me.TxtMore.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtMore.Size = New System.Drawing.Size(330, 98)
        Me.TxtMore.TabIndex = 4
        Me.TxtMore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(521, 245)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.PageView)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmError"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmError"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.TxtMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnOk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageView.ResumeLayout(False)
        Me.Page1.ResumeLayout(False)
        Me.Page2.ResumeLayout(False)
        CType(Me.TxtMore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtMessage As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnOk As Telerik.WinControls.UI.RadButton
    Friend WithEvents PageView As Telerik.WinControls.UI.RadPageView
    Friend WithEvents Page1 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents Page2 As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TxtMore As Telerik.WinControls.UI.RadTextBox
End Class
