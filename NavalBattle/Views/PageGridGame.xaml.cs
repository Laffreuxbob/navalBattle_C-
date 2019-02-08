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
        #endregion

        #region Functions
        #endregion

        #region Events
        private void generateAnotherPlacement_Click(object sender, RoutedEventArgs e)
        {
            // lancement d'une méthode générant un placement aléatoire
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
