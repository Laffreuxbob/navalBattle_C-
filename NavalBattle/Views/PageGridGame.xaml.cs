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
    /// Logique d'interaction pour PageGridGame.xaml
    /// </summary>
    public partial class PageGridGame : Page
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
        public PageGridGame()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        public static List<ListShip> placementAleatoire(List<ListShip> contentPlacement)
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

        #region Functions
        #endregion

        #region Events
        private void generateAnotherPlacement_Click(object sender, RoutedEventArgs e)
        {
            PageGridGame.placementAleatoire((this.Parent as MainWindow).PlacementPlayer);
        }

        private void placementChoice_Click(object sender, RoutedEventArgs e)
        {
            // sauvegarde bdd ici

            (this.Parent as Window).Content = new PageGame();
        }

        private void returnChoice_Click(object sender, RoutedEventArgs e)
        {
            (this.Parent as Window).Content = new PageGamePlayer();
        }
        #endregion
        
    }
}
