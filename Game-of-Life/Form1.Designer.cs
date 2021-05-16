
namespace Game_of_Life
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MooreRadioBtn = new System.Windows.Forms.RadioButton();
            this.NeumannRadioBtn = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gameBox = new System.Windows.Forms.PictureBox();
            this.chartCells = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colorRect = new System.Windows.Forms.CheckBox();
            this.akBox = new System.Windows.Forms.ComboBox();
            this.aliveBox = new System.Windows.Forms.TextBox();
            this.boardMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCells)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba zywych komórek";
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(253, 25);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(100, 20);
            this.tBox.TabIndex = 6;
            this.tBox.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liczba króków";
            // 
            // MooreRadioBtn
            // 
            this.MooreRadioBtn.AutoSize = true;
            this.MooreRadioBtn.Checked = true;
            this.MooreRadioBtn.Location = new System.Drawing.Point(376, 19);
            this.MooreRadioBtn.Name = "MooreRadioBtn";
            this.MooreRadioBtn.Size = new System.Drawing.Size(120, 17);
            this.MooreRadioBtn.TabIndex = 8;
            this.MooreRadioBtn.TabStop = true;
            this.MooreRadioBtn.Text = "Sąsiedztwo Moore\'a";
            this.MooreRadioBtn.UseVisualStyleBackColor = true;
            this.MooreRadioBtn.Click += new System.EventHandler(this.MooreRadioBtn_Click);
            // 
            // NeumannRadioBtn
            // 
            this.NeumannRadioBtn.AutoSize = true;
            this.NeumannRadioBtn.Location = new System.Drawing.Point(376, 42);
            this.NeumannRadioBtn.Name = "NeumannRadioBtn";
            this.NeumannRadioBtn.Size = new System.Drawing.Size(157, 17);
            this.NeumannRadioBtn.TabIndex = 9;
            this.NeumannRadioBtn.Text = "Sąsiedztwo von Neumann\'a";
            this.NeumannRadioBtn.UseVisualStyleBackColor = true;
            this.NeumannRadioBtn.Click += new System.EventHandler(this.NeumannRadioBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(676, 22);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // randomBtn
            // 
            this.randomBtn.Location = new System.Drawing.Point(584, 22);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(75, 23);
            this.randomBtn.TabIndex = 11;
            this.randomBtn.Text = "Rysuj";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Click += new System.EventHandler(this.randomBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(658, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // gameBox
            // 
            this.gameBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameBox.Location = new System.Drawing.Point(42, 99);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(800, 800);
            this.gameBox.TabIndex = 14;
            this.gameBox.TabStop = false;
            this.gameBox.Click += new System.EventHandler(this.gameBox_Click);
            // 
            // chartCells
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCells.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCells.Legends.Add(legend1);
            this.chartCells.Location = new System.Drawing.Point(846, 99);
            this.chartCells.Name = "chartCells";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCells.Series.Add(series1);
            this.chartCells.Size = new System.Drawing.Size(753, 595);
            this.chartCells.TabIndex = 15;
            this.chartCells.Text = "chart1";
            // 
            // colorRect
            // 
            this.colorRect.Location = new System.Drawing.Point(785, 27);
            this.colorRect.Name = "colorRect";
            this.colorRect.Size = new System.Drawing.Size(188, 17);
            this.colorRect.TabIndex = 16;
            this.colorRect.Text = "Zaznaczaj Umierajace/Ozywajace";
            this.colorRect.UseVisualStyleBackColor = true;
            // 
            // akBox
            // 
            this.akBox.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.akBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.akBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.akBox.Location = new System.Drawing.Point(26, 23);
            this.akBox.Name = "akBox";
            this.akBox.Size = new System.Drawing.Size(49, 21);
            this.akBox.TabIndex = 18;
            // 
            // aliveBox
            // 
            this.aliveBox.Location = new System.Drawing.Point(109, 25);
            this.aliveBox.Name = "aliveBox";
            this.aliveBox.Size = new System.Drawing.Size(100, 20);
            this.aliveBox.TabIndex = 1;
            this.aliveBox.Text = "50";
            // 
            // boardMode
            // 
            this.boardMode.AutoSize = true;
            this.boardMode.Checked = true;
            this.boardMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.boardMode.Location = new System.Drawing.Point(785, 51);
            this.boardMode.Name = "boardMode";
            this.boardMode.Size = new System.Drawing.Size(256, 17);
            this.boardMode.TabIndex = 19;
            this.boardMode.Text = "Rysuj plansze z losowo wypełnionymi komórkami";
            this.boardMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 908);
            this.Controls.Add(this.boardMode);
            this.Controls.Add(this.akBox);
            this.Controls.Add(this.colorRect);
            this.Controls.Add(this.chartCells);
            this.Controls.Add(this.gameBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.NeumannRadioBtn);
            this.Controls.Add(this.MooreRadioBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aliveBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MooreRadioBtn;
        private System.Windows.Forms.RadioButton NeumannRadioBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox gameBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCells;
        private System.Windows.Forms.CheckBox colorRect;
        private System.Windows.Forms.ComboBox akBox;
        private System.Windows.Forms.TextBox aliveBox;
        private System.Windows.Forms.CheckBox boardMode;
    }
}

