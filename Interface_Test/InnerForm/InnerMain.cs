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
    public partial class InnerMain : Form, iCommon
    {


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


        cCallBack _fClassMain;
        Thread _thread;

        private void btnStateLoopCheck_Click(object sender, EventArgs e)
        {
            _fClassMain = new cCallBack();
            _fClassMain.fStart();   // 비동기로 요청(내부에서 Thread 별도 동작)

            // 상태를 체크 할 로직 (별도 Thread)

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

        }
    }
}
