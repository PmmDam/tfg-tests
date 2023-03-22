using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TFG_Test.Config.ConfigModels;

namespace TFGTest.Config.ConfigModels
{
    internal class AppConfig
    {
        //Properties

        public GeneralSettings GeneralSettings { get; set; }

        public EnvironmentManager EnvironmentManager { get; set; }


        private DataLayerModel _selectedEnvironment
        {
            get
            {
                switch (GeneralSettings.RawEnvironment)
                {
                    case Environments.Development:
                        return EnvironmentManager.DevelopmentEnvironment;
                        
                    case Environments.Staging:
                        return EnvironmentManager.StagingEnvironment;
                        
                    case Environments.Production:
                        return EnvironmentManager.ProductionEnvironment;
                        
                    case Environments.None:
                        return EnvironmentManager.NoneEnvironment;
                    default:
                        throw new NotImplementedException();

                }
            }
            set { }
        }


        private DataLayerModel SelectedEnvironment { get { return _selectedEnvironment; } set { } }


        public AppConfig()
        {
            GeneralSettings = new GeneralSettings();
            EnvironmentManager = new EnvironmentManager();
            SelectedEnvironment = new DataLayerModel();
        }


        //Methods
        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();



            sb.AppendLine("-------------------------------------------------");
            sb.AppendLine("This is the actual configuration of the project");
            sb.AppendLine("-------------------------------------------------");

            sb.AppendLine();
            
            sb.Append("Is Log enabled:");
            sb.Append(GeneralSettings.LogEnabled);

            sb.AppendLine();

            sb.Append("Selected environment:");
            sb.Append(GeneralSettings.Environment);

            sb.AppendLine();

            sb.Append("Environment data:");
            sb.Append(SelectedEnvironment.ToString());

            sb.AppendLine();
            sb.AppendLine("**********************");

            return sb.ToString();
        }
    }



}
