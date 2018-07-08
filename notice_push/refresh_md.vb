Friend Module refresh_md
    Function refresh_menu(select_item As String)
        Dim error_msg As String
        Select Case (select_item)
            Case "all"
                error_msg = Refresh_main()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = Refresh_elec()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = Refresh_elect_total()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
                error_msg = Refresh_soft()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "main"
                error_msg = Refresh_main()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "elec"
                error_msg = Refresh_elec()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "elect_total"
                error_msg = Refresh_elect_total()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case "soft"
                error_msg = Refresh_soft()
                If error_msg IsNot Nothing Then
                    MsgBox("에러 발생 : " & error_msg)
                    End
                End If
            Case Else
                MsgBox("알수없는 오류가 발생하였습니다. 프로그램을 종료합니다.") '주입방지
                End
                Exit Select
        End Select
    End Function
End Module