using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lode_Runner.Models
{
    [Serializable]
    public class Wall:Cell
    {
        private Control _cellView;

        public Wall(string value = null)
        {
            this.PathToImg = value;
        }
        public override string CellName { get => this.GetType().Name; }

        public override Control CellView
        {
            get
            {
                if ((object) _cellView == null)
                {
                    _cellView = new Control();
                }

                if ((object) _cellView.BackgroundImage == null)
                {
                    string path = Application.StartupPath + @"\Images\";
                    _cellView.BackgroundImage = Image.FromFile(path + PathToImg);
                }

                return _cellView;
            }
            set { _cellView = value; }
        }

        public override string PathToImg { get; set; }
    }
}