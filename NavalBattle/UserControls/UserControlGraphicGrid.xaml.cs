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

namespace NavalBattle.UserControls
{
    /// <summary>
    /// Logique d'interaction pour UserControlGraphicGrid.xaml
    /// </summary>
    public partial class UserControlGraphicGrid : UserControl
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
        public UserControlGraphicGrid()
        {
            InitializeComponent();
            this.draw();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        public void draw()
        {
            System.Console.WriteLine("DRAWING MAP start");
            for (int i = 0; i < 5; i++)
            {
                ColumnDefinition col1 = new ColumnDefinition();
                this.graphicGrid.ColumnDefinitions.Add(col1);
            }

            for (int i = 0; i < 5; i++)
            {
                RowDefinition row1 = new RowDefinition();
                this.graphicGrid.RowDefinitions.Add(row1);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    UserControlGraphicBox box = new UserControlGraphicBox();
                    box.X = i;
                    box.Y = j;

                    Grid.SetColumn(box, i);
                    Grid.SetRow(box, j);

                    this.graphicGrid.Children.Add(box);
                }
            }
            System.Console.WriteLine("DRAWING MAP end");

        }

        #endregion

        #region Events
        #endregion


    }
}
