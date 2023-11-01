namespace IO_AISD_gr3._02
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
            this.numUd = new System.Windows.Forms.NumericUpDown();
            this.tryb = new System.Windows.Forms.CheckBox();
            this.bubbleSort = new System.Windows.Forms.Button();
            this.selectSort = new System.Windows.Forms.Button();
            this.insertSort = new System.Windows.Forms.Button();
            this.mergeSort = new System.Windows.Forms.Button();
            this.quickSort = new System.Windows.Forms.Button();
            this.generuj = new System.Windows.Forms.Button();
            this.wejscie = new System.Windows.Forms.TextBox();
            this.wyjscie = new System.Windows.Forms.Label();
            this.labelCzas = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.posortowanie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUd)).BeginInit();
            this.SuspendLayout();
            // 
            // numUd
            // 
            this.numUd.Location = new System.Drawing.Point(578, 131);
            this.numUd.Name = "numUd";
            this.numUd.Size = new System.Drawing.Size(150, 27);
            this.numUd.TabIndex = 0;
            // 
            // tryb
            // 
            this.tryb.AutoSize = true;
            this.tryb.Location = new System.Drawing.Point(495, 137);
            this.tryb.Name = "tryb";
            this.tryb.Size = new System.Drawing.Size(18, 17);
            this.tryb.TabIndex = 1;
            this.tryb.UseVisualStyleBackColor = true;
            // 
            // bubbleSort
            // 
            this.bubbleSort.Location = new System.Drawing.Point(275, 390);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(94, 29);
            this.bubbleSort.TabIndex = 2;
            this.bubbleSort.Text = "BS";
            this.bubbleSort.UseVisualStyleBackColor = true;
            this.bubbleSort.Click += new System.EventHandler(this.bubbleSort_Click);
            // 
            // selectSort
            // 
            this.selectSort.Location = new System.Drawing.Point(378, 390);
            this.selectSort.Name = "selectSort";
            this.selectSort.Size = new System.Drawing.Size(94, 29);
            this.selectSort.TabIndex = 3;
            this.selectSort.Text = "SS";
            this.selectSort.UseVisualStyleBackColor = true;
            this.selectSort.Click += new System.EventHandler(this.selectSort_Click);
            // 
            // insertSort
            // 
            this.insertSort.Location = new System.Drawing.Point(478, 390);
            this.insertSort.Name = "insertSort";
            this.insertSort.Size = new System.Drawing.Size(94, 29);
            this.insertSort.TabIndex = 4;
            this.insertSort.Text = "IS";
            this.insertSort.UseVisualStyleBackColor = true;
            this.insertSort.Click += new System.EventHandler(this.insertSort_Click);
            // 
            // mergeSort
            // 
            this.mergeSort.Location = new System.Drawing.Point(578, 390);
            this.mergeSort.Name = "mergeSort";
            this.mergeSort.Size = new System.Drawing.Size(94, 29);
            this.mergeSort.TabIndex = 5;
            this.mergeSort.Text = "MS";
            this.mergeSort.UseVisualStyleBackColor = true;
            this.mergeSort.Click += new System.EventHandler(this.mergeSort_Click);
            // 
            // quickSort
            // 
            this.quickSort.Location = new System.Drawing.Point(678, 390);
            this.quickSort.Name = "quickSort";
            this.quickSort.Size = new System.Drawing.Size(94, 29);
            this.quickSort.TabIndex = 6;
            this.quickSort.Text = "QS";
            this.quickSort.UseVisualStyleBackColor = true;
            this.quickSort.Click += new System.EventHandler(this.quickSort_Click);
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(595, 180);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(94, 29);
            this.generuj.TabIndex = 7;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.button6_Click);
            // 
            // wejscie
            // 
            this.wejscie.Location = new System.Drawing.Point(309, 130);
            this.wejscie.Name = "wejscie";
            this.wejscie.Size = new System.Drawing.Size(125, 27);
            this.wejscie.TabIndex = 8;
            this.wejscie.TextChanged += new System.EventHandler(this.tab_TextChanged);
            // 
            // wyjscie
            // 
            this.wyjscie.AutoSize = true;
            this.wyjscie.Location = new System.Drawing.Point(336, 281);
            this.wyjscie.Name = "wyjscie";
            this.wyjscie.Size = new System.Drawing.Size(48, 20);
            this.wyjscie.TabIndex = 9;
            this.wyjscie.Text = ".............";
            this.wyjscie.Click += new System.EventHandler(this.wyjscie_Click);
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(595, 281);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(42, 20);
            this.labelCzas.TabIndex = 10;
            this.labelCzas.Text = "Czas:";
            this.labelCzas.Click += new System.EventHandler(this.label2_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(643, 281);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(50, 20);
            this.czas.TabIndex = 11;
            this.czas.Text = "label3";
            // 
            // posortowanie
            // 
            this.posortowanie.AutoSize = true;
            this.posortowanie.Location = new System.Drawing.Point(225, 281);
            this.posortowanie.Name = "posortowanie";
            this.posortowanie.Size = new System.Drawing.Size(105, 20);
            this.posortowanie.TabIndex = 12;
            this.posortowanie.Text = "Po sortowaniu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 532);
            this.Controls.Add(this.posortowanie);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.labelCzas);
            this.Controls.Add(this.wyjscie);
            this.Controls.Add(this.wejscie);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.quickSort);
            this.Controls.Add(this.mergeSort);
            this.Controls.Add(this.insertSort);
            this.Controls.Add(this.selectSort);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.tryb);
            this.Controls.Add(this.numUd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numUd;
        private CheckBox tryb;
        private Button bubbleSort;
        private Button selectSort;
        private Button insertSort;
        private Button mergeSort;
        private Button quickSort;
        private Button generuj;
        private TextBox wejscie;
        private Label wyjscie;
        private Label labelCzas;
        private Label czas;
        private Label posortowanie;
    }
}