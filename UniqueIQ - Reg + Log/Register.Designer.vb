<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.loginlinklbl = New System.Windows.Forms.LinkLabel()
        Me.regcancelbtn = New System.Windows.Forms.Button()
        Me.regsubmitbtn = New System.Windows.Forms.Button()
        Me.ppbtn = New System.Windows.Forms.Button()
        Me.emailtxtbox = New System.Windows.Forms.TextBox()
        Me.pwdtxtbox = New System.Windows.Forms.TextBox()
        Me.telephonenotxtbox = New System.Windows.Forms.TextBox()
        Me.usernametxtbox = New System.Windows.Forms.TextBox()
        Me.emaillbl = New System.Windows.Forms.Label()
        Me.pwdlbl = New System.Windows.Forms.Label()
        Me.telephonenolbl = New System.Windows.Forms.Label()
        Me.pplbl = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.regpglbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loginlinklbl
        '
        Me.loginlinklbl.AutoSize = True
        Me.loginlinklbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlinklbl.Location = New System.Drawing.Point(413, 371)
        Me.loginlinklbl.Name = "loginlinklbl"
        Me.loginlinklbl.Size = New System.Drawing.Size(283, 19)
        Me.loginlinklbl.TabIndex = 27
        Me.loginlinklbl.TabStop = True
        Me.loginlinklbl.Text = "Already have an account?  Click here to login"
        '
        'regcancelbtn
        '
        Me.regcancelbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regcancelbtn.Location = New System.Drawing.Point(278, 352)
        Me.regcancelbtn.Name = "regcancelbtn"
        Me.regcancelbtn.Size = New System.Drawing.Size(112, 56)
        Me.regcancelbtn.TabIndex = 26
        Me.regcancelbtn.Text = "Cancel"
        Me.regcancelbtn.UseVisualStyleBackColor = True
        '
        'regsubmitbtn
        '
        Me.regsubmitbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regsubmitbtn.Location = New System.Drawing.Point(110, 352)
        Me.regsubmitbtn.Name = "regsubmitbtn"
        Me.regsubmitbtn.Size = New System.Drawing.Size(112, 56)
        Me.regsubmitbtn.TabIndex = 25
        Me.regsubmitbtn.Text = "Submit"
        Me.regsubmitbtn.UseVisualStyleBackColor = True
        '
        'ppbtn
        '
        Me.ppbtn.Location = New System.Drawing.Point(581, 194)
        Me.ppbtn.Name = "ppbtn"
        Me.ppbtn.Size = New System.Drawing.Size(179, 24)
        Me.ppbtn.TabIndex = 24
        Me.ppbtn.Text = "Button1"
        Me.ppbtn.UseVisualStyleBackColor = True
        '
        'emailtxtbox
        '
        Me.emailtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailtxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailtxtbox.Location = New System.Drawing.Point(157, 193)
        Me.emailtxtbox.Name = "emailtxtbox"
        Me.emailtxtbox.Size = New System.Drawing.Size(184, 26)
        Me.emailtxtbox.TabIndex = 23
        '
        'pwdtxtbox
        '
        Me.pwdtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pwdtxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdtxtbox.Location = New System.Drawing.Point(157, 259)
        Me.pwdtxtbox.Name = "pwdtxtbox"
        Me.pwdtxtbox.Size = New System.Drawing.Size(184, 26)
        Me.pwdtxtbox.TabIndex = 22
        '
        'telephonenotxtbox
        '
        Me.telephonenotxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.telephonenotxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephonenotxtbox.Location = New System.Drawing.Point(581, 128)
        Me.telephonenotxtbox.Name = "telephonenotxtbox"
        Me.telephonenotxtbox.Size = New System.Drawing.Size(179, 26)
        Me.telephonenotxtbox.TabIndex = 21
        '
        'usernametxtbox
        '
        Me.usernametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxtbox.Location = New System.Drawing.Point(157, 128)
        Me.usernametxtbox.Name = "usernametxtbox"
        Me.usernametxtbox.Size = New System.Drawing.Size(184, 26)
        Me.usernametxtbox.TabIndex = 20
        '
        'emaillbl
        '
        Me.emaillbl.AutoSize = True
        Me.emaillbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emaillbl.Location = New System.Drawing.Point(43, 190)
        Me.emaillbl.Name = "emaillbl"
        Me.emaillbl.Size = New System.Drawing.Size(68, 27)
        Me.emaillbl.TabIndex = 19
        Me.emaillbl.Text = "Email"
        '
        'pwdlbl
        '
        Me.pwdlbl.AutoSize = True
        Me.pwdlbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdlbl.Location = New System.Drawing.Point(43, 256)
        Me.pwdlbl.Name = "pwdlbl"
        Me.pwdlbl.Size = New System.Drawing.Size(104, 27)
        Me.pwdlbl.TabIndex = 18
        Me.pwdlbl.Text = "Password"
        '
        'telephonenolbl
        '
        Me.telephonenolbl.AutoSize = True
        Me.telephonenolbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephonenolbl.Location = New System.Drawing.Point(371, 125)
        Me.telephonenolbl.Name = "telephonenolbl"
        Me.telephonenolbl.Size = New System.Drawing.Size(195, 27)
        Me.telephonenolbl.TabIndex = 17
        Me.telephonenolbl.Text = "Telephone Number"
        '
        'pplbl
        '
        Me.pplbl.AutoSize = True
        Me.pplbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pplbl.Location = New System.Drawing.Point(371, 190)
        Me.pplbl.Name = "pplbl"
        Me.pplbl.Size = New System.Drawing.Size(152, 27)
        Me.pplbl.TabIndex = 16
        Me.pplbl.Text = "Profile Picture"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(43, 125)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(108, 27)
        Me.usernamelbl.TabIndex = 15
        Me.usernamelbl.Text = "Username"
        '
        'regpglbl
        '
        Me.regpglbl.AutoSize = True
        Me.regpglbl.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regpglbl.Location = New System.Drawing.Point(40, 43)
        Me.regpglbl.Name = "regpglbl"
        Me.regpglbl.Size = New System.Drawing.Size(301, 46)
        Me.regpglbl.TabIndex = 14
        Me.regpglbl.Text = "Registration Page"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loginlinklbl)
        Me.Controls.Add(Me.regcancelbtn)
        Me.Controls.Add(Me.regsubmitbtn)
        Me.Controls.Add(Me.ppbtn)
        Me.Controls.Add(Me.emailtxtbox)
        Me.Controls.Add(Me.pwdtxtbox)
        Me.Controls.Add(Me.telephonenotxtbox)
        Me.Controls.Add(Me.usernametxtbox)
        Me.Controls.Add(Me.emaillbl)
        Me.Controls.Add(Me.pwdlbl)
        Me.Controls.Add(Me.telephonenolbl)
        Me.Controls.Add(Me.pplbl)
        Me.Controls.Add(Me.usernamelbl)
        Me.Controls.Add(Me.regpglbl)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginlinklbl As LinkLabel
    Friend WithEvents regcancelbtn As Button
    Friend WithEvents regsubmitbtn As Button
    Friend WithEvents ppbtn As Button
    Friend WithEvents emailtxtbox As TextBox
    Friend WithEvents pwdtxtbox As TextBox
    Friend WithEvents telephonenotxtbox As TextBox
    Friend WithEvents usernametxtbox As TextBox
    Friend WithEvents emaillbl As Label
    Friend WithEvents pwdlbl As Label
    Friend WithEvents telephonenolbl As Label
    Friend WithEvents pplbl As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents regpglbl As Label
End Class
