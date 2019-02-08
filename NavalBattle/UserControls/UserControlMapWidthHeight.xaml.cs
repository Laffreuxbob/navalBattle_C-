using NavalBattle.Models;
using NavalBattle.Views;
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
using NavalBattle.Database;

namespace NavalBattle.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserControlMapWidthHeight.xaml
    /// </summary>
    public partial class UserControlMapWidthHeight : UserControl
    {

        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private int xWidth;
        public int YHeight;

        #endregion

        #region Properties

        public int XWidth
        {
            get { return xWidth; }
            set { xWidth = value; }
        }

        private int yHeight
        {
            get { return yHeight; }
            set { yHeight = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public UserControlMapWidthHeight()
        {
            InitializeComponent();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        private void parametersChoice_Click(object sender, RoutedEventArgs e)
        {
            System.Console.WriteLine("test");
            System.Console.WriteLine(this.Parent as Grid);
            System.Console.WriteLine(this.Content);
            //System.Console.WriteLine((this.Parent as Grid).Parent);
            System.Console.WriteLine(((this.Parent as Grid).Parent as PageGamePlayer).Parent as Window);
            (((this.Parent as Grid).Parent as PageGamePlayer).Parent as Window).Content = new PageFirstShipChoice();
            //((this.Parent as Grid).Parent as PageGamePlayer).Content = new PageFirstShipChoice();
            //this.Content = new PageFirstShipChoice();

            int size_width = sizetest(mapWidthTxt.Text);
            int size_height = sizetest(mapHeightTxt.Text);
            Game newGame = new Game(playerNameTxt.Text, size_width, size_height);

            newGame.ShowConsole();
            System.Console.WriteLine(new PageFirstShipChoice());
            System.Console.WriteLine(playerNameTxt);
        }

        private void SaveNewGameDB(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("SAVE DB");
            using (var db = new ApplicationDbContext())
            {
                db.SaveChanges();
                
            }

        }

        private int sizetest(String val)
        {
            if (val == "" || val == "0")
            {
                return 5; // default value
            }
            else
            {
                int size_width = int.Parse(val);

                return size_width = Math.Abs(size_width);
            }
        }




        #endregion


    }
}
