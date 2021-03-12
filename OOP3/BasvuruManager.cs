using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        // Dependency İnjection, Method İnjection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            // Başvuran Bilgilerini değerlendirme
            // 
            Console.Write("Başvurunuz kabul edildi-> ");  krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        // Müşteri Araba alacak. Tasit kredisi mi yoksa ihtiyaç kredisi mi seçmeli. 
        // Şimdi ön bilgilendirme içine bir veya birden fazla kredinin hesaplanması için parametre olarak krediler listesi göndermeliyiz.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, ILoggerService loggerService)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            loggerService.Log();
        }

    }
}
