using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class Box
    {

        #region StaticVariables
        #endregion

        #region Constants
        enum StateBox  {empty, ship, miss, destroy}
        #endregion

        #region Variables

        #endregion

        #region Attributs
        private int xPos;
        private int yPos;
        private StateBox state;

       


        #endregion

        #region Properties
        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        public int Ypos
        {
            get { return yPos; }
            set { yPos = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Box()
        {
            this.state = StateBox.empty;
        }

        public Box(int xPos, int yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.state = StateBox.empty;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void show()
        {
            System.Console.WriteLine("Box : x: " + this.xPos + ", y: " + this.yPos + ", state : " + this.state);
        }
        #endregion

        #region Events
        #endregion


    }
}
