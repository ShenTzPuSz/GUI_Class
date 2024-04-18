namespace N09110016
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnTextBox = new System.Windows.Forms.Button();
            this.btnMidterm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "多遊四甲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(14, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "N09110016";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "謝文鈞";
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnButton.Location = new System.Drawing.Point(136, 12);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(120, 90);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "按鈕";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBMI.Location = new System.Drawing.Point(12, 105);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(120, 90);
            this.btnBMI.TabIndex = 4;
            this.btnBMI.Text = "BMI計算";
            this.btnBMI.UseVisualStyleBackColor = true;
            // 
            // btnTextBox
            // 
            this.btnTextBox.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTextBox.Location = new System.Drawing.Point(262, 12);
            this.btnTextBox.Name = "btnTextBox";
            this.btnTextBox.Size = new System.Drawing.Size(120, 90);
            this.btnTextBox.TabIndex = 5;
            this.btnTextBox.Text = "輸入框";
            this.btnTextBox.UseVisualStyleBackColor = true;
            this.btnTextBox.Click += new System.EventHandler(this.btnTextBox_Click);
            // 
            // btnMidterm
            // 
            this.btnMidterm.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMidterm.Location = new System.Drawing.Point(388, 12);
            this.btnMidterm.Name = "btnMidterm";
            this.btnMidterm.Size = new System.Drawing.Size(120, 90);
            this.btnMidterm.TabIndex = 6;
            this.btnMidterm.Text = "期中";
            this.btnMidterm.UseVisualStyleBackColor = true;
            this.btnMidterm.Click += new System.EventHandler(this.btnMidterm_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMidterm);
            this.Controls.Add(this.btnTextBox);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnButton);
            this.Name = "FormMain";
            this.Text = "GUI 主程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnTextBox;
        private System.Windows.Forms.Button btnMidterm;
    }
}

