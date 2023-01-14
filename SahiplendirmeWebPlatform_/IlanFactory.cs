using SahiplendirmeWebPlatform_.Abstract_elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahiplendirmeWebPlatform_
{
    abstract class IlanFactory
    {
        public abstract Hayvan CreateHayvan();
        public abstract Sahip CreateSahip();
    }
}
