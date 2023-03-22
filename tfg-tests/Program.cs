using Microsoft.Extensions.Configuration;
using TFGTest.Config.ConfigModels;

namespace tfg_tests
{
    internal class Program
    {
        //AppConfig.json file path
        private static string _appConfigFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "AppConfig.json");

        //Environemtns json paths
        private static string _environmentsFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "Environments", "AppConfig_Environments.json");

        //private static string _devEnviroFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "Environments", "AppConfig_DevelopmentEnviro.json");
        //private static string _stagEnviroFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "Environments", "AppConfig_StagingEnviro.json");
        //private static string _prodEnviroFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "Environments", "AppConfig_ProductionEnviro.json");
        //private static string _noneEnviroFilePath = Path.Combine(Environment.CurrentDirectory, "Config", "Data", "Environments", "AppConfig_NoneEnviro.json");

        //all config files 
        private static string[] _configFiles = new string[] { _appConfigFilePath, _environmentsFilePath /*, _devEnviroFilePath, _stagEnviroFilePath,_prodEnviroFilePath, _noneEnviroFilePath */};


        static void Main(string[] args)
        {





            //create the config builder that will deserialize our json files
            ConfigurationBuilder configBuilder = new ConfigurationBuilder();
            configBuilder.SetBasePath(Directory.GetCurrentDirectory());

            foreach (var file in _configFiles)
            {
                Console.WriteLine(File.ReadAllText(file));
                configBuilder.AddJsonFile(file, false, true);
            }

            //configBuilder.AddCommandLine(args);

            IConfigurationRoot configRoot = configBuilder.Build();

            AppConfig config = configRoot.Get<AppConfig>();
            Console.WriteLine(config);



            // Comprobaciones para ver si el sistema que he montado de getters y setters funciona correctamente

            //ConfigModel config = configRoot.Get<ConfigModel>();

            //string currentUser = config.GeneralSettings.TestUser.ToString();
            //string currentEnviorment = config.GeneralSettings.SelectedEnvironment.ToString();
            //string EnvironmentAcces = config.ActualEnvironment.EnvironmentName;

            //Console.WriteLine($" El Usuario es: {currentUser} y el SelectedEnvironment: {currentEnviorment} deberia ser igual a: {EnvironmentAcces}");


            // Esto deberia dar nullo y efectivamente lo da
            // string wrongEnviorment = config.StagingEnvironment.ToString();
        }
    }
}