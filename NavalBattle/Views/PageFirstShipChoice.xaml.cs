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
    public partial class PageFirstShipChoice : Page
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
        public PageFirstShipChoice()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void firstShipChoice_Click(object sender, RoutedEventArgs e)
        {
            ListShip listReturn = new ListShip();
            List<Ship> submarineList = new List<Ship>();
            Ship submarine = new Ship();
            submarine.Name = "Submarine";
            submarine.State = true;
            submarine.PicturePath = "pack://application:,,,/NavalBattle;component/Resources/submarine.jpg";

            // dimensions of the ship
            if (this.firstShipWidthTxt.Text == "" || this.firstShipWidthTxt.Text == "0")
            {
                submarine.WidthNbBox = 2;
            }
            else
            {
                int widthChoice = int.Parse(this.firstShipWidthTxt.Text);
                if (widthChoice < 0)
                {
                    widthChoice = -widthChoice;
                }
                submarine.WidthNbBox = widthChoice;
            }
            if (this.firstShipHeightTxt.Text == "" || this.firstShipHeightTxt.Text == "0")
            {
                submarine.HeightNbBox = 1;
            }
            else
            {
                int heightChoice = int.Parse(this.firstShipHeightTxt.Text);
                if (heightChoice < 0)
                {
                    heightChoice = -heightChoice;
                }
                submarine.HeightNbBox = heightChoice;
            }
            submarine.PositionShip = new int[submarine.WidthNbBox, submarine.HeightNbBox];

            // number of ship
            int quantity = 0;
            if (this.firstShipQuantityTxt.Text == "" || this.firstShipQuantityTxt.Text == "0")
            {
                quantity = 1;
            }
            else
            {
                quantity = int.Parse(this.firstShipQuantityTxt.Text);
                if (quantity < 0)
                {
                    quantity = -quantity;
                }

                // gestion de la quantity a finalisée

            }

            listReturn.Quantity = quantity;
            listReturn.QuantityAlive = quantity;
            listReturn.DisplayString = listReturn.QuantityAlive + " " + submarine.Name + " alive";
            for (int i = 0; i < quantity; i++)
            {
                submarineList.Add(submarine);
            }
            listReturn.ShipsList = submarineList;

            (this.Parent as MainWindow).PlacementPlayer = new List<ListShip>();
            (this.Parent as MainWindow).PlacementVersus = new List<ListShip>();

            (this.Parent as MainWindow).PlacementPlayer.Add(listReturn);
            (this.Parent as MainWindow).PlacementVersus.Add(listReturn);

            (this.Parent as Window).Content = new PageSecondShipChoice();
        }
        #endregion

    }
}
