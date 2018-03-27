Public Class Form1
    Public hen_menu As Integer = 0
    Public bin_hen As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        refresh_menu("all")
        CheckBox1.Checked = GetSetting("dongyang", "check_box", "alarm_stat")
        CheckBox2.Checked = GetSetting("dongyang", "check_box", "alarm2_stat")
        auto_rf_chk.Checked = GetSetting("dongyang", "check_box", "auto_rf")
        CheckBox3.Checked = GetSetting("dongyang", "check_box", "auto_rf2")
        NumericUpDown1.Value = GetSetting("dongyang", "check_box", "auto_interval")
        NumericUpDown2.Value = GetSetting("dongyang", "check_box", "auto_interval2")
        RadioButton1.Checked = GetSetting("dongyang", "check_box", "elect_elect")
        RadioButton2.Checked = GetSetting("dongyang", "check_box", "elect_elec")
        RadioButton3.Checked = GetSetting("dongyang", "check_box", "elect_soft")
        If auto_rf_chk.Checked = False Then
            NumericUpDown1.Enabled = False
        Else
            auto_rf.Interval = (NumericUpDown1.Value * 60000)
            auto_rf.Enabled = True
        End If
        If CheckBox3.Checked = False Then
            NumericUpDown2.Enabled = False
        Else
            auto_rf2.Interval = (NumericUpDown2.Value * 60000)
            auto_rf2.Enabled = True
        End If
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            RadioButton1.Checked = True
        End If
    End Sub
    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        If MsgBox(ListBox1.SelectedItem & "으로 이동하시겠습니까?", vbYesNo, "하이퍼링크") = vbYes Then
            Process.Start(href_index(ListBox1.SelectedIndex))
        End If
    End Sub
    Private Sub refresh_btt_Click(sender As Object, e As EventArgs) Handles refresh_btt.Click
        refresh_menu("all")
        If auto_rf_chk.Checked = True Then
            auto_rf.Enabled = False
            auto_rf.Interval = (NumericUpDown1.Value * 60000)
            auto_rf.Enabled = True
        End If
        If CheckBox3.Checked = True Then
            auto_rf2.Enabled = False
            auto_rf2.Interval = (NumericUpDown2.Value * 60000)
            auto_rf2.Enabled = True
        End If
    End Sub
    Private Sub auto_rf_Tick(sender As Object, e As EventArgs) Handles auto_rf.Tick
        Refresh_main()
        auto_rf.Interval = (NumericUpDown1.Value * 60000)
        auto_rf.Enabled = False
        auto_rf.Enabled = True
    End Sub
#Region "이스터애그 창출력"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        bin_hen = hen_menu
        If hen_menu = bin_hen Then
            hen_menu = Nothing
        End If
    End Sub
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        hen_menu = hen_menu + 1
        If hen_menu > 9 Then
            hen_menu = Nothing
            Form2.Show()
        End If
    End Sub
#End Region
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        SaveSetting("dongyang", "check_box", "elect_total", RadioButton1.Checked)
        refresh_menu("elect_total")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        SaveSetting("dongyang", "check_box", "elect_elec", RadioButton2.Checked)
        refresh_menu("elec")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        SaveSetting("dongyang", "check_box", "elect_soft", RadioButton3.Checked)
        refresh_menu("soft")
    End Sub

    Private Sub ListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseDoubleClick
        If RadioButton1.Checked = True Then
            If MsgBox(ListBox2.SelectedItem & "으로 이동하시겠습니까?", vbYesNo, "하이퍼링크") = vbYes Then
                Process.Start(href_index_elect_total(ListBox2.SelectedIndex))
            End If
        ElseIf RadioButton2.Checked = True Then
            If MsgBox(ListBox2.SelectedItem & "으로 이동하시겠습니까?", vbYesNo, "하이퍼링크") = vbYes Then
                Process.Start(href_index_elec(ListBox2.SelectedIndex))
            End If
        ElseIf RadioButton3.Checked = True Then
            If MsgBox(ListBox2.SelectedItem & "으로 이동하시겠습니까?", vbYesNo, "하이퍼링크") = vbYes Then
                Process.Start(href_index_soft(ListBox2.SelectedIndex))
            End If
        End If
    End Sub
    Private Sub auto_rf2_Tick(sender As Object, e As EventArgs) Handles auto_rf2.Tick
        Refresh_elec()
        Refresh_elect_total()
        Refresh_soft()
        auto_rf2.Interval = (NumericUpDown1.Value * 60000)
        auto_rf2.Enabled = False
        auto_rf2.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If CheckBox3.Checked = True Then
            auto_rf2.Enabled = False
            auto_rf2.Interval = (NumericUpDown2.Value * 60000)
            auto_rf2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles CheckBox2.MouseClick
        SaveSetting("dongyang", "check_box", "alarm2_stat", CheckBox2.Checked)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SaveSetting("dongyang", "check_box", "auto_interval2", NumericUpDown2.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveSetting("dongyang", "check_box", "auto_interval", NumericUpDown1.Value)
    End Sub
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        SaveSetting("dongyang", "check_box", "alarm_stat", CheckBox1.Checked)
    End Sub

    Private Sub auto_rf_chk_Click(sender As Object, e As EventArgs) Handles auto_rf_chk.Click
        SaveSetting("dongyang", "check_box", "auto_rf", auto_rf_chk.Checked)
        If auto_rf_chk.Checked = False Then
            NumericUpDown1.Enabled = False
            auto_rf.Enabled = False
        Else
            NumericUpDown1.Enabled = True
            auto_rf.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        SaveSetting("dongyang", "check_box", "auto_rf2", CheckBox3.Checked)
        If CheckBox3.Checked = False Then
            NumericUpDown2.Enabled = False
            auto_rf2.Enabled = False
        Else
            NumericUpDown2.Enabled = True
            auto_rf2.Enabled = True
        End If
    End Sub
End Class
