namespace NLPMED
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inputWordTextBox1 = new System.Windows.Forms.TextBox();
            this.findAlternativesButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.word1TextBox1 = new System.Windows.Forms.TextBox();
            this.word2TextBox2 = new System.Windows.Forms.TextBox();
            this.medValuesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operationsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AlternativeWordsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trtFindAlternativesTextBox1 = new System.Windows.Forms.TextBox();
            this.trtMedValuesTextBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dictionaryFilePathTextBox1 = new System.Windows.Forms.TextBox();
            this.changeDictionarybutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputWordTextBox1
            // 
            this.inputWordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inputWordTextBox1.Location = new System.Drawing.Point(12, 86);
            this.inputWordTextBox1.Name = "inputWordTextBox1";
            this.inputWordTextBox1.Size = new System.Drawing.Size(172, 26);
            this.inputWordTextBox1.TabIndex = 0;
            // 
            // findAlternativesButton1
            // 
            this.findAlternativesButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findAlternativesButton1.Location = new System.Drawing.Point(12, 134);
            this.findAlternativesButton1.Name = "findAlternativesButton1";
            this.findAlternativesButton1.Size = new System.Drawing.Size(172, 38);
            this.findAlternativesButton1.TabIndex = 1;
            this.findAlternativesButton1.Text = "Find Alternatives";
            this.findAlternativesButton1.UseVisualStyleBackColor = true;
            this.findAlternativesButton1.Click += new System.EventHandler(this.findAlternativesButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Word :";
            // 
            // word1TextBox1
            // 
            this.word1TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word1TextBox1.Location = new System.Drawing.Point(222, 86);
            this.word1TextBox1.Name = "word1TextBox1";
            this.word1TextBox1.Size = new System.Drawing.Size(168, 26);
            this.word1TextBox1.TabIndex = 10;
            // 
            // word2TextBox2
            // 
            this.word2TextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.word2TextBox2.Location = new System.Drawing.Point(222, 143);
            this.word2TextBox2.Name = "word2TextBox2";
            this.word2TextBox2.Size = new System.Drawing.Size(168, 26);
            this.word2TextBox2.TabIndex = 11;
            // 
            // medValuesButton
            // 
            this.medValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.medValuesButton.Location = new System.Drawing.Point(222, 207);
            this.medValuesButton.Name = "medValuesButton";
            this.medValuesButton.Size = new System.Drawing.Size(168, 38);
            this.medValuesButton.TabIndex = 12;
            this.medValuesButton.Text = "MED Values";
            this.medValuesButton.UseVisualStyleBackColor = true;
            this.medValuesButton.Click += new System.EventHandler(this.medValuesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(219, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Word 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(218, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Word 2 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(223, 280);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView1.Size = new System.Drawing.Size(477, 208);
            this.dataGridView1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Alternative Words :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(218, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "MED Values Table :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(407, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Operations :";
            // 
            // operationsRichTextBox
            // 
            this.operationsRichTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.operationsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.operationsRichTextBox.Location = new System.Drawing.Point(411, 86);
            this.operationsRichTextBox.Name = "operationsRichTextBox";
            this.operationsRichTextBox.ReadOnly = true;
            this.operationsRichTextBox.Size = new System.Drawing.Size(289, 86);
            this.operationsRichTextBox.TabIndex = 19;
            this.operationsRichTextBox.Text = "";
            // 
            // AlternativeWordsRichTextBox
            // 
            this.AlternativeWordsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlternativeWordsRichTextBox.Location = new System.Drawing.Point(12, 280);
            this.AlternativeWordsRichTextBox.Name = "AlternativeWordsRichTextBox";
            this.AlternativeWordsRichTextBox.Size = new System.Drawing.Size(172, 208);
            this.AlternativeWordsRichTextBox.TabIndex = 20;
            this.AlternativeWordsRichTextBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Total Running Time :";
            // 
            // trtFindAlternativesTextBox1
            // 
            this.trtFindAlternativesTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trtFindAlternativesTextBox1.Location = new System.Drawing.Point(12, 216);
            this.trtFindAlternativesTextBox1.Name = "trtFindAlternativesTextBox1";
            this.trtFindAlternativesTextBox1.Size = new System.Drawing.Size(172, 26);
            this.trtFindAlternativesTextBox1.TabIndex = 22;
            // 
            // trtMedValuesTextBox1
            // 
            this.trtMedValuesTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.trtMedValuesTextBox1.Location = new System.Drawing.Point(411, 216);
            this.trtMedValuesTextBox1.Name = "trtMedValuesTextBox1";
            this.trtMedValuesTextBox1.Size = new System.Drawing.Size(172, 26);
            this.trtMedValuesTextBox1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(407, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Running Time :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Dictionary File Path :";
            // 
            // dictionaryFilePathTextBox1
            // 
            this.dictionaryFilePathTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dictionaryFilePathTextBox1.Location = new System.Drawing.Point(193, 22);
            this.dictionaryFilePathTextBox1.Name = "dictionaryFilePathTextBox1";
            this.dictionaryFilePathTextBox1.Size = new System.Drawing.Size(382, 26);
            this.dictionaryFilePathTextBox1.TabIndex = 26;
            this.dictionaryFilePathTextBox1.Text = "sozluk.txt";
            // 
            // changeDictionarybutton1
            // 
            this.changeDictionarybutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeDictionarybutton1.Location = new System.Drawing.Point(581, 22);
            this.changeDictionarybutton1.Name = "changeDictionarybutton1";
            this.changeDictionarybutton1.Size = new System.Drawing.Size(119, 35);
            this.changeDictionarybutton1.TabIndex = 27;
            this.changeDictionarybutton1.Text = "Change";
            this.changeDictionarybutton1.UseVisualStyleBackColor = true;
            this.changeDictionarybutton1.Click += new System.EventHandler(this.changeDictionarybutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 512);
            this.Controls.Add(this.changeDictionarybutton1);
            this.Controls.Add(this.dictionaryFilePathTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trtMedValuesTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trtFindAlternativesTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AlternativeWordsRichTextBox);
            this.Controls.Add(this.operationsRichTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medValuesButton);
            this.Controls.Add(this.word2TextBox2);
            this.Controls.Add(this.word1TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findAlternativesButton1);
            this.Controls.Add(this.inputWordTextBox1);
            this.Name = "Form1";
            this.Text = "NLP MED";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button findAlternativesButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputWordTextBox1;
        private System.Windows.Forms.TextBox word1TextBox1;
        private System.Windows.Forms.TextBox word2TextBox2;
        private System.Windows.Forms.Button medValuesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox operationsRichTextBox;
        private System.Windows.Forms.RichTextBox AlternativeWordsRichTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox trtFindAlternativesTextBox1;
        private System.Windows.Forms.TextBox trtMedValuesTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dictionaryFilePathTextBox1;
        private System.Windows.Forms.Button changeDictionarybutton1;
    }
}

