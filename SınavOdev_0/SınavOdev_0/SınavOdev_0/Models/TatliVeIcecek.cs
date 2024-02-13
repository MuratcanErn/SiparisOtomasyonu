using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavOdev_0.Models
{
    public class TatliVeIcecek:BaseEntity
    {
        public TatliVeIcecek(string a ,decimal b)
        {
            Ad = a;
            Fiyat = b;

        }
        public override string ToString()
        {
            return $"{Ad}=>{Fiyat:C2}";
        }
    }
}
