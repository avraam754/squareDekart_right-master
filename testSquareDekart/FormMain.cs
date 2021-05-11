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
            var n = decLabelI.GetAnswer(index);
            if (n != null)
            {
                FormEditAnswer form = new FormEditAnswer(decLabelI.GetAnswer(index));
                form.ShowDialog();
                listBoxAnswersI.DataSource = decLabelI.GetListAnswers();
            }
            else
            {
                MessageBox.Show("Добавьте ответ");
            }
        
        }
        private void buttonAddAnswerII_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(decLabelII);
            form.ShowDialog();
            listBoxAnswersII.DataSource = decLabelII.GetListAnswers();
        }

        private void buttonEditAnswerII_Click(object sender, EventArgs e)
        {
            int index = listBoxAnswersII.SelectedIndex;
            var n = decLabelII.GetAnswer(index);
            if (n != null)
            {
                FormEditAnswer form = new FormEditAnswer(decLabelII.GetAnswer(index));
                form.ShowDialog();
                listBoxAnswersII.DataSource = decLabelII.GetListAnswers();
            }
            else
            {
                MessageBox.Show("Добавьте ответ");
            }
        }
        private void buttonAddAnswerIII_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(decLabelIII);
            form.ShowDialog();
            listBoxAnswersIII.DataSource = decLabelIII.GetListAnswers();
        }

        private void buttonEditAnswerIII_Click(object sender, EventArgs e)
        {
            int index = listBoxAnswersIII.SelectedIndex;
            var n = decLabelIII.GetAnswer(index);
            if (n != null)
            {
                FormEditAnswer form = new FormEditAnswer(decLabelIII.GetAnswer(index));
                form.ShowDialog();
                listBoxAnswersIII.DataSource = decLabelIII.GetListAnswers();
            }
            else
            {
                MessageBox.Show("Добавьте ответ");
            }
        }
        private void buttonAddAnswerIV_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(decLabelIV);
            form.ShowDialog();
            listBoxAnswersIV.DataSource = decLabelIV.GetListAnswers();
        }

        private void buttonEditAnswerIV_Click(object sender, EventArgs e)
        {
            int index = listBoxAnswersIV.SelectedIndex;
            var n = decLabelIV.GetAnswer(index);
            if (n != null)
            {
                FormEditAnswer form = new FormEditAnswer(decLabelIV.GetAnswer(index));
                form.ShowDialog();
                listBoxAnswersIV.DataSource = decLabelIV.GetListAnswers();
            }
            else
            {
                MessageBox.Show("Добавьте ответ");
            }
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

        private void listBoxAnswersI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAnswersIII_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
