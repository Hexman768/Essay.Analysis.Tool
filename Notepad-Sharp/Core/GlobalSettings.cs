using FastColoredTextBoxNS;
using System.Drawing;

namespace NotepadSharp.Core
{
    /// <summary>
    /// Class to hold global settings.
    /// </summary>
    public class GlobalSettings
    {
        /// <summary>
        /// Constructs the <see cref="GlobalSettings"/> Instance.
        /// </summary>
        public GlobalSettings()
        {
            RestoreDefaults();
        }

        /// <summary>
        /// Attribute to enable or disable the
        /// viewing of the <see cref="DocumentMap"/>.
        /// </summary>
        public bool ShowDocumentMap { get; set; }

        /// <summary>
        /// Enables or disables the current line
        /// highlighting functionality of the <see cref="FastColoredTextBox"/>.
        /// </summary>
        public bool HighlightCurrentLine { get; set; }

        /// <summary>
        /// Sets the color of the current line.
        /// </summary>
        public Color CurrentLineColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the changed line.
        /// </summary>
        public Color ChangedLineColor { get; set; }

        /// <summary>
        /// Gets and sets the style of the SameWords attribute.
        /// </summary>
        public Style SameWordsStyle { get; set; }

        /// <summary>
        /// Gets and sets the Font for the <see cref="FastColoredTextBox"/>.
        /// </summary>
        public Font EditorFont { get; set; }

        /// <summary>
        /// Gets and sets the color of the line numbers in the editor.
        /// </summary>
        public Color LineNumberColor { get; set; }

        /// <summary>
        /// Gets and sets the color of the caret in the editor.
        /// </summary>
        public Color CaretColor { get; set; }

        /// <summary>
        /// Enables or disables the caret being wide or slim.
        /// </summary>
        public bool WideCaret { get; set; }

        /// <summary>
        /// Gets and sets the text color of the editor.
        /// </summary>
        public Color ForeColor { get; set; }

        /// <summary>
        /// Gets and sets the background color of the editor.
        /// </summary>
        public Color BackColor { get; set; }

        /// <summary>
        /// Enables and disables the cursor blinking in the editor.
        /// </summary>
        public bool CaretBlinking { get; set; }

        /// <summary>
        /// Gets and sets the color of selections in the editor.
        /// </summary>
        public Color SelectionColor { get; set; }

        /// <summary>
        /// Gets and sets the back color attribute of the Menu Strip.
        /// </summary>
        public Color MenuStripBackColor { get; set; }

        /// <summary>
        /// Gets and sets the text color attribute of the Menu Strip.
        /// </summary>
        public Color MenuStripTextColor { get; set; }

        /// <summary>
        /// Gets and sets the text color attribute of the Tool Strip.
        /// </summary>
        public Color ToolStripTextColor { get; set; }

        /// <summary>
        /// Gets and sets the back color attribute of the Tool Strip.
        /// </summary>
        public Color ToolStripBackColor { get; set; }

        /// <summary>
        /// Restores settings to the default values.
        /// </summary>
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
            ForeColor = Color.FromArgb(255, 0, 0, 0);
            BackColor = Color.White;
            CaretBlinking = true;
            SelectionColor = Color.Blue;
            MenuStripBackColor = SystemColors.Control;
            MenuStripTextColor = Color.Black;
            ToolStripTextColor = Color.Black;
            ToolStripBackColor = SystemColors.Control;
        }
    }
}
