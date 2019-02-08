using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle.Models
{
    class Game
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String name;
        private int height;
        private int width;
        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Game()
        {

        }
        public Game(System.Windows.Controls.TextBox playerNameTxt, System.Windows.Controls.TextBox mapWidthTxt)
        {

        }

        public Game(String name, int width, int height)
        {
            this.Name = name;
            this.Width = width;
            this.Height = height;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions

        public void ShowConsole()
        {
            System.Console.WriteLine("My game " + this.Name + " : " + this.Width + "*" + this.Height);
        }
        #endregion

        #region Events
        #endregion


    }
}
