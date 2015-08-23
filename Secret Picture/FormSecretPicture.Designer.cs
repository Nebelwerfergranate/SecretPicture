namespace Secret_Picture
{
    partial class FormSecretPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretPicture));
            this.Show1 = new System.Windows.Forms.Button();
            this.Show4 = new System.Windows.Forms.Button();
            this.Show3 = new System.Windows.Forms.Button();
            this.Show2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show1
            // 
            this.Show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show1.Location = new System.Drawing.Point(12, 12);
            this.Show1.Name = "Show1";
            this.Show1.Size = new System.Drawing.Size(110, 40);
            this.Show1.TabIndex = 0;
            this.Show1.Text = "Картинка 1";
            this.Show1.UseVisualStyleBackColor = true;
            this.Show1.Click += new System.EventHandler(this.Show1_Click);
            // 
            // Show4
            // 
            this.Show4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Show4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show4.Location = new System.Drawing.Point(259, 208);
            this.Show4.Name = "Show4";
            this.Show4.Size = new System.Drawing.Size(110, 40);
            this.Show4.TabIndex = 0;
            this.Show4.Text = "Картинка 4";
            this.Show4.UseVisualStyleBackColor = true;
            this.Show4.Click += new System.EventHandler(this.Show4_Click);
            // 
            // Show3
            // 
            this.Show3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Show3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show3.Location = new System.Drawing.Point(12, 208);
            this.Show3.Name = "Show3";
            this.Show3.Size = new System.Drawing.Size(110, 40);
            this.Show3.TabIndex = 0;
            this.Show3.Text = "Картинка 3";
            this.Show3.UseVisualStyleBackColor = true;
            this.Show3.Click += new System.EventHandler(this.Show3_Click);
            // 
            // Show2
            // 
            this.Show2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Show2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Show2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show2.Location = new System.Drawing.Point(259, 12);
            this.Show2.Name = "Show2";
            this.Show2.Size = new System.Drawing.Size(110, 40);
            this.Show2.TabIndex = 0;
            this.Show2.Text = "Картинка 2";
            this.Show2.UseVisualStyleBackColor = true;
            this.Show2.Click += new System.EventHandler(this.Show2_Click);
            // 
            // FormSecretPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Show2);
            this.Controls.Add(this.Show3);
            this.Controls.Add(this.Show4);
            this.Controls.Add(this.Show1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormSecretPicture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Картинка с секретом";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSecretPicture_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show1;
        private System.Windows.Forms.Button Show4;
        private System.Windows.Forms.Button Show3;
        private System.Windows.Forms.Button Show2;
    }
}

