using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using squareDekart;

namespace testSquareDekart
{
    public partial class FormAddAnswer : Form
    {
        QuestDekart dec;

        public FormAddAnswer(QuestDekart dec)
        {
            InitializeComponent();
            this.dec = dec;
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(Convert.ToInt32(textBoxPoint.Text)>=-5 && Convert.ToInt32(textBoxPoint.Text)<=5))
                    throw new Exception("Добавьте в вес число от -5 до 5");
                if (string.IsNullOrEmpty(textBoxAnswer.Text))
                    throw new Exception("Заполните ответ");
                Answer a = new Answer(textBoxAnswer.Text,
                                Convert.ToInt32(textBoxPoint.Text));
                dec.Add(a);
                switch (dec.Title)
                {
                    case "Что будет если это произойдет": SumPoint.sumPoint1 += a.Point; break;
                    case "Что будет если это не произойдет": SumPoint.sumPoint2 += a.Point; break;
                    case "Чего не будет если это произойдет": SumPoint.sumPoint3 += a.Point; break;
                    case "Чего не будет если это не произойдет": SumPoint.sumPoint4 += a.Point; break;
                }
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void textBoxPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddAnswer_Load(object sender, EventArgs e)
        {

        }
    }
}
