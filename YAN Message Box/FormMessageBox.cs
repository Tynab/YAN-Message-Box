using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Drawing.Color;
using static System.Drawing.FontStyle;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.Keys;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxDefaultButton;
using static System.Windows.Forms.MessageBoxIcon;
using static YAN_Message_Box.ELang;
using static YAN_Message_Box.Properties.Resources;
using static YAN_Message_Box.Scripts.Method;

namespace YAN_Message_Box
{
    public partial class FormMessageBox : Form
    {
        #region Fields
        private readonly Font _fnt_TitVn = new Font("Tahoma", 10);
        private readonly Font _fnt_TitJp = new Font("Yu Gothic", 12);
        private readonly Font _fnt_CapVn = new Font("Verdana", 10);
        private readonly Font _fnt_CapJp = new Font("Meiryo", 9);
        private readonly Font _fnt_TextVn = new Font("Segoe UI Light", 9.5f);
        private readonly Font _fnt_TextJp = new Font("Meiryo", 8);
        private Color _primaryColor = CornflowerBlue;
        #endregion

        #region Constructors
        public FormMessageBox(string text)
        {
            InitializeComponent();
            InitializeItems();
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = null;
            SetSize(MessageBoxButtons.OK);
            SetBtns(MessageBoxButtons.OK, Button1); //set default buttons
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, ELang lang)
        {
            InitializeComponent();
            InitializeItems();
            SetFntLang(lang);
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = null;
            SetSize(MessageBoxButtons.OK);
            //set default buttons
            switch (lang)
            {
                case JAP:
                {
                    SetBtnsJp(MessageBoxButtons.OK, Button1);
                    break;
                }
                case VIE:
                {
                    SetBtnsVn(MessageBoxButtons.OK, Button1);
                    break;
                }
            }
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap)
        {
            InitializeComponent();
            InitializeItems();
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(MessageBoxButtons.OK);
            SetBtns(MessageBoxButtons.OK, Button1); //set default buttons
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, ELang lang)
        {
            InitializeComponent();
            InitializeItems();
            SetFntLang(lang);
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(MessageBoxButtons.OK);
            //set default buttons
            switch (lang)
            {
                case JAP:
                {
                    SetBtnsJp(MessageBoxButtons.OK, Button1);
                    break;
                }
                case VIE:
                {
                    SetBtnsVn(MessageBoxButtons.OK, Button1);
                    break;
                }
            }
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns)
        {
            InitializeComponent();
            InitializeItems();
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            SetBtns(btns, Button1); //set [default button 1]
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns, ELang lang)
        {
            InitializeComponent();
            InitializeItems();
            SetFntLang(lang);
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            //set [default button 1]
            switch (lang)
            {
                case JAP:
                {
                    SetBtnsJp(btns, Button1);
                    break;
                }
                case VIE:
                {
                    SetBtnsVn(btns, Button1);
                    break;
                }
            }
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic)
        {
            InitializeComponent();
            InitializeItems();
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            SetBtns(btns, Button1);
            SetIc(ic);
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, ELang lang)
        {
            InitializeComponent();
            InitializeItems();
            SetFntLang(lang);
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            //set [default button 1]
            switch (lang)
            {
                case JAP:
                {
                    SetBtnsJp(btns, Button1);
                    break;
                }
                case VIE:
                {
                    SetBtnsVn(btns, Button1);
                    break;
                }
            }
            SetIc(ic);
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btnDefault)
        {
            InitializeComponent();
            InitializeItems();
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            SetBtns(btns, btnDefault);
            SetIc(ic);
            buttonX.Click += ButtonX_Click;
        }

        public FormMessageBox(string text, string cap, MessageBoxButtons btns, MessageBoxIcon ic, MessageBoxDefaultButton btnDefault, ELang lang)
        {
            InitializeComponent();
            InitializeItems();
            SetFntLang(lang);
            PrimaryColor = _primaryColor;
            labelMessage.Text = text;
            labelCaption.Text = cap;
            SetSize(btns);
            switch (lang)
            {
                case JAP:
                {
                    SetBtnsJp(btns, btnDefault);
                    break;
                }
                case VIE:
                {
                    SetBtnsVn(btns, btnDefault);
                    break;
                }
            }
            SetIc(ic);
            buttonX.Click += ButtonX_Click;
        }
        #endregion

        #region Overridden
        //ẩn sub window
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        //tắt alt+f4
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) => keyData == (Alt | F4) || base.ProcessCmdKey(ref msg, keyData);
        #endregion

        #region Properties
        public Color PrimaryColor
        {
            get => _primaryColor;
            set
            {
                _primaryColor = value;
                BackColor = _primaryColor; //form border color
            }
        }
        #endregion

        #region Events
        //thoát
        private void ButtonX_Click(object sender, EventArgs e) => Close();
        #endregion

        #region Methods
        //initialize items
        private void InitializeItems()
        {
            //title
            panelTitle.MouseDown += MoveFrm_MouseDown;
            panelTitle.MouseMove += MoveFrm_MouseMove;
            panelTitle.MouseUp += MoveFrm_MouseUp;
            //caption
            labelCaption.MouseDown += MoveFrm_MouseDown;
            labelCaption.MouseMove += MoveFrm_MouseMove;
            labelCaption.MouseUp += MoveFrm_MouseUp;
            //option
            buttonX.DialogResult = DialogResult.Cancel;
            button1.DialogResult = DialogResult.OK;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        //set ngôn ngữ font
        private void SetFntLang(ELang lang)
        {
            switch (lang)
            {
                case JAP:
                {
                    labelCaption.Font = _fnt_TitJp;
                    labelMessage.Font = _fnt_TextJp;
                    button1.Font = _fnt_CapJp;
                    button2.Font = _fnt_CapJp;
                    button3.Font = _fnt_CapJp;
                    break;
                }
                case VIE:
                {
                    labelCaption.Font = _fnt_TitVn;
                    labelMessage.Font = _fnt_TextVn;
                    button1.Font = _fnt_CapVn;
                    button2.Font = _fnt_CapVn;
                    button3.Font = _fnt_CapVn;
                    break;
                }
            }
        }

        //set size
        private void SetSize(MessageBoxButtons btns)
        {
            var w = labelMessage.Width + pictureBoxIcon.Width + panelBody.Padding.Left;
            int min;
            switch (btns)
            {
                case MessageBoxButtons.OK:
                {
                    min = button1.Width + 10 * 2 + +Padding.Left + Padding.Right;
                    break;
                }
                case OKCancel:
                case RetryCancel:
                case YesNo:
                {
                    min = button1.Width * 2 + 10 * 3 + +Padding.Left + Padding.Right;
                    break;
                }
                default:
                {
                    min = button1.Width * 3 + 10 * 4 + +Padding.Left + Padding.Right;
                    break;
                }
            }
            w = Maxer(w, min, labelCaption.Width + buttonX.Width + Padding.Left + Padding.Right);
            if (labelMessage.Height > 17 + labelMessage.Padding.Top + labelMessage.Padding.Bottom)
            {
                labelMessage.Padding = new Padding(0, 0, 0, 15);
            }
            var h = panelTitle.Height + labelMessage.Height + panelButtons.Height + panelBody.Padding.Top + Padding.Top + Padding.Bottom;
            Size = new Size(w, h);
        }

        //set buttons
        private void SetBtns(MessageBoxButtons btns, MessageBoxDefaultButton btnDefault)
        {
            var xCenter = (panelButtons.Width - button1.Width) / 2;
            var yCenter = (panelButtons.Height - button1.Height) / 2;
            switch (btns)
            {
                case MessageBoxButtons.OK:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "OK";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
                case OKCancel:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "OK";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case RetryCancel:
                {
                    //retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "Retry";
                    button1.DialogResult = Retry; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "Cancel";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNo:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "Yes";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNoCancel:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "Yes";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "No";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //cancel button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "Cancel";
                    button3.DialogResult = DialogResult.Cancel; //set dialogResult
                    button3.BackColor = DimGray;
                    //set default button
                    SetDefaultBtn(btnDefault);
                }
                break;
                case AbortRetryIgnore:
                {
                    //abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "Abort";
                    button1.DialogResult = Abort; //set dialogResult
                    button1.BackColor = Goldenrod;
                    //retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Retry";
                    button2.DialogResult = Retry; //set dialogResult
                    //ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "Ignore";
                    button3.DialogResult = Ignore; //set dialogResult
                    button3.BackColor = IndianRed;
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
            }
        }

        //set buttons tiếng việt
        private void SetBtnsVn(MessageBoxButtons btns, MessageBoxDefaultButton btnDefault)
        {
            var xCenter = (panelButtons.Width - button1.Width) / 2;
            var yCenter = (panelButtons.Height - button1.Height) / 2;
            switch (btns)
            {
                case MessageBoxButtons.OK:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "Xong";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
                case OKCancel:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "Xong";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "Hủy";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case RetryCancel:
                {
                    //retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "Thử lại";
                    button1.DialogResult = Retry; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "Hủy";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNo:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "Vâng";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "Không";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNoCancel:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "Vâng";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Không";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //cancel button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "Hủy";
                    button3.DialogResult = DialogResult.Cancel; //set dialogResult
                    button3.BackColor = DimGray;
                    //set default button
                    SetDefaultBtn(btnDefault);
                }
                break;
                case AbortRetryIgnore:
                {
                    //abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "Hủy Bỏ";
                    button1.DialogResult = Abort; //set dialogResult
                    button1.BackColor = Goldenrod;
                    //retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "Thử lại";
                    button2.DialogResult = Retry; //set dialogResult
                    //ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "Bỏ qua";
                    button3.DialogResult = Ignore; //set dialogResult
                    button3.BackColor = IndianRed;
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
            }
        }

        //set buttons tiếng nhật
        private void SetBtnsJp(MessageBoxButtons btns, MessageBoxDefaultButton btnDefault)
        {
            var xCenter = (panelButtons.Width - button1.Width) / 2;
            var yCenter = (panelButtons.Height - button1.Height) / 2;
            switch (btns)
            {
                case MessageBoxButtons.OK:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter, yCenter);
                    button1.Text = "オーケー";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
                case OKCancel:
                {
                    //ok button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "オーケー";
                    button1.DialogResult = DialogResult.OK; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "キャンセル";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case RetryCancel:
                {
                    //retry Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "リトライ";
                    button1.DialogResult = Retry; //set dialogResult
                    //cancel button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "キャンセル";
                    button2.DialogResult = DialogResult.Cancel; //set dialogResult
                    button2.BackColor = DimGray;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNo:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width / 2 - 10, yCenter);
                    button1.Text = "はい";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter + button2.Width / 2 + 10, yCenter);
                    button2.Text = "いいえ";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //set default button
                    if (btnDefault != Button3) //there are only 2 buttons, so the default button cannot be button3
                    {
                        SetDefaultBtn(btnDefault);
                    }
                    else
                    {
                        SetDefaultBtn(Button1);
                    }
                    break;
                }
                case YesNoCancel:
                {
                    //yes Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "はい";
                    button1.DialogResult = Yes; //set dialogResult
                    //no button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "いいえ";
                    button2.DialogResult = No; //set dialogResult
                    button2.BackColor = IndianRed;
                    //cancel button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "キャンセル";
                    button3.DialogResult = DialogResult.Cancel; //set dialogResult
                    button3.BackColor = DimGray;
                    //set default button
                    SetDefaultBtn(btnDefault);
                }
                break;
                case AbortRetryIgnore:
                {
                    //abort Button
                    button1.Visible = true;
                    button1.Location = new Point(xCenter - button1.Width - 10, yCenter);
                    button1.Text = "アボート";
                    button1.DialogResult = Abort; //set dialogResult
                    button1.BackColor = Goldenrod;
                    //retry Button
                    button2.Visible = true;
                    button2.Location = new Point(xCenter, yCenter);
                    button2.Text = "リトライ";
                    button2.DialogResult = Retry; //set dialogResult
                    //ignore Button
                    button3.Visible = true;
                    button3.Location = new Point(xCenter + button2.Width + 10, yCenter);
                    button3.Text = "無視";
                    button3.DialogResult = Ignore; //set dialogResult
                    button3.BackColor = IndianRed;
                    //set default button
                    SetDefaultBtn(btnDefault);
                    break;
                }
            }
        }

        //set default button
        private void SetDefaultBtn(MessageBoxDefaultButton btnDefault)
        {
            switch (btnDefault)
            {
                case Button1:
                {
                    //focus button 1
                    button1.Select();
                    button1.ForeColor = White;
                    button1.Font = new Font(button1.Font, Underline);
                    break;
                }
                case Button2:
                {
                    //focus button 2
                    button2.Select();
                    button2.ForeColor = White;
                    button2.Font = new Font(button2.Font, Underline);
                    break;
                }
                case Button3:
                {
                    //focus button 3
                    button3.Select();
                    button3.ForeColor = White;
                    button3.Font = new Font(button3.Font, Underline);
                    break;
                }
            }
        }

        //set icon
        private void SetIc(MessageBoxIcon ic)
        {
            switch (ic)
            {
                case Error:
                {
                    //error
                    pictureBoxIcon.Image = pMessError;
                    PrimaryColor = FromArgb(224, 79, 95);
                    buttonX.FlatAppearance.MouseOverBackColor = Crimson;
                    break;
                }
                case Information:
                {
                    //information
                    pictureBoxIcon.Image = pMessInfomation;
                    PrimaryColor = FromArgb(38, 191, 166);
                    break;
                }
                case Question:
                {
                    //question
                    pictureBoxIcon.Image = pMessQuestion;
                    PrimaryColor = FromArgb(10, 119, 232);
                    break;
                }
                case Warning:
                {
                    //warning
                    pictureBoxIcon.Image = pMessWarning;
                    PrimaryColor = FromArgb(255, 140, 0);
                    break;
                }
                case MessageBoxIcon.None:
                {
                    //none
                    pictureBoxIcon.Image = pMessChat;
                    PrimaryColor = CornflowerBlue;
                    break;
                }
            }
        }
        #endregion
    }
}
