using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interface_Test
{
    class cDelCallBack
    {
        public delegate string delCallBack(string strMsg);
        public delCallBack dCall;


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
            while(_iProgressLog < 100)
            {
                _iProgressLog = _iProgressLog + 10;

                // 이 calss에 있는 delegate Function 호출
                dCall(_iProgressLog.ToString());

                Thread.Sleep(500);
            }
        }

    }
}
