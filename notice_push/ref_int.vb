Module ref_int
    Public winhttp As New WinHttp.WinHttpRequest
    Public href_index(10) As String
    Public http_source As String
    Public Function refresh_main()
        Try
            Form1.ListBox1.Items.Clear()
            Dim date_hash As String
            With winhttp
                .Open("GET", "http://www.dongyang.ac.kr/web/www/-11")
                .Send()
                http_source = Split(Split(Split(.ResponseText, "table-list full-table remove-08 remove-07 i-reset")(1), "</ul>")(0), "<ul>")(0)
                For i = 2 To 11 '게시글이 10개 가정 10번 loop
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
                SaveSetting("dongyang", "last_refresh", "date", GetMd5Hash(date_hash)) '게시글 날자만 잘라서 md5으로 유효성검사
            End With
            Form1.show_date.Text = My.Computer.Clock.LocalTime
        Catch
            MsgBox("새로고침도중 오류가 발생하였습니다. 오류 내용은 다음과 같습니다." & vbCrLf & ErrorToString())
        End Try
    End Function
End Module
