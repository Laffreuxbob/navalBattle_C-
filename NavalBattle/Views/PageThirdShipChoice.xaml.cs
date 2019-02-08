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
            ListShip listReturn = new ListShip();
            List<Ship> cruiserList = new List<Ship>();
            Ship cruiser = new Ship();
            cruiser.Name = "Cruiser";
            cruiser.State = true;

            // dimensions of the ship
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
                cruiser.HeightNbBox = heightChoice;
            }
            cruiser.PositionShip = new int[cruiser.WidthNbBox, cruiser.HeightNbBox];

            // number of ship
            int quantity = 0;
            if (this.thirdShipQuantityTxt.Text == "" || this.thirdShipQuantityTxt.Text == "0")
            {
                quantity = 1;
            }
            else
            {
                quantity = int.Parse(this.thirdShipQuantityTxt.Text);
                if (quantity < 0)
                {
                    quantity = -quantity;
                }

                // gestion de la quantity a finalisée

            }

            listReturn.Quantity = quantity;
            listReturn.QuantityAlive = quantity;
            listReturn.DisplayString = listReturn.QuantityAlive + " " + cruiser.Name + " alive";
            listReturn.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/cruiser.jpg";
            for (int i = 0; i < quantity; i++)
            {
                cruiserList.Add(cruiser);
            }
            listReturn.ShipsList = cruiserList;

            (this.Parent as MainWindow).PlacementPlayer.Add(listReturn);
            (this.Parent as MainWindow).PlacementVersus.Add(listReturn);

            (this.Parent as Window).Content = new PageFourthShipChoice();
        }
        #endregion

    }
}
