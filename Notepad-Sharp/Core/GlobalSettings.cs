using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void RestoreDefaults()
        {
            ShowDocumentMap = true;
            HighlightCurrentLine = true;
            CurrentLineColor = Color.FromArgb(100, 210, 210, 255);
            ChangedLineColor = Color.FromArgb(255, 230, 230, 255);
            SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray)));
            EditorFont = new Font("Consolas", 9.75f);
        }
    }
}
