<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaksi2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.txtpegawai = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcash = New System.Windows.Forms.TextBox()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.Label()
        Me.a = New System.Windows.Forms.Label()
        Me.txtgolongan = New System.Windows.Forms.TextBox()
        Me.txtpusat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtjual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txttotalbarang = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtjbeli = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal1 = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(446, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Pegawai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(446, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(23, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cash"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(20, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Kembalian"
        '
        'txtkode
        '
        Me.txtkode.Enabled = False
        Me.txtkode.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtkode.Location = New System.Drawing.Point(155, 19)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(216, 26)
        Me.txtkode.TabIndex = 6
        '
        'txtpegawai
        '
        Me.txtpegawai.Location = New System.Drawing.Point(588, 51)
        Me.txtpegawai.Name = "txtpegawai"
        Me.txtpegawai.Size = New System.Drawing.Size(216, 20)
        Me.txtpegawai.TabIndex = 8
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txttotal.Location = New System.Drawing.Point(588, 194)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(216, 26)
        Me.txttotal.TabIndex = 9
        '
        'txtcash
        '
        Me.txtcash.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtcash.Location = New System.Drawing.Point(155, 174)
        Me.txtcash.Multiline = True
        Me.txtcash.Name = "txtcash"
        Me.txtcash.Size = New System.Drawing.Size(216, 24)
        Me.txtcash.TabIndex = 10
        '
        'txtkembalian
        '
        Me.txtkembalian.Enabled = False
        Me.txtkembalian.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtkembalian.Location = New System.Drawing.Point(155, 231)
        Me.txtkembalian.Multiline = True
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(216, 24)
        Me.txtkembalian.TabIndex = 11
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 313)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(792, 167)
        Me.DGV.TabIndex = 12
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.SkyBlue
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnsimpan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsimpan.Location = New System.Drawing.Point(272, 262)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(83, 33)
        Me.btnsimpan.TabIndex = 13
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.SkyBlue
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnhapus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapus.Location = New System.Drawing.Point(830, 313)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(83, 33)
        Me.btnhapus.TabIndex = 14
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnproses
        '
        Me.btnproses.BackColor = System.Drawing.Color.SkyBlue
        Me.btnproses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproses.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproses.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproses.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnproses.Location = New System.Drawing.Point(865, 138)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(83, 33)
        Me.btnproses.TabIndex = 15
        Me.btnproses.Text = "Proses"
        Me.btnproses.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.SkyBlue
        Me.btnbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbatal.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbatal.Location = New System.Drawing.Point(830, 370)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(83, 33)
        Me.btnbatal.TabIndex = 16
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'DTP
        '
        Me.DTP.CalendarFont = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Location = New System.Drawing.Point(588, 19)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(216, 20)
        Me.DTP.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(446, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 22)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nama Barang"
        '
        'txtbarang
        '
        Me.txtbarang.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtbarang.Location = New System.Drawing.Point(155, 58)
        Me.txtbarang.Name = "txtbarang"
        Me.txtbarang.Size = New System.Drawing.Size(216, 26)
        Me.txtbarang.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(22, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 22)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Stok Sebelum"
        '
        'txtjumlah
        '
        Me.txtjumlah.Enabled = False
        Me.txtjumlah.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtjumlah.Location = New System.Drawing.Point(155, 85)
        Me.txtjumlah.Multiline = True
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(216, 24)
        Me.txtjumlah.TabIndex = 22
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.b.ForeColor = System.Drawing.Color.Gray
        Me.b.Location = New System.Drawing.Point(446, 111)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(50, 22)
        Me.b.TabIndex = 23
        Me.b.Text = "Pusat"
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.a.ForeColor = System.Drawing.Color.Gray
        Me.a.Location = New System.Drawing.Point(446, 81)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(81, 22)
        Me.a.TabIndex = 24
        Me.a.Text = "Golongan"
        '
        'txtgolongan
        '
        Me.txtgolongan.Enabled = False
        Me.txtgolongan.Location = New System.Drawing.Point(588, 81)
        Me.txtgolongan.Multiline = True
        Me.txtgolongan.Name = "txtgolongan"
        Me.txtgolongan.Size = New System.Drawing.Size(216, 24)
        Me.txtgolongan.TabIndex = 25
        '
        'txtpusat
        '
        Me.txtpusat.Enabled = False
        Me.txtpusat.Location = New System.Drawing.Point(588, 111)
        Me.txtpusat.Multiline = True
        Me.txtpusat.Name = "txtpusat"
        Me.txtpusat.Size = New System.Drawing.Size(216, 24)
        Me.txtpusat.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(20, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 22)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Harga Jual"
        '
        'txtjual
        '
        Me.txtjual.Enabled = False
        Me.txtjual.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtjual.Location = New System.Drawing.Point(155, 115)
        Me.txtjual.Multiline = True
        Me.txtjual.Name = "txtjual"
        Me.txtjual.Size = New System.Drawing.Size(216, 24)
        Me.txtjual.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(446, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 22)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Total Barang"
        '
        'txttotalbarang
        '
        Me.txttotalbarang.Enabled = False
        Me.txttotalbarang.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txttotalbarang.Location = New System.Drawing.Point(588, 231)
        Me.txttotalbarang.Name = "txttotalbarang"
        Me.txttotalbarang.Size = New System.Drawing.Size(216, 26)
        Me.txttotalbarang.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(937, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'txtstok
        '
        Me.txtstok.Enabled = False
        Me.txtstok.Location = New System.Drawing.Point(588, 145)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(216, 20)
        Me.txtstok.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(446, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 22)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Stok Setelah"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(865, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 33)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SkyBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(155, 261)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 34)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Kembalian"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtjbeli
        '
        Me.txtjbeli.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtjbeli.Location = New System.Drawing.Point(155, 145)
        Me.txtjbeli.Multiline = True
        Me.txtjbeli.Name = "txtjbeli"
        Me.txtjbeli.Size = New System.Drawing.Size(216, 24)
        Me.txtjbeli.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(20, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 22)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Jumlah Beli"
        '
        'txttotal1
        '
        Me.txttotal1.Location = New System.Drawing.Point(12, 313)
        Me.txttotal1.Name = "txttotal1"
        Me.txttotal1.Size = New System.Drawing.Size(10, 20)
        Me.txttotal1.TabIndex = 38
        '
        'txtno
        '
        Me.txtno.Enabled = False
        Me.txtno.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.txtno.Location = New System.Drawing.Point(484, 167)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(29, 26)
        Me.txtno.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(446, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 22)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "NO"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(830, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(-2, 479)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Dibuat Oleh : Muhammad Putra Naufal"
        '
        'transaksi2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1040, 492)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttotal1)
        Me.Controls.Add(Me.txtjbeli)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtstok)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txttotalbarang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtjual)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtpusat)
        Me.Controls.Add(Me.txtgolongan)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtbarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtkembalian)
        Me.Controls.Add(Me.txtcash)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtpegawai)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "transaksi2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents txtpegawai As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtcash As TextBox
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnproses As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbarang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents b As Label
    Friend WithEvents a As Label
    Friend WithEvents txtgolongan As TextBox
    Friend WithEvents txtpusat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtjual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txttotalbarang As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtstok As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtjbeli As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal1 As TextBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label14 As Label
End Class
