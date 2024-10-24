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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabCustDet = New System.Windows.Forms.TabPage()
        Me.grpboxAuthPage = New System.Windows.Forms.GroupBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAccStatus = New System.Windows.Forms.Label()
        Me.lbURL = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFax = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblVATNum = New System.Windows.Forms.Label()
        Me.lblContactName = New System.Windows.Forms.Label()
        Me.lblPostCode = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtAccStatus = New System.Windows.Forms.TextBox()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtVATNum = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAccountNum = New System.Windows.Forms.TextBox()
        Me.tabDefSett = New System.Windows.Forms.TabPage()
        Me.tabCreditControl = New System.Windows.Forms.TabPage()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabCustDet.SuspendLayout()
        Me.grpboxAuthPage.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCustDet)
        Me.TabControl1.Controls.Add(Me.tabDefSett)
        Me.TabControl1.Controls.Add(Me.tabCreditControl)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1353, 658)
        Me.TabControl1.TabIndex = 0
        '
        'tabCustDet
        '
        Me.tabCustDet.BackColor = System.Drawing.SystemColors.Control
        Me.tabCustDet.Controls.Add(Me.grpboxAuthPage)
        Me.tabCustDet.Controls.Add(Me.DataGridView1)
        Me.tabCustDet.Controls.Add(Me.btnExitProgram)
        Me.tabCustDet.Controls.Add(Me.btnDelete)
        Me.tabCustDet.Controls.Add(Me.btnPrevious)
        Me.tabCustDet.Controls.Add(Me.btnNext)
        Me.tabCustDet.Controls.Add(Me.btnSave)
        Me.tabCustDet.Controls.Add(Me.btnAdd)
        Me.tabCustDet.Controls.Add(Me.lblAccStatus)
        Me.tabCustDet.Controls.Add(Me.lbURL)
        Me.tabCustDet.Controls.Add(Me.lblEmail)
        Me.tabCustDet.Controls.Add(Me.lblFax)
        Me.tabCustDet.Controls.Add(Me.lblTelephone)
        Me.tabCustDet.Controls.Add(Me.lblMobile)
        Me.tabCustDet.Controls.Add(Me.lblBalance)
        Me.tabCustDet.Controls.Add(Me.lblVATNum)
        Me.tabCustDet.Controls.Add(Me.lblContactName)
        Me.tabCustDet.Controls.Add(Me.lblPostCode)
        Me.tabCustDet.Controls.Add(Me.lblAddress)
        Me.tabCustDet.Controls.Add(Me.lblName)
        Me.tabCustDet.Controls.Add(Me.lblAccount)
        Me.tabCustDet.Controls.Add(Me.txtBalance)
        Me.tabCustDet.Controls.Add(Me.txtAccStatus)
        Me.tabCustDet.Controls.Add(Me.txtURL)
        Me.tabCustDet.Controls.Add(Me.txtEmail)
        Me.tabCustDet.Controls.Add(Me.txtFax)
        Me.tabCustDet.Controls.Add(Me.txtTelephone)
        Me.tabCustDet.Controls.Add(Me.txtMobile)
        Me.tabCustDet.Controls.Add(Me.txtVATNum)
        Me.tabCustDet.Controls.Add(Me.txtContactName)
        Me.tabCustDet.Controls.Add(Me.txtPostCode)
        Me.tabCustDet.Controls.Add(Me.txtAddress)
        Me.tabCustDet.Controls.Add(Me.txtName)
        Me.tabCustDet.Controls.Add(Me.txtAccountNum)
        Me.tabCustDet.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.tabCustDet.Location = New System.Drawing.Point(4, 33)
        Me.tabCustDet.Name = "tabCustDet"
        Me.tabCustDet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustDet.Size = New System.Drawing.Size(1345, 621)
        Me.tabCustDet.TabIndex = 0
        Me.tabCustDet.Text = "Customer Details"
        '
        'grpboxAuthPage
        '
        Me.grpboxAuthPage.Controls.Add(Me.btnExit)
        Me.grpboxAuthPage.Controls.Add(Me.btnReset)
        Me.grpboxAuthPage.Controls.Add(Me.btnLogin)
        Me.grpboxAuthPage.Controls.Add(Me.lblPassword)
        Me.grpboxAuthPage.Controls.Add(Me.lblUsername)
        Me.grpboxAuthPage.Controls.Add(Me.TextBox2)
        Me.grpboxAuthPage.Controls.Add(Me.TextBox1)
        Me.grpboxAuthPage.Controls.Add(Me.Label1)
        Me.grpboxAuthPage.Location = New System.Drawing.Point(3, 6)
        Me.grpboxAuthPage.Name = "grpboxAuthPage"
        Me.grpboxAuthPage.Size = New System.Drawing.Size(1339, 619)
        Me.grpboxAuthPage.TabIndex = 33
        Me.grpboxAuthPage.TabStop = False
        Me.grpboxAuthPage.Text = "..."
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(436, 347)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 24)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(436, 264)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 24)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(537, 343)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(289, 29)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(537, 261)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(289, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(948, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory Management System"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(608, 395)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(649, 192)
        Me.DataGridView1.TabIndex = 32
        '
        'btnExitProgram
        '
        Me.btnExitProgram.Location = New System.Drawing.Point(1105, 325)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(152, 29)
        Me.btnExitProgram.TabIndex = 31
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(1105, 267)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(152, 29)
        Me.btnDelete.TabIndex = 30
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(1105, 213)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(152, 29)
        Me.btnPrevious.TabIndex = 29
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1105, 162)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(152, 29)
        Me.btnNext.TabIndex = 28
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(1105, 111)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 29)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1105, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(152, 29)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblAccStatus
        '
        Me.lblAccStatus.AutoSize = True
        Me.lblAccStatus.Location = New System.Drawing.Point(604, 320)
        Me.lblAccStatus.Name = "lblAccStatus"
        Me.lblAccStatus.Size = New System.Drawing.Size(103, 24)
        Me.lblAccStatus.TabIndex = 25
        Me.lblAccStatus.Text = "Acc. Status"
        '
        'lbURL
        '
        Me.lbURL.AutoSize = True
        Me.lbURL.Location = New System.Drawing.Point(604, 265)
        Me.lbURL.Name = "lbURL"
        Me.lbURL.Size = New System.Drawing.Size(46, 24)
        Me.lbURL.TabIndex = 24
        Me.lbURL.Text = "URL"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(604, 213)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Email"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(604, 162)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(42, 24)
        Me.lblFax.TabIndex = 22
        Me.lblFax.Text = "Fax"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(604, 114)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(103, 24)
        Me.lblTelephone.TabIndex = 21
        Me.lblTelephone.Text = "Telephone"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(604, 62)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(67, 24)
        Me.lblMobile.TabIndex = 20
        Me.lblMobile.Text = "Mobile"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(69, 485)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(78, 24)
        Me.lblBalance.TabIndex = 19
        Me.lblBalance.Text = "Balance"
        '
        'lblVATNum
        '
        Me.lblVATNum.AutoSize = True
        Me.lblVATNum.Location = New System.Drawing.Point(69, 433)
        Me.lblVATNum.Name = "lblVATNum"
        Me.lblVATNum.Size = New System.Drawing.Size(94, 24)
        Me.lblVATNum.TabIndex = 18
        Me.lblVATNum.Text = "VAT Num"
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(69, 374)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(129, 24)
        Me.lblContactName.TabIndex = 17
        Me.lblContactName.Text = "Contact Name"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(69, 322)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(97, 24)
        Me.lblPostCode.TabIndex = 16
        Me.lblPostCode.Text = "Post Code"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(69, 160)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 24)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(69, 57)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(41, 24)
        Me.lblAccount.TabIndex = 13
        Me.lblAccount.Text = "A/C"
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(224, 482)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(255, 29)
        Me.txtBalance.TabIndex = 12
        '
        'txtAccStatus
        '
        Me.txtAccStatus.Location = New System.Drawing.Point(736, 324)
        Me.txtAccStatus.Name = "txtAccStatus"
        Me.txtAccStatus.Size = New System.Drawing.Size(254, 29)
        Me.txtAccStatus.TabIndex = 11
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(736, 266)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(254, 29)
        Me.txtURL.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(736, 211)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(254, 29)
        Me.txtEmail.TabIndex = 9
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(736, 159)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(254, 29)
        Me.txtFax.TabIndex = 8
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(736, 111)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(254, 29)
        Me.txtTelephone.TabIndex = 7
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(736, 59)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(254, 29)
        Me.txtMobile.TabIndex = 6
        '
        'txtVATNum
        '
        Me.txtVATNum.Location = New System.Drawing.Point(225, 433)
        Me.txtVATNum.Name = "txtVATNum"
        Me.txtVATNum.Size = New System.Drawing.Size(254, 29)
        Me.txtVATNum.TabIndex = 5
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(225, 371)
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(254, 29)
        Me.txtContactName.TabIndex = 4
        '
        'txtPostCode
        '
        Me.txtPostCode.Location = New System.Drawing.Point(225, 316)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(254, 29)
        Me.txtPostCode.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(225, 160)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(254, 124)
        Me.txtAddress.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(225, 109)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(254, 29)
        Me.txtName.TabIndex = 1
        '
        'txtAccountNum
        '
        Me.txtAccountNum.Location = New System.Drawing.Point(225, 57)
        Me.txtAccountNum.Name = "txtAccountNum"
        Me.txtAccountNum.Size = New System.Drawing.Size(254, 29)
        Me.txtAccountNum.TabIndex = 0
        '
        'tabDefSett
        '
        Me.tabDefSett.BackColor = System.Drawing.SystemColors.Control
        Me.tabDefSett.Location = New System.Drawing.Point(4, 33)
        Me.tabDefSett.Name = "tabDefSett"
        Me.tabDefSett.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDefSett.Size = New System.Drawing.Size(1345, 621)
        Me.tabDefSett.TabIndex = 1
        Me.tabDefSett.Text = "Default Settings"
        '
        'tabCreditControl
        '
        Me.tabCreditControl.BackColor = System.Drawing.SystemColors.Control
        Me.tabCreditControl.Location = New System.Drawing.Point(4, 33)
        Me.tabCreditControl.Name = "tabCreditControl"
        Me.tabCreditControl.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCreditControl.Size = New System.Drawing.Size(1345, 621)
        Me.tabCreditControl.TabIndex = 2
        Me.tabCreditControl.Text = "Credit Control"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        Me.btnLogin.Location = New System.Drawing.Point(518, 427)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 37)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(619, 427)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 39)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(725, 427)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 39)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 661)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tabCustDet.ResumeLayout(False)
        Me.tabCustDet.PerformLayout()
        Me.grpboxAuthPage.ResumeLayout(False)
        Me.grpboxAuthPage.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCustDet As TabPage
    Friend WithEvents tabDefSett As TabPage
    Friend WithEvents tabCreditControl As TabPage
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents txtAccStatus As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtVATNum As TextBox
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAccountNum As TextBox
    Friend WithEvents lblAccStatus As Label
    Friend WithEvents lbURL As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFax As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblMobile As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblVATNum As Label
    Friend WithEvents lblContactName As Label
    Friend WithEvents lblPostCode As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblAccount As Label
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents grpboxAuthPage As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
End Class
