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
        private int quantityAlive;
        private List<Ship> shipsList;
        private String displayString;
        private String picturePath;
        #endregion

        #region Properties
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int QuantityAlive
        {
            get { return quantityAlive; }
            set { quantityAlive = value; }
        }

        public List<Ship> ShipsList
        {
            get { return shipsList; }
            set { shipsList = value; }
        }

        public String DisplayString
        {
            get { return displayString; }
            set { displayString = value; }
        }

        public String PicturePath
        {
            get { return picturePath; }
            set { picturePath = value; }
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
        public static Boolean quantityTest(int quantity, int widthShip, int heightShip)
        {
            Boolean test_return = true;
            int sizeMap = GameManager.HEIGHT_GAME * GameManager.WIDTH_GAME;
            int sizeAllShip = quantity * widthShip * heightShip;

            if (sizeMap < sizeAllShip)
            {
                test_return = false;
            }

            return test_return;
        }
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion


    }
}
