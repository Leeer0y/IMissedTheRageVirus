namespace IMissedTheRageVirus
{
    partial class msgBox
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
            this.sexySteve = new System.Windows.Forms.PictureBox();
            this.lable = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sexySteve)).BeginInit();
            this.SuspendLayout();
            // 
            // sexySteve
            // 
            this.sexySteve.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sexySteve.Image = global::IMissedTheRageVirus.Properties.Resources.epic;
            this.sexySteve.Location = new System.Drawing.Point(12, 17);
            this.sexySteve.Name = "sexySteve";
            this.sexySteve.Size = new System.Drawing.Size(92, 62);
            this.sexySteve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sexySteve.TabIndex = 0;
            this.sexySteve.TabStop = false;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(110, 42);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(112, 13);
            this.lable.TabIndex = 1;
            this.lable.Text = "I MISSED THE RAGE";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(125, 68);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ight shawty";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // msgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 112);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.sexySteve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "msgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "I MISSED THE RAGE";
            this.Load += new System.EventHandler(this.msgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sexySteve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sexySteve;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button btnOk;
    }
}