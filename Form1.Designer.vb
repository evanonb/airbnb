<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirbnb
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSubheader = New System.Windows.Forms.Label()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.airbnb.My.Resources.Resources.airbnb_phone_1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(367, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Broadway", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(397, 32)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(391, 46)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Charlotte Airbnb"
        '
        'lblSubheader
        '
        Me.lblSubheader.AutoSize = True
        Me.lblSubheader.Font = New System.Drawing.Font("Broadway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheader.Location = New System.Drawing.Point(470, 90)
        Me.lblSubheader.Name = "lblSubheader"
        Me.lblSubheader.Size = New System.Drawing.Size(250, 22)
        Me.lblSubheader.TabIndex = 2
        Me.lblSubheader.Text = "Only $79.00 per night!"
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Font = New System.Drawing.Font("Broadway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInput.Location = New System.Drawing.Point(422, 177)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(206, 22)
        Me.lblInput.TabIndex = 3
        Me.lblInput.Text = "Number of Nights:"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Location = New System.Drawing.Point(644, 181)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(39, 20)
        Me.txtNumberOfDays.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Broadway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(422, 250)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(140, 22)
        Me.lblOutput.TabIndex = 5
        Me.lblOutput.Text = "Cost of Stay:"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Broadway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(405, 357)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(123, 37)
        Me.btnDisplayCost.TabIndex = 6
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Broadway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(663, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Broadway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(534, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 37)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Broadway", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(640, 250)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(0, 22)
        Me.lblTotalCost.TabIndex = 10
        '
        'frmAirbnb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.lblSubheader)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAirbnb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAirbnb"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSubheader As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
End Class
