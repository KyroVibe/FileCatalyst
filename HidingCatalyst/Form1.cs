using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n30encryption;

namespace HidingCatalyst {
    public partial class Catalyst : Form {

        public static Catalyst inst;

        private Encrypter crypt;
        private EncryptionProtocol enc;

        private string key, _path;

        public Catalyst() {
            inst = this;
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e) {
            enc.EncryptFolder(_path);
        }

        private void decrypt_Click(object sender, EventArgs e) {
            enc.DecryptFolder(_path);
        }

        private void Catalyst_Load(object sender, EventArgs e) {
            crypt = new Encrypter();
            string key = crypt.genKey(128);
            crypt.setKey(key, "password");

            enc = new EncryptionProtocol(crypt);
        }

        private void Path_Change(object sender, EventArgs e) {
            _path = pathBox.Text;
        }

        private void Key_Change(object sender, EventArgs e) {
            key = keyBox.Text;

            crypt.setKey(key, "password");
        }

        //External Use
        public void Encrypt(string path, string key) {
            crypt.setKey(key, "password");
            enc.EncryptFolder(_path);
	    MessageBox.Show("Encryption Finished");
        }

        public void Decrypt(string path, string key) {
            crypt.setKey(key, "password");
            enc.DecryptFolder(_path);
        }

    }
}
