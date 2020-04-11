<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectREport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectREport))
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.CmbRep = New Telerik.WinControls.UI.RadDropDownList()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnDell = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.Grd = New Telerik.WinControls.UI.RadGridView()
        Me.BtnView = New Telerik.WinControls.UI.RadButton()
        Me.BtnQuit = New Telerik.WinControls.UI.RadButton()
        Me.BtnCopy = New Telerik.WinControls.UI.RadButton()
        Me.BtnLock = New Telerik.WinControls.UI.RadToggleButton()
        Me.object_84507bfc_0d15_498d_b9b0_109cad844199 = New Telerik.WinControls.RootRadElement()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.p = New Telerik.WinControls.UI.RadProgressBar()
        CType(Me.CmbRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbRep
        '
        Me.CmbRep.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.CmbRep.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbRep.Location = New System.Drawing.Point(7, 8)
        Me.CmbRep.Name = "CmbRep"
        Me.CmbRep.Size = New System.Drawing.Size(304, 19)
        Me.CmbRep.TabIndex = 0
        '
        'BtnAdd
        '
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnAdd.Image = CType(resources.GetObject("BtnAdd.Image"), System.Drawing.Image)
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(5, 9)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(46, 42)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "اضافه"
        Me.BtnAdd.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnAdd.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "اضافه"
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnAdd.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'BtnDell
        '
        Me.BtnDell.Enabled = False
        Me.BtnDell.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnDell.Image = CType(resources.GetObject("BtnDell.Image"), System.Drawing.Image)
        Me.BtnDell.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDell.Location = New System.Drawing.Point(57, 9)
        Me.BtnDell.Name = "BtnDell"
        Me.BtnDell.Size = New System.Drawing.Size(46, 42)
        Me.BtnDell.TabIndex = 6
        Me.BtnDell.Text = "حذف"
        Me.BtnDell.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnDell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnDell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        CType(Me.BtnDell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnDell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnDell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnDell.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "حذف"
        CType(Me.BtnDell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnDell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnDell.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'BtnEdit
        '
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEdit.Location = New System.Drawing.Point(109, 9)
        Me.BtnEdit.Name = "BtnEdit"
        '
        '
        '
        Me.BtnEdit.RootElement.ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        Me.BtnEdit.Size = New System.Drawing.Size(46, 42)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "ویرایش"
        Me.BtnEdit.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnEdit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ویرایش"
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnEdit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.BtnView)
        Me.RadGroupBox1.Controls.Add(Me.CmbRep)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(319, 75)
        Me.RadGroupBox1.TabIndex = 9
        '
        'Grd
        '
        Me.Grd.Location = New System.Drawing.Point(1, -5)
        '
        '
        '
        Me.Grd.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.Grd.Name = "Grd"
        Me.Grd.Size = New System.Drawing.Size(30, 19)
        Me.Grd.TabIndex = 0
        Me.Grd.Text = "RadGridView1"
        Me.Grd.Visible = False
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnView.Image = CType(resources.GetObject("BtnView.Image"), System.Drawing.Image)
        Me.BtnView.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnView.Location = New System.Drawing.Point(92, 33)
        Me.BtnView.Name = "BtnView"
        '
        '
        '
        Me.BtnView.RootElement.ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        Me.BtnView.Size = New System.Drawing.Size(138, 32)
        Me.BtnView.TabIndex = 9
        Me.BtnView.Text = "نمایش گزارش(چاپ)"
        Me.BtnView.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnView.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        CType(Me.BtnView.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        CType(Me.BtnView.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnView.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        CType(Me.BtnView.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "نمایش گزارش(چاپ)"
        CType(Me.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnView.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'BtnQuit
        '
        Me.BtnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnQuit.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnQuit.Image = CType(resources.GetObject("BtnQuit.Image"), System.Drawing.Image)
        Me.BtnQuit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnQuit.Location = New System.Drawing.Point(265, 9)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(46, 42)
        Me.BtnQuit.TabIndex = 8
        Me.BtnQuit.Text = "خروج"
        Me.BtnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnQuit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        CType(Me.BtnQuit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnQuit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnQuit.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "خروج"
        CType(Me.BtnQuit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnQuit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnQuit.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'BtnCopy
        '
        Me.BtnCopy.Enabled = False
        Me.BtnCopy.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCopy.Location = New System.Drawing.Point(161, 9)
        Me.BtnCopy.Name = "BtnCopy"
        '
        '
        '
        Me.BtnCopy.RootElement.ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        Me.BtnCopy.Size = New System.Drawing.Size(46, 42)
        Me.BtnCopy.TabIndex = 11
        Me.BtnCopy.Text = "کپی"
        Me.BtnCopy.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnCopy.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        CType(Me.BtnCopy.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnCopy.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnCopy.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnCopy.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "کپی"
        CType(Me.BtnCopy.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnCopy.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnCopy.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'BtnLock
        '
        Me.BtnLock.Enabled = False
        Me.BtnLock.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.BtnLock.Image = CType(resources.GetObject("BtnLock.Image"), System.Drawing.Image)
        Me.BtnLock.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLock.Location = New System.Drawing.Point(213, 9)
        Me.BtnLock.Name = "BtnLock"
        Me.BtnLock.Size = New System.Drawing.Size(46, 42)
        Me.BtnLock.TabIndex = 10
        Me.BtnLock.Text = "قفل"
        Me.BtnLock.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnLock.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        CType(Me.BtnLock.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.BtnLock.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.BtnLock.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        CType(Me.BtnLock.GetChildAt(0), Telerik.WinControls.UI.RadToggleButtonElement).Text = "قفل"
        CType(Me.BtnLock.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.Zoom
        CType(Me.BtnLock.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageScaling = Telerik.WinControls.Enumerations.ImageScaling.SizeToFit
        CType(Me.BtnLock.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.5!, 1.5!)
        '
        'object_84507bfc_0d15_498d_b9b0_109cad844199
        '
        Me.object_84507bfc_0d15_498d_b9b0_109cad844199.Name = "object_84507bfc_0d15_498d_b9b0_109cad844199"
        Me.object_84507bfc_0d15_498d_b9b0_109cad844199.StretchHorizontally = True
        Me.object_84507bfc_0d15_498d_b9b0_109cad844199.StretchVertically = True
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.BtnAdd)
        Me.RadGroupBox2.Controls.Add(Me.BtnCopy)
        Me.RadGroupBox2.Controls.Add(Me.BtnQuit)
        Me.RadGroupBox2.Controls.Add(Me.BtnEdit)
        Me.RadGroupBox2.Controls.Add(Me.BtnDell)
        Me.RadGroupBox2.Controls.Add(Me.BtnLock)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(12, 93)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(319, 61)
        Me.RadGroupBox2.TabIndex = 12
        '
        'p
        '
        Me.p.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.p.Location = New System.Drawing.Point(12, 182)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(266, 16)
        Me.p.TabIndex = 12
        Me.p.Visible = False
        '
        'FrmSelectREport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 166)
        Me.Controls.Add(Me.Grd)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmSelectREport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "انتخاب گزارش"
        CType(Me.CmbRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.Grd.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCopy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmbRep As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDell As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents BtnQuit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnView As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnLock As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents object_84507bfc_0d15_498d_b9b0_109cad844199 As Telerik.WinControls.RootRadElement
    Friend WithEvents Grd As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BtnCopy As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents p As Telerik.WinControls.UI.RadProgressBar
End Class
