using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SınavOdev_0.Models
{
    public class Siparis : BaseEntity
    {
        public Siparis(string ad)
        {
            Ekstralar = new List<TatliVeIcecek>();
            
            Ad = ad;
           
        }
        public AnaYemek SecilenAnaYemek { get; set; }
        
        public List<TatliVeIcecek> Ekstralar{ get; set; }
        
      
        public void Tutar()
        {

          
                Fiyat = SecilenAnaYemek.Fiyat;
                      
            foreach (TatliVeIcecek item in Ekstralar)
            {
                Fiyat += item.Fiyat;
                
            }
           


        }
        public override string ToString()
        {           
            if (Ekstralar.Count<1)
            {            

                return $"{Ad} Numaralı masaya: {SecilenAnaYemek.Ad} Ana yemeği, Toplam:{Fiyat:C2}";           
            }
                                 
            string ekstra = null;
            foreach (TatliVeIcecek item in Ekstralar)
            {
                ekstra += $"{item.Ad},";
               
            }
            ekstra = ekstra.TrimEnd(',');
            return $"{Ad} Numaralı masaya: {SecilenAnaYemek.Ad} Ana yemeği ve yanında ekstra arasıcağı, içecek veya tatlı olarak {ekstra}, Toplam:{Fiyat:C2}";





        }


    }
    
}
