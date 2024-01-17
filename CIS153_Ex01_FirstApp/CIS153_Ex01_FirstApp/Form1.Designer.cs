namespace CIS153_Ex01_FirstApp
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
            this.btn_clickMe = new System.Windows.Forms.Button();
            this.lbl_welcomeMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clickMe
            // 
            this.btn_clickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clickMe.Location = new System.Drawing.Point(12, 388);
            this.btn_clickMe.Name = "btn_clickMe";
            this.btn_clickMe.Size = new System.Drawing.Size(776, 50);
            this.btn_clickMe.TabIndex = 0;
            this.btn_clickMe.Text = "Click Me!";
            this.btn_clickMe.UseVisualStyleBackColor = true;
            this.btn_clickMe.Click += new System.EventHandler(this.btn_clickMe_Click);
            // 
            // lbl_welcomeMsg
            // 
            this.lbl_welcomeMsg.AutoSize = true;
            this.lbl_welcomeMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeMsg.Location = new System.Drawing.Point(295, 9);
            this.lbl_welcomeMsg.Name = "lbl_welcomeMsg";
            this.lbl_welcomeMsg.Size = new System.Drawing.Size(191, 25);
            this.lbl_welcomeMsg.TabIndex = 1;
            this.lbl_welcomeMsg.Text = "Welcome to my app!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_welcomeMsg);
            this.Controls.Add(this.btn_clickMe);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clickMe;
        private System.Windows.Forms.Label lbl_welcomeMsg;
    }
}

