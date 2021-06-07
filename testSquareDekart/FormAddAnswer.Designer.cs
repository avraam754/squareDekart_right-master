namespace testSquareDekart
{
    partial class FormAddAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAnswer.Location = new System.Drawing.Point(63, 106);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(611, 53);
            this.textBoxAnswer.TabIndex = 0;
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoint.Location = new System.Drawing.Point(63, 236);
            this.textBoxPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(132, 53);
            this.textBoxPoint.TabIndex = 1;
            this.textBoxPoint.TextChanged += new System.EventHandler(this.textBoxPoint_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добавить аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(487, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Добавить вес аргумента";
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddAnswer.Location = new System.Drawing.Point(63, 335);
            this.buttonAddAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(612, 59);
            this.buttonAddAnswer.TabIndex = 4;
            this.buttonAddAnswer.Text = "Сохранить ответ";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // FormAddAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 494);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPoint);
            this.Controls.Add(this.textBoxAnswer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddAnswer";
            this.Text = "Добавить аргумент";
            this.Load += new System.EventHandler(this.FormAddAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddAnswer;
    }
}