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
    public partial class Form1 : Form
    {
        int iMainFormCount = 1;
        int iSubFormCount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InnerMain childForm = new InnerMain();

            childForm.strFormName = $"Main Form #{iMainFormCount}";
            childForm.TopLevel = false;
            fFormLocation(childForm);
            pMain.Controls.Add(childForm);
            childForm.Show();

            iMainFormCount++;
        }

        private void subForm생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InnerSub childForm = new InnerSub();

            childForm.strFormName = string.Format("Sub Form #{0}",iSubFormCount);
            childForm.TopLevel = false;
            fFormLocation(childForm);
            pMain.Controls.Add(childForm);
            childForm.Show();

            iSubFormCount++;
        }



        #region Fuction
        // Form Location 안 겹쳐서 생성되게 
        private void fFormLocation(Form childForm)
        {
            if (pMain.Controls.Count > 0)
            {
                foreach (Form item in pMain.Controls)
                {
                    childForm.Location = new Point(item.Location.X + 20);
                }
            }
        }
        #endregion
    }
}
