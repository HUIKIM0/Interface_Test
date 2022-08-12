using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Test
{
    public partial class InnerSub : Form, iCommon
    {
        public InnerSub()
        {
            InitializeComponent();
        }

        private void InnerSub_Load(object sender, EventArgs e)
        {
            fInit();
        }

        #region Interface인 iCommon 구현
        public string strFormName { get => this.Text; set => this.Text = value; }

        public void fColorChange(Color color)
        {
            lblInnerSub.BackColor = color;
        }

        public void fInit()
        {
            lblInnerSub.Text = $"{this.Text} Call";
        }

        #endregion

        #region Delegate CallBack

        cDelCallBack _DelCallBack;
        private void btnDelCallBack_Click(object sender, EventArgs e)
        {
            _DelCallBack = new cDelCallBack();

            _DelCallBack.dCall = fDelCall;  // Delegate Function Link. delegate니까 fDelCall() X

            _DelCallBack.fStart();
        }

        private string fDelCall(string strMsg)
        {
            int iMsg = int.Parse(strMsg);

            Invoke(new Action(delegate ()
            {

                tsCountlbl.Text = $"{iMsg}";
                tsProgressBar.Value = iMsg;

                btnDelCallBack.Text = (iMsg < 100) ? "Playing" : "Interface CallBack Start";
            }));

            return iMsg.ToString();
        }
        #endregion
    }
}
