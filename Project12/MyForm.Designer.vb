Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyForm
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

    ' Token: 0x06000057 RID: 87 RVA: 0x00001164 File Offset: 0x00000564
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyForm))
        Me.label1 = New Global.System.Windows.Forms.Label()
        Me.textBox1 = New Global.System.Windows.Forms.TextBox()
        Me.button1 = New Global.System.Windows.Forms.Button()
        Me.pictureBox1 = New Global.System.Windows.Forms.PictureBox()
        'CType(pictureBox, Global.System.ComponentModel.ISupportInitialize).BeginInit()
        MyBase.SuspendLayout()
        Me.label1.AutoSize = True
        Me.label1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 16.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
        Me.label1.Location = New Global.System.Drawing.Point(-3, 320)
        Me.label1.Name = "label1"
        Me.label1.Size = New Global.System.Drawing.Size(508, 32)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Enter Whatsapp, Include Country code!"
        Me.label1.TextAlign = Global.System.Drawing.ContentAlignment.TopCenter
        Me.textBox1.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 16.2F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
        Me.textBox1.Location = New Global.System.Drawing.Point(528, 317)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Global.System.Drawing.Size(347, 38)
        Me.textBox1.TabIndex = 1
        Me.button1.Location = New Global.System.Drawing.Point(291, 386)
        Me.button1.Name = "button1"
        Me.button1.Size = New Global.System.Drawing.Size(283, 57)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Get Code!"
        Me.button1.UseVisualStyleBackColor = True
        AddHandler Me.button1.Click, AddressOf Me.button1_Click
        Me.pictureBox1.Image = My.Resources.pictureBox1_Image
        Me.pictureBox1.Location = New Global.System.Drawing.Point(225, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New Global.System.Drawing.Size(414, 276)
        Me.pictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 3
        Me.pictureBox1.TabStop = False
        MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(8.0F, 16.0F)
        MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
        MyBase.ClientSize = New Global.System.Drawing.Size(887, 455)
        MyBase.Controls.Add(Me.pictureBox1)
        MyBase.Controls.Add(Me.button1)
        MyBase.Controls.Add(Me.textBox1)
        MyBase.Controls.Add(Me.label1)
        MyBase.Name = "MyForm"
        Me.Text = "WhatsApp Cracker"
        'CType(Me.pictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
        MyBase.ResumeLayout(False)
        MyBase.PerformLayout()
    End Sub

    Private components As Global.System.ComponentModel.IContainer
    Friend WithEvents button1 As Button
    Friend WithEvents label1 As Label
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents pictureBox1 As PictureBox
End Class
