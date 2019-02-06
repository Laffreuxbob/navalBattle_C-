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


namespace NavalBattle
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        List<Ship> list_ship_display;
        List<ListShip> placementPlayeur;
        List<ListShip> placementVersus;
        int quantity;
        List<Ship> maListe;
        #endregion

        #region Attributs
        #endregion

        #region Properties
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            createBox();

        }
        #endregion

        #region StaticFunctions
        
        #endregion

        #region Functions

        public void createBox()
        {
            System.Console.WriteLine("create box");
            Box box1 = new Box();
            box1.show();
            
        }
        #endregion

        #region Events
        #endregion

    }
}
