
namespace cripta
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_crip = new System.Windows.Forms.Button();
            this.txt_resolut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_incode = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.btn_dec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_crip_custom = new System.Windows.Forms.RadioButton();
            this.rb_crip_key = new System.Windows.Forms.RadioButton();
            this.rb_crip_hex = new System.Windows.Forms.RadioButton();
            this.rb_crip_base = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_crip);
            this.groupBox1.Controls.Add(this.txt_resolut);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_incode);
            this.groupBox1.Controls.Add(this.txt_key);
            this.groupBox1.Controls.Add(this.btn_dec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 289);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salão de descriptografia";
            // 
            // btn_crip
            // 
            this.btn_crip.Location = new System.Drawing.Point(33, 104);
            this.btn_crip.Name = "btn_crip";
            this.btn_crip.Size = new System.Drawing.Size(119, 26);
            this.btn_crip.TabIndex = 12;
            this.btn_crip.Text = "criptografar";
            this.btn_crip.UseVisualStyleBackColor = true;
            this.btn_crip.Click += new System.EventHandler(this.btn_crip_Click);
            // 
            // txt_resolut
            // 
            this.txt_resolut.Location = new System.Drawing.Point(33, 136);
            this.txt_resolut.Multiline = true;
            this.txt_resolut.Name = "txt_resolut";
            this.txt_resolut.Size = new System.Drawing.Size(329, 141);
            this.txt_resolut.TabIndex = 11;
            this.txt_resolut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mensagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chave";
            // 
            // txt_incode
            // 
            this.txt_incode.Location = new System.Drawing.Point(33, 78);
            this.txt_incode.Name = "txt_incode";
            this.txt_incode.Size = new System.Drawing.Size(329, 20);
            this.txt_incode.TabIndex = 8;
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(33, 39);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(329, 20);
            this.txt_key.TabIndex = 7;
            // 
            // btn_dec
            // 
            this.btn_dec.Location = new System.Drawing.Point(243, 104);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(119, 26);
            this.btn_dec.TabIndex = 6;
            this.btn_dec.Text = "descriptografar";
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "criar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_crip_custom);
            this.groupBox2.Controls.Add(this.rb_crip_key);
            this.groupBox2.Controls.Add(this.rb_crip_hex);
            this.groupBox2.Controls.Add(this.rb_crip_base);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "critografias";
            // 
            // rb_crip_custom
            // 
            this.rb_crip_custom.AutoSize = true;
            this.rb_crip_custom.Checked = true;
            this.rb_crip_custom.Location = new System.Drawing.Point(185, 19);
            this.rb_crip_custom.Name = "rb_crip_custom";
            this.rb_crip_custom.Size = new System.Drawing.Size(60, 17);
            this.rb_crip_custom.TabIndex = 12;
            this.rb_crip_custom.TabStop = true;
            this.rb_crip_custom.Text = "Custom";
            this.rb_crip_custom.UseVisualStyleBackColor = true;
            // 
            // rb_crip_key
            // 
            this.rb_crip_key.AutoSize = true;
            this.rb_crip_key.Location = new System.Drawing.Point(123, 19);
            this.rb_crip_key.Name = "rb_crip_key";
            this.rb_crip_key.Size = new System.Drawing.Size(56, 17);
            this.rb_crip_key.TabIndex = 11;
            this.rb_crip_key.Text = "Chave";
            this.rb_crip_key.UseVisualStyleBackColor = true;
            this.rb_crip_key.CheckedChanged += new System.EventHandler(this.rb_crip_key_CheckedChanged);
            // 
            // rb_crip_hex
            // 
            this.rb_crip_hex.AutoSize = true;
            this.rb_crip_hex.Location = new System.Drawing.Point(73, 19);
            this.rb_crip_hex.Name = "rb_crip_hex";
            this.rb_crip_hex.Size = new System.Drawing.Size(44, 17);
            this.rb_crip_hex.TabIndex = 10;
            this.rb_crip_hex.Text = "Hex";
            this.rb_crip_hex.UseVisualStyleBackColor = true;
            this.rb_crip_hex.CheckedChanged += new System.EventHandler(this.rb_crip_hex_CheckedChanged);
            // 
            // rb_crip_base
            // 
            this.rb_crip_base.AutoSize = true;
            this.rb_crip_base.Location = new System.Drawing.Point(6, 19);
            this.rb_crip_base.Name = "rb_crip_base";
            this.rb_crip_base.Size = new System.Drawing.Size(61, 17);
            this.rb_crip_base.TabIndex = 9;
            this.rb_crip_base.Text = "Base64";
            this.rb_crip_base.UseVisualStyleBackColor = true;
            this.rb_crip_base.CheckedChanged += new System.EventHandler(this.rb_crip_base_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cama de criptografia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_resolut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_incode;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_crip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_crip_custom;
        private System.Windows.Forms.RadioButton rb_crip_key;
        private System.Windows.Forms.RadioButton rb_crip_hex;
        private System.Windows.Forms.RadioButton rb_crip_base;
    }
}

