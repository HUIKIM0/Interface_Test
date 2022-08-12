using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Test
{
    public partial class InnerMain : Form, iCommon, iCallBack
    {
        Thread _thread;

        public InnerMain()
        {
            InitializeComponent();
        }

        private void InnerMain_Load(object sender, EventArgs e)
        {
            fInit();
        }

        #region Interface인 iCommon 구현
        public string strFormName 
        {
            get
            {
                return this.Text;    
            }
            set
            {
                this.Text = value;
            }
        }

        public void fColorChange(Color color)
        {
            lblInnerMain.BackColor = color;
        }

        public void fInit()
        {
            lblInnerMain.Text = $"{this.Text} Call";
        }
        #endregion


        #region Class CallBack

        cClassCallBack _ClassCallBack;

        // Loop Check
        private void btnStateLoopCheck_Click(object sender, EventArgs e)
        {
            _ClassCallBack = new cClassCallBack();
            _ClassCallBack.fStart();   // 비동기로 요청(내부에서 Thread 별도 동작)

            // 상태를 체크 할 로직 (별도 Thread)
            fTProgressCheck();

        }

        void fTProgressCheck()
        {
            _thread = new Thread(pCheck);
            _thread.Start();
        }

        /// <summary>
        /// 0.3초에 10씩 증가 하다가 100이 되면 종료
        /// </summary>
        private void pCheck()
        {
            int iCheck = 0;

            while (_ClassCallBack._iProgressLog <=100)
            {
                Invoke(new Action(delegate ()
                {
                    iCheck = _ClassCallBack._iProgressLog;
                    tsCountlbl.Text = $"{iCheck}%";
                    tsProgressBar.Value = iCheck;

                    btnStateLoopCheck.Text = (iCheck < 100) ? "Playing" : "Status Loop Check Start";


                }));
                Thread.Sleep(300);
            }

            _thread.Join();
        }
        #endregion

        #region Interface CallBack

        cInterCallBack _InterCallBack;
        private void btnInterfaceCallBack_Click(object sender, EventArgs e)
        {
            _InterCallBack = new cInterCallBack(this);
            _InterCallBack.fStart();
        }

        // Interface Funcion구현. cInterCallBack의 Thread에 의해 주기적 호출
        public string fCallBackMessage(string strMsg)
        {
            int iMsg = int.Parse(strMsg);

            Invoke(new Action(delegate ()
            {

                //interface로 CallBack응답 받음

                tsCountlbl.Text = $"{iMsg}";
                tsProgressBar.Value = iMsg;

                btnInterfaceCallBack.Text = (iMsg < 100) ? "Playing" : "Interface CallBack Start";
            }));

            return iMsg.ToString();
        }
        #endregion
    }
}
