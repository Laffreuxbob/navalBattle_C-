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

        private Boolean CheckDestroyedShip(Ship ship)
        {
            /* If at least one box is state.ship, ship is not destroyed yet*/
            return Array.Exists(ship.positionShip, box => box.State.Equals(StateBox.ship));
            
        }



        #endregion

        #region Events
        #endregion


    }
}
