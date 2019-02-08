using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class GameManager
    {

        #region StaticVariables
        #endregion

        #region Constants
        /*
         width 
         height 
         nbPlayer
         name1 & name2 
         => send by user
             */
        public const int WIDTH_GAME = 4;
        public const int HEIGHT_GAME = 5;
        public const int NB_PLAYER = 1;
        public const String NAME1 = "name1";
        public const String NAME2 = "name2";
        #endregion

        #region Variables
        public Player player1 = new Player();
        public Player player2 = new Player();


        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public GameManager()
        {
                
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void Play()
        {
            switch (NB_PLAYER)
            {
                case 1:
                    player1 = new Player(NAME1, PlayerType.human);
                    player2 = new PlayerAI(NAME2, PlayerType.ai, PlayerMode.sandbox);  // default mode, send by user
                    //System.Console.WriteLine((player2 as PlayerAI).Mode);
                    break;
                case 2:
                    player1 = new Player(NAME1, PlayerType.human);
                    player2 = new Player(NAME2, PlayerType.human);
                    break;
                default:
                    System.Console.WriteLine("Default case");
                    break;
            }

            player1.Show();
            player2.Show();

            Box shottedBox = new Box();

            var game = new Game("Name", 4, 4);
            var list = Box.GenerateList(game.Width, game.Height);
            Box.ShowListBoxConsole_1Dto2D(list, game.Height, false);
            // PLayer1 put ship in grid on mouse clic
            this.GetBoxInListOnClick(player1, 2, 4, list);
            Box.ShowListBoxConsole_1Dto2D(list, game.Height, true);
            // Player2 shot graphical Box(2.2)
            shottedBox = player2.SelectBox(list, 1, 1, game.Height);
            this.GetShot(shottedBox);
            this.UpdateList(list, shottedBox, game.Height);
            Box.ShowListBoxConsole_1Dto2D(list, game.Height, true);
            player2.CheckWin(list);

            // Player2 shot graphical Box(2.2)
            shottedBox = player2.SelectBox(list, 0, 2, game.Height);
            this.GetShot(shottedBox);
            this.UpdateList(list, shottedBox, game.Height);
            Box.ShowListBoxConsole_1Dto2D(list, game.Height, true);

            player2.CheckWin(list);




            GameManager.CreateGame();

            /*create 2 Players
             while player1.win OR player2.win
             */
            
        }

        private void createPlayer()
        {
            throw new NotImplementedException();
        }

        private static void CreateGame()
        {
            /* graphic map creation
             * create x * y button
             * add onclick / state change (empty, ship, miss, destroy)
             * update color
             */
        }


        #region Box
        public void createBox()
        {
            System.Console.WriteLine("create box");
            Box box1 = new Box();
            box1.ShowBoxConsole();
            Box.GenerateList(HEIGHT_GAME, WIDTH_GAME);
            

        }

        private void GetShot(Box box)
        {
            if (box.State.Equals(StateBox.empty))
            {
                box.State = StateBox.miss;
            }

            if (box.State.Equals(StateBox.ship))
            {
                box.State = StateBox.destroy;
            }

        }

        private void getShip(Box box)
        {
            if (box.State == StateBox.empty)
            {
                box.State = StateBox.ship;
            }
            else
            {
                System.Console.WriteLine("Cant add ship here !");
            }

        }

        public Box GetBoxInListOnClick(Player player, int x, int y, List<Box> list)
        {
            /* 
             * (x,y) coordonnées du clic
             * step = table width
             *  
             */
            int key = WIDTH_GAME * (x - 1) + y;
            Box returnBox = list[key];
            /* UPDATE BOX STATE */
            this.getShip(returnBox);

            list[key] = returnBox;

            return returnBox;

            
        }

        public List<Box> UpdateList(List<Box> list, Box box, int step)
        {
            list[box.XPos + box.YPos * step] = box;
            return list;
        }
        #endregion

        #region Ship

        private List<Ship> CreateShipList()
        {
            /*
             Data send by user (how many ships, nbBox and coords)
             */
            List<Ship> list = new List<Ship>();
            return list;
            
        }
        private Boolean CheckDestroyedShip(Ship ship)
        {
            /* If at least one box is state.ship, ship is not destroyed yet*/
            //return Array.Exists(ship.positionShip, box => box.State.Equals(StateBox.ship));
            return true;

        }
        #endregion

        #region Player

        private void ShotBox(Box box)
        {
            GetShot(box);
        }

        
        #endregion





        #endregion

        #region Events
        #endregion


    }
}
