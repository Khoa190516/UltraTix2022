using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace UltraTix2022.API.UltraTix2022.Business.Services.SecretServices
{
    public static class KeyVaultServices
    {
        public static string GetConnectionString()
        {
            string conn = null;
            try
            {

                conn = "Server=tuongtlc.ddns.net,1433;Initial Catalog=UltraTixDB;Persist Security Info=True;User ID=sa;Password=Monk242!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return conn;
        }
        public static List<string> GetPaymentSecrets()
        {
            List<string> secrets = new List<string>();
            string partnerCode = "MOMOFH0Y20221003";
            string accessKey = "YAX7OxslhYkTXzbK";
            string secretKey = "jrQjul5BxdOMI7kHvIYAWCka1XIXXF7M";
            secrets.Add(partnerCode);
            secrets.Add(accessKey);
            secrets.Add(secretKey);
            return secrets;
        }
        public static string GetImgConnectionString()
        {
            return null;
        }
    }

}
