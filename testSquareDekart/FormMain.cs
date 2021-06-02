using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
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
            labelTitleI.Text = decLabelI.Title;
            labelTitleII.Text = decLabelII.Title;
            labelTitleIII.Text = decLabelIII.Title;
            labelTitleIV.Text = decLabelIV.Title;            
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            FormAddAnswer form = new FormAddAnswer(decLabelI);
            form.ShowDialog();
            labelSum1.Text = SumPoint.sumPoint1.ToString();
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
            labelSum2.Text = SumPoint.sumPoint2.ToString();
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
            labelSum3.Text = SumPoint.sumPoint3.ToString();
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
            labelSum4.Text = SumPoint.sumPoint4.ToString();
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

        private void buttonResult_Click(object sender, EventArgs e)
        {
            int Sum1 = Convert.ToInt32(labelSum1.Text);
            int Sum2 = Convert.ToInt32(labelSum2.Text);
            int Sum3 = Convert.ToInt32(labelSum3.Text);
            int Sum4 = Convert.ToInt32(labelSum4.Text);
            MessageBox.Show("За: " + (Sum1 - Sum3) + " Против: " + (Sum2 - Sum4));
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }
        public void SaveToFile()
        {
            var answerJson = JsonConvert.SerializeObject(decLabelI.GetListAnswers());
            answerJson = JsonConvert.SerializeObject(decLabelII.GetListAnswers());
            using (StreamWriter sw = new StreamWriter("listmeets.json"))
                sw.WriteLine(answerJson);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
