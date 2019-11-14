<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.logcancelbtn = New System.Windows.Forms.Button()
        Me.logsubmitbtn = New System.Windows.Forms.Button()
        Me.pwdtxtbox = New System.Windows.Forms.TextBox()
        Me.usernametxtbox = New System.Windows.Forms.TextBox()
        Me.pwdlbl = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        Me.loginpglbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loginlinklbl
        '
        Me.loginlinklbl.AutoSize = True
        Me.loginlinklbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginlinklbl.Location = New System.Drawing.Point(404, 339)
        Me.loginlinklbl.Name = "loginlinklbl"
        Me.loginlinklbl.Size = New System.Drawing.Size(310, 19)
        Me.loginlinklbl.TabIndex = 26
        Me.loginlinklbl.TabStop = True
        Me.loginlinklbl.Text = "Need to register?  Click here to create an account"
        '
        'logcancelbtn
        '
        Me.logcancelbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logcancelbtn.Location = New System.Drawing.Point(269, 320)
        Me.logcancelbtn.Name = "logcancelbtn"
        Me.logcancelbtn.Size = New System.Drawing.Size(112, 56)
        Me.logcancelbtn.TabIndex = 25
        Me.logcancelbtn.Text = "Cancel"
        Me.logcancelbtn.UseVisualStyleBackColor = True
        '
        'logsubmitbtn
        '
        Me.logsubmitbtn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsubmitbtn.Location = New System.Drawing.Point(101, 320)
        Me.logsubmitbtn.Name = "logsubmitbtn"
        Me.logsubmitbtn.Size = New System.Drawing.Size(112, 56)
        Me.logsubmitbtn.TabIndex = 24
        Me.logsubmitbtn.Text = "Submit"
        Me.logsubmitbtn.UseVisualStyleBackColor = True
        '
        'pwdtxtbox
        '
        Me.pwdtxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pwdtxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdtxtbox.Location = New System.Drawing.Point(203, 230)
        Me.pwdtxtbox.Name = "pwdtxtbox"
        Me.pwdtxtbox.Size = New System.Drawing.Size(184, 26)
        Me.pwdtxtbox.TabIndex = 23
        '
        'usernametxtbox
        '
        Me.usernametxtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxtbox.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxtbox.Location = New System.Drawing.Point(203, 160)
        Me.usernametxtbox.Name = "usernametxtbox"
        Me.usernametxtbox.Size = New System.Drawing.Size(184, 26)
        Me.usernametxtbox.TabIndex = 22
        '
        'pwdlbl
        '
        Me.pwdlbl.AutoSize = True
        Me.pwdlbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwdlbl.Location = New System.Drawing.Point(89, 227)
        Me.pwdlbl.Name = "pwdlbl"
        Me.pwdlbl.Size = New System.Drawing.Size(104, 27)
        Me.pwdlbl.TabIndex = 21
        Me.pwdlbl.Text = "Password"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(89, 157)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(108, 27)
        Me.usernamelbl.TabIndex = 20
        Me.usernamelbl.Text = "Username"
        '
        'loginpglbl
        '
        Me.loginpglbl.AutoSize = True
        Me.loginpglbl.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginpglbl.Location = New System.Drawing.Point(86, 75)
        Me.loginpglbl.Name = "loginpglbl"
        Me.loginpglbl.Size = New System.Drawing.Size(200, 46)
        Me.loginpglbl.TabIndex = 19
        Me.loginpglbl.Text = "Login Page"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.loginlinklbl)
        Me.Controls.Add(Me.logcancelbtn)
        Me.Controls.Add(Me.logsubmitbtn)
        Me.Controls.Add(Me.pwdtxtbox)
        Me.Controls.Add(Me.usernametxtbox)
        Me.Controls.Add(Me.pwdlbl)
        Me.Controls.Add(Me.usernamelbl)
        Me.Controls.Add(Me.loginpglbl)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginlinklbl As LinkLabel
    Friend WithEvents logcancelbtn As Button
    Friend WithEvents logsubmitbtn As Button
    Friend WithEvents pwdtxtbox As TextBox
    Friend WithEvents usernametxtbox As TextBox
    Friend WithEvents pwdlbl As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents loginpglbl As Label
End Class
