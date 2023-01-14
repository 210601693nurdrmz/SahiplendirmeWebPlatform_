using SahiplendirmeWebPlatform_.Abstract_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahiplendirmeWebPlatform_
{
    class Kullanici
    {

        private readonly Hayvan _hayvan;
        private readonly Sahip _sahip;

        public Kullanici(IlanFactory factory)
        {
            _hayvan = factory.CreateHayvan();
            _sahip = factory.CreateSahip();
        }

        public string IlanAciklamasi()
        {
            return $"İlan Sahibi:{_sahip.GetType().Name} " +
                $"ve Hayvan Türü: {_hayvan.GetType().Name} ";
        }
    }
}
