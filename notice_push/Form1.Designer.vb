<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.refresh_btt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.show_date = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show_note_nv = New System.Windows.Forms.Label()
        Me.auto_rf_chk = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.auto_rf = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.auto_rf2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refresh_btt
        '
        Me.refresh_btt.Location = New System.Drawing.Point(236, 258)
        Me.refresh_btt.Name = "refresh_btt"
        Me.refresh_btt.Size = New System.Drawing.Size(139, 21)
        Me.refresh_btt.TabIndex = 1
        Me.refresh_btt.Text = "ALL Refresh"
        Me.refresh_btt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Last refresh date:"
        '
        'show_date
        '
        Me.show_date.AutoSize = True
        Me.show_date.Location = New System.Drawing.Point(120, 8)
        Me.show_date.Name = "show_date"
        Me.show_date.Size = New System.Drawing.Size(137, 12)
        Me.show_date.TabIndex = 3
        Me.show_date.Text = "yyyy-mm-dd / HH:MM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New notice: "
        '
        'show_note_nv
        '
        Me.show_note_nv.AutoSize = True
        Me.show_note_nv.Location = New System.Drawing.Point(122, 28)
        Me.show_note_nv.Name = "show_note_nv"
        Me.show_note_nv.Size = New System.Drawing.Size(66, 12)
        Me.show_note_nv.TabIndex = 5
        Me.show_note_nv.Text = "Not loaded"
        '
        'auto_rf_chk
        '
        Me.auto_rf_chk.AutoSize = True
        Me.auto_rf_chk.Location = New System.Drawing.Point(21, 9)
        Me.auto_rf_chk.Name = "auto_rf_chk"
        Me.auto_rf_chk.Size = New System.Drawing.Size(96, 16)
        Me.auto_rf_chk.TabIndex = 6
        Me.auto_rf_chk.Text = "Auto Refresh"
        Me.auto_rf_chk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Minute"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.auto_rf_chk)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(437, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 70)
        Me.Panel1.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(13, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(55, 21)
        Me.NumericUpDown1.TabIndex = 10
        Me.NumericUpDown1.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(14, 53)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(122, 16)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "new notice alarm"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(14, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(608, 160)
        Me.ListBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "최상단 10개까지만 가져옵니다."
        '
        'auto_rf
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(14, 328)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.Size = New System.Drawing.Size(608, 160)
        Me.ListBox2.TabIndex = 21
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(14, 306)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(122, 16)
        Me.CheckBox2.TabIndex = 20
        Me.CheckBox2.Text = "new notice alarm"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.Panel2.Controls.Add(Me.CheckBox3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(437, 252)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 70)
        Me.Panel2.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 30)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(13, 37)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(55, 21)
        Me.NumericUpDown2.TabIndex = 10
        Me.NumericUpDown2.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(21, 9)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Auto Refresh"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Minute"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 12)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Not loaded"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "New notice: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "yyyy-mm-dd / HH:MM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 12)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Last refresh date:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(101, 494)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(141, 16)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.Text = "전기전자통신공(학부)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(269, 494)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(141, 16)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.Text = "전기전자통신공학(과)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(437, 494)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(165, 16)
        Me.RadioButton3.TabIndex = 25
        Me.RadioButton3.Text = "컴퓨터소프트웨어공학(과)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(309, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 12)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Not loaded"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(488, 513)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 12)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Not loaded"
        '
        'auto_rf2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 536)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.show_note_nv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.show_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.refresh_btt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents refresh_btt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents show_date As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents show_note_nv As Label
    Friend WithEvents auto_rf_chk As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents auto_rf As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents auto_rf2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
