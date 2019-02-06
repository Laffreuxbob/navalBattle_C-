using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    public class ListShip
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int quantity;
        private List<Ship> shipsList;
        private String chaine;
        #endregion

        #region Properties
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public List<Ship> ShipsList
        {
            get { return shipsList; }
            set { shipsList = value; }
        }

        public String Chaine
        {
            get { return chaine; }
            set { chaine = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ListShip()
        {

        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
