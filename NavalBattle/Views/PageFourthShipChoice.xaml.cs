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
            /*foreach (var elem in )
            {
                // liste.Add(Type ship)
            }*/
            (this.Parent as Window).Content = new PageGridGame();
        }
        #endregion

    }
}
