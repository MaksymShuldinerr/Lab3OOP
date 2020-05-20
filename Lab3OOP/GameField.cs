using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Cell = Lode_Runner.Models.Cell;
using Door = Lode_Runner.Models.Door;
using EmptyCell = Lode_Runner.Models.EmptyCell;
using FlyingPomagator = Lode_Runner.Models.FlyingPomagator;
using Ladder = Lode_Runner.Models.Ladder;
using Platform = Lode_Runner.Models.Platform;
using Player = Lode_Runner.Models.Player;
using PlayerOnLadderCell = Lode_Runner.Models.PlayerOnLadderCell;
using Wall = Lode_Runner.Models.Wall;


namespace Lode_Runner
{
    public class GameField
    {
        

        public static Cell[,] CreateField()
        {
            FlyingPomagator pomagator = new FlyingPomagator("Glider.png");
            EmptyCell emptyCell = new EmptyCell("Empty.png");
            Ladder ladder = new Ladder("Ladder.png");
            Platform platform = new Platform("Platform.png");
            Player player = Player.getInstance("Hero.png");
            PlayerOnLadderCell playerOnLadderCell = new PlayerOnLadderCell("HeroOnLadder.png");
            Wall wall = new Wall("Wall.PNG");
            Models.Coin Coin = new Models.Coin("Coin.png");
            Door door = new Door("OpenDoor.png");
            Cell[,] structuredCells = {
                {
                    wall, platform, emptyCell, Coin, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, Coin, ladder, player, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, wall
                    },
                    {
                    wall, platform, platform, platform, platform, platform, platform, platform, platform, platform,
                        platform, platform, ladder, platform, platform, platform, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, ladder, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, platform, platform, ladder, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, Coin, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, ladder, emptyCell, emptyCell,
                        platform, platform, platform, ladder, platform, platform, platform, platform, platform,
                        platform,
                        platform, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, ladder, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, ladder, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, ladder, emptyCell, emptyCell,
                        Coin,
                        emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, wall
                    },
                    {
                    wall, platform, platform, platform, platform, platform, platform, ladder, platform,
                        platform, platform, platform, platform, emptyCell, emptyCell, ladder, platform, platform,
                        platform,
                        platform, platform, ladder, platform, platform, platform, platform, platform, platform,
                        platform,
                        wall

                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, ladder, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, ladder, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, ladder, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, platform, platform, platform, platform, platform, platform, platform, platform,
                        platform, platform, platform, platform, platform, platform, platform, platform, platform,
                        platform,
                        platform, platform, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, Coin, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, ladder, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, ladder, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, platform, platform, platform,
                        platform, platform, platform, platform, platform, platform, platform, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, platform, platform, platform, platform, platform, platform,
                        platform, ladder, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, ladder, wall
                    },
                    {
                    wall, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, ladder, wall
                    },
                    {
                    door, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell, emptyCell,
                        emptyCell,
                        emptyCell, ladder, wall
                    },
                    {
                    wall, platform, platform, platform, platform, platform, platform, platform, platform,
                        platform, platform, platform, platform, platform, platform, platform, platform, platform,
                        platform,
                        platform, platform, platform, platform, platform, platform, platform, platform, platform,
                        ladder,
                        wall
                    },

                };
            return structuredCells;
        }

    }
}