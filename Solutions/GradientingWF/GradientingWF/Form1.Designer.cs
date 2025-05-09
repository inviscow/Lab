namespace GradientingWF
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
            rndLabel = new Label();
            panel1 = new Panel();
            spawnBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rndLabel
            // 
            rndLabel.AutoSize = true;
            rndLabel.Location = new Point(58, 56);
            rndLabel.Name = "rndLabel";
            rndLabel.Size = new Size(83, 15);
            rndLabel.TabIndex = 0;
            rndLabel.Text = "Random Label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 35, 35);
            panel1.Controls.Add(spawnBtn);
            panel1.Location = new Point(58, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 129);
            panel1.TabIndex = 1;
            // 
            // spawnBtn
            // 
            spawnBtn.Location = new Point(3, 103);
            spawnBtn.Name = "spawnBtn";
            spawnBtn.Size = new Size(75, 23);
            spawnBtn.TabIndex = 2;
            spawnBtn.Text = "Spawn";
            spawnBtn.UseVisualStyleBackColor = true;
            spawnBtn.Click += spawnBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(rndLabel);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rndLabel;
        private Panel panel1;
        private Button spawnBtn;
    }
}
