
using System;

namespace Tyuiu.NedospasovaAE.Sprint7.Project.V4
{
    partial class FormMain_NAE
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStripShowActions_NAE = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemShowCertificate_NAE = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAboutProgram_NAE = new System.Windows.Forms.ToolStripMenuItem();
            this.panelLocatedTop_NAE = new System.Windows.Forms.Panel();
            this.groupBoxShowGraph_NAE = new System.Windows.Forms.GroupBox();
            this.radioButtonChoiceDiagram_NAE = new System.Windows.Forms.RadioButton();
            this.radioButtonChoiceHistogram_NAE = new System.Windows.Forms.RadioButton();
            this.radioButtonChoiceFunction_NAE = new System.Windows.Forms.RadioButton();
            this.buttonDeleteGraph_NAE = new System.Windows.Forms.Button();
            this.buttonShowGraph_NAE = new System.Windows.Forms.Button();
            this.groupBoxShowStatistics_NAE = new System.Windows.Forms.GroupBox();
            this.labelCostsMaximum_NAE = new System.Windows.Forms.Label();
            this.labelCostsMinimum_NAE = new System.Windows.Forms.Label();
            this.textBoxCostsMaximum_NAE = new System.Windows.Forms.TextBox();
            this.textBoxCostsMinimum_NAE = new System.Windows.Forms.TextBox();
            this.buttonCalculateMax_NAE = new System.Windows.Forms.Button();
            this.buttonCalculateMin_NAE = new System.Windows.Forms.Button();
            this.groupBoxShowTools_NAE = new System.Windows.Forms.GroupBox();
            this.buttonCancelSearch_NAE = new System.Windows.Forms.Button();
            this.textBoxFindElement_NAE = new System.Windows.Forms.TextBox();
            this.buttonDeleteLine_NAE = new System.Windows.Forms.Button();
            this.buttonFindElement_NAE = new System.Windows.Forms.Button();
            this.buttonUpdateLine_NAE = new System.Windows.Forms.Button();
            this.buttonAddLine_NAE = new System.Windows.Forms.Button();
            this.panelLocatedLeft_NAE = new System.Windows.Forms.Panel();
            this.groupBoxOutPutBase_NAE = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutBase_NAE = new System.Windows.Forms.DataGridView();
            this.panelLocatedRight_NAE = new System.Windows.Forms.Panel();
            this.groupBoxOutPutGraph_NAE = new System.Windows.Forms.GroupBox();
            this.chartOutPutGraph_NAE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterLocatedBetween_NAE = new System.Windows.Forms.Splitter();
            this.toolTipHelpInfo_NAE = new System.Windows.Forms.ToolTip(this.components);
            this.labelCostsAverage_NAE = new System.Windows.Forms.Label();
            this.textBoxCostsAverage_NAE = new System.Windows.Forms.TextBox();
            this.buttonCalculateAv_NAE = new System.Windows.Forms.Button();
            this.menuStripShowActions_NAE.SuspendLayout();
            this.panelLocatedTop_NAE.SuspendLayout();
            this.groupBoxShowGraph_NAE.SuspendLayout();
            this.groupBoxShowStatistics_NAE.SuspendLayout();
            this.groupBoxShowTools_NAE.SuspendLayout();
            this.panelLocatedLeft_NAE.SuspendLayout();
            this.groupBoxOutPutBase_NAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutBase_NAE)).BeginInit();
            this.panelLocatedRight_NAE.SuspendLayout();
            this.groupBoxOutPutGraph_NAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutGraph_NAE)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripShowActions_NAE
            // 
            this.menuStripShowActions_NAE.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStripShowActions_NAE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemShowCertificate_NAE,
            this.ToolStripMenuItemAboutProgram_NAE});
            this.menuStripShowActions_NAE.Location = new System.Drawing.Point(0, 0);
            this.menuStripShowActions_NAE.Name = "menuStripShowActions_NAE";
            this.menuStripShowActions_NAE.Size = new System.Drawing.Size(1284, 24);
            this.menuStripShowActions_NAE.TabIndex = 0;
            this.menuStripShowActions_NAE.Text = "menuStrip1";
            // 
            // ToolStripMenuItemShowCertificate_NAE
            // 
            this.ToolStripMenuItemShowCertificate_NAE.Name = "ToolStripMenuItemShowCertificate_NAE";
            this.ToolStripMenuItemShowCertificate_NAE.Size = new System.Drawing.Size(65, 20);
            this.ToolStripMenuItemShowCertificate_NAE.Text = "Справка";
            this.ToolStripMenuItemShowCertificate_NAE.ToolTipText = "С помощью данной кнопки вы можете \r\nознакомиться с  необходимой информацией \r\nдля" +
    " дальнейшей работы с библиотекой\r\n\r\n";
            this.ToolStripMenuItemShowCertificate_NAE.Click += new System.EventHandler(this.ToolStripMenuItemShowCertificate_NAE_Click);
            // 
            // ToolStripMenuItemAboutProgram_NAE
            // 
            this.ToolStripMenuItemAboutProgram_NAE.Name = "ToolStripMenuItemAboutProgram_NAE";
            this.ToolStripMenuItemAboutProgram_NAE.Size = new System.Drawing.Size(94, 20);
            this.ToolStripMenuItemAboutProgram_NAE.Text = "О программе";
            this.ToolStripMenuItemAboutProgram_NAE.ToolTipText = "С помощью данной кнопки вы можете \r\nознакомиться с информацией о разработчике\r\nда" +
    "нного проекта\r\n";
            this.ToolStripMenuItemAboutProgram_NAE.Click += new System.EventHandler(this.ToolStripMenuItemAboutProgram_NAE_Click);
            // 
            // panelLocatedTop_NAE
            // 
            this.panelLocatedTop_NAE.Controls.Add(this.groupBoxShowGraph_NAE);
            this.panelLocatedTop_NAE.Controls.Add(this.groupBoxShowStatistics_NAE);
            this.panelLocatedTop_NAE.Controls.Add(this.groupBoxShowTools_NAE);
            this.panelLocatedTop_NAE.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocatedTop_NAE.Location = new System.Drawing.Point(0, 24);
            this.panelLocatedTop_NAE.Name = "panelLocatedTop_NAE";
            this.panelLocatedTop_NAE.Size = new System.Drawing.Size(1284, 118);
            this.panelLocatedTop_NAE.TabIndex = 1;
            // 
            // groupBoxShowGraph_NAE
            // 
            this.groupBoxShowGraph_NAE.Controls.Add(this.radioButtonChoiceDiagram_NAE);
            this.groupBoxShowGraph_NAE.Controls.Add(this.radioButtonChoiceHistogram_NAE);
            this.groupBoxShowGraph_NAE.Controls.Add(this.radioButtonChoiceFunction_NAE);
            this.groupBoxShowGraph_NAE.Controls.Add(this.buttonDeleteGraph_NAE);
            this.groupBoxShowGraph_NAE.Controls.Add(this.buttonShowGraph_NAE);
            this.groupBoxShowGraph_NAE.Location = new System.Drawing.Point(252, 3);
            this.groupBoxShowGraph_NAE.Name = "groupBoxShowGraph_NAE";
            this.groupBoxShowGraph_NAE.Size = new System.Drawing.Size(216, 112);
            this.groupBoxShowGraph_NAE.TabIndex = 11;
            this.groupBoxShowGraph_NAE.TabStop = false;
            this.groupBoxShowGraph_NAE.Text = "График";
            // 
            // radioButtonChoiceDiagram_NAE
            // 
            this.radioButtonChoiceDiagram_NAE.AutoSize = true;
            this.radioButtonChoiceDiagram_NAE.Location = new System.Drawing.Point(125, 54);
            this.radioButtonChoiceDiagram_NAE.Name = "radioButtonChoiceDiagram_NAE";
            this.radioButtonChoiceDiagram_NAE.Size = new System.Drawing.Size(85, 17);
            this.radioButtonChoiceDiagram_NAE.TabIndex = 4;
            this.radioButtonChoiceDiagram_NAE.TabStop = true;
            this.radioButtonChoiceDiagram_NAE.Text = "Диаграмма";
            this.radioButtonChoiceDiagram_NAE.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoiceHistogram_NAE
            // 
            this.radioButtonChoiceHistogram_NAE.AutoSize = true;
            this.radioButtonChoiceHistogram_NAE.Location = new System.Drawing.Point(6, 54);
            this.radioButtonChoiceHistogram_NAE.Name = "radioButtonChoiceHistogram_NAE";
            this.radioButtonChoiceHistogram_NAE.Size = new System.Drawing.Size(93, 17);
            this.radioButtonChoiceHistogram_NAE.TabIndex = 3;
            this.radioButtonChoiceHistogram_NAE.TabStop = true;
            this.radioButtonChoiceHistogram_NAE.Text = "Гистограмма";
            this.radioButtonChoiceHistogram_NAE.UseVisualStyleBackColor = true;
            // 
            // radioButtonChoiceFunction_NAE
            // 
            this.radioButtonChoiceFunction_NAE.AutoSize = true;
            this.radioButtonChoiceFunction_NAE.Location = new System.Drawing.Point(72, 78);
            this.radioButtonChoiceFunction_NAE.Name = "radioButtonChoiceFunction_NAE";
            this.radioButtonChoiceFunction_NAE.Size = new System.Drawing.Size(71, 17);
            this.radioButtonChoiceFunction_NAE.TabIndex = 2;
            this.radioButtonChoiceFunction_NAE.TabStop = true;
            this.radioButtonChoiceFunction_NAE.Text = "Функция";
            this.radioButtonChoiceFunction_NAE.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGraph_NAE
            // 
            this.buttonDeleteGraph_NAE.Location = new System.Drawing.Point(108, 19);
            this.buttonDeleteGraph_NAE.Name = "buttonDeleteGraph_NAE";
            this.buttonDeleteGraph_NAE.Size = new System.Drawing.Size(102, 23);
            this.buttonDeleteGraph_NAE.TabIndex = 1;
            this.buttonDeleteGraph_NAE.Text = "Удалить график";
            this.buttonDeleteGraph_NAE.UseVisualStyleBackColor = true;
            this.buttonDeleteGraph_NAE.Click += new System.EventHandler(this.buttonDeleteGraph_NAE_Click);
            // 
            // buttonShowGraph_NAE
            // 
            this.buttonShowGraph_NAE.Location = new System.Drawing.Point(6, 19);
            this.buttonShowGraph_NAE.Name = "buttonShowGraph_NAE";
            this.buttonShowGraph_NAE.Size = new System.Drawing.Size(102, 23);
            this.buttonShowGraph_NAE.TabIndex = 0;
            this.buttonShowGraph_NAE.Text = "Вывести график";
            this.buttonShowGraph_NAE.UseVisualStyleBackColor = true;
            this.buttonShowGraph_NAE.Click += new System.EventHandler(this.buttonShowGraph_NAE_Click);
            // 
            // groupBoxShowStatistics_NAE
            // 
            this.groupBoxShowStatistics_NAE.Controls.Add(this.buttonCalculateAv_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.textBoxCostsAverage_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.labelCostsAverage_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.labelCostsMaximum_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.labelCostsMinimum_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.textBoxCostsMaximum_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.textBoxCostsMinimum_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.buttonCalculateMax_NAE);
            this.groupBoxShowStatistics_NAE.Controls.Add(this.buttonCalculateMin_NAE);
            this.groupBoxShowStatistics_NAE.Location = new System.Drawing.Point(474, 3);
            this.groupBoxShowStatistics_NAE.Name = "groupBoxShowStatistics_NAE";
            this.groupBoxShowStatistics_NAE.Size = new System.Drawing.Size(359, 112);
            this.groupBoxShowStatistics_NAE.TabIndex = 0;
            this.groupBoxShowStatistics_NAE.TabStop = false;
            this.groupBoxShowStatistics_NAE.Text = "Статистика";
            // 
            // labelCostsMaximum_NAE
            // 
            this.labelCostsMaximum_NAE.AutoSize = true;
            this.labelCostsMaximum_NAE.Location = new System.Drawing.Point(126, 30);
            this.labelCostsMaximum_NAE.Name = "labelCostsMaximum_NAE";
            this.labelCostsMaximum_NAE.Size = new System.Drawing.Size(111, 13);
            this.labelCostsMaximum_NAE.TabIndex = 5;
            this.labelCostsMaximum_NAE.Text = "Максимальная цена";
            // 
            // labelCostsMinimum_NAE
            // 
            this.labelCostsMinimum_NAE.AutoSize = true;
            this.labelCostsMinimum_NAE.Location = new System.Drawing.Point(10, 30);
            this.labelCostsMinimum_NAE.Name = "labelCostsMinimum_NAE";
            this.labelCostsMinimum_NAE.Size = new System.Drawing.Size(105, 13);
            this.labelCostsMinimum_NAE.TabIndex = 4;
            this.labelCostsMinimum_NAE.Text = "Минимальная цена";
            // 
            // textBoxCostsMaximum_NAE
            // 
            this.textBoxCostsMaximum_NAE.Location = new System.Drawing.Point(126, 46);
            this.textBoxCostsMaximum_NAE.Name = "textBoxCostsMaximum_NAE";
            this.textBoxCostsMaximum_NAE.ReadOnly = true;
            this.textBoxCostsMaximum_NAE.Size = new System.Drawing.Size(111, 20);
            this.textBoxCostsMaximum_NAE.TabIndex = 3;
            // 
            // textBoxCostsMinimum_NAE
            // 
            this.textBoxCostsMinimum_NAE.Location = new System.Drawing.Point(6, 46);
            this.textBoxCostsMinimum_NAE.Name = "textBoxCostsMinimum_NAE";
            this.textBoxCostsMinimum_NAE.ReadOnly = true;
            this.textBoxCostsMinimum_NAE.Size = new System.Drawing.Size(111, 20);
            this.textBoxCostsMinimum_NAE.TabIndex = 2;
            // 
            // buttonCalculateMax_NAE
            // 
            this.buttonCalculateMax_NAE.Location = new System.Drawing.Point(139, 72);
            this.buttonCalculateMax_NAE.Name = "buttonCalculateMax_NAE";
            this.buttonCalculateMax_NAE.Size = new System.Drawing.Size(88, 23);
            this.buttonCalculateMax_NAE.TabIndex = 1;
            this.buttonCalculateMax_NAE.Text = "Вычислить";
            this.buttonCalculateMax_NAE.UseVisualStyleBackColor = true;
            this.buttonCalculateMax_NAE.Click += new System.EventHandler(this.buttonCalculateMax_NAE_Click);
            // 
            // buttonCalculateMin_NAE
            // 
            this.buttonCalculateMin_NAE.Location = new System.Drawing.Point(19, 72);
            this.buttonCalculateMin_NAE.Name = "buttonCalculateMin_NAE";
            this.buttonCalculateMin_NAE.Size = new System.Drawing.Size(88, 23);
            this.buttonCalculateMin_NAE.TabIndex = 0;
            this.buttonCalculateMin_NAE.Text = "Вычислить";
            this.buttonCalculateMin_NAE.UseVisualStyleBackColor = true;
            this.buttonCalculateMin_NAE.Click += new System.EventHandler(this.buttonCalculateMin_NAE_Click);
            // 
            // groupBoxShowTools_NAE
            // 
            this.groupBoxShowTools_NAE.Controls.Add(this.buttonCancelSearch_NAE);
            this.groupBoxShowTools_NAE.Controls.Add(this.textBoxFindElement_NAE);
            this.groupBoxShowTools_NAE.Controls.Add(this.buttonDeleteLine_NAE);
            this.groupBoxShowTools_NAE.Controls.Add(this.buttonFindElement_NAE);
            this.groupBoxShowTools_NAE.Controls.Add(this.buttonUpdateLine_NAE);
            this.groupBoxShowTools_NAE.Controls.Add(this.buttonAddLine_NAE);
            this.groupBoxShowTools_NAE.Location = new System.Drawing.Point(3, 3);
            this.groupBoxShowTools_NAE.Name = "groupBoxShowTools_NAE";
            this.groupBoxShowTools_NAE.Size = new System.Drawing.Size(243, 112);
            this.groupBoxShowTools_NAE.TabIndex = 0;
            this.groupBoxShowTools_NAE.TabStop = false;
            this.groupBoxShowTools_NAE.Text = "Инструменты";
            // 
            // buttonCancelSearch_NAE
            // 
            this.buttonCancelSearch_NAE.Location = new System.Drawing.Point(126, 77);
            this.buttonCancelSearch_NAE.Name = "buttonCancelSearch_NAE";
            this.buttonCancelSearch_NAE.Size = new System.Drawing.Size(111, 20);
            this.buttonCancelSearch_NAE.TabIndex = 10;
            this.buttonCancelSearch_NAE.Text = "Отмена поиска";
            this.buttonCancelSearch_NAE.UseVisualStyleBackColor = true;
            this.buttonCancelSearch_NAE.Click += new System.EventHandler(this.buttonCancelSearch_NAE_Click);
            // 
            // textBoxFindElement_NAE
            // 
            this.textBoxFindElement_NAE.Location = new System.Drawing.Point(6, 77);
            this.textBoxFindElement_NAE.Name = "textBoxFindElement_NAE";
            this.textBoxFindElement_NAE.Size = new System.Drawing.Size(111, 20);
            this.textBoxFindElement_NAE.TabIndex = 5;
            // 
            // buttonDeleteLine_NAE
            // 
            this.buttonDeleteLine_NAE.Location = new System.Drawing.Point(126, 20);
            this.buttonDeleteLine_NAE.Name = "buttonDeleteLine_NAE";
            this.buttonDeleteLine_NAE.Size = new System.Drawing.Size(111, 23);
            this.buttonDeleteLine_NAE.TabIndex = 9;
            this.buttonDeleteLine_NAE.Text = "Удалить ";
            this.buttonDeleteLine_NAE.UseVisualStyleBackColor = true;
            this.buttonDeleteLine_NAE.Click += new System.EventHandler(this.buttonDeleteLine_NAE_Click);
            // 
            // buttonFindElement_NAE
            // 
            this.buttonFindElement_NAE.Location = new System.Drawing.Point(126, 48);
            this.buttonFindElement_NAE.Name = "buttonFindElement_NAE";
            this.buttonFindElement_NAE.Size = new System.Drawing.Size(111, 23);
            this.buttonFindElement_NAE.TabIndex = 8;
            this.buttonFindElement_NAE.Text = "Поиск ";
            this.buttonFindElement_NAE.UseVisualStyleBackColor = true;
            this.buttonFindElement_NAE.Click += new System.EventHandler(this.buttonFindElement_NAE_Click);
            // 
            // buttonUpdateLine_NAE
            // 
            this.buttonUpdateLine_NAE.Location = new System.Drawing.Point(6, 48);
            this.buttonUpdateLine_NAE.Name = "buttonUpdateLine_NAE";
            this.buttonUpdateLine_NAE.Size = new System.Drawing.Size(111, 23);
            this.buttonUpdateLine_NAE.TabIndex = 7;
            this.buttonUpdateLine_NAE.Text = "Изменить";
            this.buttonUpdateLine_NAE.UseVisualStyleBackColor = true;
            this.buttonUpdateLine_NAE.Click += new System.EventHandler(this.buttonUpdateLine_NAE_Click);
            // 
            // buttonAddLine_NAE
            // 
            this.buttonAddLine_NAE.Location = new System.Drawing.Point(6, 20);
            this.buttonAddLine_NAE.Name = "buttonAddLine_NAE";
            this.buttonAddLine_NAE.Size = new System.Drawing.Size(111, 23);
            this.buttonAddLine_NAE.TabIndex = 6;
            this.buttonAddLine_NAE.Text = "Добавить";
            this.buttonAddLine_NAE.UseVisualStyleBackColor = true;
            this.buttonAddLine_NAE.Click += new System.EventHandler(this.buttonAddLine_NAE_Click);
            // 
            // panelLocatedLeft_NAE
            // 
            this.panelLocatedLeft_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.panelLocatedLeft_NAE.Controls.Add(this.groupBoxOutPutBase_NAE);
            this.panelLocatedLeft_NAE.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLocatedLeft_NAE.Location = new System.Drawing.Point(0, 142);
            this.panelLocatedLeft_NAE.Name = "panelLocatedLeft_NAE";
            this.panelLocatedLeft_NAE.Size = new System.Drawing.Size(615, 419);
            this.panelLocatedLeft_NAE.TabIndex = 0;
            // 
            // groupBoxOutPutBase_NAE
            // 
            this.groupBoxOutPutBase_NAE.Controls.Add(this.dataGridViewOutPutBase_NAE);
            this.groupBoxOutPutBase_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutBase_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutBase_NAE.Name = "groupBoxOutPutBase_NAE";
            this.groupBoxOutPutBase_NAE.Size = new System.Drawing.Size(615, 419);
            this.groupBoxOutPutBase_NAE.TabIndex = 0;
            this.groupBoxOutPutBase_NAE.TabStop = false;
            this.groupBoxOutPutBase_NAE.Text = "База данных";
            // 
            // dataGridViewOutPutBase_NAE
            // 
            this.dataGridViewOutPutBase_NAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutBase_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPutBase_NAE.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPutBase_NAE.Name = "dataGridViewOutPutBase_NAE";
            this.dataGridViewOutPutBase_NAE.ReadOnly = true;
            this.dataGridViewOutPutBase_NAE.Size = new System.Drawing.Size(609, 400);
            this.dataGridViewOutPutBase_NAE.TabIndex = 0;
            // 
            // panelLocatedRight_NAE
            // 
            this.panelLocatedRight_NAE.BackColor = System.Drawing.SystemColors.Control;
            this.panelLocatedRight_NAE.Controls.Add(this.groupBoxOutPutGraph_NAE);
            this.panelLocatedRight_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLocatedRight_NAE.Location = new System.Drawing.Point(615, 142);
            this.panelLocatedRight_NAE.Name = "panelLocatedRight_NAE";
            this.panelLocatedRight_NAE.Size = new System.Drawing.Size(669, 419);
            this.panelLocatedRight_NAE.TabIndex = 0;
            // 
            // groupBoxOutPutGraph_NAE
            // 
            this.groupBoxOutPutGraph_NAE.Controls.Add(this.chartOutPutGraph_NAE);
            this.groupBoxOutPutGraph_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPutGraph_NAE.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPutGraph_NAE.Name = "groupBoxOutPutGraph_NAE";
            this.groupBoxOutPutGraph_NAE.Size = new System.Drawing.Size(669, 419);
            this.groupBoxOutPutGraph_NAE.TabIndex = 0;
            this.groupBoxOutPutGraph_NAE.TabStop = false;
            this.groupBoxOutPutGraph_NAE.Text = "График";
            // 
            // chartOutPutGraph_NAE
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOutPutGraph_NAE.ChartAreas.Add(chartArea2);
            this.chartOutPutGraph_NAE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartOutPutGraph_NAE.Legends.Add(legend2);
            this.chartOutPutGraph_NAE.Location = new System.Drawing.Point(3, 16);
            this.chartOutPutGraph_NAE.Name = "chartOutPutGraph_NAE";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOutPutGraph_NAE.Series.Add(series2);
            this.chartOutPutGraph_NAE.Size = new System.Drawing.Size(663, 400);
            this.chartOutPutGraph_NAE.TabIndex = 1;
            this.chartOutPutGraph_NAE.Text = "chart1";
            // 
            // splitterLocatedBetween_NAE
            // 
            this.splitterLocatedBetween_NAE.Location = new System.Drawing.Point(615, 142);
            this.splitterLocatedBetween_NAE.Name = "splitterLocatedBetween_NAE";
            this.splitterLocatedBetween_NAE.Size = new System.Drawing.Size(3, 419);
            this.splitterLocatedBetween_NAE.TabIndex = 2;
            this.splitterLocatedBetween_NAE.TabStop = false;
            // 
            // toolTipHelpInfo_NAE
            // 
            this.toolTipHelpInfo_NAE.IsBalloon = true;
            this.toolTipHelpInfo_NAE.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipHelpInfo_NAE.ToolTipTitle = "Подсказка";
            // 
            // labelCostsAverage_NAE
            // 
            this.labelCostsAverage_NAE.AutoSize = true;
            this.labelCostsAverage_NAE.Location = new System.Drawing.Point(260, 30);
            this.labelCostsAverage_NAE.Name = "labelCostsAverage_NAE";
            this.labelCostsAverage_NAE.Size = new System.Drawing.Size(77, 13);
            this.labelCostsAverage_NAE.TabIndex = 6;
            this.labelCostsAverage_NAE.Text = "Средняя цена";
            // 
            // textBoxCostsAverage_NAE
            // 
            this.textBoxCostsAverage_NAE.Location = new System.Drawing.Point(242, 46);
            this.textBoxCostsAverage_NAE.Name = "textBoxCostsAverage_NAE";
            this.textBoxCostsAverage_NAE.ReadOnly = true;
            this.textBoxCostsAverage_NAE.Size = new System.Drawing.Size(111, 20);
            this.textBoxCostsAverage_NAE.TabIndex = 7;
            // 
            // buttonCalculateAv_NAE
            // 
            this.buttonCalculateAv_NAE.Location = new System.Drawing.Point(252, 72);
            this.buttonCalculateAv_NAE.Name = "buttonCalculateAv_NAE";
            this.buttonCalculateAv_NAE.Size = new System.Drawing.Size(88, 23);
            this.buttonCalculateAv_NAE.TabIndex = 8;
            this.buttonCalculateAv_NAE.Text = "Вычислить";
            this.buttonCalculateAv_NAE.UseVisualStyleBackColor = true;
            this.buttonCalculateAv_NAE.Click += new System.EventHandler(this.buttonCalculateAv_NAE_Click);
            // 
            // FormMain_NAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.splitterLocatedBetween_NAE);
            this.Controls.Add(this.panelLocatedRight_NAE);
            this.Controls.Add(this.panelLocatedLeft_NAE);
            this.Controls.Add(this.panelLocatedTop_NAE);
            this.Controls.Add(this.menuStripShowActions_NAE);
            this.MainMenuStrip = this.menuStripShowActions_NAE;
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "FormMain_NAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 4 | ИИПб-23-2 | Недоспасова.А.Э";
            this.menuStripShowActions_NAE.ResumeLayout(false);
            this.menuStripShowActions_NAE.PerformLayout();
            this.panelLocatedTop_NAE.ResumeLayout(false);
            this.groupBoxShowGraph_NAE.ResumeLayout(false);
            this.groupBoxShowGraph_NAE.PerformLayout();
            this.groupBoxShowStatistics_NAE.ResumeLayout(false);
            this.groupBoxShowStatistics_NAE.PerformLayout();
            this.groupBoxShowTools_NAE.ResumeLayout(false);
            this.groupBoxShowTools_NAE.PerformLayout();
            this.panelLocatedLeft_NAE.ResumeLayout(false);
            this.groupBoxOutPutBase_NAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutBase_NAE)).EndInit();
            this.panelLocatedRight_NAE.ResumeLayout(false);
            this.groupBoxOutPutGraph_NAE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOutPutGraph_NAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }









        #endregion

        private System.Windows.Forms.MenuStrip menuStripShowActions_NAE;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemShowCertificate_NAE;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAboutProgram_NAE;
        private System.Windows.Forms.Panel panelLocatedTop_NAE;
        private System.Windows.Forms.Panel panelLocatedLeft_NAE;
        private System.Windows.Forms.Panel panelLocatedRight_NAE;
        private System.Windows.Forms.Splitter splitterLocatedBetween_NAE;
        private System.Windows.Forms.GroupBox groupBoxShowGraph_NAE;
        private System.Windows.Forms.RadioButton radioButtonChoiceDiagram_NAE;
        private System.Windows.Forms.RadioButton radioButtonChoiceHistogram_NAE;
        private System.Windows.Forms.RadioButton radioButtonChoiceFunction_NAE;
        private System.Windows.Forms.Button buttonDeleteGraph_NAE;
        private System.Windows.Forms.Button buttonShowGraph_NAE;
        private System.Windows.Forms.GroupBox groupBoxShowStatistics_NAE;
        private System.Windows.Forms.Label labelCostsMaximum_NAE;
        private System.Windows.Forms.Label labelCostsMinimum_NAE;
        private System.Windows.Forms.TextBox textBoxCostsMaximum_NAE;
        private System.Windows.Forms.TextBox textBoxCostsMinimum_NAE;
        private System.Windows.Forms.Button buttonCalculateMax_NAE;
        private System.Windows.Forms.Button buttonCalculateMin_NAE;
        private System.Windows.Forms.GroupBox groupBoxShowTools_NAE;
        private System.Windows.Forms.TextBox textBoxFindElement_NAE;
        private System.Windows.Forms.Button buttonDeleteLine_NAE;
        private System.Windows.Forms.Button buttonFindElement_NAE;
        private System.Windows.Forms.Button buttonUpdateLine_NAE;
        private System.Windows.Forms.Button buttonAddLine_NAE;
        private System.Windows.Forms.GroupBox groupBoxOutPutBase_NAE;
        private System.Windows.Forms.DataGridView dataGridViewOutPutBase_NAE;
        private System.Windows.Forms.GroupBox groupBoxOutPutGraph_NAE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPutGraph_NAE;
        private System.Windows.Forms.ToolTip toolTipHelpInfo_NAE;
        private System.Windows.Forms.Button buttonCancelSearch_NAE;
        private System.Windows.Forms.Button buttonCalculateAv_NAE;
        private System.Windows.Forms.TextBox textBoxCostsAverage_NAE;
        private System.Windows.Forms.Label labelCostsAverage_NAE;
    }
}

