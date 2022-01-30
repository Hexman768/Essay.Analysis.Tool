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
        }
    }
}
