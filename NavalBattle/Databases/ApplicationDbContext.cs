using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavalBattle.Models;

namespace NavalBattle.Databases
{
    public class ApplicationDbContext : DbContext
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
        public ApplicationDbContext()
        {
            DevResetDatabase();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        private void DevResetDatabase()
        {
            if (!this.Database.CompatibleWithModel(false))
            {
                this.Database.Delete();
                this.Database.Create();
            }
        }
        #endregion

        #region Events
        #endregion


    }
}
