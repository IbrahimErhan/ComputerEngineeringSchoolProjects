using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Drawing;

namespace NLPMED
{
    public partial class Form1 : Form
    {
        MED med;
        public Form1()
        {
            InitializeComponent();
            InitFiles();
        }
        private void findAlternativesButton1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch1 = new Stopwatch();
            AlternativeWordsRichTextBox.Clear();
            stopWatch1.Start();
            List<Word> alternativeWords = med.FindAlternates(inputWordTextBox1.Text.ToString());
            stopWatch1.Stop();
            trtFindAlternativesTextBox1.Text = stopWatch1.Elapsed.TotalSeconds.ToString() + " s";

            foreach (Word word in alternativeWords)
            {
                AlternativeWordsRichTextBox.AppendText(word.str + "\n");
            }
        }
        private void medValuesButton_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            string[,] gridData = med.GenerateGridData(word1TextBox1.Text, word2TextBox2.Text);
            PopulateGridView(gridData);
            WriteOperationList(gridData);
            med.FindOperations(gridData);
            stopWatch1.Stop();
            trtMedValuesTextBox1.Text = stopWatch1.Elapsed.TotalSeconds.ToString() + " s";
        }
        private void PopulateGridView(string[,] data)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            int height = data.GetLength(0);
            int width = data.GetLength(1);

            dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = data[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }
        }
        private void WriteOperationList(string[,] data)
        {
            operationsRichTextBox.Clear();
            List<string> operations = med.FindOperations(data);
            foreach (string operation in operations){
                operationsRichTextBox.AppendText(operation + "\n");
            }
            foreach (Point item in med.operationIndexes)
            {
                dataGridView1.Rows[item.X].Cells[item.Y].Style.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
            }
        }
        private void changeDictionarybutton1_Click(object sender, EventArgs e)
        {
            InitFiles();
        }
        private void InitFiles()
        {
            try
            {
                med = new MED(dictionaryFilePathTextBox1.Text);
                findAlternativesButton1.Enabled = true;
                medValuesButton.Enabled = true;
            }
            catch (Exception ex)
            {
                dictionaryFilePathTextBox1.Text = "File not found.";
                findAlternativesButton1.Enabled = false;
                medValuesButton.Enabled = false;
            }
        }
    }
}
