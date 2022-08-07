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
    }
}
