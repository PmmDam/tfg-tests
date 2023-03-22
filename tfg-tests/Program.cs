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

        //all config files 
        private static string[] _configFiles = new string[] { _appConfigFilePath, _environmentsFilePath};


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


        }
    }
}