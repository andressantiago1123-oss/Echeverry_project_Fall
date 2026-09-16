namespace Echeverry_project_Fall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            lstOut = new ListBox();
            btnCalculate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(237, 32);
            label1.Name = "label1";
            label1.Size = new Size(275, 25);
            label1.TabIndex = 0;
            label1.Text = "VideoGame Transaction Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(57, 110);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 1;
            label2.Text = "Game Name Based Input";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(276, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(57, 179);
            label3.Name = "label3";
            label3.Size = new Size(174, 21);
            label3.TabIndex = 3;
            label3.Text = "Game Price Based Input";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(276, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.Location = new Point(57, 238);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(455, 124);
            lstOut.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(57, 398);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 62);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate && &Display";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(251, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 57);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(437, 398);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 55);
            btnExit.TabIndex = 8;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnCalculate);
            Controls.Add(lstOut);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Echeverry_Project_Fall";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private ListBox lstOut;
        private Button btnCalculate;
        private Button btnDelete;
        private Button btnExit;
    }
}
