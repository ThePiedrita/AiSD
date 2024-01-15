namespace AiSD_gr3_grafy
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
            this.btn = new System.Windows.Forms.Button();
            this.drzewoB = new System.Windows.Forms.Button();
            this.liczbaUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaUD)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(89, 71);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(94, 29);
            this.btn.TabIndex = 0;
            this.btn.Text = "GUZIK";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // drzewoB
            // 
            this.drzewoB.Location = new System.Drawing.Point(433, 271);
            this.drzewoB.Name = "drzewoB";
            this.drzewoB.Size = new System.Drawing.Size(94, 29);
            this.drzewoB.TabIndex = 1;
            this.drzewoB.Text = "Add";
            this.drzewoB.UseVisualStyleBackColor = true;
            this.drzewoB.Click += new System.EventHandler(this.drzewoB_Click);
            // 
            // liczbaUD
            // 
            this.liczbaUD.Location = new System.Drawing.Point(557, 271);
            this.liczbaUD.Name = "liczbaUD";
            this.liczbaUD.Size = new System.Drawing.Size(150, 27);
            this.liczbaUD.TabIndex = 2;
            this.liczbaUD.ValueChanged += new System.EventHandler(this.liczbaUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 576);
            this.Controls.Add(this.liczbaUD);
            this.Controls.Add(this.drzewoB);
            this.Controls.Add(this.btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liczbaUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn;
        private Button drzewoB;
        private NumericUpDown liczbaUD;
    }
}