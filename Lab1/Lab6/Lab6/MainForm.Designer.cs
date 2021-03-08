namespace Lab6
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTimeInterval = new System.Windows.Forms.TextBox();
            this.tbGenIntensity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOAIntensity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbOACount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenCount = new System.Windows.Forms.TextBox();
            this.tbdispersion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Шаг по времени:";
            // 
            // tbTimeInterval
            // 
            this.tbTimeInterval.Location = new System.Drawing.Point(12, 25);
            this.tbTimeInterval.Name = "tbTimeInterval";
            this.tbTimeInterval.Size = new System.Drawing.Size(89, 20);
            this.tbTimeInterval.TabIndex = 1;
            // 
            // tbGenIntensity
            // 
            this.tbGenIntensity.Location = new System.Drawing.Point(12, 64);
            this.tbGenIntensity.Name = "tbGenIntensity";
            this.tbGenIntensity.Size = new System.Drawing.Size(89, 20);
            this.tbGenIntensity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Интенсивность генератора";
            // 
            // tbOAIntensity
            // 
            this.tbOAIntensity.Location = new System.Drawing.Point(12, 103);
            this.tbOAIntensity.Name = "tbOAIntensity";
            this.tbOAIntensity.Size = new System.Drawing.Size(89, 20);
            this.tbOAIntensity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Интенсивность ОА";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 347);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(59, 13);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Результат";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(11, 298);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(123, 35);
            this.btnSimulate.TabIndex = 18;
            this.btnSimulate.Text = "Моделировать";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Время моделирования:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(12, 182);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(89, 20);
            this.tbTime.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Количество операторов:";
            // 
            // tbOACount
            // 
            this.tbOACount.Location = new System.Drawing.Point(12, 263);
            this.tbOACount.Name = "tbOACount";
            this.tbOACount.Size = new System.Drawing.Size(89, 20);
            this.tbOACount.TabIndex = 26;
            this.tbOACount.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество генераторов";
            // 
            // tbGenCount
            // 
            this.tbGenCount.Location = new System.Drawing.Point(11, 223);
            this.tbGenCount.Name = "tbGenCount";
            this.tbGenCount.Size = new System.Drawing.Size(89, 20);
            this.tbGenCount.TabIndex = 8;
            // 
            // tbdispersion
            // 
            this.tbdispersion.Location = new System.Drawing.Point(11, 142);
            this.tbdispersion.Name = "tbdispersion";
            this.tbdispersion.Size = new System.Drawing.Size(89, 20);
            this.tbdispersion.TabIndex = 28;
            this.tbdispersion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Отклонение ОА";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1003, 460);
            this.Controls.Add(this.tbdispersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbOACount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbOAIntensity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbGenCount);
            this.Controls.Add(this.tbGenIntensity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimeInterval);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №1 ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTimeInterval;
        private System.Windows.Forms.TextBox tbGenIntensity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOAIntensity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbOACount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGenCount;
        private System.Windows.Forms.TextBox tbdispersion;
        private System.Windows.Forms.Label label4;
    }
}

