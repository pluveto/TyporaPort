
namespace TyporaPort
{
    partial class MainForm
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
            this.textBoxMarkdown = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonTitleDown = new System.Windows.Forms.Button();
            this.textBoxOutputDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMarkdown
            // 
            this.textBoxMarkdown.Location = new System.Drawing.Point(12, 9);
            this.textBoxMarkdown.Multiline = true;
            this.textBoxMarkdown.Name = "textBoxMarkdown";
            this.textBoxMarkdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMarkdown.Size = new System.Drawing.Size(373, 333);
            this.textBoxMarkdown.TabIndex = 0;
            this.textBoxMarkdown.Text = "# text\r\n## text\r\n### text\r\n#### text";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(400, 12);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(109, 49);
            this.buttonConvert.TabIndex = 1;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonTitleDown
            // 
            this.buttonTitleDown.Location = new System.Drawing.Point(400, 67);
            this.buttonTitleDown.Name = "buttonTitleDown";
            this.buttonTitleDown.Size = new System.Drawing.Size(109, 29);
            this.buttonTitleDown.TabIndex = 2;
            this.buttonTitleDown.Text = "Title Down";
            this.buttonTitleDown.UseVisualStyleBackColor = true;
            this.buttonTitleDown.Click += new System.EventHandler(this.buttonTitleDown_Click);
            // 
            // textBoxOutputDir
            // 
            this.textBoxOutputDir.Location = new System.Drawing.Point(87, 348);
            this.textBoxOutputDir.Name = "textBoxOutputDir";
            this.textBoxOutputDir.Size = new System.Drawing.Size(298, 23);
            this.textBoxOutputDir.TabIndex = 4;
            this.textBoxOutputDir.DoubleClick += new System.EventHandler(this.textBoxOutputDir_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output Dir";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutputDir);
            this.Controls.Add(this.buttonTitleDown);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxMarkdown);
            this.Name = "MainForm";
            this.Text = "Output Dir";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarkdown;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonTitleDown;
        private System.Windows.Forms.TextBox textBoxOutputDir;
        private System.Windows.Forms.Label label1;
    }
}

