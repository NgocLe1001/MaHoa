namespace cryptography
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashSHA1Result1 = new System.Windows.Forms.TextBox();
            this.txtHashMD5Result1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnRsa = new System.Windows.Forms.RadioButton();
            this.rbtnAes = new System.Windows.Forms.RadioButton();
            this.rbtnDes = new System.Windows.Forms.RadioButton();
            this.txtCrypt = new System.Windows.Forms.TextBox();
            this.txtHashSHA1Result2 = new System.Windows.Forms.TextBox();
            this.txtHashMD5Result2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.txtKeyDes = new System.Windows.Forms.TextBox();
            this.txtKeyAes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilePathSave = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCompareHashFnc = new System.Windows.Forms.Button();
            this.txtFileComparePath = new System.Windows.Forms.TextBox();
            this.btnEncypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(34, 42);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(287, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File path";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(339, 42);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 20);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA1 Hash result (1)";
            // 
            // txtHashSHA1Result1
            // 
            this.txtHashSHA1Result1.Location = new System.Drawing.Point(34, 108);
            this.txtHashSHA1Result1.Multiline = true;
            this.txtHashSHA1Result1.Name = "txtHashSHA1Result1";
            this.txtHashSHA1Result1.Size = new System.Drawing.Size(344, 69);
            this.txtHashSHA1Result1.TabIndex = 0;
            // 
            // txtHashMD5Result1
            // 
            this.txtHashMD5Result1.Location = new System.Drawing.Point(459, 108);
            this.txtHashMD5Result1.Multiline = true;
            this.txtHashMD5Result1.Name = "txtHashMD5Result1";
            this.txtHashMD5Result1.Size = new System.Drawing.Size(344, 69);
            this.txtHashMD5Result1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MD5 Hash result (1)";
            // 
            // rbtnRsa
            // 
            this.rbtnRsa.AutoSize = true;
            this.rbtnRsa.Location = new System.Drawing.Point(358, 88);
            this.rbtnRsa.Name = "rbtnRsa";
            this.rbtnRsa.Size = new System.Drawing.Size(47, 17);
            this.rbtnRsa.TabIndex = 3;
            this.rbtnRsa.TabStop = true;
            this.rbtnRsa.Text = "RSA";
            this.rbtnRsa.UseVisualStyleBackColor = true;
            // 
            // rbtnAes
            // 
            this.rbtnAes.AutoSize = true;
            this.rbtnAes.Location = new System.Drawing.Point(140, 89);
            this.rbtnAes.Name = "rbtnAes";
            this.rbtnAes.Size = new System.Drawing.Size(46, 17);
            this.rbtnAes.TabIndex = 3;
            this.rbtnAes.TabStop = true;
            this.rbtnAes.Text = "AES";
            this.rbtnAes.UseVisualStyleBackColor = true;
            // 
            // rbtnDes
            // 
            this.rbtnDes.AutoSize = true;
            this.rbtnDes.Location = new System.Drawing.Point(512, 88);
            this.rbtnDes.Name = "rbtnDes";
            this.rbtnDes.Size = new System.Drawing.Size(47, 17);
            this.rbtnDes.TabIndex = 3;
            this.rbtnDes.TabStop = true;
            this.rbtnDes.Text = "DES";
            this.rbtnDes.UseVisualStyleBackColor = true;
            // 
            // txtCrypt
            // 
            this.txtCrypt.Location = new System.Drawing.Point(12, 231);
            this.txtCrypt.Multiline = true;
            this.txtCrypt.Name = "txtCrypt";
            this.txtCrypt.Size = new System.Drawing.Size(769, 110);
            this.txtCrypt.TabIndex = 0;
            // 
            // txtHashSHA1Result2
            // 
            this.txtHashSHA1Result2.Location = new System.Drawing.Point(12, 101);
            this.txtHashSHA1Result2.Multiline = true;
            this.txtHashSHA1Result2.Name = "txtHashSHA1Result2";
            this.txtHashSHA1Result2.Size = new System.Drawing.Size(344, 76);
            this.txtHashSHA1Result2.TabIndex = 0;
            // 
            // txtHashMD5Result2
            // 
            this.txtHashMD5Result2.Location = new System.Drawing.Point(437, 101);
            this.txtHashMD5Result2.Multiline = true;
            this.txtHashMD5Result2.Name = "txtHashMD5Result2";
            this.txtHashMD5Result2.Size = new System.Drawing.Size(344, 76);
            this.txtHashMD5Result2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SHA1 Hash result (2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "MD5 Hash result (2)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncypt);
            this.groupBox1.Controls.Add(this.btnDecrypt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Controls.Add(this.txtKeyDes);
            this.groupBox1.Controls.Add(this.txtKeyAes);
            this.groupBox1.Controls.Add(this.rbtnDes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbtnRsa);
            this.groupBox1.Controls.Add(this.rbtnAes);
            this.groupBox1.Controls.Add(this.txtCrypt);
            this.groupBox1.Controls.Add(this.txtFilePathSave);
            this.groupBox1.Location = new System.Drawing.Point(22, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 360);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cryptography";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(465, 168);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(316, 44);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decryption";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Key: ";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Location = new System.Drawing.Point(142, 114);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(31, 13);
            this.key.TabIndex = 5;
            this.key.Text = "Key: ";
            // 
            // txtKeyDes
            // 
            this.txtKeyDes.Location = new System.Drawing.Point(558, 111);
            this.txtKeyDes.Name = "txtKeyDes";
            this.txtKeyDes.Size = new System.Drawing.Size(110, 20);
            this.txtKeyDes.TabIndex = 4;
            this.txtKeyDes.Text = "01234567";
            // 
            // txtKeyAes
            // 
            this.txtKeyAes.Location = new System.Drawing.Point(179, 110);
            this.txtKeyAes.Name = "txtKeyAes";
            this.txtKeyAes.Size = new System.Drawing.Size(111, 20);
            this.txtKeyAes.TabIndex = 4;
            this.txtKeyAes.Text = "password12345678";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "File save\'s path";
            // 
            // txtFilePathSave
            // 
            this.txtFilePathSave.Location = new System.Drawing.Point(271, 32);
            this.txtFilePathSave.Name = "txtFilePathSave";
            this.txtFilePathSave.Size = new System.Drawing.Size(287, 20);
            this.txtFilePathSave.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCompareHashFnc);
            this.groupBox2.Controls.Add(this.txtFileComparePath);
            this.groupBox2.Controls.Add(this.txtHashMD5Result2);
            this.groupBox2.Controls.Add(this.txtHashSHA1Result2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(22, 634);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 183);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash file decryption";
            // 
            // btnCompareHashFnc
            // 
            this.btnCompareHashFnc.Location = new System.Drawing.Point(317, 42);
            this.btnCompareHashFnc.Name = "btnCompareHashFnc";
            this.btnCompareHashFnc.Size = new System.Drawing.Size(75, 23);
            this.btnCompareHashFnc.TabIndex = 3;
            this.btnCompareHashFnc.Text = "Compare";
            this.btnCompareHashFnc.UseVisualStyleBackColor = true;
            this.btnCompareHashFnc.Click += new System.EventHandler(this.btnCompareHashFnc_Click);
            // 
            // txtFileComparePath
            // 
            this.txtFileComparePath.Location = new System.Drawing.Point(12, 45);
            this.txtFileComparePath.Name = "txtFileComparePath";
            this.txtFileComparePath.Size = new System.Drawing.Size(287, 20);
            this.txtFileComparePath.TabIndex = 2;
            // 
            // btnEncypt
            // 
            this.btnEncypt.Location = new System.Drawing.Point(12, 169);
            this.btnEncypt.Name = "btnEncypt";
            this.btnEncypt.Size = new System.Drawing.Size(316, 43);
            this.btnEncypt.TabIndex = 7;
            this.btnEncypt.Text = "Encryption";
            this.btnEncypt.UseVisualStyleBackColor = true;
            this.btnEncypt.Click += new System.EventHandler(this.btnEncypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 829);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHashMD5Result1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHashSHA1Result1);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHashSHA1Result1;
        private System.Windows.Forms.TextBox txtHashMD5Result1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnRsa;
        private System.Windows.Forms.RadioButton rbtnAes;
        private System.Windows.Forms.RadioButton rbtnDes;
        private System.Windows.Forms.TextBox txtCrypt;
        private System.Windows.Forms.TextBox txtHashSHA1Result2;
        private System.Windows.Forms.TextBox txtHashMD5Result2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.TextBox txtKeyDes;
        private System.Windows.Forms.TextBox txtKeyAes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilePathSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCompareHashFnc;
        private System.Windows.Forms.TextBox txtFileComparePath;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncypt;
    }
}

