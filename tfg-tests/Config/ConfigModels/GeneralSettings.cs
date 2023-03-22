using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TFG_Test.Config.ConfigModels
{
    internal class GeneralSettings
    {
        public GeneralSettings()
        {
      

        }

        //Control of the logs in the application
        public bool LogEnabled { get; set; }

        //Lazy property which deserialize from the config json a complex type "Environments" 
        #region Selected environment
        //Lazy property of environments to see which environment is selected in the config file
        private Environments _environment { get; set; }

        [JsonIgnore]
        //Current SelectedEnvironment
        public Environments RawEnvironment { get => _environment; set { _environment = value; } }

        //This will be the propertie that will be serialize/deseriale into the AppConfig.json
        public string Environment
        {
            get { return _environment.ToString(); }
            set
            {
                Environments result;
                _environment = Enum.TryParse<Environments>(value, out result) ? result : Environments.None;
            }
        }
        #endregion Selected environment



    }
}
