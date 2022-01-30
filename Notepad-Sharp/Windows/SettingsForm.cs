using System.Windows.Forms;

namespace NotepadSharp.Windows
{
    public partial class SettingsForm : Form
    {
        internal MainForm _parent;

        /// <summary>
        /// Constructs the <see cref="SettingsForm"/>.
        /// </summary>
        /// <param name="parent"></param>
        public SettingsForm(MainForm parent)
        {
            _parent = parent;
            InitializeComponent();
            UpdateUI();
        }

        private void UpdateUI()
        {
            txtClrBox.BackColor = _parent.GlobalSettingsVar.ForeColor;
            bckClrBox.BackColor = _parent.GlobalSettingsVar.BackColor;
            curLineClrBox.BackColor = _parent.GlobalSettingsVar.CurrentLineColor;
            chgLineClrBox.BackColor = _parent.GlobalSettingsVar.ChangedLineColor;
            lineNbrClrBox.BackColor = _parent.GlobalSettingsVar.LineNumberColor;
            caretClrBox.BackColor = _parent.GlobalSettingsVar.CaretColor;
            slctClrBox.BackColor = _parent.GlobalSettingsVar.SelectionColor;
        }

        private void TxtClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.ForeColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void BckClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.BackColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void CurLineClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.CurrentLineColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void ChgLineClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.ChangedLineColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void LineNbrClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.LineNumberColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void CaretClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.CaretColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }

        private void SlctClrBox_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _parent.GlobalSettingsVar.SelectionColor = colorDialog.Color;
                UpdateUI();
                _parent.UpdateActiveTabs();
            }
        }
    }
}
