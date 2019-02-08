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
    public partial class PageSecondShipChoice : Page
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
        public PageSecondShipChoice()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void secondShipChoice_Click(object sender, RoutedEventArgs e)
        {
            Ship corvette = new Ship();
            corvette.Name = "Corvette";
            corvette.State = true;
            corvette.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/corvette.jpg";

            if (this.secondShipWidthTxt.Text == "" || this.secondShipWidthTxt.Text == "0")
            {
                corvette.WidthNbBox = 3;
            }
            else
            {
                int widthChoice = int.Parse(this.secondShipWidthTxt.Text);
                if (widthChoice < 0)
                {
                    widthChoice = -widthChoice;
                }
                corvette.WidthNbBox = widthChoice;
            }

            if (this.secondShipHeightTxt.Text == "" || this.secondShipHeightTxt.Text == "0")
            {
                corvette.HeightNbBox = 1;
            }
            else
            {
                int heightChoice = int.Parse(this.secondShipHeightTxt.Text);
                if (heightChoice < 0)
                {
                    heightChoice = -heightChoice;
                }
                corvette.WidthNbBox = heightChoice;
            }

            // gestion de la quantity
            // enregistrement du bateau dans une list epour affichage ?

            (this.Parent as Window).Content = new PageThirdShipChoice();
        }
        #endregion

    }
}
