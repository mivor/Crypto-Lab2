namespace Crypto_Lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrmFile = new System.Windows.Forms.TextBox();
            this.txtEncFile = new System.Windows.Forms.TextBox();
            this.btnNrmNew = new System.Windows.Forms.Button();
            this.btnNrmExs = new System.Windows.Forms.Button();
            this.btnEncNew = new System.Windows.Forms.Button();
            this.btnEncExs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnKeySel = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.listAlgorithm = new System.Windows.Forms.ComboBox();
            this.listMode = new System.Windows.Forms.ComboBox();
            this.listPadding = new System.Windows.Forms.ComboBox();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encrypte File:";
            // 
            // txtNrmFile
            // 
            this.txtNrmFile.Enabled = false;
            this.txtNrmFile.Location = new System.Drawing.Point(91, 6);
            this.txtNrmFile.Name = "txtNrmFile";
            this.txtNrmFile.Size = new System.Drawing.Size(121, 20);
            this.txtNrmFile.TabIndex = 2;
            // 
            // txtEncFile
            // 
            this.txtEncFile.Enabled = false;
            this.txtEncFile.Location = new System.Drawing.Point(91, 32);
            this.txtEncFile.Name = "txtEncFile";
            this.txtEncFile.Size = new System.Drawing.Size(121, 20);
            this.txtEncFile.TabIndex = 3;
            // 
            // btnNrmNew
            // 
            this.btnNrmNew.Location = new System.Drawing.Point(218, 3);
            this.btnNrmNew.Name = "btnNrmNew";
            this.btnNrmNew.Size = new System.Drawing.Size(75, 23);
            this.btnNrmNew.TabIndex = 4;
            this.btnNrmNew.Text = "New";
            this.btnNrmNew.UseVisualStyleBackColor = true;
            // 
            // btnNrmExs
            // 
            this.btnNrmExs.Location = new System.Drawing.Point(299, 3);
            this.btnNrmExs.Name = "btnNrmExs";
            this.btnNrmExs.Size = new System.Drawing.Size(75, 23);
            this.btnNrmExs.TabIndex = 5;
            this.btnNrmExs.Text = "Existing";
            this.btnNrmExs.UseVisualStyleBackColor = true;
            // 
            // btnEncNew
            // 
            this.btnEncNew.Location = new System.Drawing.Point(218, 29);
            this.btnEncNew.Name = "btnEncNew";
            this.btnEncNew.Size = new System.Drawing.Size(75, 23);
            this.btnEncNew.TabIndex = 6;
            this.btnEncNew.Text = "New";
            this.btnEncNew.UseVisualStyleBackColor = true;
            // 
            // btnEncExs
            // 
            this.btnEncExs.Location = new System.Drawing.Point(300, 29);
            this.btnEncExs.Name = "btnEncExs";
            this.btnEncExs.Size = new System.Drawing.Size(75, 23);
            this.btnEncExs.TabIndex = 7;
            this.btnEncExs.Text = "Existing";
            this.btnEncExs.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Algorithm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Padding:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Key File:";
            // 
            // txtKey
            // 
            this.txtKey.Enabled = false;
            this.txtKey.Location = new System.Drawing.Point(91, 60);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(121, 20);
            this.txtKey.TabIndex = 12;
            // 
            // btnKeySel
            // 
            this.btnKeySel.Location = new System.Drawing.Point(217, 58);
            this.btnKeySel.Name = "btnKeySel";
            this.btnKeySel.Size = new System.Drawing.Size(75, 23);
            this.btnKeySel.TabIndex = 13;
            this.btnKeySel.Text = "Select";
            this.btnKeySel.UseVisualStyleBackColor = true;
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(16, 173);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(65, 30);
            this.btnEnc.TabIndex = 17;
            this.btnEnc.Text = "Encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(91, 173);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(65, 30);
            this.btnDec.TabIndex = 18;
            this.btnDec.Text = "Decrypt";
            this.btnDec.UseVisualStyleBackColor = true;
            // 
            // listAlgorithm
            // 
            this.listAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listAlgorithm.FormattingEnabled = true;
            this.listAlgorithm.Location = new System.Drawing.Point(91, 86);
            this.listAlgorithm.Name = "listAlgorithm";
            this.listAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.listAlgorithm.TabIndex = 19;
            // 
            // listMode
            // 
            this.listMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listMode.FormattingEnabled = true;
            this.listMode.Location = new System.Drawing.Point(91, 113);
            this.listMode.Name = "listMode";
            this.listMode.Size = new System.Drawing.Size(121, 21);
            this.listMode.TabIndex = 20;
            // 
            // listPadding
            // 
            this.listPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listPadding.FormattingEnabled = true;
            this.listPadding.Location = new System.Drawing.Point(91, 140);
            this.listPadding.Name = "listPadding";
            this.listPadding.Size = new System.Drawing.Size(121, 21);
            this.listPadding.TabIndex = 21;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.listPadding);
            this.Controls.Add(this.listMode);
            this.Controls.Add(this.listAlgorithm);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.btnKeySel);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncExs);
            this.Controls.Add(this.btnEncNew);
            this.Controls.Add(this.btnNrmExs);
            this.Controls.Add(this.btnNrmNew);
            this.Controls.Add(this.txtEncFile);
            this.Controls.Add(this.txtNrmFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrmFile;
        private System.Windows.Forms.TextBox txtEncFile;
        private System.Windows.Forms.Button btnNrmNew;
        private System.Windows.Forms.Button btnNrmExs;
        private System.Windows.Forms.Button btnEncNew;
        private System.Windows.Forms.Button btnEncExs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnKeySel;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.ComboBox listAlgorithm;
        private System.Windows.Forms.ComboBox listMode;
        private System.Windows.Forms.ComboBox listPadding;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.SaveFileDialog saveDialog;
    }
}

