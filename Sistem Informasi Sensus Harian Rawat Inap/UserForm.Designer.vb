<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim NikLabel As System.Windows.Forms.Label
        Dim Nama_lengkapLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.NikTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_lengkapTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KonfirmasiPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        NikLabel = New System.Windows.Forms.Label()
        Nama_lengkapLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NikLabel
        '
        NikLabel.AutoSize = True
        NikLabel.Location = New System.Drawing.Point(13, 27)
        NikLabel.Name = "NikLabel"
        NikLabel.Size = New System.Drawing.Size(25, 13)
        NikLabel.TabIndex = 4
        NikLabel.Text = "NIK"
        '
        'Nama_lengkapLabel
        '
        Nama_lengkapLabel.AutoSize = True
        Nama_lengkapLabel.Location = New System.Drawing.Point(13, 53)
        Nama_lengkapLabel.Name = "Nama_lengkapLabel"
        Nama_lengkapLabel.Size = New System.Drawing.Size(80, 13)
        Nama_lengkapLabel.TabIndex = 6
        Nama_lengkapLabel.Text = "Nama Lengkap"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(13, 79)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(55, 13)
        UsernameLabel.TabIndex = 8
        UsernameLabel.Text = "Username"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(13, 105)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(78, 13)
        PasswordLabel.TabIndex = 10
        PasswordLabel.Text = "Password Baru"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(13, 131)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(129, 13)
        Label1.TabIndex = 14
        Label1.Text = "Konfirmasi Password Baru"
        '
        'NikTextBox
        '
        Me.NikTextBox.Enabled = False
        Me.NikTextBox.Location = New System.Drawing.Point(160, 24)
        Me.NikTextBox.Name = "NikTextBox"
        Me.NikTextBox.Size = New System.Drawing.Size(167, 20)
        Me.NikTextBox.TabIndex = 5
        '
        'Nama_lengkapTextBox
        '
        Me.Nama_lengkapTextBox.Enabled = False
        Me.Nama_lengkapTextBox.Location = New System.Drawing.Point(160, 50)
        Me.Nama_lengkapTextBox.Name = "Nama_lengkapTextBox"
        Me.Nama_lengkapTextBox.Size = New System.Drawing.Size(167, 20)
        Me.Nama_lengkapTextBox.TabIndex = 7
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(160, 76)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.UsernameTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(160, 102)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(167, 20)
        Me.PasswordTextBox.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KonfirmasiPasswordTextBox)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(UsernameLabel)
        Me.GroupBox1.Controls.Add(NikLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameTextBox)
        Me.GroupBox1.Controls.Add(Me.NikTextBox)
        Me.GroupBox1.Controls.Add(PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.Nama_lengkapTextBox)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Nama_lengkapLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 226)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit"
        '
        'KonfirmasiPasswordTextBox
        '
        Me.KonfirmasiPasswordTextBox.Location = New System.Drawing.Point(160, 128)
        Me.KonfirmasiPasswordTextBox.Name = "KonfirmasiPasswordTextBox"
        Me.KonfirmasiPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.KonfirmasiPasswordTextBox.Size = New System.Drawing.Size(167, 20)
        Me.KonfirmasiPasswordTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 249)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserForm"
        Me.Text = "Master Data User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NikTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_lengkapTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents KonfirmasiPasswordTextBox As System.Windows.Forms.TextBox
End Class
