namespace Project1.Pages
{
    partial class MapPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enemy2Button = new System.Windows.Forms.Button();
            this.Enemy1Button = new System.Windows.Forms.Button();
            this.Enemy3Button = new System.Windows.Forms.Button();
            this.Enemy4Button = new System.Windows.Forms.Button();
            this.BossButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy2Button
            // 
            this.Enemy2Button.Location = new System.Drawing.Point(218, 233);
            this.Enemy2Button.Name = "Enemy2Button";
            this.Enemy2Button.Size = new System.Drawing.Size(92, 81);
            this.Enemy2Button.TabIndex = 1;
            this.Enemy2Button.Text = "enemy2Button";
            this.Enemy2Button.UseVisualStyleBackColor = true;
            this.Enemy2Button.Click += new System.EventHandler(this.Enemy2Button_Click);
            // 
            // Enemy1Button
            // 
            this.Enemy1Button.Location = new System.Drawing.Point(78, 349);
            this.Enemy1Button.Name = "Enemy1Button";
            this.Enemy1Button.Size = new System.Drawing.Size(92, 81);
            this.Enemy1Button.TabIndex = 2;
            this.Enemy1Button.Text = "Enemy1Button";
            this.Enemy1Button.UseVisualStyleBackColor = true;
            this.Enemy1Button.Click += new System.EventHandler(this.Enemy1Button_Click);
            // 
            // Enemy3Button
            // 
            this.Enemy3Button.Location = new System.Drawing.Point(404, 166);
            this.Enemy3Button.Name = "Enemy3Button";
            this.Enemy3Button.Size = new System.Drawing.Size(92, 81);
            this.Enemy3Button.TabIndex = 3;
            this.Enemy3Button.Text = "Enemy3Button";
            this.Enemy3Button.UseVisualStyleBackColor = true;
            this.Enemy3Button.Click += new System.EventHandler(this.Enemy3Button_Click);
            // 
            // Enemy4Button
            // 
            this.Enemy4Button.Location = new System.Drawing.Point(651, 135);
            this.Enemy4Button.Name = "Enemy4Button";
            this.Enemy4Button.Size = new System.Drawing.Size(92, 81);
            this.Enemy4Button.TabIndex = 4;
            this.Enemy4Button.Text = "Enemy4Button";
            this.Enemy4Button.UseVisualStyleBackColor = true;
            this.Enemy4Button.Click += new System.EventHandler(this.Enemy4Button_Click);
            // 
            // BossButton
            // 
            this.BossButton.Location = new System.Drawing.Point(813, 316);
            this.BossButton.Name = "BossButton";
            this.BossButton.Size = new System.Drawing.Size(92, 81);
            this.BossButton.TabIndex = 5;
            this.BossButton.Text = "BossButton";
            this.BossButton.UseVisualStyleBackColor = true;
            this.BossButton.Click += new System.EventHandler(this.BossButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Project1.Properties.Resources.fight_map;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MapPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.BossButton);
            this.Controls.Add(this.Enemy4Button);
            this.Controls.Add(this.Enemy3Button);
            this.Controls.Add(this.Enemy1Button);
            this.Controls.Add(this.Enemy2Button);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MapPage";
            this.Size = new System.Drawing.Size(984, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enemy2Button;
        private System.Windows.Forms.Button Enemy1Button;
        private System.Windows.Forms.Button Enemy3Button;
        private System.Windows.Forms.Button Enemy4Button;
        private System.Windows.Forms.Button BossButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
