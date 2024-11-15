namespace lab3._5
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
            this.tbExp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSimpsona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.btnRunge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbExp
            // 
            this.tbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbExp.Location = new System.Drawing.Point(25, 23);
            this.tbExp.Name = "tbExp";
            this.tbExp.Size = new System.Drawing.Size(211, 27);
            this.tbExp.TabIndex = 33;
            this.tbExp.Text = "cos(5*x) + 0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(242, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(108, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "a";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(159, 70);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(77, 27);
            this.tbB.TabIndex = 30;
            this.tbB.Text = "2";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(25, 70);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(77, 27);
            this.tbA.TabIndex = 29;
            this.tbA.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(108, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "n";
            // 
            // tbN
            // 
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(25, 113);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(77, 27);
            this.tbN.TabIndex = 34;
            this.tbN.Text = "51";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(311, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 276);
            this.listBox1.TabIndex = 36;
            // 
            // btnSimpsona
            // 
            this.btnSimpsona.Location = new System.Drawing.Point(12, 198);
            this.btnSimpsona.Name = "btnSimpsona";
            this.btnSimpsona.Size = new System.Drawing.Size(90, 42);
            this.btnSimpsona.TabIndex = 37;
            this.btnSimpsona.Text = "Simpsona";
            this.btnSimpsona.UseVisualStyleBackColor = true;
            this.btnSimpsona.Click += new System.EventHandler(this.btnSimpsona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "e";
            // 
            // tbE
            // 
            this.tbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbE.Location = new System.Drawing.Point(159, 116);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(77, 27);
            this.tbE.TabIndex = 38;
            this.tbE.Text = "0,0001";
            // 
            // btnRunge
            // 
            this.btnRunge.Location = new System.Drawing.Point(159, 198);
            this.btnRunge.Name = "btnRunge";
            this.btnRunge.Size = new System.Drawing.Size(90, 42);
            this.btnRunge.TabIndex = 40;
            this.btnRunge.Text = "Runge";
            this.btnRunge.UseVisualStyleBackColor = true;
            this.btnRunge.Click += new System.EventHandler(this.btnRunge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 585);
            this.Controls.Add(this.btnRunge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.btnSimpsona);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbExp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSimpsona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.Button btnRunge;
    }
}

