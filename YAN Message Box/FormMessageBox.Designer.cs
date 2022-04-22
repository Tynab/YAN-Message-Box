namespace YAN_Message_Box
{
    partial class FormMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessageBox));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.buttonX = new YAN_Controls.YANButton();
            this.labelCaption = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button3 = new YAN_Controls.YANButton();
            this.button2 = new YAN_Controls.YANButton();
            this.button1 = new YAN_Controls.YANButton();
            this.panelBody = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelTitle.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Transparent;
            this.panelTitle.Controls.Add(this.buttonX);
            this.panelTitle.Controls.Add(this.labelCaption);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(2, 2);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelTitle.Size = new System.Drawing.Size(340, 35);
            this.panelTitle.TabIndex = 0;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.Transparent;
            this.buttonX.BorderColor = System.Drawing.Color.Empty;
            this.buttonX.BorderRadius = 0;
            this.buttonX.BorderSize = 0;
            this.buttonX.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(89)))), ((int)(((byte)(105)))));
            this.buttonX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(79)))), ((int)(((byte)(95)))));
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.White;
            this.buttonX.Location = new System.Drawing.Point(307, 0);
            this.buttonX.Margin = new System.Windows.Forms.Padding(0);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(33, 33);
            this.buttonX.TabIndex = 0;
            this.buttonX.TabStop = false;
            this.buttonX.Text = "✕";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.ButtonX_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.labelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaption.ForeColor = System.Drawing.Color.White;
            this.labelCaption.Location = new System.Drawing.Point(0, 7);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelCaption.Size = new System.Drawing.Size(84, 20);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Caption";
            this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(2, 94);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(340, 55);
            this.panelButtons.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.BorderColor = System.Drawing.Color.Empty;
            this.button3.BorderRadius = 0;
            this.button3.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(230, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.BorderColor = System.Drawing.Color.Empty;
            this.button2.BorderRadius = 0;
            this.button2.BorderSize = 0;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(120, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.BorderColor = System.Drawing.Color.Empty;
            this.button1.BorderRadius = 0;
            this.button1.BorderSize = 0;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.Controls.Add(this.labelMessage);
            this.panelBody.Controls.Add(this.pictureBoxIcon);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(2, 37);
            this.panelBody.Margin = new System.Windows.Forms.Padding(0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panelBody.Size = new System.Drawing.Size(340, 57);
            this.panelBody.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.labelMessage.Location = new System.Drawing.Point(60, 10);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(0);
            this.labelMessage.MaximumSize = new System.Drawing.Size(550, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(10, 5, 10, 25);
            this.labelMessage.Size = new System.Drawing.Size(85, 47);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Message";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = global::YAN_Message_Box.Properties.Resources.pMessChat;
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 47);
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // FormMessageBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessageBox";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YAN Message Box";
            this.TopMost = true;
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label labelCaption;
        private YAN_Controls.YANButton buttonX;
        private YAN_Controls.YANButton button3;
        private YAN_Controls.YANButton button2;
        private YAN_Controls.YANButton button1;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelMessage;
    }
}

