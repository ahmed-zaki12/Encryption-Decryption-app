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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.txt_input = New System.Windows.Forms.TextBox()
        Me.txt_output = New System.Windows.Forms.TextBox()
        Me.btn_Encrypt = New System.Windows.Forms.Button()
        Me.btn_Decrypt = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.ComboBox_algo = New System.Windows.Forms.ComboBox()
        Me.txt_Key = New System.Windows.Forms.TextBox()
        Me.lbl_key = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Choose the algorithm"
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Location = New System.Drawing.Point(63, 311)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(45, 16)
        Me.lbl_result.TabIndex = 2
        Me.lbl_result.Text = "Result"
        '
        'txt_input
        '
        Me.txt_input.Location = New System.Drawing.Point(218, 46)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.Size = New System.Drawing.Size(122, 22)
        Me.txt_input.TabIndex = 3
        '
        'txt_output
        '
        Me.txt_output.Location = New System.Drawing.Point(218, 323)
        Me.txt_output.Name = "txt_output"
        Me.txt_output.Size = New System.Drawing.Size(122, 22)
        Me.txt_output.TabIndex = 5
        '
        'btn_Encrypt
        '
        Me.btn_Encrypt.Location = New System.Drawing.Point(190, 210)
        Me.btn_Encrypt.Name = "btn_Encrypt"
        Me.btn_Encrypt.Size = New System.Drawing.Size(84, 35)
        Me.btn_Encrypt.TabIndex = 6
        Me.btn_Encrypt.Text = "Encrypt"
        Me.btn_Encrypt.UseVisualStyleBackColor = True
        '
        'btn_Decrypt
        '
        Me.btn_Decrypt.Location = New System.Drawing.Point(321, 210)
        Me.btn_Decrypt.Name = "btn_Decrypt"
        Me.btn_Decrypt.Size = New System.Drawing.Size(87, 35)
        Me.btn_Decrypt.TabIndex = 7
        Me.btn_Decrypt.Text = "Decrypt"
        Me.btn_Decrypt.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(254, 380)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(85, 37)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Close
        '
        Me.btn_Close.Location = New System.Drawing.Point(357, 380)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(88, 37)
        Me.btn_Close.TabIndex = 9
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'ComboBox_algo
        '
        Me.ComboBox_algo.FormattingEnabled = True
        Me.ComboBox_algo.Items.AddRange(New Object() {"Caesar Cipher", "MonoAlphabetic Cipher"})
        Me.ComboBox_algo.Location = New System.Drawing.Point(218, 143)
        Me.ComboBox_algo.Name = "ComboBox_algo"
        Me.ComboBox_algo.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_algo.TabIndex = 10
        '
        'txt_Key
        '
        Me.txt_Key.Location = New System.Drawing.Point(218, 265)
        Me.txt_Key.Name = "txt_Key"
        Me.txt_Key.Size = New System.Drawing.Size(122, 22)
        Me.txt_Key.TabIndex = 11
        Me.txt_Key.Visible = False
        '
        'lbl_key
        '
        Me.lbl_key.AutoSize = True
        Me.lbl_key.Location = New System.Drawing.Point(120, 268)
        Me.lbl_key.Name = "lbl_key"
        Me.lbl_key.Size = New System.Drawing.Size(30, 16)
        Me.lbl_key.TabIndex = 12
        Me.lbl_key.Text = "Key"
        Me.lbl_key.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 450)
        Me.Controls.Add(Me.lbl_key)
        Me.Controls.Add(Me.txt_Key)
        Me.Controls.Add(Me.ComboBox_algo)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Decrypt)
        Me.Controls.Add(Me.btn_Encrypt)
        Me.Controls.Add(Me.txt_output)
        Me.Controls.Add(Me.txt_input)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_result As Label
    Friend WithEvents txt_input As TextBox
    Friend WithEvents txt_output As TextBox
    Friend WithEvents btn_Encrypt As Button
    Friend WithEvents btn_Decrypt As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Close As Button
    Friend WithEvents ComboBox_algo As ComboBox
    Friend WithEvents txt_Key As TextBox
    Friend WithEvents lbl_key As Label
End Class
