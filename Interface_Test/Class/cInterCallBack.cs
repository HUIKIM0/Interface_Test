using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interface_Test
{
    /// <summary>
    /// interface를 사용 한 class에 대한 CallBack 구현
    /// interface는 부모 class에서 구현을 함 -> 자식 class는 상속 받은 interface를 정의해 주기만 하면 OK
    /// 형변환 한 interface 느슨한 결합과 비슷한 느낌
    /// </summary>
    class cInterCallBack
    {
        iCallBack _iCall;  // interface 정의 (구현은 부모 class)

        int _iCount = 1;

        // 생성자
        public cInterCallBack(iCallBack iCall) 
        {
            _iCall = iCall;   //자식 = 부모. _iCall에 부모값 넘어감
        }


        #region Thread
        public void fStart()
        {
            fThCallProgress();
        }

        Thread _thread;
        int _iProgressLog = 0;

        void fThCallProgress()
        {
            _thread = new Thread(Run);
            _thread.Start();
        }

        // 0.5초에 10씩 증가 -> 100이 되면 종료
        // 전역 상태만 변경
        private void Run()
        {
            _iProgressLog = 0;
            while (_iProgressLog<100)
            {
                _iProgressLog = _iProgressLog + 10;

                // 부모 class 에 있는 fCallBackMessage 주기적 호출
                _iCall.fCallBackMessage(_iProgressLog.ToString());  

                Thread.Sleep(500);
            }
        }
        #endregion
    }
}
