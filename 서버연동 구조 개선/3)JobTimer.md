* 잡 타이머
게임룸을 캡슐화 시키는 방법을 사용하고 있는데 극단적인 상황으로 생각했을 떄, 아무 패킷이 오지 않는다고 가정.

Update는 계속해서 돌아가야 한다. 

클라이언트처럼 서버도 무한루프로 돌리는 코드임. 그치만 좋은 방법이 x.



몬스터 ai 같은 부분에서 예약을 하는 경우가 있는데 업데이트에서 계속 확인하는 방법은 좋지 못하다. 유니티에서는 코루틴을 활용하여 시간 확인을 했었음. 

일정 시간이 되면 예약되는 시스템이 필요 -> 잡타이머

업데이트를 어느 주기별로 할 지도 결정을 해야 한다.


잡을 Action으로 관리하고 있었으나 Job으로 관리하도록 하자.

전역 Instance로 활용하던 걸 삭제. 잡 시리얼라이저에 추가해서 활용할 예정.

예약하는 아이라서 Push가 아닌 PushAfter로 함수 선언.


Push와 Flush를 나누었으니 Flush를 Update에서 호출을 해준다. 


C#의 기능을 활용해서 Update를 호출해준다. 
>>timer.Elapsed<<

