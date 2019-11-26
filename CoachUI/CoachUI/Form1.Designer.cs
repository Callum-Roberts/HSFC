namespace CoachUI
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
            this.Addbutton = new System.Windows.Forms.Button();
            this.Coachlabel = new System.Windows.Forms.Label();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.Agetextbox = new System.Windows.Forms.TextBox();
            this.SeatLabel = new System.Windows.Forms.Label();
            this.Seattextxbox = new System.Windows.Forms.TextBox();
            this.getbynameButton = new System.Windows.Forms.Button();
            this.removebynameButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.White;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Addbutton.Location = new System.Drawing.Point(152, 291);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(66, 43);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Add To Bus";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Coachlabel
            // 
            this.Coachlabel.AutoSize = true;
            this.Coachlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coachlabel.ForeColor = System.Drawing.Color.Blue;
            this.Coachlabel.Location = new System.Drawing.Point(210, 96);
            this.Coachlabel.Name = "Coachlabel";
            this.Coachlabel.Size = new System.Drawing.Size(168, 26);
            this.Coachlabel.TabIndex = 1;
            this.Coachlabel.Text = "Coach bookings";
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(251, 149);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(127, 20);
            this.Nametextbox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(182, 148);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 18);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(182, 192);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(36, 18);
            this.AgeLabel.TabIndex = 4;
            this.AgeLabel.Text = "Age";
            // 
            // Agetextbox
            // 
            this.Agetextbox.Location = new System.Drawing.Point(251, 193);
            this.Agetextbox.Name = "Agetextbox";
            this.Agetextbox.Size = new System.Drawing.Size(19, 20);
            this.Agetextbox.TabIndex = 5;
            // 
            // SeatLabel
            // 
            this.SeatLabel.AutoSize = true;
            this.SeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatLabel.Location = new System.Drawing.Point(293, 192);
            this.SeatLabel.Name = "SeatLabel";
            this.SeatLabel.Size = new System.Drawing.Size(42, 18);
            this.SeatLabel.TabIndex = 6;
            this.SeatLabel.Text = "Seat";
            this.SeatLabel.Click += new System.EventHandler(this.SeatLabel_Click);
            // 
            // Seattextxbox
            // 
            this.Seattextxbox.Location = new System.Drawing.Point(359, 193);
            this.Seattextxbox.Name = "Seattextxbox";
            this.Seattextxbox.Size = new System.Drawing.Size(19, 20);
            this.Seattextxbox.TabIndex = 7;
            // 
            // getbynameButton
            // 
            this.getbynameButton.BackColor = System.Drawing.Color.White;
            this.getbynameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getbynameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.getbynameButton.Location = new System.Drawing.Point(251, 291);
            this.getbynameButton.Name = "getbynameButton";
            this.getbynameButton.Size = new System.Drawing.Size(66, 43);
            this.getbynameButton.TabIndex = 8;
            this.getbynameButton.Text = "Get by Name";
            this.getbynameButton.UseVisualStyleBackColor = false;
            this.getbynameButton.Click += new System.EventHandler(this.getbynameButton_Click);
            // 
            // removebynameButton
            // 
            this.removebynameButton.BackColor = System.Drawing.Color.White;
            this.removebynameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebynameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.removebynameButton.Location = new System.Drawing.Point(359, 291);
            this.removebynameButton.Name = "removebynameButton";
            this.removebynameButton.Size = new System.Drawing.Size(66, 43);
            this.removebynameButton.TabIndex = 9;
            this.removebynameButton.Text = "Remove by Name";
            this.removebynameButton.UseVisualStyleBackColor = false;
            this.removebynameButton.Click += new System.EventHandler(this.removebynameButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearButton.Location = new System.Drawing.Point(251, 355);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(66, 43);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::CoachUI.Properties.Resources._3J7A1949;
            this.ClientSize = new System.Drawing.Size(538, 443);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.removebynameButton);
            this.Controls.Add(this.getbynameButton);
            this.Controls.Add(this.Seattextxbox);
            this.Controls.Add(this.SeatLabel);
            this.Controls.Add(this.Agetextbox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.Coachlabel);
            this.Controls.Add(this.Addbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Coachlabel;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox Agetextbox;
        private System.Windows.Forms.Label SeatLabel;
        private System.Windows.Forms.TextBox Seattextxbox;
        private System.Windows.Forms.Button getbynameButton;
        private System.Windows.Forms.Button removebynameButton;
        private System.Windows.Forms.Button clearButton;
    }
}

