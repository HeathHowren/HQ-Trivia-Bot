namespace v3_OCR_HQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.answerBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.questionBox = new System.Windows.Forms.PictureBox();
            this.answerBox2 = new System.Windows.Forms.PictureBox();
            this.answerBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.answerBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-1, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(463, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan for answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerBox1
            // 
            this.answerBox1.BackColor = System.Drawing.Color.Transparent;
            this.answerBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerBox1.BackgroundImage")));
            this.answerBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answerBox1.Location = new System.Drawing.Point(-1, 236);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(463, 69);
            this.answerBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerBox1.TabIndex = 1;
            this.answerBox1.TabStop = false;
            this.answerBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-1, 512);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(463, 105);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // questionBox
            // 
            this.questionBox.BackColor = System.Drawing.Color.Transparent;
            this.questionBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("questionBox.BackgroundImage")));
            this.questionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.questionBox.Location = new System.Drawing.Point(-1, 49);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(463, 181);
            this.questionBox.TabIndex = 3;
            this.questionBox.TabStop = false;
            this.questionBox.Click += new System.EventHandler(this.questionBox_Click);
            // 
            // answerBox2
            // 
            this.answerBox2.BackColor = System.Drawing.Color.Transparent;
            this.answerBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerBox2.BackgroundImage")));
            this.answerBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answerBox2.Location = new System.Drawing.Point(-1, 311);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(463, 69);
            this.answerBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerBox2.TabIndex = 4;
            this.answerBox2.TabStop = false;
            // 
            // answerBox3
            // 
            this.answerBox3.BackColor = System.Drawing.Color.Transparent;
            this.answerBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerBox3.BackgroundImage")));
            this.answerBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answerBox3.Location = new System.Drawing.Point(-1, 386);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(463, 69);
            this.answerBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.answerBox3.TabIndex = 5;
            this.answerBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(461, 617);
            this.Controls.Add(this.answerBox3);
            this.Controls.Add(this.answerBox2);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.answerBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "HQ Trivia Helper";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.answerBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox answerBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox questionBox;
        private System.Windows.Forms.PictureBox answerBox2;
        private System.Windows.Forms.PictureBox answerBox3;
    }
}

