using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseBallGameWindows
{
    public partial class BaseGame : Form
    {
        private BaseBallGameEngine bge;

        public BaseGame()
        {
            InitializeComponent();
            bge = new BaseBallGameEngine();
            bge.Init();
            MessageBox.Show(bge.GetQuiz());
        }

        private void bInput_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(tNumber1.Text);
            }
            catch
            {
                MessageBox.Show("첫번째 숫자가 이상함");
                tNumber1.Text = "";
                return;
            }
            try
            {
                int a = int.Parse(tNumber2.Text);
            }
            catch
            {
                MessageBox.Show("두번째 숫자가 이상함");
                tNumber2.Text = "";
                return;
            }
            try
            {
                int a = int.Parse(tNumber3.Text);
            }
            catch
            {
                MessageBox.Show("세번째 숫자가 이상함");
                tNumber3.Text = "";
                return;
            }
            string input = tNumber1.Text + tNumber2.Text + tNumber3.Text;
            bge.Play(input);
            statusLable.Text = String.Format("Strike : {0}, Ball : {1}", bge.GetStrike(), bge.GetBall());
            //strike와 quiz길이가 같으면 ㅊㅋㅊㅋ 메시지 박스
            if(bge.GetStrike() == bge.GetQuizLength())
            {
                MessageBox.Show("ㅊㅋㅊㅋ");
                //Close();
                
                Clear();
                
                bge.Init();
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tNumber1.Text = "";
            tNumber2.Text = "";
            tNumber3.Text = "";
            statusLable.Text = "Play Ball!";
        }

    }
}
