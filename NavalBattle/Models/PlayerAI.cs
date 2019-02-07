using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class PlayerAI : Player
    {

        #region StaticVariables
        #endregion

        #region Constants

        #endregion

        #region Variables
        private int selectedBoxIndex = new int();
        private Box shottedBox = new Box();
        private Random rnd = new Random();
        #endregion

        #region Attributs
        #endregion

        #region Properties
        private PlayerMode mode;

        public PlayerMode Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PlayerAI()
        {

        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private Box SelectBox(List<Box> list)
        {
            switch (this.Mode)
            {
                case PlayerMode.sandbox:
                    
                    this.selectedBoxIndex = this.rnd.Next(1, list.Count + 1);
                    this.shottedBox = list[this.selectedBoxIndex];
                    break;
                case PlayerMode.normal:
                    this.selectedBoxIndex = this.rnd.Next(1, list.Count + 1);
                    this.shottedBox = list[this.selectedBoxIndex];
                    break;
                case PlayerMode.evil:
                    this.selectedBoxIndex = this.rnd.Next(1, list.Count + 1);
                    this.shottedBox = list[this.selectedBoxIndex];
                    break;
                default:
                    return list[0];

            }
            return this.shottedBox;


        }
        #endregion

        #region Events
        #endregion


    }
}
