namespace Task_1
{
    partial class Form1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblHeaderNumber = new System.Windows.Forms.Label();
            this.lblHeaderCount = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHeaderTrueNumber = new System.Windows.Forms.Label();
            this.lblTrueNumber = new System.Windows.Forms.Label();
            this.lblCongratz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(36, 130);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(36, 168);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(248, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(126, 98);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(338, 135);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "label1";
            // 
            // lblHeaderNumber
            // 
            this.lblHeaderNumber.AutoSize = true;
            this.lblHeaderNumber.Location = new System.Drawing.Point(33, 98);
            this.lblHeaderNumber.Name = "lblHeaderNumber";
            this.lblHeaderNumber.Size = new System.Drawing.Size(87, 13);
            this.lblHeaderNumber.TabIndex = 5;
            this.lblHeaderNumber.Text = "Текущее число:";
            // 
            // lblHeaderCount
            // 
            this.lblHeaderCount.AutoSize = true;
            this.lblHeaderCount.Location = new System.Drawing.Point(245, 135);
            this.lblHeaderCount.Name = "lblHeaderCount";
            this.lblHeaderCount.Size = new System.Drawing.Size(85, 13);
            this.lblHeaderCount.TabIndex = 6;
            this.lblHeaderCount.Text = "Сделано ходов:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(32, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "button1";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblHeaderTrueNumber
            // 
            this.lblHeaderTrueNumber.AutoSize = true;
            this.lblHeaderTrueNumber.Location = new System.Drawing.Point(32, 70);
            this.lblHeaderTrueNumber.Name = "lblHeaderTrueNumber";
            this.lblHeaderTrueNumber.Size = new System.Drawing.Size(88, 13);
            this.lblHeaderTrueNumber.TabIndex = 8;
            this.lblHeaderTrueNumber.Text = "Искомое число:";
            // 
            // lblTrueNumber
            // 
            this.lblTrueNumber.AutoSize = true;
            this.lblTrueNumber.Location = new System.Drawing.Point(127, 69);
            this.lblTrueNumber.Name = "lblTrueNumber";
            this.lblTrueNumber.Size = new System.Drawing.Size(35, 13);
            this.lblTrueNumber.TabIndex = 9;
            this.lblTrueNumber.Text = "label2";
            // 
            // lblCongratz
            // 
            this.lblCongratz.AutoSize = true;
            this.lblCongratz.Location = new System.Drawing.Point(32, 10);
            this.lblCongratz.Name = "lblCongratz";
            this.lblCongratz.Size = new System.Drawing.Size(35, 13);
            this.lblCongratz.TabIndex = 10;
            this.lblCongratz.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 205);
            this.Controls.Add(this.lblCongratz);
            this.Controls.Add(this.lblTrueNumber);
            this.Controls.Add(this.lblHeaderTrueNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHeaderCount);
            this.Controls.Add(this.lblHeaderNumber);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblHeaderNumber;
        private System.Windows.Forms.Label lblHeaderCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHeaderTrueNumber;
        private System.Windows.Forms.Label lblTrueNumber;
        private System.Windows.Forms.Label lblCongratz;
    }
}

