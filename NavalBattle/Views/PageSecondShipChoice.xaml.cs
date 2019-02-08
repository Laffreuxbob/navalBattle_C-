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
            ListShip listReturn = new ListShip();
            List<Ship> corvetteList = new List<Ship>();
            Ship corvette = new Ship();
            corvette.Name = "Corvette";
            corvette.State = true;

            // dimensions of the ship
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
                corvette.HeightNbBox = heightChoice;
            }
            corvette.PositionShip = new int[corvette.WidthNbBox, corvette.HeightNbBox];

            // number of ship
            int quantity = 0;
            if (this.secondShipQuantityTxt.Text == "" || this.secondShipQuantityTxt.Text == "0")
            {
                quantity = 1;
            }
            else
            {
                quantity = int.Parse(this.secondShipQuantityTxt.Text);
                if (quantity < 0)
                {
                    quantity = -quantity;
                }

                // gestion de la quantity a finalisée

            }

            listReturn.Quantity = quantity;
            listReturn.QuantityAlive = quantity;
            listReturn.DisplayString = listReturn.QuantityAlive + " " + corvette.Name + " alive";
            listReturn.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/corvette.jpg";
            for (int i = 0; i < quantity; i++)
            {
                corvetteList.Add(corvette);
            }
            listReturn.ShipsList = corvetteList;
            
            (this.Parent as MainWindow).PlacementPlayer.Add(listReturn);
            (this.Parent as MainWindow).PlacementVersus.Add(listReturn);

            (this.Parent as Window).Content = new PageThirdShipChoice();
        }
        #endregion

    }
}
