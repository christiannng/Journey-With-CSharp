namespace Nguyen_VanHa_Assignment1
{
    partial class IndexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbNonIntelligent = new System.Windows.Forms.RadioButton();
            this.rbHeuristics = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.numericStartX = new System.Windows.Forms.NumericUpDown();
            this.numericStartY = new System.Windows.Forms.NumericUpDown();
            this.numericTrials = new System.Windows.Forms.NumericUpDown();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTrials)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kight Start Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Trials:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Method Choice:";
            // 
            // rbNonIntelligent
            // 
            this.rbNonIntelligent.AutoSize = true;
            this.rbNonIntelligent.Location = new System.Drawing.Point(165, 175);
            this.rbNonIntelligent.Name = "rbNonIntelligent";
            this.rbNonIntelligent.Size = new System.Drawing.Size(120, 21);
            this.rbNonIntelligent.TabIndex = 8;
            this.rbNonIntelligent.TabStop = true;
            this.rbNonIntelligent.Text = "Non-Intelligent";
            this.rbNonIntelligent.UseVisualStyleBackColor = true;
            // 
            // rbHeuristics
            // 
            this.rbHeuristics.AutoSize = true;
            this.rbHeuristics.Location = new System.Drawing.Point(165, 202);
            this.rbHeuristics.Name = "rbHeuristics";
            this.rbHeuristics.Size = new System.Drawing.Size(91, 21);
            this.rbHeuristics.TabIndex = 9;
            this.rbHeuristics.TabStop = true;
            this.rbHeuristics.Text = "Heuristics";
            this.rbHeuristics.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(96, 239);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 33);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run Simulation";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // numericStartX
            // 
            this.numericStartX.Location = new System.Drawing.Point(193, 90);
            this.numericStartX.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericStartX.Name = "numericStartX";
            this.numericStartX.Size = new System.Drawing.Size(40, 22);
            this.numericStartX.TabIndex = 11;
            // 
            // numericStartY
            // 
            this.numericStartY.Location = new System.Drawing.Point(270, 90);
            this.numericStartY.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericStartY.Name = "numericStartY";
            this.numericStartY.Size = new System.Drawing.Size(40, 22);
            this.numericStartY.TabIndex = 12;
            // 
            // numericTrials
            // 
            this.numericTrials.Location = new System.Drawing.Point(165, 131);
            this.numericTrials.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericTrials.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTrials.Name = "numericTrials";
            this.numericTrials.Size = new System.Drawing.Size(68, 22);
            this.numericTrials.TabIndex = 13;
            this.numericTrials.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(316, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(472, 426);
            this.rtbDisplay.TabIndex = 14;
            this.rtbDisplay.Text = "";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.numericTrials);
            this.Controls.Add(this.numericStartY);
            this.Controls.Add(this.numericStartX);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rbHeuristics);
            this.Controls.Add(this.rbNonIntelligent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "IndexForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTrials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbNonIntelligent;
        private System.Windows.Forms.RadioButton rbHeuristics;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.NumericUpDown numericStartX;
        private System.Windows.Forms.NumericUpDown numericStartY;
        private System.Windows.Forms.NumericUpDown numericTrials;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

