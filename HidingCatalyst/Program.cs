using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HidingCatalyst {
    static class Program {

        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Catalyst());

            if (args.Length > 0) {
                if (args[0].ToLower().Equals("encrypt")) {
                    Catalyst.inst.Encrypt(args[1], args[2]);
                } else {
                    Catalyst.inst.Decrypt(args[1], args[2]);
                }

                Application.Exit();
            }
        }
    }
}
