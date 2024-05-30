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

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    public partial class FormAddEdit_NAE : Form
    {
        public bool IsEdit;
        public Book_NAE Model;
        public FormAddEdit_NAE()
        {
            InitializeComponent();
        }

        private void buttonCancel_NAE_Click(object sender, EventArgs e)
        {
            Program.formMain.Show();
            Program.formAddEdit.Hide();
        }

        private void buttonOK_NAE_Click(object sender, EventArgs e)
        {
            if (IsEdit == false) //при добавлении новой записи
            {
                BD_NAE.Books.Add(new Book_NAE(Convert.ToInt32(textBoxPublishYear_NAE.Text), textBoxWriteAuthor_NAE.Text, textBoxNameBook_NAE.Text,
                Convert.ToInt32(textBoxCountQuantity_NAE.Text), Convert.ToDouble(textBoxCostPrise_NAE.Text), dateTimePickerDate_NAE.Value.Date));
            }
            else //при изменении существующей записи
            {
                Model.PublishYear_NAE = Convert.ToInt32(textBoxPublishYear_NAE.Text);
                Model.WriteAuthor_NAE = textBoxWriteAuthor_NAE.Text;
                Model.NameBook_NAE = textBoxNameBook_NAE.Text;
                Model.CountQuantity_NAE = Convert.ToInt32(textBoxCountQuantity_NAE.Text);
                Model.CostPrise_NAE = Convert.ToDouble(textBoxCostPrise_NAE.Text);
                Model.EnrollData_NAE = dateTimePickerDate_NAE.Value.Date;
            }

            BD_NAE.SaveToCsvFile();
            BD_NAE.SortBooks();
            Program.formMain.RefreshGridView();
            Program.formMain.Show();
            Program.formAddEdit.Hide();
        }

        private void FormAddEdit_NAE_VisibleChanged(object sender, EventArgs e)
        {

            if (IsEdit == true)
            {
                textBoxPublishYear_NAE.Text = Convert.ToString(Model.PublishYear_NAE);
                textBoxNameBook_NAE.Text = Model.NameBook_NAE;
                textBoxCostPrise_NAE.Text = Convert.ToString(Model.CostPrise_NAE);
                textBoxCountQuantity_NAE.Text = Convert.ToString(Model.CountQuantity_NAE);
                textBoxWriteAuthor_NAE.Text = Model.WriteAuthor_NAE;
                dateTimePickerDate_NAE.Value = Model.EnrollData_NAE;
            }
            else
            {
                textBoxPublishYear_NAE.Text = "";
                textBoxNameBook_NAE.Text = "";
                textBoxCostPrise_NAE.Text = "";
                textBoxCountQuantity_NAE.Text = "";
                textBoxWriteAuthor_NAE.Text = "";
                dateTimePickerDate_NAE.Value = DateTime.Now;
            }

        }
    }
}
