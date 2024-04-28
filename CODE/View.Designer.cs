namespace XMLandJSON
{
    partial class View
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
            this.firstDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.secondDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.ListBox();
            this.SynchronizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstDirectoryTextBox
            // 
            this.firstDirectoryTextBox.Location = new System.Drawing.Point(161, 4);
            this.firstDirectoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstDirectoryTextBox.Name = "firstDirectoryTextBox";
            this.firstDirectoryTextBox.Size = new System.Drawing.Size(430, 20);
            this.firstDirectoryTextBox.TabIndex = 0;
            // 
            // secondDirectoryTextBox
            // 
            this.secondDirectoryTextBox.Location = new System.Drawing.Point(161, 31);
            this.secondDirectoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondDirectoryTextBox.Name = "secondDirectoryTextBox";
            this.secondDirectoryTextBox.Size = new System.Drawing.Size(430, 20);
            this.secondDirectoryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь до первой директории";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь до второй директории";
            // 
            // Results
            // 
            this.Results.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.FormattingEnabled = true;
            this.Results.ItemHeight = 20;
            this.Results.Location = new System.Drawing.Point(9, 64);
            this.Results.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(583, 204);
            this.Results.TabIndex = 4;
            // 
            // SynchronizeButton
            // 
            this.SynchronizeButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SynchronizeButton.Location = new System.Drawing.Point(9, 275);
            this.SynchronizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SynchronizeButton.Name = "SynchronizeButton";
            this.SynchronizeButton.Size = new System.Drawing.Size(582, 80);
            this.SynchronizeButton.TabIndex = 5;
            this.SynchronizeButton.Text = "Синхронизировать";
            this.SynchronizeButton.UseVisualStyleBackColor = true;
            this.SynchronizeButton.Click += new System.EventHandler(this.SynchronizeButton_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SynchronizeButton);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondDirectoryTextBox);
            this.Controls.Add(this.firstDirectoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstDirectoryTextBox;
        private System.Windows.Forms.TextBox secondDirectoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button SynchronizeButton;
    }
}