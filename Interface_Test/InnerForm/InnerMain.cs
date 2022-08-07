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
    public partial class InnerMain : Form, iCommon
    {
        public InnerMain()
        {
            InitializeComponent();
        }

        #region Interface인 iCommon 구현
        public string strFormName { get => this.Text; set => this.Text = value; }

        public void fColorChange(Color color)
        {
            lblInnerMain.BackColor = color;
        }

        public void fInit()
        {
            lblInnerMain.Text = $"{this.Text} Call";
        }
        #endregion
    }
}
