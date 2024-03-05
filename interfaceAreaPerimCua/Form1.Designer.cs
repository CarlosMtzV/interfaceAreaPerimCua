namespace interfaceAreaPerimCua
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
            txtSideLength = new TextBox();
            txtArea = new TextBox();
            txtPerimeter = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtSideLength
            // 
            txtSideLength.Location = new Point(177, 113);
            txtSideLength.Name = "txtSideLength";
            txtSideLength.Size = new Size(128, 23);
            txtSideLength.TabIndex = 0;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(621, 113);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(128, 23);
            txtArea.TabIndex = 2;
            // 
            // txtPerimeter
            // 
            txtPerimeter.Location = new Point(621, 197);
            txtPerimeter.Name = "txtPerimeter";
            txtPerimeter.Size = new Size(128, 23);
            txtPerimeter.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 4;
            label1.Text = "Calculate Area and Perimeter of a  Square";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 164);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Side value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 153);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, 250);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Perimeter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(755, 116);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 8;
            label5.Text = "U2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(755, 205);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 9;
            label6.Text = "U2";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(280, 249);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(122, 54);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPerimeter);
            Controls.Add(txtArea);
            Controls.Add(txtSideLength);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSideLength;
        private TextBox txtArea;
        private TextBox txtPerimeter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalculate;
    }
}
