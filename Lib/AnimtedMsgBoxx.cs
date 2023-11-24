using ServiceStack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Managment.Lib
{
    public class AnimtedMsgBoxx : Form
    {
        private const int CS_DROPSHADOW = 0x00020000;
        private static AnimtedMsgBoxx _msgBox;
        private Panel _plHeader = new Panel();
        private Panel _plFooter = new Panel();
        private Panel _plIcon = new Panel();
        private PictureBox _picIcon = new PictureBox();
        private FlowLayoutPanel _flpButtons = new FlowLayoutPanel();
        private Label _lblTitle;
        private Label _lblMessage;
        private List<Button> _buttonCollection = new List<Button>();
        private static DialogResult _buttonResult = new DialogResult();
        private static Timer _timer;
        private static Point lastMousePos;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);


        private AnimtedMsgBoxx()
        {
            try
            {
                Screen myScreen = Screen.FromControl(this);
                Rectangle area = myScreen.WorkingArea;

                this.Top = (area.Height - this.Height) - 200;
                this.Left = (area.Width - this.Width) - 530;

                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.BackColor = Color.FromArgb(45, 45, 48);
                this.StartPosition = FormStartPosition.Manual;
                this.Padding = new System.Windows.Forms.Padding(3);
                this.Width = 200;

                _lblTitle = new Label();
                _lblTitle.ForeColor = Color.White;
                _lblTitle.Font = new System.Drawing.Font("Segoe UI", 12);
                _lblTitle.Dock = DockStyle.Top;
                //  _lblTitle.Height = 40;

                _lblMessage = new Label();
                _lblMessage.ForeColor = Color.White;
                _lblMessage.Font = new System.Drawing.Font("Segoe UI", 8);
                _lblMessage.Dock = DockStyle.Fill;

                _flpButtons.FlowDirection = FlowDirection.RightToLeft;
                _flpButtons.Dock = DockStyle.None;
                _flpButtons.Padding = new Padding(3);

                _plHeader.Dock = DockStyle.Fill;
                _plHeader.Padding = new Padding(20);
                _plHeader.Controls.Add(_lblMessage);
                _plHeader.Controls.Add(_lblTitle);

                _plFooter.Dock = DockStyle.Bottom;
                _plFooter.Padding = new Padding(20);
                _plFooter.BackColor = Color.FromArgb(37, 37, 38);
                _plFooter.Height = 40;
                _plFooter.Controls.Add(_flpButtons);

                //Logo
                _picIcon.Width = 50;
                _picIcon.Height = 70;
                _picIcon.Location = new Point(14, 35);

                _plIcon.Dock = DockStyle.Left;
                _plIcon.Padding = new Padding(20);
                _plIcon.Width = 50;
                _plIcon.Controls.Add(_picIcon);

                List<Control> controlCollection = new List<Control>();
                controlCollection.Add(this);
                controlCollection.Add(_lblTitle);
                controlCollection.Add(_lblMessage);
                controlCollection.Add(_flpButtons);
                controlCollection.Add(_plHeader);
                controlCollection.Add(_plFooter);
                controlCollection.Add(_plIcon);
                controlCollection.Add(_picIcon);

                foreach (Control control in controlCollection)
                {
                    control.MouseDown += AnimtedMsgBox_MouseDown;
                    control.MouseMove += AnimtedMsgBox_MouseMove;
                }

                this.Controls.Add(_plHeader);
                this.Controls.Add(_plIcon);
                this.Controls.Add(_plFooter);
            }
            catch (Exception ex)
            {
                int LineNo = AnimtedMsgBoxx.GetLineNumber(ex);
                string MethodName = MethodBase.GetCurrentMethod().Name;
                string EventType = Events.ToString();
                MessageBox.Show(ex.Message);
            }
        }

        private static void AnimtedMsgBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMousePos = new Point(e.X, e.Y);
            }
        }


        private static void AnimtedMsgBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _msgBox.Left += e.X - lastMousePos.X;
                _msgBox.Top += e.Y - lastMousePos.Y;
            }
        }

        public static int GetLineNumber(Exception ex)
        {
            var lineNumber = 0;
            const string lineSearch = ":line";
            var index = ex.StackTrace.LastIndexOf(lineSearch);
            if (index != -1)
            {
                var lineNumberText = ex.StackTrace.Substring(index + lineSearch.Length);
                if (int.TryParse(lineNumberText, out lineNumber))
                {
                }
            }
            return lineNumber;
        }
        private static void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case "Abort":
                    _buttonResult = DialogResult.Abort;
                    break;

                case "Retry":
                    _buttonResult = DialogResult.Retry;
                    break;

                case "Ignore":
                    _buttonResult = DialogResult.Ignore;
                    break;

                case "OK":
                    _buttonResult = DialogResult.OK;
                    break;

                case "Cancel":
                    _buttonResult = DialogResult.Cancel;
                    break;

                case "Yes":
                    _buttonResult = DialogResult.Yes;
                    break;

                case "No":
                    _buttonResult = DialogResult.No;
                    break;
            }

            _msgBox.Dispose();
        }
        private void InitAbortRetryIgnoreButtons()
        {
            Button btnAbort = new Button();
            btnAbort.Text = "Abort";
            btnAbort.Click += ButtonClick;

            Button btnRetry = new Button();
            btnRetry.Text = "Retry";
            btnRetry.Click += ButtonClick;

            Button btnIgnore = new Button();
            btnIgnore.Text = "Ignore";
            btnIgnore.Click += ButtonClick;

            this._buttonCollection.Add(btnAbort);
            this._buttonCollection.Add(btnRetry);
            this._buttonCollection.Add(btnIgnore);
        }
        private void InitOKButton()
        {
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;
            this._buttonCollection.Add(btnOK);
        }

        private void InitOKCancelButtons()
        {
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnOK);
            this._buttonCollection.Add(btnCancel);
        }

        private void InitRetryCancelButtons()
        {
            Button btnRetry = new Button();
            btnRetry.Text = "OK";
            btnRetry.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;


            this._buttonCollection.Add(btnRetry);
            this._buttonCollection.Add(btnCancel);
        }

        private void InitYesNoButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Yes";
            btnYes.Click += ButtonClick;

            Button btnNo = new Button();
            btnNo.Text = "No";
            btnNo.Click += ButtonClick;


            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
        }

        private void InitYesNoCancelButtons()
        {
            Button btnYes = new Button();
            btnYes.Text = "Abort";
            btnYes.Click += ButtonClick;

            Button btnNo = new Button();
            btnNo.Text = "Retry";
            btnNo.Click += ButtonClick;

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;

            this._buttonCollection.Add(btnYes);
            this._buttonCollection.Add(btnNo);
            this._buttonCollection.Add(btnCancel);
        }
        private static void InitButtonsMedium(Buttons buttons)
        {
            switch (buttons)
            {
                case AnimtedMsgBoxx.Buttons.AbortRetryIgnore:
                    _msgBox.InitAbortRetryIgnoreButtons();
                    break;

                case AnimtedMsgBoxx.Buttons.OK:
                    _msgBox.InitOKButton();
                    break;

                case AnimtedMsgBoxx.Buttons.OKCancel:
                    _msgBox.InitOKCancelButtons();
                    break;

                case AnimtedMsgBoxx.Buttons.RetryCancel:
                    _msgBox.InitRetryCancelButtons();
                    break;

                case AnimtedMsgBoxx.Buttons.YesNo:
                    _msgBox.InitYesNoButtons();
                    break;

                case AnimtedMsgBoxx.Buttons.YesNoCancel:
                    _msgBox.InitYesNoCancelButtons();
                    break;
            }

            foreach (Button btn in _msgBox._buttonCollection)
            {
                btn.ForeColor = Color.FromArgb(170, 170, 170);
                btn.Font = new System.Drawing.Font("Segoe UI", 8);
                btn.Padding = new Padding(3);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Height = 27;
                btn.Width = 60;
                btn.Location = new Point(14, 50);
                btn.FlatAppearance.BorderColor = Color.FromArgb(99, 99, 98);
                btn.Cursor = Cursors.Hand;

                _msgBox._flpButtons.Controls.Add(btn);
            }
        }
        public enum Icon
        {
            Application = 1,
            Exclamation = 2,
            Error = 3,
            Warning = 4,
            Info = 5,
            Question = 6,
            Shield = 7,
            Search = 8,
        }
        private static void InitIcon(Icon icon)
        {
            switch (icon)
            {
                case AnimtedMsgBoxx.Icon.Application:
                    _msgBox._picIcon.Image = SystemIcons.Application.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Exclamation:
                    _msgBox._picIcon.Image = SystemIcons.Exclamation.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Error:
                    _msgBox._picIcon.Image = SystemIcons.Error.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Info:
                    _msgBox._picIcon.Image = SystemIcons.Information.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Question:
                    _msgBox._picIcon.Image = SystemIcons.Question.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Shield:
                    _msgBox._picIcon.Image = SystemIcons.Shield.ToBitmap();
                    break;

                case AnimtedMsgBoxx.Icon.Warning:
                    _msgBox._picIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
            }
        }
        private static Size MessageSizeMedium(string message)
        {
            Graphics g = _msgBox.CreateGraphics();
            int width = 250;
            int height = 155;

            SizeF size = g.MeasureString(message, new System.Drawing.Font("Segoe UI", 8));

            if (message.Length < 150)
            {
                if ((int)size.Width > 250)
                {
                    width = (int)size.Width;
                }
            }
            else
            {
                string[] groups = (from Match m in Regex.Matches(message, ".{1,180}") select m.Value).ToArray();
                int lines = groups.Length;
                width = 250;
                height += (int)(size.Height) * lines;
            }
            return new Size(width, height);
        }
        public enum AnimateStyle
        {
            SlideDown = 1,
            FadeIn = 2,
            ZoomIn = 3
        }
        class ApplyAnimation
        {
            public Size FormSize;
            public AnimtedMsgBoxx.AnimateStyle Style;

            public ApplyAnimation(Size formSize, AnimtedMsgBoxx.AnimateStyle style)
            {
                this.FormSize = formSize;
                this.Style = style;
            }
        }
        public enum Buttons
        {
            AbortRetryIgnore = 1,
            OK = 2,
            OKCancel = 3,
            RetryCancel = 4,
            YesNo = 5,
            YesNoCancel = 6
        }
        public static DialogResult ShowMedium(string message, Buttons buttons, Icon icon, AnimateStyle style)
        {
            try
            {
                AnimtedMsgBoxx msg = new AnimtedMsgBoxx();
                msg._lblMessage.Text = message;
                // _msgBox._lblTitle.Text = title;
                _msgBox.Height = 0;

                AnimtedMsgBoxx.InitButtonsMedium(buttons);
                AnimtedMsgBoxx.InitIcon(icon);

                _timer = new Timer();
                Size formSize = AnimtedMsgBoxx.MessageSizeMedium(message);

                switch (style)
                {
                    case AnimtedMsgBoxx.AnimateStyle.SlideDown:
                        _msgBox.Size = new Size(formSize.Width, 0);
                        _timer.Interval = 1;
                        _timer.Tag = new ApplyAnimation(formSize, style);
                        break;

                    case AnimtedMsgBoxx.AnimateStyle.FadeIn:
                        _msgBox.Size = formSize;
                        _msgBox.Opacity = 0;
                        _timer.Interval = 20;
                        _timer.Tag = new ApplyAnimation(formSize, style);
                        break;

                    case AnimtedMsgBoxx.AnimateStyle.ZoomIn:
                        _msgBox.Size = new Size(formSize.Width + 30, formSize.Height + 30);
                        _timer.Tag = new ApplyAnimation(formSize, style);
                        _timer.Interval = 1;
                        break;
                }

                _timer.Tick += timer_Tick;
                _timer.Start();

                _msgBox.ShowDialog();
                MessageBeep(0);
                return _buttonResult;
            }
            catch (Exception ex)
            { return _buttonResult; }
        }

        static void timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            ApplyAnimation animate = (ApplyAnimation)timer.Tag;

            switch (animate.Style)
            {
                case AnimtedMsgBoxx.AnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case AnimtedMsgBoxx.AnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }
                    break;

                case AnimtedMsgBoxx.AnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width)
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }
                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }
                    break;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AnimtedMsgBoxx
            // 
            this.ClientSize = new System.Drawing.Size(284, 138);
            this.Name = "AnimtedMsgBoxx";
            this.ResumeLayout(false);

        }
    }
}
