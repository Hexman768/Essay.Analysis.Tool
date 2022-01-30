using FastColoredTextBoxNS;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadSharp.Core
{
    public class GlobalSettings
    {
        public GlobalSettings()
        {
            RestoreDefaults();
        }

        public bool ShowDocumentMap { get; set; }

        public bool HighlightCurrentLine { get; set; }

        public Color CurrentLineColor { get; set; }

        public Color ChangedLineColor { get; set; }

        public Style SameWordsStyle { get; set; }

        public Font EditorFont { get; set; }

        public Color LineNumberColor { get; set; } // default is color.teal

        public Color CaretColor { get; set; } // default is black

        public bool WideCaret { get; set; }

        public void RestoreDefaults()
        {
            ShowDocumentMap = true;
            HighlightCurrentLine = true;
            CurrentLineColor = Color.FromArgb(100, 210, 210, 255);
            ChangedLineColor = Color.FromArgb(255, 230, 230, 255);
            SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray)));
            EditorFont = new Font("Consolas", 9.75f);
            LineNumberColor = Color.Teal;
            CaretColor = Color.Blue;
            WideCaret = false;
        }
    }
}
