using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bussiness Logic Layer
namespace BLL
{
    public class OgrenciBL
    {

        public bool Kaydet(Ogrenci ogr)
        {
            if (ogr == null)
            {
                throw new NullReferenceException("Ogrenci nesnesi null geldi");
            }

            try
            {
                Helper hlp = new Helper();
                int sonuc = hlp.ExecuteNonQuery($"Insert into tblOgrenciler (Ad,Soyad,Numara,SinifId) values ('{ogr.Ad}','{ogr.Soyad}','{ogr.Numara}',{ogr.Sinifid})");
                return sonuc > 0;
            }
            catch (Exception)
            {
                throw;
            }

        }

        bool Guncelle(Ogrenci ogr)
        {
            return true;
        }

        bool OgrenciSil(int ogrenciid)
        {
            return true;
        }

        Ogrenci OgrenciGetir(int ogrenciid)
        {
            return null;
        }

        List<Ogrenci> OgrenciListesi()
        {
            return null;
        }
    }
}
