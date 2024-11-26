namespace WinForm1
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
            Sayi = new Label();
            label2 = new Label();
            mTxt_sayi = new MaskedTextBox();
            mTxt_sayi2 = new MaskedTextBox();
            combobox = new ComboBox();
            islemyap = new Button();
            lst_Listele = new ListBox();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // Sayi
            // 
            Sayi.AutoSize = true;
            Sayi.Location = new Point(55, 27);
            Sayi.Name = "Sayi";
            Sayi.Size = new Size(28, 15);
            Sayi.TabIndex = 0;
            Sayi.Text = "Sayi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 84);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Sayi2";
            // 
            // mTxt_sayi
            // 
            mTxt_sayi.Location = new Point(55, 45);
            mTxt_sayi.Mask = "000000000000";
            mTxt_sayi.Name = "mTxt_sayi";
            mTxt_sayi.Size = new Size(127, 23);
            mTxt_sayi.TabIndex = 1;
            mTxt_sayi.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // mTxt_sayi2
            // 
            mTxt_sayi2.Location = new Point(55, 102);
            mTxt_sayi2.Mask = "000000000000";
            mTxt_sayi2.Name = "mTxt_sayi2";
            mTxt_sayi2.Size = new Size(127, 23);
            mTxt_sayi2.TabIndex = 1;
            mTxt_sayi2.ValidatingType = typeof(int);
            // 
            // combobox
            // 
            combobox.FormattingEnabled = true;
            combobox.Items.AddRange(new object[] { "+", "-", "/", "*" });
            combobox.Location = new Point(55, 158);
            combobox.Name = "combobox";
            combobox.Size = new Size(127, 23);
            combobox.TabIndex = 2;
            // 
            // islemyap
            // 
            islemyap.Location = new Point(55, 199);
            islemyap.Name = "islemyap";
            islemyap.Size = new Size(127, 45);
            islemyap.TabIndex = 3;
            islemyap.Text = "İşlem Yap";
            islemyap.UseVisualStyleBackColor = true;
            islemyap.Click += islemyap_Click;
            // 
            // lst_Listele
            // 
            lst_Listele.BackColor = SystemColors.MenuHighlight;
            lst_Listele.FormattingEnabled = true;
            lst_Listele.ItemHeight = 15;
            lst_Listele.Location = new Point(231, 47);
            lst_Listele.Name = "lst_Listele";
            lst_Listele.Size = new Size(279, 199);
            lst_Listele.TabIndex = 4;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(284, 271);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(187, 44);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Listeyi Temizle";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(lst_Listele);
            Controls.Add(islemyap);
            Controls.Add(combobox);
            Controls.Add(mTxt_sayi2);
            Controls.Add(mTxt_sayi);
            Controls.Add(label2);
            Controls.Add(Sayi);
            Name = "Form1";
            Text = "HesapMakinesi";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Sayi;
        private Label label2;
        private MaskedTextBox mTxt_sayi;
        private MaskedTextBox mTxt_sayi2;
        private ComboBox combobox;
        private Button islemyap;
        private ListBox lst_Listele;
        private Button btn_clear;
    }
}
