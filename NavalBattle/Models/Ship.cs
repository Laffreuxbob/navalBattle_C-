using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class Ship
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id; // id of the ship
        private String name; // name of the ship
        private int nbBox; // size of the ship
        private Boolean state; // the ship is still alive ?
        private int[][] positionShip; // position X,Y of each case of the ship
        private String picturePath; // path for the picture of the ship
        #endregion

        #region Properties
        [Key]
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NbBox
        {
            get { return nbBox; }
            set { nbBox = value; }
        }

        public Boolean State
        {
            get { return state; }
            set { state = value; }
        }

        public int[][] PositionShip
        {
            get { return positionShip; }
            set { positionShip = value; }
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
        public Ship()
        {

        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void ShipCreation()
        {
            // first ship
            Ship shipA = new Ship();
            shipA.Id = 1;
            shipA.Name = "Submarine";
            shipA.NbBox = 2;
            shipA.State = true;
            shipA.PicturePath = "";
            Ship shipB = new Ship();
            shipB.Id = 2;
            shipB.Name = "Corvette";
            shipB.NbBox = 3;
            shipB.State = true;
            shipB.PicturePath = "";
            Ship shipC = new Ship();
            shipC.Id = 3;
            shipC.Name = "Cruiser";
            shipC.NbBox = 4;
            shipC.State = true;
            shipC.PicturePath = "";
            Ship shipD = new Ship();
            shipD.Id = 4;
            shipD.Name = "Aircraft carrier";
            shipD.NbBox = 5;
            shipD.State = true;
            shipD.PicturePath = "";
        }
        #endregion

        #region Events
        #endregion


    }
}
