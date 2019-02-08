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
    /// Logique d'interaction pour PageGridGame.xaml
    /// </summary>
    public partial class PageGridGame : Page
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        ObservableCollection<ListShip> viewPlayerShips = new ObservableCollection<ListShip>();
        #endregion

        #region Attributs
        private List<ListShip> placementShipsPlayer;
        #endregion

        #region Properties

        public List<ListShip> PlacementShipsPlayer
        {
            get { return placementShipsPlayer; }
            set { placementShipsPlayer = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PageGridGame()
        {
            InitializeComponent();
            this.DataContext = this;
            //this.PlacementShipsPlayer = (this.Parent as MainWindow).PlacementPlayer;
            //BindListviews();
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

            this.playerShipList.ItemsSource = viewPlayerShips;
        }

        public List<ListShip> placementAleatoire(List<ListShip> contentPlacement)
        {
            List<ListShip> returnTable = new List<ListShip>();
            //returnTable.
            Random rnd = new Random();
            int heightMap = GameManager.HEIGHT_GAME;
            int widthMap = GameManager.WIDTH_GAME;
            int pointOrigin = 0;

            foreach (var item in contentPlacement)
            {
                foreach (var elem in item.ShipsList)
                {
                    int xOrigin = rnd.Next(heightMap);
                    int yOrigin = rnd.Next(widthMap);


                }
            }

            return returnTable;
        }
        #endregion

        #region Events
        private void generateAnotherPlacement_Click(object sender, RoutedEventArgs e)
        {
            placementAleatoire((this.Parent as MainWindow).PlacementPlayer);
        }

        private void placementChoice_Click(object sender, RoutedEventArgs e)
        {
            // sauvegarde bdd ici

            PageGame game = new PageGame();
            game.PlacementShipsPlayer = (this.Parent as MainWindow).PlacementPlayer;
            game.PlacementShipsVersus = (this.Parent as MainWindow).PlacementVersus;
            game.BindListviews();

            (this.Parent as Window).Content = game;
        }

        private void returnChoice_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Window).Content = new PageGamePlayer();
        }
        #endregion
        
    }
}
