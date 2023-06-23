using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingTimer.Converter;

namespace WorkingTimer
{
    public partial class frm_main : Form
    {
        private int totalSeconds;
        private string _format = "03:00";
        private bool _timerRun;
        public frm_main()
        {
            InitializeComponent();
            totalSeconds = TimeConverter.ConvertTimeStringToSeconds(lbl_timer.Text);
        }

        private void btn_action_Click(object sender, System.EventArgs e)
        {
            txt_minute.Visible = lbl_confirm.Visible = txt_second.Visible = false;
            if (_timerRun)
                btn_action.Image = Properties.Resources.start;
            else
                btn_action.Image = Properties.Resources.pause;
            _timerRun = !_timerRun;
            timer.Enabled = _timerRun;
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            if (totalSeconds > 0)
                Task.Run(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lbl_timer.Text = TimeConverter.ConvertSecondsToTimeString(--totalSeconds);
                    });
                });
            else
            {
                timer.Enabled = false;
                _timerRun = !_timerRun;
                btn_action.Image = Properties.Resources.start;
                totalSeconds = TimeConverter.ConvertTimeStringToSeconds(_format);
                new SoundPlayer()
                {
                    SoundLocation = "F:\\C#\\WorkingTimer\\WorkingTimer\\sounds\\end_timer.wav" // SOUND_PATH
                }.Play();
            }
        }

        private void btn_stop_Click(object sender, System.EventArgs e)
        {
            btn_action.Image = Properties.Resources.start;
            totalSeconds = TimeConverter.ConvertTimeStringToSeconds(_format);
            _timerRun = timer.Enabled = false;
            lbl_timer.Text = TimeConverter.ConvertSecondsToTimeString(totalSeconds);
        }

        private void lbl_timer_DoubleClick(object sender, System.EventArgs e)
        {
            if (!_timerRun)
                txt_minute.Visible = lbl_confirm.Visible = txt_second.Visible = true;
        }

        private void txt_second_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void lbl_confirm_Click(object sender, System.EventArgs e)
        {
            _format = $"{txt_minute.Text.PadLeft(2, '0')}:{txt_second.Text.PadLeft(2, '0')}";
            lbl_timer.Text = _format;
            totalSeconds = TimeConverter.ConvertTimeStringToSeconds(_format);
            txt_minute.Visible = lbl_confirm.Visible = txt_second.Visible = false;
        }
    }
}
