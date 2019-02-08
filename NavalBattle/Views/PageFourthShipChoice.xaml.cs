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
    public partial class PageFourthShipChoice : Page
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
        public PageFourthShipChoice()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void fourthShipChoice_Click(object sender, RoutedEventArgs e)
        {
            Ship corvette = new Ship();
            corvette.Name = "Aircraft carrier";
            corvette.State = true;
            corvette.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/aircraft_carrier.jpg";

            if (this.fourthShipWidthTxt.Text == "" || this.fourthShipWidthTxt.Text == "0")
            {
                corvette.WidthNbBox = 4;
            }
            else
            {
                int widthChoice = int.Parse(this.fourthShipWidthTxt.Text);
                if (widthChoice < 0)
                {
                    widthChoice = -widthChoice;
                }
                corvette.WidthNbBox = widthChoice;
            }

            if (this.fourthShipHeightTxt.Text == "" || this.fourthShipHeightTxt.Text == "0")
            {
                corvette.HeightNbBox = 2;
            }
            else
            {
                int heightChoice = int.Parse(this.fourthShipHeightTxt.Text);
                if (heightChoice < 0)
                {
                    heightChoice = -heightChoice;
                }
                corvette.WidthNbBox = heightChoice;
            }

            // gestion de la quantity
            // enregistrement du bateau dans une list epour affichage ?

            (this.Parent as Window).Content = new PageGridGame();
        }
        #endregion

    }
}
