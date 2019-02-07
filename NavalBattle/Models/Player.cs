using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class Player
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String name;
        private PlayerType player;
        private Boolean winner = false;
        private Boolean lose = false;
        private List<Box> list;

        
        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }


        public PlayerType Type
        {
            get { return player; }
            set { player = value; }
        }


        public Boolean Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public Boolean Lose
        {
            get { return lose; }
            set { lose = value; }
        }

        public List<Box> List
        {
            get { return list; }
            set { list = value; }
        }



        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player()
        {

        }

        public Player(String name, PlayerType type)
        {
            this.Name = name != "" ? name : "default_name";
            this.Type = type;
        }
        #endregion

        #region StaticFunctions

        public static Player CreatePlayer(String name, PlayerType type)
        {
            return new Player(name, type);
        }
        #endregion

        #region Functions

        public virtual void Show()
        {
            System.Console.WriteLine(this.Name + " - " + this.Type + " - " + this.Winner);
        }
        #endregion

        //
        public Boolean CheckWin(List<Box> list)
        {
            foreach(Box box in this.list)
            {
                if (box.State.Equals(StateBox.ship))
                {
                    this.Lose = false;
                    break;
                }
                this.lose = true;
            }
            return this.lose;

        }

        #region Events
        #endregion


    }
}
