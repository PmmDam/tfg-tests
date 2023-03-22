using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFG_Test.Config.ConfigModels
{
    internal class EnvironmentManager
    {



        public EnvironmentManager()
        {
            DevelopmentEnvironment = new DataLayerModel();
            StagingEnvironment = new DataLayerModel();
            ProductionEnvironment = new DataLayerModel();
            NoneEnvironment = new DataLayerModel();

            _developmentEnvironment = new DataLayerModel();
            _stagingEnvironment = new DataLayerModel();
            _productionEnvironment = new DataLayerModel();
            _noneEnvironment = new DataLayerModel();

        }


        //Loads all the distincts environments configurations in memory
        #region All environments data in memory



        private DataLayerModel _developmentEnvironment { get; set; }
        public DataLayerModel DevelopmentEnvironment
        {
            get
            {
                return _developmentEnvironment;
            }
            set { _developmentEnvironment = value; }

        }
        private DataLayerModel _stagingEnvironment { get; set; }
        public DataLayerModel StagingEnvironment
        {
            get
            {
                return _stagingEnvironment;
            }
            set { this._stagingEnvironment = value; }

        }
        private DataLayerModel _productionEnvironment { get; set; }
        public DataLayerModel ProductionEnvironment
        {
            get { return this._productionEnvironment; }
            set { this._productionEnvironment = value; }

        }
        private DataLayerModel _noneEnvironment { get; set; }
        public DataLayerModel NoneEnvironment
        {
            get { return _noneEnvironment; }
            set { this._noneEnvironment = value; }

        }

        #endregion All environments data in memory


    }
}
