using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Lode_Runner.Models
{
    public class Player : Cell
    {
        private static Player _player;

        private bool isFlyingNotByBreak { get; set; }
        public List<Item> items { get; set; }
        public int X { get; set; }
        public int Y { get; set; } //Не декартовые координаты

        public bool isCoinTaken { get; set; }
        public bool isInFly { get; set; }
        public bool isPlayerKilled { get; set; }

        public bool isPlayerAbleToFinish { get; set; }


        private Player(string imgpath)
        {
            this.PathToImg = imgpath;
        }

        public static Player getInstance(string imgpath)
        {
            if (_player != null)
            {
                return _player;
            }

            _player = new Player(imgpath) {items = new List<Item>() { }};
            return _player;
        }

        private Control _cellView;

        public override string CellName
        {
            get => this.GetType().Name;
        }

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