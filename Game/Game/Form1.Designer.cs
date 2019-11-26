namespace Game
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
            this.nudgeButton1 = new System.Windows.Forms.Button();
            this.nudgeButton2 = new System.Windows.Forms.Button();
            this.nudgeButton3 = new System.Windows.Forms.Button();
            this.spinButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudgeButton1
            // 
            this.nudgeButton1.Location = new System.Drawing.Point(54, 168);
            this.nudgeButton1.Name = "nudgeButton1";
            this.nudgeButton1.Size = new System.Drawing.Size(90, 23);
            this.nudgeButton1.TabIndex = 3;
            this.nudgeButton1.Text = "Nudge ";
            this.nudgeButton1.UseVisualStyleBackColor = true;
            // 
            // nudgeButton2
            // 
            this.nudgeButton2.Location = new System.Drawing.Point(199, 168);
            this.nudgeButton2.Name = "nudgeButton2";
            this.nudgeButton2.Size = new System.Drawing.Size(90, 23);
            this.nudgeButton2.TabIndex = 4;
            this.nudgeButton2.Text = "Nudge ";
            this.nudgeButton2.UseVisualStyleBackColor = true;
            // 
            // nudgeButton3
            // 
            this.nudgeButton3.Location = new System.Drawing.Point(344, 168);
            this.nudgeButton3.Name = "nudgeButton3";
            this.nudgeButton3.Size = new System.Drawing.Size(90, 23);
            this.nudgeButton3.TabIndex = 5;
            this.nudgeButton3.Text = "Nudge ";
            this.nudgeButton3.UseVisualStyleBackColor = true;
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.Color.Aqua;
            this.spinButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(188, 251);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(114, 36);
            this.spinButton.TabIndex = 6;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Game.Properties.Resources.bar;
            this.pictureBox3.Location = new System.Drawing.Point(344, 58);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 85);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game.Properties.Resources.banana;
            this.pictureBox2.Location = new System.Drawing.Point(199, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 85);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.apple;
            this.pictureBox1.Location = new System.Drawing.Point(54, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 85);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(507, 304);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.nudgeButton3);
            this.Controls.Add(this.nudgeButton2);
            this.Controls.Add(this.nudgeButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button nudgeButton1;
        private System.Windows.Forms.Button nudgeButton2;
        private System.Windows.Forms.Button nudgeButton3;
        private System.Windows.Forms.Button spinButton;
    }
}

