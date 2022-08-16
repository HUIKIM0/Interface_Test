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
        // class
        InnerMain MainForm;
        InnerSub SubForm;

        // 생성 된 form count
        int iMainFormCount = 1;
        int iSubFormCount = 1;

        // form 담을 list
        List<Form> lform = new List<Form>();

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
            MainForm = new InnerMain();

            MainForm.strFormName = $"Main Form #{iMainFormCount}";
            MainForm.TopLevel = false;
            fFormLocation(MainForm);
            pMain.Controls.Add(MainForm);
            lform.Add(MainForm);
            MainForm.Show();

            iMainFormCount++;
        }

        private void subForm생성ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForm = new InnerSub();

            SubForm.strFormName = string.Format("Sub Form #{0}",iSubFormCount);
            SubForm.TopLevel = false;
            fFormLocation(SubForm);
            pMain.Controls.Add(SubForm);
            lform.Add(SubForm);
            SubForm.Show();

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
                    childForm.Location = new Point(item.Size.Width-200);
                }
            }
        }
        #endregion

        private void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form oitem in lform)
            {
                oitem.Close();
            }
        }

        private void 선택Form색상변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cColor = new ColorDialog();

            if(cColor.ShowDialog() == DialogResult.OK)
            {
                foreach (Form oform in pMain.Controls)  
                {
                    //if(oform is InnerMain)  
                    //{
                    //    InnerMain main = oform as InnerMain; // 이거 해줘야 Lable 색 바꾸는 function 접근가능
                    //    // main.BackColor = cColor.Color; X
                    //    main.fColorChange(cColor.Color);
                    //}
                    //else if(oform is InnerSub)  
                    //{
                    //    InnerSub sub = oform as InnerSub;
                    //    sub.fColorChange(cColor.Color);
                    

                // interface 느슨한 결합. interface의 function에 다 접근
                iCommon icom = oform as iCommon;
                icom.fColorChange(cColor.Color);
                }
            }
        }
    }
}
