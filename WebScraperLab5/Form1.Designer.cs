namespace WebScraperLab5
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
            this.textBox_URLInsertion = new System.Windows.Forms.TextBox();
            this.button_ExtractWeb = new System.Windows.Forms.Button();
            this.button_SaveImages = new System.Windows.Forms.Button();
            this.listBox_AllLoadedImages = new System.Windows.Forms.ListBox();
            this.label_ImgCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox_URLInsertion
            // 
            this.textBox_URLInsertion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_URLInsertion.Location = new System.Drawing.Point(60, 30);
            this.textBox_URLInsertion.Name = "textBox_URLInsertion";
            this.textBox_URLInsertion.Size = new System.Drawing.Size(598, 20);
            this.textBox_URLInsertion.TabIndex = 0;
            this.textBox_URLInsertion.Text = "Enter URL here";
            this.textBox_URLInsertion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_URLInsertion_KeyDown);
            // 
            // button_ExtractWeb
            // 
            this.button_ExtractWeb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExtractWeb.Location = new System.Drawing.Point(689, 30);
            this.button_ExtractWeb.Name = "button_ExtractWeb";
            this.button_ExtractWeb.Size = new System.Drawing.Size(75, 23);
            this.button_ExtractWeb.TabIndex = 2;
            this.button_ExtractWeb.Text = "Extract";
            this.button_ExtractWeb.UseVisualStyleBackColor = true;
            this.button_ExtractWeb.Click += new System.EventHandler(this.button_ExtractWeb_Click);
            // 
            // button_SaveImages
            // 
            this.button_SaveImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveImages.Location = new System.Drawing.Point(577, 391);
            this.button_SaveImages.Name = "button_SaveImages";
            this.button_SaveImages.Size = new System.Drawing.Size(75, 23);
            this.button_SaveImages.TabIndex = 3;
            this.button_SaveImages.Text = "Save";
            this.button_SaveImages.UseVisualStyleBackColor = true;
            this.button_SaveImages.Click += new System.EventHandler(this.button_SaveImages_Click);
            // 
            // listBox_AllLoadedImages
            // 
            this.listBox_AllLoadedImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_AllLoadedImages.FormattingEnabled = true;
            this.listBox_AllLoadedImages.HorizontalScrollbar = true;
            this.listBox_AllLoadedImages.Location = new System.Drawing.Point(60, 81);
            this.listBox_AllLoadedImages.Name = "listBox_AllLoadedImages";
            this.listBox_AllLoadedImages.Size = new System.Drawing.Size(592, 303);
            this.listBox_AllLoadedImages.TabIndex = 4;
            // 
            // label_ImgCounter
            // 
            this.label_ImgCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ImgCounter.AutoSize = true;
            this.label_ImgCounter.Location = new System.Drawing.Point(60, 391);
            this.label_ImgCounter.Name = "label_ImgCounter";
            this.label_ImgCounter.Size = new System.Drawing.Size(35, 13);
            this.label_ImgCounter.TabIndex = 5;
            this.label_ImgCounter.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(186, 391);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(373, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 473);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_ImgCounter);
            this.Controls.Add(this.listBox_AllLoadedImages);
            this.Controls.Add(this.button_SaveImages);
            this.Controls.Add(this.button_ExtractWeb);
            this.Controls.Add(this.textBox_URLInsertion);
            this.MinimumSize = new System.Drawing.Size(850, 512);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_URLInsertion;
        private System.Windows.Forms.Button button_ExtractWeb;
        private System.Windows.Forms.Button button_SaveImages;
        private System.Windows.Forms.ListBox listBox_AllLoadedImages;
        private System.Windows.Forms.Label label_ImgCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

