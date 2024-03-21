namespace N09110016
{
    partial class FormButton
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
            this.btnButton = new System.Windows.Forms.Button();
            this.btnLabel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label_Add = new System.Windows.Forms.Label();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnButton.Location = new System.Drawing.Point(12, 12);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(177, 80);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "點我";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLabel
            // 
            this.btnLabel.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLabel.Location = new System.Drawing.Point(376, 53);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(80, 39);
            this.btnLabel.TabIndex = 1;
            this.btnLabel.Text = "點我";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(283, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 2;
            // 
            // btnReduce
            // 
            this.btnReduce.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReduce.Location = new System.Drawing.Point(708, 53);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(80, 39);
            this.btnReduce.TabIndex = 3;
            this.btnReduce.Text = "-1";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(622, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label_Add
            // 
            this.label_Add.AutoSize = true;
            this.label_Add.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Add.Location = new System.Drawing.Point(691, 12);
            this.label_Add.Name = "label_Add";
            this.label_Add.Size = new System.Drawing.Size(26, 27);
            this.label_Add.TabIndex = 5;
            this.label_Add.Text = "0";
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEnlarge.Location = new System.Drawing.Point(12, 113);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(80, 39);
            this.btnEnlarge.TabIndex = 6;
            this.btnEnlarge.Text = "點我";
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // FormButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnlarge);
            this.Controls.Add(this.label_Add);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.btnButton);
            this.Name = "FormButton";
            this.Text = "按鈕課程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label_Add;
        private System.Windows.Forms.Button btnEnlarge;
    }
}