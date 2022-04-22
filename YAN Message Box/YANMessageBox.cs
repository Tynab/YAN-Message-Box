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
        public static DialogResult Show(string text)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, lang))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, lang))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, lang))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, lang))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btn_Default)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, btn_Default))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        public static DialogResult Show(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btn_Default, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, btn_Default, lang))
            {
                res = msgFrm.ShowDialog();
            }
            return res;
        }

        /*IWin32Window Owner*/

        public static DialogResult Show(IWin32Window owner, string text)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, lang))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, lang))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, lang))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, lang))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btn_Default)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, btn_Default))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }

        public static DialogResult Show(IWin32Window owner, string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btn_Default, ELang lang)
        {
            DialogResult res;
            using (var msgFrm = new FormMessageBox(text, cap, btns, ic, btn_Default, lang))
            {
                res = msgFrm.ShowDialog(owner);
            }
            return res;
        }
    }
}
