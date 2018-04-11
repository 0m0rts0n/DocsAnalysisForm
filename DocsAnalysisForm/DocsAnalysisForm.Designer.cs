namespace DocsAnalysisForm
{
    partial class DocsAnalysisForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.WordsTableDGV = new System.Windows.Forms.DataGridView();
            this.SimMeasLabel = new System.Windows.Forms.Label();
            this.FreqTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WordsTableDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcBtn
            // 
            this.CalcBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcBtn.Location = new System.Drawing.Point(320, 12);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(251, 41);
            this.CalcBtn.TabIndex = 0;
            this.CalcBtn.Text = "Расчёт";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // ResultTB
            // 
            this.ResultTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTB.Location = new System.Drawing.Point(12, 106);
            this.ResultTB.Multiline = true;
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.ReadOnly = true;
            this.ResultTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTB.Size = new System.Drawing.Size(279, 291);
            this.ResultTB.TabIndex = 1;
            // 
            // WordsTableDGV
            // 
            this.WordsTableDGV.AllowUserToAddRows = false;
            this.WordsTableDGV.AllowUserToDeleteRows = false;
            this.WordsTableDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.WordsTableDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.WordsTableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WordsTableDGV.Location = new System.Drawing.Point(297, 106);
            this.WordsTableDGV.Name = "WordsTableDGV";
            this.WordsTableDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WordsTableDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordsTableDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.WordsTableDGV.Size = new System.Drawing.Size(556, 291);
            this.WordsTableDGV.TabIndex = 2;
            // 
            // SimMeasLabel
            // 
            this.SimMeasLabel.AutoSize = true;
            this.SimMeasLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimMeasLabel.Location = new System.Drawing.Point(72, 78);
            this.SimMeasLabel.Name = "SimMeasLabel";
            this.SimMeasLabel.Size = new System.Drawing.Size(145, 25);
            this.SimMeasLabel.TabIndex = 3;
            this.SimMeasLabel.Text = "Мера сходства";
            // 
            // FreqTableLabel
            // 
            this.FreqTableLabel.AutoSize = true;
            this.FreqTableLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreqTableLabel.Location = new System.Drawing.Point(403, 78);
            this.FreqTableLabel.Name = "FreqTableLabel";
            this.FreqTableLabel.Size = new System.Drawing.Size(346, 25);
            this.FreqTableLabel.TabIndex = 4;
            this.FreqTableLabel.Text = "Таблица частот слов в каждом тексте";
            // 
            // DocsAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 421);
            this.Controls.Add(this.FreqTableLabel);
            this.Controls.Add(this.SimMeasLabel);
            this.Controls.Add(this.WordsTableDGV);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.CalcBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DocsAnalysisForm";
            this.Text = "Анализ документов";
            ((System.ComponentModel.ISupportInitialize)(this.WordsTableDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.DataGridView WordsTableDGV;
        private System.Windows.Forms.Label SimMeasLabel;
        private System.Windows.Forms.Label FreqTableLabel;
    }
}

