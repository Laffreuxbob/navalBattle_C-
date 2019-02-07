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
        // Fully random selection (sandbox ai)
        private Box SelectBox_sandbox(List<Box> list)
        {
            this.selectedBoxIndex = this.rnd.Next(1, list.Count + 1);
            return this.shottedBox = list[this.selectedBoxIndex];
            
        }
            return this.shottedBox;
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
