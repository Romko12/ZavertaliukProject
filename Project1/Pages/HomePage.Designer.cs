namespace Project1.Pages
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.playButton = new System.Windows.Forms.Button();
            this.InvButton2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameNamePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameNamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(382, 230);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(220, 49);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // InvButton2
            // 
            this.InvButton2.Location = new System.Drawing.Point(382, 285);
            this.InvButton2.Name = "InvButton2";
            this.InvButton2.Size = new System.Drawing.Size(220, 49);
            this.InvButton2.TabIndex = 4;
            this.InvButton2.Text = "Inventory";
            this.InvButton2.UseVisualStyleBackColor = true;
            this.InvButton2.Click += new System.EventHandler(this.InvButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1.Properties.Resources.resized_984x493;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 493);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GameNamePictureBox
            // 
            this.GameNamePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GameNamePictureBox.BackgroundImage = global::Project1.Properties.Resources.image_Photoroom;
            this.GameNamePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("GameNamePictureBox.Image")));
            this.GameNamePictureBox.Location = new System.Drawing.Point(367, 54);
            this.GameNamePictureBox.Name = "GameNamePictureBox";
            this.GameNamePictureBox.Size = new System.Drawing.Size(250, 170);
            this.GameNamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GameNamePictureBox.TabIndex = 3;
            this.GameNamePictureBox.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.InvButton2);
            this.Controls.Add(this.GameNamePictureBox);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(984, 493);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameNamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox GameNamePictureBox;
        public System.Windows.Forms.Button playButton;
        public System.Windows.Forms.Button InvButton2;
    }
}
