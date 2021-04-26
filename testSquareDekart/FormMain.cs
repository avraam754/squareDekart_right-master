using System;
using System.Windows.Forms;
using squareDekart;



namespace testSquareDekart
{
    public partial class FormMain : Form
    {
        QuestDekart decLabelI;
        QuestDekart decLabelII;
        QuestDekart decLabelIII;
        QuestDekart decLabelIV;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Answer a = new Answer("Чяго", 2);
            //Answer b = new Answer("НиЧяго", 5);
            decLabelI = new QuestDekart("Что будет если это произойдет");
            decLabelII = new QuestDekart("Что будет если это не произойдет");
            decLabelIII = new QuestDekart("Чего не будет если это произойдет");
            decLabelIV = new QuestDekart("Чего не будет если это не произойдет");

            //dec.Add(a);
            //dec.Add(b);
            listBoxAnswersI.DataSource = decLabelI.GetListAnswers();
            labelTitleI.Text = decLabelI.Title  + " " + decLabelI.SumPoint();
            labelTitleII.Text = decLabelII.Title + " " + decLabelII.SumPoint();
            labelTitleIII.Text = decLabelIII.Title + " " + decLabelIII.SumPoint();
            labelTitleIV.Text = decLabelIV.Title + " " + decLabelIV.SumPoint();
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(decLabelI);
            form.ShowDialog();
            listBoxAnswersI.DataSource = decLabelI.GetListAnswers();
        }

        private void buttonEditAnswer_Click(object sender, EventArgs e)
        {
            int index = listBoxAnswersI.SelectedIndex;
            FormEditAnswer form = new FormEditAnswer(decLabelI.GetAnswer(index));
            form.ShowDialog();
            listBoxAnswersI.DataSource = decLabelI.GetListAnswers();
           
        }

        private void labelTitleI_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitleII_Click(object sender, EventArgs e)
        {

        }

        private void labelTitleIV_Click(object sender, EventArgs e)
        {

        }
    }
}
