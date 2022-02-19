using System.Windows.Forms;

namespace YAN_Message_Box
{
    public enum ELang
    {
        VIE,
        JAP
    }

    public abstract class YANMessageBox
    {
        public static DialogResult Show(string txt)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, lang))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, lang))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, lang))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, lang))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton defaultBtn)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, defaultBtn))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton defaultBtn, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, defaultBtn, lang))
            {
                res = msgForm.ShowDialog();
            }
            return res;
        }

        /*IWin32Window Owner*/

        public static DialogResult Show(IWin32Window owner, string txt)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, lang))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, lang))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, lang))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, lang))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton defaultBtn)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, defaultBtn))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string txt, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton defaultBtn, ELang lang)
        {
            DialogResult res;
            using (var msgForm = new FormMessageBox(txt, cap, btns, ic, defaultBtn, lang))
            {
                res = msgForm.ShowDialog(owner);
            }
            return res;
        }
    }
}
