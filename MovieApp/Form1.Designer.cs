
namespace MovieApp
{
    partial class Form1
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
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(462, 275);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(231, 275);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(322, 48);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(100, 23);
            this.movieTitleTextBox.TabIndex = 2;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(322, 183);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(100, 23);
            this.directorTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
    }
}

