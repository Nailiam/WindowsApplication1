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
        Me.btn_FormMobil = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Input_Data_Pelanggan = New System.Windows.Forms.GroupBox()
        Me.txt_Notelepon = New System.Windows.Forms.TextBox()
        Me.txt_Alamat = New System.Windows.Forms.TextBox()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.txt_Noktp = New System.Windows.Forms.TextBox()
        Me.txt_Nopel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Input_Data_Pelanggan.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_FormMobil
        '
        Me.btn_FormMobil.Location = New System.Drawing.Point(437, 323)
        Me.btn_FormMobil.Name = "btn_FormMobil"
        Me.btn_FormMobil.Size = New System.Drawing.Size(129, 23)
        Me.btn_FormMobil.TabIndex = 43
        Me.btn_FormMobil.Text = "Form Mobil"
        Me.btn_FormMobil.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(237, 323)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 42
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(116, 323)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 41
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(22, 323)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 40
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(237, 281)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 39
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(116, 281)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(22, 281)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 37
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 290)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Pelanggan"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(17, 25)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(482, 256)
        Me.DGV.TabIndex = 0
        '
        'Input_Data_Pelanggan
        '
        Me.Input_Data_Pelanggan.Controls.Add(Me.txt_Notelepon)
        Me.Input_Data_Pelanggan.Controls.Add(Me.txt_Alamat)
        Me.Input_Data_Pelanggan.Controls.Add(Me.txt_Nama)
        Me.Input_Data_Pelanggan.Controls.Add(Me.txt_Noktp)
        Me.Input_Data_Pelanggan.Controls.Add(Me.txt_Nopel)
        Me.Input_Data_Pelanggan.Controls.Add(Me.Label5)
        Me.Input_Data_Pelanggan.Controls.Add(Me.Label4)
        Me.Input_Data_Pelanggan.Controls.Add(Me.Label3)
        Me.Input_Data_Pelanggan.Controls.Add(Me.Label2)
        Me.Input_Data_Pelanggan.Controls.Add(Me.Label1)
        Me.Input_Data_Pelanggan.Location = New System.Drawing.Point(22, 23)
        Me.Input_Data_Pelanggan.Name = "Input_Data_Pelanggan"
        Me.Input_Data_Pelanggan.Size = New System.Drawing.Size(290, 234)
        Me.Input_Data_Pelanggan.TabIndex = 35
        Me.Input_Data_Pelanggan.TabStop = False
        Me.Input_Data_Pelanggan.Text = "Input Data Pelanggan"
        '
        'txt_Notelepon
        '
        Me.txt_Notelepon.Location = New System.Drawing.Point(138, 188)
        Me.txt_Notelepon.Name = "txt_Notelepon"
        Me.txt_Notelepon.Size = New System.Drawing.Size(138, 20)
        Me.txt_Notelepon.TabIndex = 9
        '
        'txt_Alamat
        '
        Me.txt_Alamat.Location = New System.Drawing.Point(138, 155)
        Me.txt_Alamat.Name = "txt_Alamat"
        Me.txt_Alamat.Size = New System.Drawing.Size(138, 20)
        Me.txt_Alamat.TabIndex = 8
        '
        'txt_Nama
        '
        Me.txt_Nama.Location = New System.Drawing.Point(138, 116)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.Size = New System.Drawing.Size(138, 20)
        Me.txt_Nama.TabIndex = 7
        '
        'txt_Noktp
        '
        Me.txt_Noktp.Location = New System.Drawing.Point(138, 80)
        Me.txt_Noktp.Name = "txt_Noktp"
        Me.txt_Noktp.Size = New System.Drawing.Size(138, 20)
        Me.txt_Noktp.TabIndex = 6
        '
        'txt_Nopel
        '
        Me.txt_Nopel.Location = New System.Drawing.Point(138, 46)
        Me.txt_Nopel.Name = "txt_Nopel"
        Me.txt_Nopel.Size = New System.Drawing.Size(138, 20)
        Me.txt_Nopel.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No.Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No.Ktp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pelanggan"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 359)
        Me.Controls.Add(Me.btn_FormMobil)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Input_Data_Pelanggan)
        Me.Name = "Form1"
        Me.Text = "Detail Pelanggan"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Input_Data_Pelanggan.ResumeLayout(False)
        Me.Input_Data_Pelanggan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_FormMobil As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Input_Data_Pelanggan As GroupBox
    Friend WithEvents txt_Notelepon As TextBox
    Friend WithEvents txt_Alamat As TextBox
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents txt_Noktp As TextBox
    Friend WithEvents txt_Nopel As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
