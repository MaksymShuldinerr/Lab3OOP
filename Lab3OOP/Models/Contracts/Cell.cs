using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lode_Runner.Models
{
    [Serializable]
    public abstract class Cell
    {
        public abstract string CellName { get; }

        public abstract Control CellView { get; set; }

        public abstract string PathToImg { get; set; }
        public Cell Clone()
        {
            return (Cell)this.MemberwiseClone();
        }
    }
}