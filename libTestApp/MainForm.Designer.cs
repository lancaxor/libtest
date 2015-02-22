namespace libTestApp
{
    partial class MainForm
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
            this.idMainCall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idMainCall
            // 
            this.idMainCall.Location = new System.Drawing.Point(233, 12);
            this.idMainCall.Name = "idMainCall";
            this.idMainCall.Size = new System.Drawing.Size(85, 35);
            this.idMainCall.TabIndex = 0;
            this.idMainCall.Text = "Call Main";
            this.idMainCall.UseVisualStyleBackColor = true;
            this.idMainCall.Click += new System.EventHandler(this.idMainCall_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 57);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idMainCall);
            this.Name = "MainForm";
            this.Text = "Main Tes Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button idMainCall;
        private System.Windows.Forms.Button button1;
    }
}

