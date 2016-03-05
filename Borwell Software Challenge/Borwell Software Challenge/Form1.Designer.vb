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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVol = New System.Windows.Forms.TextBox()
        Me.txtPaint = New System.Windows.Forms.TextBox()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAreaOfDoors = New System.Windows.Forms.TextBox()
        Me.txtAreaOfWindows = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbCoats = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(190, 373)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Height (M)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Width (M)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Length (M)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Borwell Software Challenge"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(129, 182)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(121, 20)
        Me.txtWidth.TabIndex = 5
        Me.txtWidth.Text = "0"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(129, 138)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(121, 20)
        Me.txtLength.TabIndex = 6
        Me.txtLength.Text = "0"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(129, 224)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(121, 20)
        Me.txtHeight.TabIndex = 7
        Me.txtHeight.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(423, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Volume of Room (Metres Squared)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Area of Floor (Metres Squared)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(423, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Paint needed for Walls (Litres)"
        '
        'txtVol
        '
        Me.txtVol.Location = New System.Drawing.Point(426, 144)
        Me.txtVol.Name = "txtVol"
        Me.txtVol.ReadOnly = True
        Me.txtVol.Size = New System.Drawing.Size(100, 20)
        Me.txtVol.TabIndex = 11
        '
        'txtPaint
        '
        Me.txtPaint.Location = New System.Drawing.Point(426, 227)
        Me.txtPaint.Name = "txtPaint"
        Me.txtPaint.ReadOnly = True
        Me.txtPaint.Size = New System.Drawing.Size(100, 20)
        Me.txtPaint.TabIndex = 12
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(426, 185)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.ReadOnly = True
        Me.txtFloor.Size = New System.Drawing.Size(100, 20)
        Me.txtFloor.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 373)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 125)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'txtAreaOfDoors
        '
        Me.txtAreaOfDoors.Location = New System.Drawing.Point(190, 311)
        Me.txtAreaOfDoors.Name = "txtAreaOfDoors"
        Me.txtAreaOfDoors.Size = New System.Drawing.Size(121, 20)
        Me.txtAreaOfDoors.TabIndex = 15
        Me.txtAreaOfDoors.Text = "0"
        '
        'txtAreaOfWindows
        '
        Me.txtAreaOfWindows.Location = New System.Drawing.Point(190, 285)
        Me.txtAreaOfWindows.Name = "txtAreaOfWindows"
        Me.txtAreaOfWindows.Size = New System.Drawing.Size(121, 20)
        Me.txtAreaOfWindows.TabIndex = 16
        Me.txtAreaOfWindows.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Area covered by Doors (M2)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Area covered by Windows (M2)"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(286, 46)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Coats of Paint"
        '
        'cmbCoats
        '
        Me.cmbCoats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCoats.FormattingEnabled = True
        Me.cmbCoats.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbCoats.Location = New System.Drawing.Point(190, 342)
        Me.cmbCoats.Name = "cmbCoats"
        Me.cmbCoats.Size = New System.Drawing.Size(121, 21)
        Me.cmbCoats.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(126, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Room Dimensions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 534)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbCoats)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAreaOfWindows)
        Me.Controls.Add(Me.txtAreaOfDoors)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.txtPaint)
        Me.Controls.Add(Me.txtVol)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVol As System.Windows.Forms.TextBox
    Friend WithEvents txtPaint As System.Windows.Forms.TextBox
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAreaOfDoors As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaOfWindows As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbCoats As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
