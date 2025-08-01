<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ToFoodmenuButton = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = Global.FINALPROGRAM.My.Resources.Resources.New_Project__1_
        Me.LogoPictureBox.Location = New System.Drawing.Point(482, 100)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(400, 400)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'ToFoodmenuButton
        '
        Me.ToFoodmenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ToFoodmenuButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ToFoodmenuButton.FlatAppearance.BorderSize = 2
        Me.ToFoodmenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToFoodmenuButton.Font = New System.Drawing.Font("Bodoni MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToFoodmenuButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ToFoodmenuButton.Location = New System.Drawing.Point(559, 525)
        Me.ToFoodmenuButton.Name = "ToFoodmenuButton"
        Me.ToFoodmenuButton.Size = New System.Drawing.Size(247, 58)
        Me.ToFoodmenuButton.TabIndex = 1
        Me.ToFoodmenuButton.Text = "Order Now!"
        Me.ToFoodmenuButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FINALPROGRAM.My.Resources.Resources.bagong_background_15_yung_opacity
        Me.ClientSize = New System.Drawing.Size(1364, 749)
        Me.Controls.Add(Me.ToFoodmenuButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Welcome!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents ToFoodmenuButton As Button
End Class
