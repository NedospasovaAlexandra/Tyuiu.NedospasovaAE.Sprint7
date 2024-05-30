using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.NedospasovaAE.Sprint7.Project.V4.Lib;
using System.IO;

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    public partial class FormMain_NAE : Form
    {
        public FormMain_NAE()
        {
            InitializeComponent();
            RefreshGridView();
            dataGridViewOutPutBase_NAE.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(OnColumnHeaderMouseClick);

        }
        public void OnColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1) //не сортируем -1 столбец, т.к отсчет с 0
            {
                if (dataGridViewOutPutBase_NAE.Columns[e.ColumnIndex].Name == BD_NAE.SortedColumnName)
                {
                    BD_NAE.SortDirectionASC = !BD_NAE.SortDirectionASC;
                }
                else
                {
                    BD_NAE.SortDirectionASC = true;
                    BD_NAE.SortedColumnName = dataGridViewOutPutBase_NAE.Columns[e.ColumnIndex].Name;
                }        
                BD_NAE.SortBooks();
                RefreshGridView();
            }
        }
    

        public void RefreshGridView()
        {
            dataGridViewOutPutBase_NAE.DataSource = null;
            dataGridViewOutPutBase_NAE.DataSource = BD_NAE.SortedBooks;
            dataGridViewOutPutBase_NAE.Columns["PublishYear_NAE"].HeaderText = "Год издания";
            dataGridViewOutPutBase_NAE.Columns["WriteAuthor_NAE"].HeaderText = "Автор";
            dataGridViewOutPutBase_NAE.Columns["NameBook_NAE"].HeaderText = "Название книги";
            dataGridViewOutPutBase_NAE.Columns["CountQuantity_NAE"].HeaderText = "Количество";
            dataGridViewOutPutBase_NAE.Columns["CostPrise_NAE"].HeaderText = "Цена";
            dataGridViewOutPutBase_NAE.Columns["EnrollData_NAE"].HeaderText = "Дата поступления";
        }

        private void ToolStripMenuItemShowCertificate_NAE_Click(object sender, EventArgs e)
        {
            FormAbout_NAE formAbout = new FormAbout_NAE();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuItemAboutProgram_NAE_Click(object sender, EventArgs e)
        {
            FormInfo_NAE formInfo = new FormInfo_NAE();
            formInfo.ShowDialog();
        }

        private void buttonAddLine_NAE_Click(object sender, EventArgs e)
        {
            Program.formAddEdit.IsEdit = false;
            Program.formAddEdit.Show();
            Program.formMain.Hide();
        }

        private void buttonUpdateLine_NAE_Click(object sender, EventArgs e)
        {
            if (dataGridViewOutPutBase_NAE.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
            
            Program.formAddEdit.IsEdit = true;
            Program.formAddEdit.Model = BD_NAE.SortedBooks[dataGridViewOutPutBase_NAE.CurrentCell.RowIndex]; //обращение к книге
            Program.formAddEdit.Show();
            Program.formMain.Hide();
        }

        private void buttonDeleteLine_NAE_Click(object sender, EventArgs e)
        {
            if (dataGridViewOutPutBase_NAE.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }         
            BD_NAE.Books.Remove(BD_NAE.SortedBooks[dataGridViewOutPutBase_NAE.CurrentCell.RowIndex]);
            BD_NAE.SaveToCsvFile();
            Program.formMain.RefreshGridView();
        }

        private void buttonFindElement_NAE_Click(object sender, EventArgs e)
        {
            BD_NAE.SearchString = textBoxFindElement_NAE.Text;
            BD_NAE.FindBooks();
            RefreshGridView();
            
        }

        private void buttonCalculateMin_NAE_Click(object sender, EventArgs e)
        {
            double min = (double)dataGridViewOutPutBase_NAE.Rows[0].Cells[4].Value;
            for (int i = 0; i < dataGridViewOutPutBase_NAE.RowCount; i++)
            {
                if (dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value != null && (double)dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value < min)
                {
                    min = (double)dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value;
                }
            }
            textBoxCostsMinimum_NAE.Text = min.ToString();
        }

        private void buttonCalculateMax_NAE_Click(object sender, EventArgs e)
        {
            double max = (double)dataGridViewOutPutBase_NAE.Rows[0].Cells[4].Value;
            for (int i = 0; i < dataGridViewOutPutBase_NAE.RowCount; i++)
            {
                if (dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value != null && (double)dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value > max)
                {
                    max = (double)dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value;
                }
            }
            textBoxCostsMaximum_NAE.Text = max.ToString();
        }

        private void buttonCancelSearch_NAE_Click(object sender, EventArgs e)
        {
            BD_NAE.SearchString = "";
            BD_NAE.SortBooks();
            RefreshGridView();
        }

        private void buttonShowGraph_NAE_Click(object sender, EventArgs e)
        {
            if (radioButtonChoiceHistogram_NAE.Checked)
            {
                for (int i = 0; i < dataGridViewOutPutBase_NAE.Rows.Count; i++)
                {
                    chartOutPutGraph_NAE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisX.Title = "Год издания";
                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisY.Title = "Количество";

                    int x = Convert.ToInt32(dataGridViewOutPutBase_NAE.Rows[i].Cells["PublishYear_NAE"].Value);
                    int y = Convert.ToInt32(dataGridViewOutPutBase_NAE.Rows[i].Cells["CountQuantity_NAE"].Value);
                    chartOutPutGraph_NAE.Series[0].Points.AddXY(x, y);

                }
            }

            if (radioButtonChoiceFunction_NAE.Checked)
            {
                for (int i = 0; i < dataGridViewOutPutBase_NAE.Rows.Count; i++)
                {
                    chartOutPutGraph_NAE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisX.Title = "Год издания";
                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisY.Title = "Количество";
                    chartOutPutGraph_NAE.Series[0].Points.AddXY(dataGridViewOutPutBase_NAE.Rows[i].Cells["PublishYear_NAE"].Value, dataGridViewOutPutBase_NAE.Rows[i].Cells["CountQuantity_NAE"].Value);

                }
            }
            if (radioButtonChoiceDiagram_NAE.Checked)
            {
                Dictionary<string, int> AuthorBooksCount = new Dictionary<string, int>();
                for (int i = 0; i < dataGridViewOutPutBase_NAE.Rows.Count; i++)
                {
                    chartOutPutGraph_NAE.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisX.Title = "Автор";
                    this.chartOutPutGraph_NAE.ChartAreas[0].AxisY.Title = "Количество изданий";

                    if (AuthorBooksCount.ContainsKey(Convert.ToString(dataGridViewOutPutBase_NAE.Rows[i].Cells[1].Value)))
                    {
                        AuthorBooksCount[Convert.ToString(dataGridViewOutPutBase_NAE.Rows[i].Cells[1].Value)] += 1;
                    }
                    else
                    {
                        AuthorBooksCount.Add(Convert.ToString(dataGridViewOutPutBase_NAE.Rows[i].Cells[1].Value),1);
                        
                    }   
                }
                foreach (KeyValuePair<string, int> entry in AuthorBooksCount)
                {
                    chartOutPutGraph_NAE.Series[0].Points.AddXY(entry.Key, entry.Value);
                }

            }
            buttonDeleteGraph_NAE.Enabled = true;
        }

        private void buttonDeleteGraph_NAE_Click(object sender, EventArgs e)
        {
            chartOutPutGraph_NAE.Series[0].Points.Clear();
        }

        private void buttonCalculateAv_NAE_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double average;
            for (int i = 0; i < dataGridViewOutPutBase_NAE.RowCount; i++)
            {
                sum += Convert.ToDouble(dataGridViewOutPutBase_NAE.Rows[i].Cells[4].Value);
            }
            average = Math.Round(sum / dataGridViewOutPutBase_NAE.Rows.Count, 3);
            textBoxCostsAverage_NAE.Text = average.ToString();

        }
    }
}
