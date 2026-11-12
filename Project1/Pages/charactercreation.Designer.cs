namespace Project1.Pages
{
    partial class charactercreation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MagePictureBox = new System.Windows.Forms.PictureBox();
            this.TankPictureBox = new System.Windows.Forms.PictureBox();
            this.PlayerNamingLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TankRadioButton1 = new System.Windows.Forms.RadioButton();
            this.MageRadioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TankPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Project1.Properties.Resources.characterCreation;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MagePictureBox
            // 
            this.MagePictureBox.Location = new System.Drawing.Point(709, 71);
            this.MagePictureBox.Name = "MagePictureBox";
            this.MagePictureBox.Size = new System.Drawing.Size(199, 367);
            this.MagePictureBox.TabIndex = 3;
            this.MagePictureBox.TabStop = false;
            // 
            // TankPictureBox
            // 
            this.TankPictureBox.Location = new System.Drawing.Point(76, 71);
            this.TankPictureBox.Name = "TankPictureBox";
            this.TankPictureBox.Size = new System.Drawing.Size(199, 367);
            this.TankPictureBox.TabIndex = 4;
            this.TankPictureBox.TabStop = false;
            // 
            // PlayerNamingLabel
            // 
            this.PlayerNamingLabel.AutoSize = true;
            this.PlayerNamingLabel.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNamingLabel.Location = new System.Drawing.Point(309, 90);
            this.PlayerNamingLabel.Name = "PlayerNamingLabel";
            this.PlayerNamingLabel.Size = new System.Drawing.Size(364, 46);
            this.PlayerNamingLabel.TabIndex = 5;
            this.PlayerNamingLabel.Text = "Name ur character";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 46);
            this.textBox1.TabIndex = 6;
            // 
            // TankRadioButton1
            // 
            this.TankRadioButton1.AutoSize = true;
            this.TankRadioButton1.Location = new System.Drawing.Point(134, 444);
            this.TankRadioButton1.Name = "TankRadioButton1";
            this.TankRadioButton1.Size = new System.Drawing.Size(75, 27);
            this.TankRadioButton1.TabIndex = 7;
            this.TankRadioButton1.TabStop = true;
            this.TankRadioButton1.Text = "Tank";
            this.TankRadioButton1.UseVisualStyleBackColor = true;
            // 
            // MageRadioButton2
            // 
            this.MageRadioButton2.AutoSize = true;
            this.MageRadioButton2.Location = new System.Drawing.Point(765, 444);
            this.MageRadioButton2.Name = "MageRadioButton2";
            this.MageRadioButton2.Size = new System.Drawing.Size(82, 27);
            this.MageRadioButton2.TabIndex = 8;
            this.MageRadioButton2.TabStop = true;
            this.MageRadioButton2.Text = "Mage";
            this.MageRadioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // charactercreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MageRadioButton2);
            this.Controls.Add(this.TankRadioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PlayerNamingLabel);
            this.Controls.Add(this.TankPictureBox);
            this.Controls.Add(this.MagePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "charactercreation";
            this.Size = new System.Drawing.Size(984, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TankPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox MagePictureBox;
        private System.Windows.Forms.PictureBox TankPictureBox;
        private System.Windows.Forms.Label PlayerNamingLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton TankRadioButton1;
        private System.Windows.Forms.RadioButton MageRadioButton2;
        private System.Windows.Forms.Button button1;
    }
}
