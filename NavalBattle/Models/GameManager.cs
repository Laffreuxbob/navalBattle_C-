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

        public void getShip(Box box)
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
        #endregion

        #region Events
        #endregion


    }
}
