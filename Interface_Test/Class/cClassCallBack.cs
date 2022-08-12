using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interface_Test
{
    class cClassCallBack
    {
        #region Thread로 상태 체크
        Thread _thread;
        public int _iProgressLog = 0;

        // 외부에서 fTCallProgress(Thread)를 호출하기 위한
        public void fStart()
        {
            fThCallProgress();
        }
        
        void fThCallProgress()
        {
            _thread = new Thread(Run);
            _thread.Start();
        }


        private void Run()
        {
            _iProgressLog = 0;

            while (_iProgressLog <=100)
            {
                _iProgressLog = _iProgressLog + 10;

                Thread.Sleep(500);
            }
        }
        #endregion
    }
}
