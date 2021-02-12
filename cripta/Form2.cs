using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cripta
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string decrita(string txt, string key)
        {
            var criout = string.Empty;
            var byte_txt = new byte[txt.Length / 2];
            if (this.chk_tobyte.Checked)
            {
                for (var i = 0; i < byte_txt.Length; i++)
                {
                    byte_txt[i] = Convert.ToByte(txt.Substring(i * 2, 2), 16);
                }
            }else
                byte_txt = null;

            

            if (!this.chk_have_key.Checked || rb_key_notchange.Checked)
                key = this.txt_key.Text;


            if (!this.chk_key_sub.Checked && !this.chk_key_add.Checked) return criout;
            {
                int ckey = 0, corrente = 0;
                if (this.chk_keychain.Checked)
                    ckey = 1;

                if (this.chk_toindex.Checked)
                {
                    if (byte_txt == null)
                    {

                        foreach (var tchar in txt)
                        {
                            if (this.chk_keychain.Checked)
                                corrente = key[ckey - 1] - '0';
                            else
                                corrente = 0;

                            var tkey = key[ckey];

                            var newkey = 0;

                            if (this.chk_key_add.Checked)
                                newkey = Convert.ToInt32(tchar) - Convert.ToInt32(tkey - '0' + corrente);
                            else if (this.chk_key_sub.Checked)
                                newkey = Convert.ToInt32(tkey - '0' + corrente) + Convert.ToInt32(tchar);

                            if (newkey < 0)
                                newkey *= -1;

                            criout += Convert.ToChar(newkey);

                            ++ckey;
                            if (ckey < key.Length) continue;
                            ckey = this.chk_keychain.Checked ? 1 : 0;
                        }

                    }
                    else
                    {
                        for (var i = 0; i < byte_txt.Length; ++i)
                        {

                            if (this.chk_keychain.Checked)
                                corrente = key[ckey - 1] - '0';
                            else
                                corrente = 0;

                            var tkey = key[ckey];


                            var newkey = 0;
                            if (this.chk_key_add.Checked)
                                newkey = byte_txt[i] - Convert.ToInt32(tkey - '0' + corrente);
                            else if (this.chk_key_sub.Checked)
                                newkey = byte_txt[i] + Convert.ToInt32(tkey - '0' + corrente);

                            if (newkey < 0)
                                newkey *= -1;

                            byte_txt[i] = Convert.ToByte(newkey);

                            ++ckey;
                            if (ckey < key.Length) continue;
                            ckey = this.chk_keychain.Checked ? 1 : 0;


                        }

                        criout = Encoding.ASCII.GetString(byte_txt);
                    }
                }
            }

            return criout;
        }

        public string crita(string txt, string key)
        {
            var criout = string.Empty;
            byte[] byte_txt = Encoding.ASCII.GetBytes(txt);
            if (!this.chk_tobyte.Checked)
                byte_txt = null;

            if (!this.chk_have_key.Checked || rb_key_notchange.Checked)
                key = this.txt_key.Text;


            if (this.chk_key_sub.Checked || this.chk_key_add.Checked)
            {
                var ckey = 0;
                if (this.chk_keychain.Checked)
                    ckey = 1;

                if (this.chk_toindex.Checked)
                {
                    var corrente = 0;
                    if (byte_txt == null)
                    {
                       
                       foreach (var tchar in txt)
                       {
                            if (this.chk_keychain.Checked)
                                corrente = key[ckey - 1] - '0';
                            else
                                corrente = 0;

                            var tkey = key[ckey];



                            var newkey = 0;

                            if(this.chk_key_add.Checked)
                                newkey = Convert.ToInt32(tchar) + Convert.ToInt32(tkey - '0' + corrente);
                            else if (this.chk_key_sub.Checked)
                                newkey = Convert.ToInt32(tkey - '0' + corrente) - Convert.ToInt32(tchar);

                            if (newkey < 0)
                                newkey *= -1;

                            criout += Convert.ToChar(newkey);

                            ++ckey;
                            if (ckey < key.Length) continue;
                            ckey = this.chk_keychain.Checked ? 1 : 0;
                       }
                    
                    }
                    else
                    {
                        for (int i = 0; i < byte_txt.Length; ++i)
                        {

                            if (this.chk_keychain.Checked)
                                corrente = key[ckey - 1] - '0';
                            else
                                corrente = 0;

                            var tkey = key[ckey];


                            var newkey = 0;
                            if (this.chk_key_add.Checked)
                                newkey =  byte_txt[i] + Convert.ToInt32(tkey - '0' + corrente);
                            else if (this.chk_key_sub.Checked)
                                newkey = byte_txt[i] - Convert.ToInt32(tkey - '0' + corrente);

                            if (newkey < 0)
                                newkey *= -1;

                            byte_txt[i] = Convert.ToByte(newkey);
          
                            ++ckey;
                            if (ckey < key.Length) continue;
                            ckey = this.chk_keychain.Checked ? 1 : 0;


                        }

                        criout = byte_txt.Aggregate(criout, (current, na) => current + na.ToString("X"));
                    }
                }
            }

            return criout;
        }

        private void chk_number_CheckedChanged_1(object sender, EventArgs e)
        {
      
        }

        private void txt_key_TextChanged(object sender, EventArgs e)
        {
            if (!chk_number.Checked) return;
            if (!int.TryParse(txt_key.Text, out _))
            {
                txt_key.Text = "";
            }
        }

        private void btn_encryp_Click(object sender, EventArgs e)
        {
            txt_testing_result.Text = crita(txt_testing_txt.Text, txt_testing_key.Text);
        }

        private void chk_have_key_CheckedChanged(object sender, EventArgs e)
        {
                txt_testing_key.Visible = chk_have_key.Checked;
        }

        private void btn_decryp_Click(object sender, EventArgs e)
        {
            txt_testing_result.Text = decrita(txt_testing_txt.Text, txt_testing_key.Text);
        }
    }
}
