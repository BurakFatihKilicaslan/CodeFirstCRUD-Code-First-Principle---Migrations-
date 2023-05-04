using CodeFirstCRUD.Context;
using CodeFirstCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCRUD.Repositories
{
    internal class KisiRepository
    {
        public KisiRepository()
        {
            db = new KisiDB();
        }
        KisiDB db;

        public bool Add(Kisi kisi)
        {
            db.Kisiler.Add(kisi);
            return db.SaveChanges() > 0;
        }
        public bool Update(Kisi kisi)
        {
            db.Kisiler.Update(kisi);
            return db.SaveChanges() > 0;
        }
        public List<Kisi> GetAll()
        {
            List<Kisi>kisiler = db.Kisiler.ToList();
            return kisiler;
        }

        public Kisi GetByID(int id)
        {
            Kisi kisi = db.Kisiler.Find(id);
            return kisi;
        }
        public List<Kisi> GetByName(string name)
        {
            List<Kisi>kisiler = db.Kisiler.Where(x=>x.Ad.Contains(name) || x.Soyad.Contains(name)).ToList();
            return kisiler;
        }

    }
}
