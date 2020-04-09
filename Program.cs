using System;
using System.Configuration;

namespace AO_DataBackup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started Backup Program");
            var connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            var backupFolder = ConfigurationManager.AppSettings["BackupFolder"];
            try
            {
                BackupService bk = new BackupService(connectionString, backupFolder);
                bk.BackupAllUserDatabases();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
