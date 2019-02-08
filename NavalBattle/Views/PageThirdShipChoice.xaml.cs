using NavalBattle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NavalBattle.Views
{
    /// <summary>
    /// Logique d'interaction pour PageFirstShipChoice.xaml
    /// </summary>
    public partial class PageThirdShipChoice : Page
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
        public PageThirdShipChoice()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void thirdShipChoice_Click(object sender, RoutedEventArgs e)
        {
            Ship cruiser = new Ship();
            cruiser.Name = "Cruiser";
            cruiser.State = true;
            cruiser.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/cruiser.jpg";

            if (this.thirdShipWidthTxt.Text == "" || this.thirdShipWidthTxt.Text == "0")
            {
                cruiser.WidthNbBox = 4;
            }
            else
            {
                int widthChoice = int.Parse(this.thirdShipWidthTxt.Text);
                if (widthChoice < 0)
                {
                    widthChoice = -widthChoice;
                }
                cruiser.WidthNbBox = widthChoice;
            }

            if (this.thirdShipHeightTxt.Text == "" || this.thirdShipHeightTxt.Text == "0")
            {
                cruiser.HeightNbBox = 1;
            }
            else
            {
                int heightChoice = int.Parse(this.thirdShipHeightTxt.Text);
                if (heightChoice < 0)
                {
                    heightChoice = -heightChoice;
                }
                cruiser.WidthNbBox = heightChoice;
            }

            // gestion de la quantity
            // enregistrement du bateau dans une list epour affichage ?

            (this.Parent as Window).Content = new PageFourthShipChoice();
        }
        #endregion

    }
}
