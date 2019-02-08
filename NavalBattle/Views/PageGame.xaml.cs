using NavalBattle.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour PageGame.xaml
    /// </summary>
    public partial class PageGame : Page
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        ObservableCollection<ListShip> viewPlayerShips = new ObservableCollection<ListShip>();
        ObservableCollection<ListShip> viewVersusShips = new ObservableCollection<ListShip>();
        #endregion

        #region Attributs
        private List<ListShip> placementShipsPlayer;
        private List<ListShip> placementShipsVersus;
        #endregion

        #region Properties

        public List<ListShip> PlacementShipsPlayer
        {
            get { return placementShipsPlayer; }
            set { placementShipsPlayer = value; }
        }

        public List<ListShip> PlacementShipsVersus
        {
            get { return placementShipsVersus; }
            set { placementShipsVersus = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PageGame()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void BindListviews()
        {
            foreach (var elem in this.PlacementShipsPlayer)
            {
                viewPlayerShips.Add(elem);
            }
            foreach (var elem in this.PlacementShipsVersus)
            {
                viewVersusShips.Add(elem);
            }

            this.playerShipsList.ItemsSource = viewPlayerShips;
            this.versusShipsList.ItemsSource = viewVersusShips;
        }
        #endregion

        #region Events
        #endregion

    }
}
