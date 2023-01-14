using SahiplendirmeWebPlatform_.Abstract_elements;
using SahiplendirmeWebPlatform_.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahiplendirmeWebPlatform_.Factories
{
    class KusIlaniFactory : IlanFactory
    {
        public override Hayvan CreateHayvan()
        {
            return new Kus();
        }

        public override Sahip CreateSahip()
        {
            return new ElementSahip();
        }
    }
}
