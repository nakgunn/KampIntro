using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Böyle tanımlanırsa IKrediManager TasitKrediManager'in referansını tutar.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //Böyle tanımlanırsa kendi ref kendi tutar.
            TasitKrediManager tasitKrediManager1 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            ILoggerService smsLoggerService = new SmsLoggerService();
            //smsLoggerService.Log(); 

            ILoggerService databaseLoggerService = new DatabaseLoggerService();

           // List<ILoggerService> loggerServices = new List<ILoggerService>() { smsLoggerService, databaseLoggerService };
           
            BasvuruManager basvuruManager = new BasvuruManager(); // Dependency İnjection 
           

           // basvuruManager.BasvuruYap(konutKrediManager, loggerServices);
           
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, new EsnafKrediManager() };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler, smsLoggerService);

            MultiLoggerService multiLoggerService = new MultiLoggerService();
            multiLoggerService.Log(smsLoggerService, databaseLoggerService);
           


           

            
            
        }
    }
}
