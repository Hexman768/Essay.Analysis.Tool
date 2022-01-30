using FastColoredTextBoxNS;
using WeifenLuo.WinFormsUI.Docking;

namespace NotepadSharp.Windows
{
    public partial class DocMap : DockContent
    {
        public DocumentMap map
        {
            get
            {
                return documentMap1;
            }
        }

        /// <summary>
        /// Constructs the <see cref="DocMap"/>.
        /// </summary>
        public DocMap()
        {
            InitializeComponent();
        }
    }
}
