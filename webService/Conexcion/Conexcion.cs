namespace webService.Conexcion
{
    public class Conexcion
    {
        private string connectionString = string.Empty;
        public Conexcion()
        {
            var constrcutor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build ();
            connectionString = constrcutor.GetSection("MiConexionBD").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }

}
