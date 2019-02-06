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
         width & height send by user
             */
        int WIDTH_GAME = 4;
        int HEIGHT_GAME = 5;
        #endregion

        #region Variables
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
            createBox();
            var list = Box.GenerateList(WIDTH_GAME, HEIGHT_GAME);
            Box.ShowListBoxConsole(list);
            GameManager.CreateGame();
            
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

        public Box GetBoxInListOnClick(int x, int y, List<Box> list)
        {
            /* 
             * (x,y) coordonnées du clic
             * step = table width
             *  
             */
            int key = WIDTH_GAME * (x - 1) + y;
            return list[key];

            /* UPDATE BOX STATE */
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


       



        #endregion

        #region Events
        #endregion


    }
}
