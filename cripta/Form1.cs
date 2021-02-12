using System;
using System.Text;
using System.Windows.Forms;

namespace cripta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 Custom_cryp;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void rb_crip_base_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_crip_base.Checked)
                txt_key.Enabled = false;
        }

        private void rb_crip_hex_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_crip_hex.Checked)
                txt_key.Enabled = false;
        }

        private void rb_crip_key_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_crip_hex.Checked)
                txt_key.Enabled = true;
        }

        private void btn_crip_Click(object sender, EventArgs e)
        {
            if (rb_crip_base.Checked)
            {
                txt_resolut.Text = Convert.ToBase64String(Encoding.ASCII.GetBytes(txt_incode.Text));
            }
            if (rb_crip_hex.Checked)
            {
                string hex_ = string.Empty;
                foreach (char key in txt_incode.Text)
                {
                    hex_ += Convert.ToByte(key).ToString("X");
                }
                txt_resolut.Text = hex_;
            }
            if (rb_crip_key.Checked)
            {
                var ckey = 0;
                var data = string.Empty;
                foreach (var key in txt_incode.Text)
                {
                    var tkey = txt_key.Text[ckey];
                    var newkey = Convert.ToInt32(key) + Convert.ToInt32(tkey - '0');
                    if (newkey < 0)
                        newkey *= -1;

                    data += (char)newkey;
                    ++ckey;
                    if (txt_key.Text.Length <= ckey)
                        ckey = 0;
                }

                txt_resolut.Text = data;
            }
            if (rb_crip_custom.Checked)
                txt_resolut.Text = Custom_cryp.crita(txt_incode.Text, txt_key.Text);
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            if (rb_crip_base.Checked)
            {
                txt_resolut.Text = Encoding.ASCII.GetString(Convert.FromBase64String(txt_incode.Text));
            }
            if (rb_crip_hex.Checked)
            {
                byte[] data = new byte[txt_incode.Text.Length / 2];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = Convert.ToByte(txt_incode.Text.Substring(i * 2, 2), 16);
                }
                txt_resolut.Text = Encoding.ASCII.GetString(data);
            }
            if (rb_crip_key.Checked)
            {
                var ckey = 0;
                var data = string.Empty;
                foreach (var key in txt_incode.Text)
                {
                    var tkey = txt_key.Text[ckey];
                    var newkey = Convert.ToInt32(key) - Convert.ToInt32(tkey - '0');
                    if (newkey < 0)
                        newkey *= -1;

                    data += (char)newkey;
                    ++ckey;
                    if (txt_key.Text.Length <= ckey)
                        ckey = 0;
                }

                txt_resolut.Text = data;
            }

            if (rb_crip_custom.Checked)
                txt_resolut.Text = Custom_cryp.decrita(txt_incode.Text, txt_key.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Custom_cryp = new Form2();
            Custom_cryp.ShowDialog();
        }
    }
}