namespace SuperAdventure
{
    partial class SuperAdventure
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
            this.IbIHitPoints = new System.Windows.Forms.Label();
            this.IbIGold = new System.Windows.Forms.Label();
            this.IbIExperience = new System.Windows.Forms.Label();
            this.IbILevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experience:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            // 
            // IbIHitPoints
            // 
            this.IbIHitPoints.AutoSize = true;
            this.IbIHitPoints.Location = new System.Drawing.Point(110, 19);
            this.IbIHitPoints.Name = "IbIHitPoints";
            this.IbIHitPoints.Size = new System.Drawing.Size(0, 13);
            this.IbIHitPoints.TabIndex = 4;
            // 
            // IbIGold
            // 
            this.IbIGold.AutoSize = true;
            this.IbIGold.Location = new System.Drawing.Point(110, 45);
            this.IbIGold.Name = "IbIGold";
            this.IbIGold.Size = new System.Drawing.Size(0, 13);
            this.IbIGold.TabIndex = 5;
            // 
            // IbIExperience
            // 
            this.IbIExperience.AutoSize = true;
            this.IbIExperience.Location = new System.Drawing.Point(110, 73);
            this.IbIExperience.Name = "IbIExperience";
            this.IbIExperience.Size = new System.Drawing.Size(0, 13);
            this.IbIExperience.TabIndex = 6;
            // 
            // IbILevel
            // 
            this.IbILevel.AutoSize = true;
            this.IbILevel.Location = new System.Drawing.Point(110, 99);
            this.IbILevel.Name = "IbILevel";
            this.IbILevel.Size = new System.Drawing.Size(0, 13);
            this.IbILevel.TabIndex = 7;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.IbILevel);
            this.Controls.Add(this.IbIExperience);
            this.Controls.Add(this.IbIGold);
            this.Controls.Add(this.IbIHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperAdventure";
            this.Text = "My Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IbIHitPoints;
        private System.Windows.Forms.Label IbIGold;
        private System.Windows.Forms.Label IbIExperience;
        private System.Windows.Forms.Label IbILevel;
    }
}

