namespace Project1
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MoneyCounterLabel = new System.Windows.Forms.Label();
            this.Item2CounterLabel = new System.Windows.Forms.Label();
            this.Item1CounterLabel = new System.Windows.Forms.Label();
            this.Item1PictureBox = new System.Windows.Forms.PictureBox();
            this.Item2PictureBox = new System.Windows.Forms.PictureBox();
            this.MoneyPictureBox = new System.Windows.Forms.PictureBox();
            this.InvButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.MapButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.MoneyCounterLabel);
            this.panel2.Controls.Add(this.Item2CounterLabel);
            this.panel2.Controls.Add(this.Item1CounterLabel);
            this.panel2.Controls.Add(this.Item1PictureBox);
            this.panel2.Controls.Add(this.Item2PictureBox);
            this.panel2.Controls.Add(this.MoneyPictureBox);
            this.panel2.Controls.Add(this.InvButton);
            this.panel2.Controls.Add(this.ShopButton);
            this.panel2.Controls.Add(this.MapButton);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 38);
            this.panel2.TabIndex = 0;
            // 
            // MoneyCounterLabel
            // 
            this.MoneyCounterLabel.AutoSize = true;
            this.MoneyCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.MoneyCounterLabel.Location = new System.Drawing.Point(860, 8);
            this.MoneyCounterLabel.Name = "MoneyCounterLabel";
            this.MoneyCounterLabel.Size = new System.Drawing.Size(69, 23);
            this.MoneyCounterLabel.TabIndex = 12;
            this.MoneyCounterLabel.Text = "label4";
            // 
            // Item2CounterLabel
            // 
            this.Item2CounterLabel.AutoSize = true;
            this.Item2CounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.Item2CounterLabel.Location = new System.Drawing.Point(679, 9);
            this.Item2CounterLabel.Name = "Item2CounterLabel";
            this.Item2CounterLabel.Size = new System.Drawing.Size(69, 23);
            this.Item2CounterLabel.TabIndex = 10;
            this.Item2CounterLabel.Text = "label2";
            // 
            // Item1CounterLabel
            // 
            this.Item1CounterLabel.AutoSize = true;
            this.Item1CounterLabel.Location = new System.Drawing.Point(496, 9);
            this.Item1CounterLabel.Name = "Item1CounterLabel";
            this.Item1CounterLabel.Size = new System.Drawing.Size(69, 23);
            this.Item1CounterLabel.TabIndex = 9;
            this.Item1CounterLabel.Text = "label1";
            // 
            // Item1PictureBox
            // 
            this.Item1PictureBox.Location = new System.Drawing.Point(571, 1);
            this.Item1PictureBox.Name = "Item1PictureBox";
            this.Item1PictureBox.Size = new System.Drawing.Size(46, 38);
            this.Item1PictureBox.TabIndex = 8;
            this.Item1PictureBox.TabStop = false;
            // 
            // Item2PictureBox
            // 
            this.Item2PictureBox.Location = new System.Drawing.Point(754, 0);
            this.Item2PictureBox.Name = "Item2PictureBox";
            this.Item2PictureBox.Size = new System.Drawing.Size(46, 39);
            this.Item2PictureBox.TabIndex = 7;
            this.Item2PictureBox.TabStop = false;
            // 
            // MoneyPictureBox
            // 
            this.MoneyPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.MoneyPictureBox.Location = new System.Drawing.Point(935, 0);
            this.MoneyPictureBox.Name = "MoneyPictureBox";
            this.MoneyPictureBox.Size = new System.Drawing.Size(46, 39);
            this.MoneyPictureBox.TabIndex = 5;
            this.MoneyPictureBox.TabStop = false;
            // 
            // InvButton
            // 
            this.InvButton.Location = new System.Drawing.Point(153, 3);
            this.InvButton.Name = "InvButton";
            this.InvButton.Size = new System.Drawing.Size(44, 32);
            this.InvButton.TabIndex = 4;
            this.InvButton.Text = "I";
            this.InvButton.UseVisualStyleBackColor = true;
            this.InvButton.Click += new System.EventHandler(this.InvButton_Click);
            // 
            // ShopButton
            // 
            this.ShopButton.Location = new System.Drawing.Point(103, 3);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(44, 32);
            this.ShopButton.TabIndex = 3;
            this.ShopButton.Text = "S";
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // MapButton
            // 
            this.MapButton.Location = new System.Drawing.Point(53, 3);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(44, 32);
            this.MapButton.TabIndex = 2;
            this.MapButton.Text = "M";
            this.MapButton.UseVisualStyleBackColor = true;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(44, 32);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "H";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1.Properties.Resources.Gemini_Generated_Image_wep1pkwep1pkwep1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 38);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(984, 493);
            this.panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximumSize = new System.Drawing.Size(1000, 570);
            this.MinimumSize = new System.Drawing.Size(1000, 570);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Item1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Item2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label MoneyCounterLabel;
        private System.Windows.Forms.Label Item2CounterLabel;
        private System.Windows.Forms.Label Item1CounterLabel;
        private System.Windows.Forms.PictureBox Item1PictureBox;
        private System.Windows.Forms.PictureBox Item2PictureBox;
        private System.Windows.Forms.PictureBox MoneyPictureBox;
        private System.Windows.Forms.Button InvButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Button MapButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelContent;
    }
}

