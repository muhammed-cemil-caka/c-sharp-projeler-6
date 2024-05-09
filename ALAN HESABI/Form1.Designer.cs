namespace ALAN_HESABI
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
            label3 = new Label();
            labelkarealan = new Label();
            labeldikdörtgenalan = new Label();
            labeldairealan = new Label();
            textBoxkenar = new TextBox();
            textBoxkısakenar = new TextBox();
            textBoxuzunkenar = new TextBox();
            textBoxyaricap = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(104, 339);
            button1.Name = "button1";
            button1.Size = new Size(613, 42);
            button1.TabIndex = 0;
            button1.Text = "ALAN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "KARE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 39);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "DİKDÖRTGEN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 39);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 3;
            label3.Text = "DAİRE";
            // 
            // labelkarealan
            // 
            labelkarealan.AutoSize = true;
            labelkarealan.Location = new Point(52, 138);
            labelkarealan.Name = "labelkarealan";
            labelkarealan.Size = new Size(17, 20);
            labelkarealan.TabIndex = 4;
            labelkarealan.Text = "0";
            // 
            // labeldikdörtgenalan
            // 
            labeldikdörtgenalan.AutoSize = true;
            labeldikdörtgenalan.Location = new Point(375, 138);
            labeldikdörtgenalan.Name = "labeldikdörtgenalan";
            labeldikdörtgenalan.Size = new Size(17, 20);
            labeldikdörtgenalan.TabIndex = 5;
            labeldikdörtgenalan.Text = "0";
            // 
            // labeldairealan
            // 
            labeldairealan.AutoSize = true;
            labeldairealan.Location = new Point(677, 138);
            labeldairealan.Name = "labeldairealan";
            labeldairealan.Size = new Size(17, 20);
            labeldairealan.TabIndex = 6;
            labeldairealan.Text = "0";
            // 
            // textBoxkenar
            // 
            textBoxkenar.Location = new Point(50, 84);
            textBoxkenar.Name = "textBoxkenar";
            textBoxkenar.Size = new Size(84, 27);
            textBoxkenar.TabIndex = 7;
            // 
            // textBoxkısakenar
            // 
            textBoxkısakenar.Location = new Point(375, 74);
            textBoxkısakenar.Name = "textBoxkısakenar";
            textBoxkısakenar.Size = new Size(84, 27);
            textBoxkısakenar.TabIndex = 8;
            // 
            // textBoxuzunkenar
            // 
            textBoxuzunkenar.Location = new Point(375, 108);
            textBoxuzunkenar.Name = "textBoxuzunkenar";
            textBoxuzunkenar.Size = new Size(84, 27);
            textBoxuzunkenar.TabIndex = 9;
            // 
            // textBoxyaricap
            // 
            textBoxyaricap.Location = new Point(667, 74);
            textBoxyaricap.Name = "textBoxyaricap";
            textBoxyaricap.Size = new Size(84, 27);
            textBoxyaricap.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxyaricap);
            Controls.Add(textBoxuzunkenar);
            Controls.Add(textBoxkısakenar);
            Controls.Add(textBoxkenar);
            Controls.Add(labeldairealan);
            Controls.Add(labeldikdörtgenalan);
            Controls.Add(labelkarealan);
            Controls.Add(label3);
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
        private Label label3;
        private Label labelkarealan;
        private Label labeldikdörtgenalan;
        private Label labeldairealan;
        private TextBox textBoxkenar;
        private TextBox textBoxkısakenar;
        private TextBox textBoxuzunkenar;
        private TextBox textBoxyaricap;
    }
}