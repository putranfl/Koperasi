<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jumlahperbulan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jumlahperbulan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(30, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(30, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tanggal"
        '
        'DTP
        '
        Me.DTP.Location = New System.Drawing.Point(113, 59)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(300, 20)
        Me.DTP.TabIndex = 12
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(20, 154)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1003, 317)
        Me.DGV.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(473, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 61)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(965, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'txtno
        '
        Me.txtno.Enabled = False
        Me.txtno.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtno.Location = New System.Drawing.Point(113, 12)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(300, 32)
        Me.txtno.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(30, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 22)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "NO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-3, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Dibuat Oleh : Muhammad Putra Naufal"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(896, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txttotal.Location = New System.Drawing.Point(113, 116)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(300, 32)
        Me.txttotal.TabIndex = 43
        '
        'jumlahperbulan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1040, 492)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "jumlahperbulan"
        Me.Text = "Jumlah PerBulan"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txttotal As TextBox
End Class
