namespace Max_s_Game
{
    partial class MaxsGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaxsGame));
            this.playButton = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Lime;
            this.playButton.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.playButton.Location = new System.Drawing.Point(302, 284);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(187, 80);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play Game";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Black;
            this.countdown.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.countdown.ForeColor = System.Drawing.Color.Black;
            this.countdown.Location = new System.Drawing.Point(300, 200);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(187, 23);
            this.countdown.TabIndex = 1;
            this.countdown.Text = "Starting in 3...";
            this.countdown.Click += new System.EventHandler(this.countdown_Click);
            // 
            // go
            // 
            this.go.AutoSize = true;
            this.go.Font = new System.Drawing.Font("Magneto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.go.ForeColor = System.Drawing.Color.Black;
            this.go.Location = new System.Drawing.Point(346, 183);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(102, 45);
            this.go.TabIndex = 2;
            this.go.Text = "GO!";
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // MaxsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.go);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaxsGame";
            this.Text = "Max\'s Game";
            this.Load += new System.EventHandler(this.MaxGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button playButton;
        private Label countdown;
        private Label go;
    }
}