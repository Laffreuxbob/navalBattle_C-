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

        #endregion

        #region Properties

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private PlayerType player;

        public PlayerType Type
        {
            get { return player; }
            set { player = value; }
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
        #endregion

        #region Events
        #endregion


    }
}
