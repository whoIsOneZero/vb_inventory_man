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
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tabDefSett = New System.Windows.Forms.TabPage()
        Me.tabCreditControl = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tabCustDet.SuspendLayout()
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
        Me.tabCustDet.Controls.Add(Me.TextBox13)
        Me.tabCustDet.Controls.Add(Me.TextBox12)
        Me.tabCustDet.Controls.Add(Me.TextBox11)
        Me.tabCustDet.Controls.Add(Me.TextBox10)
        Me.tabCustDet.Controls.Add(Me.TextBox9)
        Me.tabCustDet.Controls.Add(Me.TextBox8)
        Me.tabCustDet.Controls.Add(Me.TextBox7)
        Me.tabCustDet.Controls.Add(Me.TextBox6)
        Me.tabCustDet.Controls.Add(Me.TextBox5)
        Me.tabCustDet.Controls.Add(Me.TextBox4)
        Me.tabCustDet.Controls.Add(Me.TextBox3)
        Me.tabCustDet.Controls.Add(Me.TextBox2)
        Me.tabCustDet.Controls.Add(Me.TextBox1)
        Me.tabCustDet.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.tabCustDet.Location = New System.Drawing.Point(4, 33)
        Me.tabCustDet.Name = "tabCustDet"
        Me.tabCustDet.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCustDet.Size = New System.Drawing.Size(1345, 621)
        Me.tabCustDet.TabIndex = 0
        Me.tabCustDet.Text = "Customer Details"
        '
        'lblAccStatus
        '
        Me.lblAccStatus.AutoSize = True
        Me.lblAccStatus.Location = New System.Drawing.Point(618, 323)
        Me.lblAccStatus.Name = "lblAccStatus"
        Me.lblAccStatus.Size = New System.Drawing.Size(103, 24)
        Me.lblAccStatus.TabIndex = 25
        Me.lblAccStatus.Text = "Acc. Status"
        '
        'lbURL
        '
        Me.lbURL.AutoSize = True
        Me.lbURL.Location = New System.Drawing.Point(618, 268)
        Me.lbURL.Name = "lbURL"
        Me.lbURL.Size = New System.Drawing.Size(46, 24)
        Me.lbURL.TabIndex = 24
        Me.lbURL.Text = "URL"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(618, 216)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(57, 24)
        Me.lblEmail.TabIndex = 23
        Me.lblEmail.Text = "Email"
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(618, 165)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(42, 24)
        Me.lblFax.TabIndex = 22
        Me.lblFax.Text = "Fax"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(618, 117)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(103, 24)
        Me.lblTelephone.TabIndex = 21
        Me.lblTelephone.Text = "Telephone"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(618, 65)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(67, 24)
        Me.lblMobile.TabIndex = 20
        Me.lblMobile.Text = "Mobile"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(36, 488)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(78, 24)
        Me.lblBalance.TabIndex = 19
        Me.lblBalance.Text = "Balance"
        '
        'lblVATNum
        '
        Me.lblVATNum.AutoSize = True
        Me.lblVATNum.Location = New System.Drawing.Point(36, 436)
        Me.lblVATNum.Name = "lblVATNum"
        Me.lblVATNum.Size = New System.Drawing.Size(94, 24)
        Me.lblVATNum.TabIndex = 18
        Me.lblVATNum.Text = "VAT Num"
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(36, 377)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(129, 24)
        Me.lblContactName.TabIndex = 17
        Me.lblContactName.Text = "Contact Name"
        '
        'lblPostCode
        '
        Me.lblPostCode.AutoSize = True
        Me.lblPostCode.Location = New System.Drawing.Point(36, 325)
        Me.lblPostCode.Name = "lblPostCode"
        Me.lblPostCode.Size = New System.Drawing.Size(97, 24)
        Me.lblPostCode.TabIndex = 16
        Me.lblPostCode.Text = "Post Code"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(36, 163)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 24)
        Me.lblAddress.TabIndex = 15
        Me.lblAddress.Text = "Address"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(36, 112)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(61, 24)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Location = New System.Drawing.Point(36, 60)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(41, 24)
        Me.lblAccount.TabIndex = 13
        Me.lblAccount.Text = "A/C"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(191, 485)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(255, 29)
        Me.TextBox13.TabIndex = 12
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(727, 325)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(254, 29)
        Me.TextBox12.TabIndex = 11
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(727, 267)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(254, 29)
        Me.TextBox11.TabIndex = 10
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(727, 212)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(254, 29)
        Me.TextBox10.TabIndex = 9
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(727, 160)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(254, 29)
        Me.TextBox9.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(727, 112)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(254, 29)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(727, 60)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(254, 29)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(192, 436)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(254, 29)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(192, 374)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(254, 29)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(192, 319)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(254, 29)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(192, 163)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(254, 124)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(192, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(254, 29)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 29)
        Me.TextBox1.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCustDet As TabPage
    Friend WithEvents tabDefSett As TabPage
    Friend WithEvents tabCreditControl As TabPage
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
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
End Class
