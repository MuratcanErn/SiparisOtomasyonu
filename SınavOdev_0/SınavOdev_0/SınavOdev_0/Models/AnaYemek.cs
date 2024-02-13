using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOdev_0.Models
{
    public class AnaYemek:BaseEntity
    {
        public override string ToString()
        {
            return $"{Ad} => {Fiyat:C2}";
        }
    }
}
