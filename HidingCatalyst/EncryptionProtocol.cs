using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using n30encryption;

namespace HidingCatalyst {
    public class EncryptionProtocol {

        private Encrypter crypt;

        private List<Thread> createdThreads = new List<Thread>();

        private List<byte[]> recoveryFiles = new List<byte[]>();

        public EncryptionProtocol(Encrypter crypt) { this.crypt = crypt; }

        public void EncryptFolder(string path) {
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);

            string key = crypt.getKey("password");

            // Encrypt folder

            foreach (string a in files) {

                if (!GetFileName(a).Substring(0, 3).Equals("n30")) {

                    byte[] buffer = File.ReadAllBytes(a);

                    recoveryFiles.Add(buffer);
                    File.Delete(a);

                    byte[] newBuffer = crypt.encryptKey(buffer, key);
                    File.WriteAllBytes(a, newBuffer);
                }
            }

            foreach (string a in folders) {
                Thread b = new Thread(() => EncryptFolder(a)) { Name = a };
                b.Start();

                createdThreads.Add(b);
            }
        }

        public void DecryptFolder(string path) {
            string[] files = Directory.GetFiles(path);
            string[] folders = Directory.GetDirectories(path);

            string key = crypt.getKey("password");

            foreach (string a in files) {

                if (!GetFileName(a).Substring(0, 3).Equals("n30")) {

                    byte[] buffer = File.ReadAllBytes(a);

                    File.Delete(a);

                    byte[] newBuffer = crypt.decryptKey(buffer, key);
                    File.WriteAllBytes(a, newBuffer);
                }

            }

            foreach (string a in folders) {
                DecryptFolder(a);
            }
        }

        public void ClearThreads() {
            foreach (Thread a in createdThreads) {
                a.Abort();
            }
        }

        public string GetFileName(string a) {
            return a.Substring(a.LastIndexOf('\\') + 1);
        }

    }
}
