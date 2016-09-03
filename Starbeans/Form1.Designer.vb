<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCaff = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalPounds = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Caffinated (lbs):"
        '
        'txtCaff
        '
        Me.txtCaff.Location = New System.Drawing.Point(17, 172)
        Me.txtCaff.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCaff.Name = "txtCaff"
        Me.txtCaff.Size = New System.Drawing.Size(132, 22)
        Me.txtCaff.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(155, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Decaffinated (lbs):"
        '
        'txtDecaf
        '
        Me.txtDecaf.Location = New System.Drawing.Point(159, 172)
        Me.txtDecaf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(132, 22)
        Me.txtDecaf.TabIndex = 3
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(17, 324)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(133, 84)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 324)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 84)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 216)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total lbs:"
        '
        'lblTotalPounds
        '
        Me.lblTotalPounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPounds.Location = New System.Drawing.Point(88, 232)
        Me.lblTotalPounds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPounds.Name = "lblTotalPounds"
        Me.lblTotalPounds.Size = New System.Drawing.Size(132, 22)
        Me.lblTotalPounds.TabIndex = 7
        Me.lblTotalPounds.Text = " "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 263)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total price:"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPrice.Location = New System.Drawing.Point(88, 279)
        Me.lblTotalPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(132, 22)
        Me.lblTotalPrice.TabIndex = 9
        Me.lblTotalPrice.Text = " "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 423)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalPounds)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCaff)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Starbeans"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCaff As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalPounds As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
