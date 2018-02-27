Module ref_elec
    Public winhttp As New WinHttp.WinHttpRequest
    Public href_index_elec(15) As String
    Public http_source_elec As String
    Public Function refresh_elec()
        Try
            Form1.ListBox2.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/epower/-34?p_p_id=Bbs_WAR_bbsportlet&p_p_lifecycle=0&p_p_state=normal&p_p_mode=view&p_p_col_id=column-1&p_p_col_count=1&_Bbs_WAR_bbsportlet_action=view")
                .Send()
                http_source_elec = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 16
                    date_hash = date_hash & Split(Split(http_source_elec, "col-05"">")(i), "</div>")(0)
                    Form1.ListBox2.Items.Add(Split(Split(http_source_elec, "<span class=""t""")(i - 1), "</span>")(0))
                    href_index_elec(i - 2) = Split(Split(http_source_elec, "href=""")(i - 1), """ class")(0)
                Next i
                If (GetSetting("dongyang", "last_refresh", "date_elec") = GetMd5Hash(date_hash)) Then
                    Form1.Label5.Text = "NO"
                Else
                    Form1.Label5.Text = "YES"
                    If Form1.CheckBox2.Checked = True Then
                        My.Computer.Audio.Play(Application.StartupPath & "\sound\ring.wav")
                    End If
                End If
                SaveSetting("dongyang", "last_refresh", "date_elec", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사
            End With
            Form1.Label9.Text = My.Computer.Clock.LocalTime
        Catch
            MsgBox("새로고침도중 오류가 발생하였습니다. 오류 내용은 다음과 같습니다." & vbCrLf & ErrorToString())
        End Try
    End Function
End Module
