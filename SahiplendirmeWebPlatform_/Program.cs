using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SahiplendirmeWebPlatform_.Factories;

namespace SahiplendirmeWebPlatform_
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici hayvansahip = new Kullanici(new KediIlanıFactory());
            hayvansahip.IlanAciklamasi();
            Console.WriteLine($"İlan detayları: {hayvansahip.IlanAciklamasi()}");

            Kullanici adaysahip = new Kullanici(new KopekIlaniFactory());
            adaysahip.IlanAciklamasi();
            Console.WriteLine($"İlan detayları: {adaysahip.IlanAciklamasi()}");

            Console.ReadKey();
        }
    }
}
