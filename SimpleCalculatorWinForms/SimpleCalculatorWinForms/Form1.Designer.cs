namespace SimpleCalculatorWinForms
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
			this.textBoxNum1 = new System.Windows.Forms.TextBox();
			this.textBoxNum2 = new System.Windows.Forms.TextBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonSubtract = new System.Windows.Forms.Button();
			this.buttonMultiply = new System.Windows.Forms.Button();
			this.buttonDivide = new System.Windows.Forms.Button();
			this.labelResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxNum1
			// 
			this.textBoxNum1.Location = new System.Drawing.Point(90, 125);
			this.textBoxNum1.Name = "textBoxNum1";
			this.textBoxNum1.Size = new System.Drawing.Size(100, 20);
			this.textBoxNum1.TabIndex = 0;
			// 
			// textBoxNum2
			// 
			this.textBoxNum2.Location = new System.Drawing.Point(90, 167);
			this.textBoxNum2.Name = "textBoxNum2";
			this.textBoxNum2.Size = new System.Drawing.Size(100, 20);
			this.textBoxNum2.TabIndex = 1;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(237, 121);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Text = "Сложение";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonSubtract
			// 
			this.buttonSubtract.Location = new System.Drawing.Point(237, 163);
			this.buttonSubtract.Name = "buttonSubtract";
			this.buttonSubtract.Size = new System.Drawing.Size(75, 23);
			this.buttonSubtract.TabIndex = 3;
			this.buttonSubtract.Text = "Вычитание";
			this.buttonSubtract.UseVisualStyleBackColor = true;
			this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
			// 
			// buttonMultiply
			// 
			this.buttonMultiply.Location = new System.Drawing.Point(237, 203);
			this.buttonMultiply.Name = "buttonMultiply";
			this.buttonMultiply.Size = new System.Drawing.Size(75, 23);
			this.buttonMultiply.TabIndex = 4;
			this.buttonMultiply.Text = "Умножение";
			this.buttonMultiply.UseVisualStyleBackColor = true;
			this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
			// 
			// buttonDivide
			// 
			this.buttonDivide.Location = new System.Drawing.Point(237, 242);
			this.buttonDivide.Name = "buttonDivide";
			this.buttonDivide.Size = new System.Drawing.Size(75, 23);
			this.buttonDivide.TabIndex = 5;
			this.buttonDivide.Text = "Деление";
			this.buttonDivide.UseVisualStyleBackColor = true;
			this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(90, 74);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(35, 13);
			this.labelResult.TabIndex = 6;
			this.labelResult.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.buttonDivide);
			this.Controls.Add(this.buttonMultiply);
			this.Controls.Add(this.buttonSubtract);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxNum2);
			this.Controls.Add(this.textBoxNum1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNum1;
        private System.Windows.Forms.TextBox textBoxNum2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Label labelResult;
    }
}

