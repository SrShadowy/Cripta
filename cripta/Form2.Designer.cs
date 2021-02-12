
namespace cripta
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_number = new System.Windows.Forms.CheckBox();
            this.rb_key_notchange = new System.Windows.Forms.RadioButton();
            this.rb_key_change = new System.Windows.Forms.RadioButton();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.chk_have_key = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_decryp = new System.Windows.Forms.Button();
            this.btn_encryp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_testing_result = new System.Windows.Forms.TextBox();
            this.txt_testing_key = new System.Windows.Forms.TextBox();
            this.txt_testing_txt = new System.Windows.Forms.TextBox();
            this.chk_toindex = new System.Windows.Forms.CheckBox();
            this.chk_tobyte = new System.Windows.Forms.CheckBox();
            this.chk_key_add = new System.Windows.Forms.CheckBox();
            this.chk_key_sub = new System.Windows.Forms.CheckBox();
            this.rb_key_setor = new System.Windows.Forms.RadioButton();
            this.rb_key_total = new System.Windows.Forms.RadioButton();
            this.chk_keychain = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_number);
            this.groupBox1.Controls.Add(this.rb_key_notchange);
            this.groupBox1.Controls.Add(this.rb_key_change);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.chk_have_key);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração de key";
            // 
            // chk_number
            // 
            this.chk_number.AutoSize = true;
            this.chk_number.Location = new System.Drawing.Point(149, 55);
            this.chk_number.Name = "chk_number";
            this.chk_number.Size = new System.Drawing.Size(109, 17);
            this.chk_number.TabIndex = 9;
            this.chk_number.Text = "Numerica apenas";
            this.chk_number.UseVisualStyleBackColor = true;
            this.chk_number.CheckedChanged += new System.EventHandler(this.chk_number_CheckedChanged_1);
            // 
            // rb_key_notchange
            // 
            this.rb_key_notchange.AutoSize = true;
            this.rb_key_notchange.Location = new System.Drawing.Point(78, 54);
            this.rb_key_notchange.Name = "rb_key_notchange";
            this.rb_key_notchange.Size = new System.Drawing.Size(65, 17);
            this.rb_key_notchange.TabIndex = 8;
            this.rb_key_notchange.Text = "Imutavel";
            this.rb_key_notchange.UseVisualStyleBackColor = true;
            // 
            // rb_key_change
            // 
            this.rb_key_change.AutoSize = true;
            this.rb_key_change.Checked = true;
            this.rb_key_change.Location = new System.Drawing.Point(9, 54);
            this.rb_key_change.Name = "rb_key_change";
            this.rb_key_change.Size = new System.Drawing.Size(63, 17);
            this.rb_key_change.TabIndex = 7;
            this.rb_key_change.TabStop = true;
            this.rb_key_change.Text = "Mutavel";
            this.rb_key_change.UseVisualStyleBackColor = true;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(65, 28);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(410, 20);
            this.txt_key.TabIndex = 6;
            this.txt_key.TextChanged += new System.EventHandler(this.txt_key_TextChanged);
            // 
            // chk_have_key
            // 
            this.chk_have_key.AutoSize = true;
            this.chk_have_key.Checked = true;
            this.chk_have_key.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_have_key.Location = new System.Drawing.Point(9, 30);
            this.chk_have_key.Name = "chk_have_key";
            this.chk_have_key.Size = new System.Drawing.Size(43, 17);
            this.chk_have_key.TabIndex = 5;
            this.chk_have_key.Text = "key";
            this.chk_have_key.UseVisualStyleBackColor = true;
            this.chk_have_key.CheckedChanged += new System.EventHandler(this.chk_have_key_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_decryp);
            this.groupBox2.Controls.Add(this.btn_encryp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_testing_result);
            this.groupBox2.Controls.Add(this.txt_testing_key);
            this.groupBox2.Controls.Add(this.txt_testing_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 201);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing area";
            // 
            // btn_decryp
            // 
            this.btn_decryp.Location = new System.Drawing.Point(400, 166);
            this.btn_decryp.Name = "btn_decryp";
            this.btn_decryp.Size = new System.Drawing.Size(75, 23);
            this.btn_decryp.TabIndex = 24;
            this.btn_decryp.Text = "Decrypt";
            this.btn_decryp.UseVisualStyleBackColor = true;
            this.btn_decryp.Click += new System.EventHandler(this.btn_decryp_Click);
            // 
            // btn_encryp
            // 
            this.btn_encryp.Location = new System.Drawing.Point(12, 166);
            this.btn_encryp.Name = "btn_encryp";
            this.btn_encryp.Size = new System.Drawing.Size(75, 23);
            this.btn_encryp.TabIndex = 23;
            this.btn_encryp.Text = "Encrypt";
            this.btn_encryp.UseVisualStyleBackColor = true;
            this.btn_encryp.Click += new System.EventHandler(this.btn_encryp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "result teste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "key";
            // 
            // txt_testing_result
            // 
            this.txt_testing_result.Location = new System.Drawing.Point(9, 116);
            this.txt_testing_result.Multiline = true;
            this.txt_testing_result.Name = "txt_testing_result";
            this.txt_testing_result.Size = new System.Drawing.Size(466, 44);
            this.txt_testing_result.TabIndex = 19;
            // 
            // txt_testing_key
            // 
            this.txt_testing_key.Location = new System.Drawing.Point(9, 37);
            this.txt_testing_key.Name = "txt_testing_key";
            this.txt_testing_key.Size = new System.Drawing.Size(466, 20);
            this.txt_testing_key.TabIndex = 17;
            // 
            // txt_testing_txt
            // 
            this.txt_testing_txt.Location = new System.Drawing.Point(9, 79);
            this.txt_testing_txt.Name = "txt_testing_txt";
            this.txt_testing_txt.Size = new System.Drawing.Size(466, 20);
            this.txt_testing_txt.TabIndex = 18;
            // 
            // chk_toindex
            // 
            this.chk_toindex.AutoSize = true;
            this.chk_toindex.Checked = true;
            this.chk_toindex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_toindex.Location = new System.Drawing.Point(316, 187);
            this.chk_toindex.Name = "chk_toindex";
            this.chk_toindex.Size = new System.Drawing.Size(138, 17);
            this.chk_toindex.TabIndex = 13;
            this.chk_toindex.Text = "usar setores numerados";
            this.chk_toindex.UseVisualStyleBackColor = true;
            this.chk_toindex.Visible = false;
            // 
            // chk_tobyte
            // 
            this.chk_tobyte.AutoSize = true;
            this.chk_tobyte.Location = new System.Drawing.Point(19, 118);
            this.chk_tobyte.Name = "chk_tobyte";
            this.chk_tobyte.Size = new System.Drawing.Size(149, 17);
            this.chk_tobyte.TabIndex = 14;
            this.chk_tobyte.Text = "converter texto para bytes";
            this.chk_tobyte.UseVisualStyleBackColor = true;
            // 
            // chk_key_add
            // 
            this.chk_key_add.AutoSize = true;
            this.chk_key_add.Location = new System.Drawing.Point(316, 118);
            this.chk_key_add.Name = "chk_key_add";
            this.chk_key_add.Size = new System.Drawing.Size(171, 17);
            this.chk_key_add.TabIndex = 15;
            this.chk_key_add.Text = "Soma caracteres com a chave";
            this.chk_key_add.UseVisualStyleBackColor = true;
            // 
            // chk_key_sub
            // 
            this.chk_key_sub.AutoSize = true;
            this.chk_key_sub.Location = new System.Drawing.Point(316, 141);
            this.chk_key_sub.Name = "chk_key_sub";
            this.chk_key_sub.Size = new System.Drawing.Size(182, 17);
            this.chk_key_sub.TabIndex = 16;
            this.chk_key_sub.Text = "Subitrair caracteres com a chave";
            this.chk_key_sub.UseVisualStyleBackColor = true;
            // 
            // rb_key_setor
            // 
            this.rb_key_setor.AutoSize = true;
            this.rb_key_setor.Checked = true;
            this.rb_key_setor.Location = new System.Drawing.Point(316, 164);
            this.rb_key_setor.Name = "rb_key_setor";
            this.rb_key_setor.Size = new System.Drawing.Size(67, 17);
            this.rb_key_setor.TabIndex = 17;
            this.rb_key_setor.TabStop = true;
            this.rb_key_setor.Text = "Por setor";
            this.rb_key_setor.UseVisualStyleBackColor = true;
            // 
            // rb_key_total
            // 
            this.rb_key_total.AutoSize = true;
            this.rb_key_total.Location = new System.Drawing.Point(389, 164);
            this.rb_key_total.Name = "rb_key_total";
            this.rb_key_total.Size = new System.Drawing.Size(62, 17);
            this.rb_key_total.TabIndex = 18;
            this.rb_key_total.Text = "No total";
            this.rb_key_total.UseVisualStyleBackColor = true;
            this.rb_key_total.Visible = false;
            // 
            // chk_keychain
            // 
            this.chk_keychain.AutoSize = true;
            this.chk_keychain.Location = new System.Drawing.Point(19, 141);
            this.chk_keychain.Name = "chk_keychain";
            this.chk_keychain.Size = new System.Drawing.Size(154, 17);
            this.chk_keychain.TabIndex = 19;
            this.chk_keychain.Text = "setor de chave de corrente";
            this.chk_keychain.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 433);
            this.Controls.Add(this.chk_keychain);
            this.Controls.Add(this.rb_key_total);
            this.Controls.Add(this.rb_key_setor);
            this.Controls.Add(this.chk_key_sub);
            this.Controls.Add(this.chk_key_add);
            this.Controls.Add(this.chk_tobyte);
            this.Controls.Add(this.chk_toindex);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Criação custom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk_number;
        private System.Windows.Forms.RadioButton rb_key_notchange;
        private System.Windows.Forms.RadioButton rb_key_change;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.CheckBox chk_have_key;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_decryp;
        private System.Windows.Forms.Button btn_encryp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_testing_result;
        private System.Windows.Forms.TextBox txt_testing_key;
        private System.Windows.Forms.TextBox txt_testing_txt;
        private System.Windows.Forms.CheckBox chk_toindex;
        private System.Windows.Forms.CheckBox chk_tobyte;
        private System.Windows.Forms.CheckBox chk_key_add;
        private System.Windows.Forms.CheckBox chk_key_sub;
        private System.Windows.Forms.RadioButton rb_key_setor;
        private System.Windows.Forms.RadioButton rb_key_total;
        private System.Windows.Forms.CheckBox chk_keychain;
    }
}