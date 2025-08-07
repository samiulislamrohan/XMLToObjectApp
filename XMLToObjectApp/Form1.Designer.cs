namespace XMLToObjectApp
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(336, 6);
            button1.Name = "button1";
            button1.Size = new Size(229, 60);
            button1.TabIndex = 0;
            button1.Text = "XMLtoObject";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 314);
            label1.Name = "label1";
            label1.Size = new Size(158, 25);
            label1.TabIndex = 1;
            label1.Text = "Item Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 160);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 370);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(795, 418);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 113);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 5;
            label3.Text = "Document";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 145);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 6;
            label4.Text = "Key:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 188);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "Item";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 227);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 8;
            label6.Text = "Key:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 220);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 27);
            textBox3.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(529, 149);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(529, 227);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(372, 142);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Find value";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 218);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Find value";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 953);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button3;
    }
}
