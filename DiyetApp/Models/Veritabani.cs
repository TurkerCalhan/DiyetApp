using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiyetApp.Models
{
    public static class Veritabani
    {
        private static List<Diyet> _liste;

        static Veritabani()
        {
            _liste = new List<Diyet>()
            {
                new Diyet(){Ogun="Kahvaltı",Aciklama="Peynir,Zeytin ve 1 Yumurta", Tarih=DateTime.Now.AddDays(-1),Tamamlandimi=true},
                new Diyet(){Ogun="Ara Öğün",Aciklama="1 Elma", Tarih=DateTime.Now.AddDays(-1),Tamamlandimi=true},
                new Diyet(){Ogun="Öğle Yemeği",Aciklama="Zeytinyağlı fasulye, Yoğurt ve Yağsız Salata", Tarih=DateTime.Now.AddDays(-1),Tamamlandimi=true},
                 new Diyet(){Ogun="Ara Öğün",Aciklama="1 Armut", Tarih=DateTime.Now.AddDays(-1),Tamamlandimi=true},
                  new Diyet(){Ogun="Akşam Yemeği",Aciklama="Çorba Tavuk ve Salata", Tarih=DateTime.Now.AddDays(-1),Tamamlandimi=true},


                  new Diyet(){Ogun="Kahvaltı",Aciklama="Peynir,Zeytin ve 1 Yumurta", Tarih=DateTime.Now.AddDays(0),Tamamlandimi=false},
                new Diyet(){Ogun="Ara Öğün",Aciklama="1 Elma", Tarih=DateTime.Now.AddDays(0),Tamamlandimi=false},
                new Diyet(){Ogun="Öğle Yemeği",Aciklama="Zeytinyağlı fasulye, Yoğurt ve Yağsız Salata", Tarih=DateTime.Now.AddDays(0),Tamamlandimi=false},
                 new Diyet(){Ogun="Ara Öğün",Aciklama="1 Armut", Tarih=DateTime.Now.AddDays(0),Tamamlandimi=false},
                  new Diyet(){Ogun="Akşam Yemeği",Aciklama="Çorba Tavuk ve Salata", Tarih=DateTime.Now.AddDays(0),Tamamlandimi=false},


                  new Diyet(){Ogun="Kahvaltı",Aciklama="Peynir,Zeytin ve 1 Yumurta", Tarih=DateTime.Now.AddDays(1),Tamamlandimi=false},
                new Diyet(){Ogun="Ara Öğün",Aciklama="1 Elma", Tarih=DateTime.Now.AddDays(1),Tamamlandimi=false},
                new Diyet(){Ogun="Öğle Yemeği",Aciklama="Zeytinyağlı fasulye, Yoğurt ve Yağsız Salata", Tarih=DateTime.Now.AddDays(1),Tamamlandimi=false},
                 new Diyet(){Ogun="Ara Öğün",Aciklama="1 Armut", Tarih=DateTime.Now.AddDays(1),Tamamlandimi=false},
                  new Diyet(){Ogun="Akşam Yemeği",Aciklama="Çorba Tavuk ve Salata", Tarih=DateTime.Now.AddDays(1),Tamamlandimi=false},
            };
        }

        public static List<Diyet> Liste
        {
            get { return _liste; }
        }

        public static void Ekle(Diyet diyet)
        {
            _liste.Add(diyet);
        }
    }
}