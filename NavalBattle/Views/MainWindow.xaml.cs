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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        #region StaticVariables
        #endregion

        #region Constants
        
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private List<ListShip> placementPlayer;
        private List<ListShip> placementVersus;
        private ListShip viewPlacementPlayer;
        private ListShip viewPlacementVersus;
        #endregion

        #region Properties

        public List<ListShip> PlacementPlayer
        {
            get { return placementPlayer; }
            set { placementPlayer = value; }
        }

        public List<ListShip> PlacementVersus
        {
            get { return placementVersus; }
            set { placementVersus = value; }
        }

        public ListShip ViewPlacementPlayer
        {
            get { return viewPlacementPlayer; }
            set { viewPlacementPlayer = value; }
        }

        public ListShip ViewPlacementVersus
        {
            get { return viewPlacementVersus; }
            set { viewPlacementVersus = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new PageGamePlayer();

            GameManager mainGame = new GameManager();
            mainGame.Play();
            createBox();
            /*
            placementPlayeur.Clear();
            placementVersus.Clear();
            foreach (Ship item in list_ship_display)
            {
                // define quantity, name and dimension for each ship

                // affichage similaire pour chaque navire -> template
                // attente de l'évènement (click) qui fait passer a la suite
                quantity = 1;
                ListShip element = new ListShip();
                element.Quantity = quantity;
                element.Chaine = quantity + " " + item.Name + " restant(s).";

                maListe.Clear();
                for (int i = 0; i < quantity; i++)
                {
                    Ship boat = new Ship(item.Name, item.WidthNbBox, item.HeightNbBox, item.State, item.PicturePath);
                    maListe.Add(boat);
                }
                element.ShipsList = maListe;

                placementPlayeur.Add(element);
                placementVersus.Add(element);
            }*/
            // define position for each ship of the playeur
            // define position for each ship of the IA
            /* begin to delete when position is operationnal */
            /* end to delete when position is operationnal */
            //display_ship_list();
        }
        #endregion

        #region StaticFunctions
        
        #endregion

        #region Functions
        
        public void createBox()
        {
            System.Console.WriteLine("create box");
            Box box1 = new Box();
            box1.ShowBoxConsole();
            Box.GenerateList(GameManager.HEIGHT_GAME, GameManager.WIDTH_GAME);
            
        }

        public void display_ship_list()
        {
            String elem_display_playeur = "";
            String elem_display_versus = "";
        }
        #endregion

        #region Events
        #endregion

    }
}
