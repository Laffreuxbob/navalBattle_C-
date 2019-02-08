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
        // Needed variables in box selection functions
        private int selectedBoxIndex = -1;
        private Box shottedBox = new Box();
        private Random rnd = new Random();
        private Box tempoBox = new Box();

        #endregion

        #region Attributs
        private PlayerMode mode;

        #endregion

        #region Properties

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

        public PlayerAI(String name, PlayerType type, PlayerMode mode)
        {
            this.Name = name;
            this.Type = type;
            this.Mode = mode;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions

        // Automatic Box selection in list and game grid

        public override void Show()
        {
            base.Show();
            System.Console.WriteLine( this.Mode);
        }


        // Select a box according to the method of the PlayerAI.mode
        private Box SelectBox_byAi(List<Box> list, int width, int height, int step)
        {
            switch (this.Mode)
            {
                case PlayerMode.sandbox:
                    this.shottedBox = this.SelectBox_sandbox(list);
                    break;
                case PlayerMode.normal:
                    this.shottedBox =  this.SelectBox_normal(list, width, height, step);
                    break;
                case PlayerMode.evil:
                    this.shottedBox =  this.SelectBox_evil(list);
                    break;
                default:
                    return list[0];
            }
            return this.shottedBox;
        }

        // Fully random selection (sandbox ai)
        private Box SelectBox_sandbox(List<Box> list)
        {
            this.selectedBoxIndex = this.rnd.Next(1, list.Count + 1);
            return this.shottedBox = list[this.selectedBoxIndex];
            
        }

        // Controlled selection (if i touched ship, a can try randmonly side boxes)
        private Box SelectBox_normal(List<Box> list, int width, int height, int step)
        {
            
            if (this.shottedBox.State.Equals(StateBox.ship))
            {
                List<Box> targets = new List<Box>();

                int lastBox_X = this.shottedBox.XPos;
                int lastBox_Y = this.shottedBox.YPos;
                if (lastBox_X + 1 < width)
                {
                    targets.Add(list[this.selectedBoxIndex + 1]);
                }
                if (lastBox_X - 1 > 0)
                {
                    targets.Add(list[this.selectedBoxIndex - 1]);
                }
                if (lastBox_Y + 1 < height)
                {
                    targets.Add(list[this.selectedBoxIndex + step]);
                }
                if (lastBox_Y - 1 > 0)
                {
                    targets.Add(list[this.selectedBoxIndex - step]);
                }

                targets.Add(list[this.rnd.Next(list.Count)]);

                this.tempoBox =  targets[this.rnd.Next(targets.Count)];
            }
            else
            {
                this.tempoBox = this.SelectBox_sandbox(list);
            }

            return tempoBox;

        }

        // THIS IS EVIL AI, SHE KNOWS WHERE YOUR FLEET IS
        private Box SelectBox_evil(List<Box> list)
        {
            return list[this.selectedBoxIndex + 1];
        }
        #endregion

        #region Events
        #endregion


    }
}
