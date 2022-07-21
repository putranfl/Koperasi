<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.txtsatuan = New System.Windows.Forms.TextBox()
        Me.TextJenis_Kelamin = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No"
        '
        'txtno
        '
        Me.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtno.Location = New System.Drawing.Point(167, 22)
        Me.txtno.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(167, 26)
        Me.txtno.TabIndex = 1
        '
        'TextNama
        '
        Me.TextNama.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNama.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextNama.Location = New System.Drawing.Point(167, 61)
        Me.TextNama.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(273, 26)
        Me.TextNama.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(30, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jenis"
        '
        'TextAlamat
        '
        Me.TextAlamat.BackColor = System.Drawing.Color.White
        Me.TextAlamat.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAlamat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextAlamat.Location = New System.Drawing.Point(759, 66)
        Me.TextAlamat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextAlamat.Name = "TextAlamat"
        Me.TextAlamat.Size = New System.Drawing.Size(76, 26)
        Me.TextAlamat.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(646, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah"
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.GridColor = System.Drawing.Color.Gray
        Me.DGV.Location = New System.Drawing.Point(0, 271)
        Me.DGV.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1003, 204)
        Me.DGV.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(646, 107)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Satuan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(30, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Harga Jual"
        '
        'txtharga
        '
        Me.txtharga.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtharga.Location = New System.Drawing.Point(167, 137)
        Me.txtharga.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(273, 26)
        Me.txtharga.TabIndex = 14
        '
        'txtsatuan
        '
        Me.txtsatuan.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsatuan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtsatuan.Location = New System.Drawing.Point(759, 106)
        Me.txtsatuan.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtsatuan.Name = "txtsatuan"
        Me.txtsatuan.Size = New System.Drawing.Size(76, 26)
        Me.txtsatuan.TabIndex = 15
        '
        'TextJenis_Kelamin
        '
        Me.TextJenis_Kelamin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJenis_Kelamin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextJenis_Kelamin.Location = New System.Drawing.Point(167, 101)
        Me.TextJenis_Kelamin.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextJenis_Kelamin.Name = "TextJenis_Kelamin"
        Me.TextJenis_Kelamin.Size = New System.Drawing.Size(167, 26)
        Me.TextJenis_Kelamin.TabIndex = 16
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1040, 492)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape4.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape4.BorderWidth = 4
        Me.RectangleShape4.CornerRadius = 20
        Me.RectangleShape4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape4.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape4.Location = New System.Drawing.Point(688, 205)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(123, 46)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape3.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape3.BorderWidth = 4
        Me.RectangleShape3.CornerRadius = 20
        Me.RectangleShape3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape3.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(549, 204)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(123, 46)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape2.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape2.BorderWidth = 4
        Me.RectangleShape2.CornerRadius = 20
        Me.RectangleShape2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape2.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape2.Location = New System.Drawing.Point(408, 204)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(123, 46)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.RectangleShape1.BorderColor = System.Drawing.Color.GhostWhite
        Me.RectangleShape1.BorderWidth = 4
        Me.RectangleShape1.CornerRadius = 20
        Me.RectangleShape1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RectangleShape1.FillColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape1.Location = New System.Drawing.Point(269, 204)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(123, 46)
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
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(297, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Simpan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(440, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Hapus"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(587, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 23)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Ubah"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(971, 90)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(725, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Reset"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-3, 479)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Dibuat Oleh : Muhammad Putra Naufal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1040, 492)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextJenis_Kelamin)
        Me.Controls.Add(Me.txtsatuan)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TextAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtno As System.Windows.Forms.TextBox
    Friend WithEvents TextNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtharga As System.Windows.Forms.TextBox
    Friend WithEvents txtsatuan As System.Windows.Forms.TextBox
    Friend WithEvents TextJenis_Kelamin As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
