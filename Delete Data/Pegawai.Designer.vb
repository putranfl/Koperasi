<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtgolongan = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.txtpusat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShagf = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtgolongan
        '
        Me.txtgolongan.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgolongan.Location = New System.Drawing.Point(403, 91)
        Me.txtgolongan.Name = "txtgolongan"
        Me.txtgolongan.Size = New System.Drawing.Size(339, 26)
        Me.txtgolongan.TabIndex = 32
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(15, 276)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1003, 204)
        Me.DGV.TabIndex = 25
        '
        'txtpusat
        '
        Me.txtpusat.BackColor = System.Drawing.Color.White
        Me.txtpusat.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpusat.Location = New System.Drawing.Point(403, 128)
        Me.txtpusat.Name = "txtpusat"
        Me.txtpusat.Size = New System.Drawing.Size(339, 26)
        Me.txtpusat.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(310, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Pusat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(307, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Golongan"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(403, 55)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(339, 26)
        Me.txtnama.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(307, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama"
        '
        'txtno
        '
        Me.txtno.BackColor = System.Drawing.Color.White
        Me.txtno.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(403, 18)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(339, 26)
        Me.txtno.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(308, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "No"
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape1.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape1.BorderWidth = 4
        Me.RectangleShape1.CornerRadius = 20
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape1.FillColor = System.Drawing.Color.SkyBlue
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(318, 204)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(123, 46)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3, Me.RectangleShagf, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1040, 492)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape2.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape2.BorderWidth = 4
        Me.RectangleShape2.CornerRadius = 20
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape2.FillColor = System.Drawing.Color.SkyBlue
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(769, 203)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(123, 46)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape3.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape3.BorderWidth = 4
        Me.RectangleShape3.CornerRadius = 20
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape3.FillColor = System.Drawing.Color.SkyBlue
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(629, 203)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(123, 46)
        '
        'RectangleShagf
        '
        Me.RectangleShagf.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShagf.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShagf.BorderWidth = 4
        Me.RectangleShagf.CornerRadius = 20
        Me.RectangleShagf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShagf.FillColor = System.Drawing.Color.SkyBlue
        Me.RectangleShagf.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShagf.Location = New System.Drawing.Point(471, 204)
        Me.RectangleShagf.Name = "RectangleShagf"
        Me.RectangleShagf.Size = New System.Drawing.Size(123, 46)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SkyBlue
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(345, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Simpan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SkyBlue
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(509, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Ubah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.SkyBlue
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(663, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 23)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Hapus"
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
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SkyBlue
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(804, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 23)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Reset"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(965, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-3, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Dibuat Oleh : Muhammad Putra Naufal"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1040, 492)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtgolongan)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtpusat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pegawai"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtgolongan As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents txtpusat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShagf As PowerPacks.RectangleShape
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
End Class
