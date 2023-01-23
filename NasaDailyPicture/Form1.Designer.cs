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
            ((System.ComponentModel.ISupportInitialize)(this.nasaPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // todayBtn
            // 
            this.todayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayBtn.Location = new System.Drawing.Point(30, 396);
            this.todayBtn.Name = "todayBtn";
            this.todayBtn.Size = new System.Drawing.Size(89, 42);
            this.todayBtn.TabIndex = 0;
            this.todayBtn.Text = "Todays Picture";
            this.todayBtn.UseVisualStyleBackColor = true;
            // 
            // yesterdayBtn
            // 
            this.yesterdayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesterdayBtn.Location = new System.Drawing.Point(125, 396);
            this.yesterdayBtn.Name = "yesterdayBtn";
            this.yesterdayBtn.Size = new System.Drawing.Size(105, 42);
            this.yesterdayBtn.TabIndex = 1;
            this.yesterdayBtn.Text = "Yesterdays Picture";
            this.yesterdayBtn.UseVisualStyleBackColor = true;
            // 
            // randomBtn
            // 
            this.randomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBtn.Location = new System.Drawing.Point(236, 396);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(96, 42);
            this.randomBtn.TabIndex = 2;
            this.randomBtn.Text = "Random Picture";
            this.randomBtn.UseVisualStyleBackColor = true;
            // 
            // nasaPicture
            // 
            this.nasaPicture.Location = new System.Drawing.Point(12, 13);
            this.nasaPicture.Name = "nasaPicture";
            this.nasaPicture.Size = new System.Drawing.Size(740, 377);
            this.nasaPicture.TabIndex = 3;
            this.nasaPicture.TabStop = false;
            // 
            // pictureTextLbl
            // 
            this.pictureTextLbl.AutoSize = true;
            this.pictureTextLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureTextLbl.Location = new System.Drawing.Point(338, 396);
            this.pictureTextLbl.MinimumSize = new System.Drawing.Size(100, 20);
            this.pictureTextLbl.Name = "pictureTextLbl";
            this.pictureTextLbl.Size = new System.Drawing.Size(252, 20);
            this.pictureTextLbl.TabIndex = 4;
            this.pictureTextLbl.Text = "Here will read the pictures explanation.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.pictureTextLbl);
            this.Controls.Add(this.nasaPicture);
            this.Controls.Add(this.randomBtn);
            this.Controls.Add(this.yesterdayBtn);
            this.Controls.Add(this.todayBtn);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

