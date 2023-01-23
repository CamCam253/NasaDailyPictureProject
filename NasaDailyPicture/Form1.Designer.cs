namespace NasaDailyPicture
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
            this.todayBtn = new System.Windows.Forms.Button();
            this.yesterdayBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.nasaPicture = new System.Windows.Forms.PictureBox();
            this.pictureTextLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.copyrightLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nasaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // todayBtn
            // 
            this.todayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayBtn.Location = new System.Drawing.Point(30, 427);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(89, 42);
            this.todayBtn.TabIndex = 0;
            this.todayBtn.Text = "Todays Picture";
            this.todayBtn.UseVisualStyleBackColor = true;
            // 
            // yesterdayBtn
            // 
            this.yesterdayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesterdayBtn.Location = new System.Drawing.Point(125, 427);
            this.yesterdayBtn.Name = "yesterdayBtn";
            this.yesterdayBtn.Size = new System.Drawing.Size(105, 42);
            this.yesterdayBtn.TabIndex = 1;
            this.yesterdayBtn.Text = "Yesterdays Picture";
            this.yesterdayBtn.UseVisualStyleBackColor = true;
            // 
            // randomBtn
            // 
            this.randomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBtn.Location = new System.Drawing.Point(236, 427);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(96, 42);
            this.randomBtn.TabIndex = 2;
            this.randomBtn.Text = "Random Picture";
            this.randomBtn.UseVisualStyleBackColor = true;
            // 
            // nasaPicture
            // 
            this.nasaPicture.Location = new System.Drawing.Point(12, 44);
            this.nasaPicture.Name = "nasaPicture";
            this.nasaPicture.Size = new System.Drawing.Size(740, 377);
            this.nasaPicture.TabIndex = 3;
            this.nasaPicture.TabStop = false;
            // 
            // pictureTextLbl
            // 
            this.pictureTextLbl.AutoSize = true;
            this.pictureTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureTextLbl.Location = new System.Drawing.Point(338, 427);
            this.pictureTextLbl.MinimumSize = new System.Drawing.Size(100, 20);
            this.pictureTextLbl.Name = "pictureTextLbl";
            this.pictureTextLbl.Size = new System.Drawing.Size(100, 20);
            this.pictureTextLbl.TabIndex = 4;
            this.pictureTextLbl.Text = "Explanation: ";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.dateLbl.Location = new System.Drawing.Point(524, 9);
            this.dateLbl.MinimumSize = new System.Drawing.Size(130, 20);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(209, 20);
            this.dateLbl.TabIndex = 5;
            this.dateLbl.Text = "Date of the picture: yyyy-mm-dd";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(27, 12);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(35, 17);
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "Title";
            // 
            // copyrightLbl
            // 
            this.copyrightLbl.AutoSize = true;
            this.copyrightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLbl.Location = new System.Drawing.Point(30, 476);
            this.copyrightLbl.Name = "copyrightLbl";
            this.copyrightLbl.Size = new System.Drawing.Size(64, 15);
            this.copyrightLbl.TabIndex = 7;
            this.copyrightLbl.Text = "Copyright: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 535);
            this.Controls.Add(this.copyrightLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.pictureTextLbl);
            this.Controls.Add(this.nasaPicture);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.yesterdayBtn);
            this.Controls.Add(this.todayBtn);
            this.Name = "Form1";
            this.Text = "NASAs daily picture";
            ((System.ComponentModel.ISupportInitialize)(this.nasaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button todayBtn;
        private System.Windows.Forms.Button yesterdayBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.PictureBox nasaPicture;
        private System.Windows.Forms.Label pictureTextLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label copyrightLbl;
    }
}

