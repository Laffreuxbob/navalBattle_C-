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

        public StateBox State
        {
            get { return state; }
            set { state = value; }
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

        public static List<List<Box>> GenerateList2D(int width, int height)
        {
            System.Console.WriteLine("Generate list 2D");
            List<List<Box>> listBoxGame = new List<List<Box>>();
            for (int i = 1; i <= width; i++)
            {
                List<Box> rowBox = new List<Box>();
                String rowConsole = "";
                for (int j = 1; j <= height; j++)
                {
                    Box addBox = new Box(i, j);
                    rowConsole += addBox.StringBox();
                    rowBox.Add(addBox);
                }
                System.Console.WriteLine(rowConsole);
                listBoxGame.Add(rowBox);
            }
            return listBoxGame;
        }

        public static List<Box> GenerateList(int width, int height)
        {
            List<Box> listBoxGame = new List<Box>();

            for(int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= height; j++)
                {
                    listBoxGame.Add(new Box(i, j));
                }
            }
            return listBoxGame;
        }

        

        #endregion

        #region Functions
        public void ShowBoxConsole() => System.Console.WriteLine("Box : x: " + this.xPos + ", y: " + this.yPos + ", state : " + this.state);
        public String StringBox()
        {
            return ("[" + this.xPos + "-" + this.yPos + "-" + this.state + "] ");
        }

        public static void ShowListBoxConsole(List<Box> list)
        {
            foreach(Box box in list)
            {
                System.Console.WriteLine(box.StringBox());
            }
        }

        
        #endregion

        #region Events
        #endregion


    }
}
