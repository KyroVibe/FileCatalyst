using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n30encryption {
    public class Encrypter {

        protected string key = "abcdefg";
        protected string password = "password";

        protected string chars = "qwertyuioplkjhgfdsazxcvbnmQWERTYUIOPLKJHGFDSAZXCVBNM1234567890";

        // Constructors

        public Encrypter() { }

        public Encrypter(string key, string password) {
            this.password = password;
            this.key = key;
        }

        // Main Methods

        public byte[] encryptKey(byte[] buffer, string key) {

            int keyCount = 0;
            List<byte> result = new List<byte>();

            for (int i = 0; i < buffer.Length; i++) {

                byte a = Convert.ToByte(buffer[i]);
                byte b = Convert.ToByte(key[keyCount]);

                
                a += b;

                result.Add(a);

                keyCount++;
                if (keyCount <= key.Length) {
                    keyCount = 0;
                }
            }

            return result.ToArray();
        }

        public byte[] encryptPassword(byte[] buffer, string password) {
            if (password == this.password) {
                return encryptKey(buffer, key);
            }

            return null;
        }

        public byte[] decryptKey(byte[] buffer, string key) {

            int keyCount = 0;
            List<byte> result = new List<byte>();

            for (int i = 0; i < buffer.Length; i++) {

                byte a = Convert.ToByte(buffer[i]);
                byte b = Convert.ToByte(key[keyCount]);


                a -= b;

                result.Add(a);

                keyCount++;
                if (keyCount <= key.Length) {
                    keyCount = 0;
                }
            }

            return result.ToArray();
        }

        public byte[] decryptPassword(byte[] buffer, string password) {
            if (password == this.password) {
                return encryptKey(buffer, key);
            }

            return null;
        }

        // Utility Functions

        public string genKey(int sha, int seed) {
            Random rand = new Random(seed);

            string a = "";

            for (int i = 0; i < sha; i++) {

                int index = rand.Next(0, chars.Length);
                a += chars[index];
            }

            return a;
        }

        public string genKey(int sha) {
            int seed = 453423423;
            return genKey(sha, seed);
        }

        public void setKey(string key, string password) {
            if (this.password == password) {
                this.key = key;
            }
        }

        public string getKey(string password) {
            if (password == this.password) {
                return key;
            }

            return null;
        }

    }
}
