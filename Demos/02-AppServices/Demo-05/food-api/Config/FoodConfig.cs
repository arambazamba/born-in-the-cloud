namespace FoodApp
{
    public class FoodConfig    {
        public AppConfig App { get; set; } 
        public Azure Azure { get; set; } 
        public FeatureManagement FeatureManagement { get; set; } 
        public Logging Logging { get; set; } 
    }

     public class AppConfig    {
        public bool AuthEnabled { get; set; } 
        public bool UseSQLite {get;set;}
        public bool UseAppConfig {get;set;}
        public bool UseKubernetes {get;set;}
        public ConnectionStrings ConnectionStrings { get; set; } 
    }
   
    public class Azure    {
        public string TenantId { get; set; } 
        public string ClientId { get; set; } 
        public string Instance {get;set;}
        public string cacheLocation { get; set; } 
        public string ApplicationInsights { get; set; } 
        public string AppConfiguration { get; set; } 
        public string KeyVault { get; set; } 
        public string EventGridKey { get; set; }
        public string EventGridEP { get; set; }
        public string SignalREndpoint { get; set; }
        public string SignalRConString { get; set; }
    }    

    public class ConnectionStrings    {
        public string SQLiteDBConnection { get; set; } 
        public string SQLServerConnection { get; set; } 
    }
        
    public class FeatureManagement{
        public bool Reactive { get; set; } 
        public bool ConverterApi { get; set; }
    }
    
    public class LogLevel    {
        public string Default { get; set; } 
        public string Microsoft { get; set; }     
    }

    public class Logging    {
        public LogLevel LogLevel { get; set; } 
    }
}