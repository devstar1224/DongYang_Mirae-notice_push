# DongYang_Mirae-notice_push

> 참고

최종적으로 exe생성후 같은 폴더 (app.path) 내부에 sound\ring.wav 라는 파일이 있어야 알람이 울림.

------------------

2018-02-27 / 업로드 

> 동양미래대학교 공지사항 홈페이지연동 - 전기과, 컴퓨터소프트웨어과 중심으로 과 홈페이지 공지사항 연결
- 아직 초기 단계이어서 오류가 아직 많음.
- 이 코드는 매우 더러움.. 또한 알고리즘이 매우 않좋음. 추후 개선함.

2018-03-23 / 모듈분리

> 새로고침부분 모듈로 분리
- 에러알림 연속으로 뜨던것을 한번만뜨게 수정.
- 코드가 더 더러워짐...

2018-03-27 / 새로고침 모듈 통합화

> 새로고침부분 모듈통합
- 지저분한 모듈들 하나로 통합 

2018-08-06 / 버그 수정

> 프로그램 킬때 이전 설정이 저장되지 않은 버그 수정
> 프로그램 킬때 로딩속도 개선을 위해 모든공지사항을 새로고침을 하지않고 이전에 설정한 과와 공지사항만 새로고침.(최초 실행일 경우 기본값 설정 로딩)
> 프로그램이 로딩이 되지 않았을때 yes/no 로 뜨던 상태를 Not loaded로 초기값으로 설정

추후 UI 개선할 예정이며, 다른 다른과도 조회가 가능하도록 수정예정.