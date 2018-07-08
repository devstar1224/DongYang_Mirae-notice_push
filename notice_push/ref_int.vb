Module ref_int
    Public winhttp As New WinHttp.WinHttpRequest
    Public href_index(10) As String
    Public http_source As String
#Region "source_soft"
    Public href_index_soft(15) As String
    Public http_source_soft As String
#End Region
#Region "elect_total"
    Public href_index_elect_total(15) As String
    Public http_source_elect_total As String
#End Region
#Region "elect"
    Public href_index_elec(15) As String
    Public http_source_elec As String
#End Region
#Region "refresh_main"
    Public Function Refresh_main()
        Try
            Form1.ListBox1.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/www/-11")
                .Send()
                http_source = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 11 '게시글 10개 가져오기
                    date_hash = date_hash & Split(Split(http_source, "col-05"">")(i), "</div>")(0)
                    Form1.ListBox1.Items.Add(Split(Split(http_source, "<span class=""t""")(i - 1), "</span>")(0))
                    href_index(i - 2) = Split(Split(http_source, "href=""")(i - 1), """ class")(0)
                Next i
                If (GetSetting("dongyang", "last_refresh", "date") = GetMd5Hash(date_hash)) Then
                    Form1.show_note_nv.Text = "NO"
                Else
                    Form1.show_note_nv.Text = "YES"
                    If Form1.CheckBox1.Checked = True Then
                        My.Computer.Audio.Play(Application.StartupPath & "\sound\ring.wav")
                    End If
                End If
                SaveSetting("dongyang", "last_refresh", "date", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사 저장
            End With
            Form1.show_date.Text = My.Computer.Clock.LocalTime
            Return (Nothing)
        Catch
            Return (ErrorToString())
        End Try
    End Function
#End Region
#Region "refresh_soft"
    Public Function Refresh_soft()
        Try
            Form1.ListBox2.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/computer/-17?p_p_id=Bbs_WAR_bbsportlet&p_p_lifecycle=0&p_p_state=normal&p_p_mode=view&p_p_col_id=column-1&p_p_col_count=1&_Bbs_WAR_bbsportlet_action=view")
                .Send()
                http_source_soft = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 16
                    date_hash = date_hash & Split(Split(http_source_soft, "col-05"">")(i), "</div>")(0)
                    Form1.ListBox2.Items.Add(Split(Split(http_source_soft, "<span class=""t""")(i - 1), "</span>")(0))
                    href_index_soft(i - 2) = Split(Split(http_source_soft, "href=""")(i - 1), """ class")(0)
                Next i
                If (GetSetting("dongyang", "last_refresh", "date_soft") = GetMd5Hash(date_hash)) Then
                    Form1.Label11.Text = "NO"
                Else
                    Form1.Label11.Text = "YES"
                    If Form1.CheckBox2.Checked = True Then
                        My.Computer.Audio.Play(Application.StartupPath & "\sound\ring.wav")
                    End If
                End If
                SaveSetting("dongyang", "last_refresh", "date_soft", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사
            End With
            Form1.Label9.Text = My.Computer.Clock.LocalTime
            Return (Nothing)
        Catch
            Return (ErrorToString())
        End Try
    End Function
#End Region
#Region "refresh_elect_total"
    Public Function Refresh_elect_total()
        Try
            Form1.ListBox2.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/epower/-19")
                .Send()
                http_source_elect_total = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 16 ' 게시글이 15개
                    date_hash = date_hash & Split(Split(http_source_elect_total, "col-05"">")(i), "</div>")(0)
                    Form1.ListBox2.Items.Add(Split(Split(http_source_elect_total, "<span class=""t""")(i - 1), "</span>")(0))
                    href_index_elect_total(i - 2) = Split(Split(http_source_elect_total, "href=""")(i - 1), """ class")(0)
                Next i
                If (GetSetting("dongyang", "last_refresh", "date_elect_total") = GetMd5Hash(date_hash)) Then
                    Form1.Label7.Text = "NO"
                Else
                    Form1.Label7.Text = "YES"
                    If Form1.CheckBox2.Checked = True Then
                        My.Computer.Audio.Play(Application.StartupPath & "\sound\ring.wav")
                    End If
                End If
                SaveSetting("dongyang", "last_refresh", "date_elect_total", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사
            End With
            Form1.Label9.Text = My.Computer.Clock.LocalTime
            Return (Nothing)
        Catch
            Return (ErrorToString())
        End Try
    End Function
#End Region
#Region "refresh_elect"
    Public Function Refresh_elec()
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
            Return (Nothing)
        Catch
            Return (ErrorToString())
        End Try
    End Function
#End Region
End Module
