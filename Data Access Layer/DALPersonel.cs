using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace Data_Access_Layer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelList()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * from TBLBILGI", Connection.connect);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.PersonelId = int.Parse(dr["ID"].ToString());
                ent.PersonelAd = dr["AD"].ToString();
                ent.PersonelSoyad = dr["SOYAD"].ToString();
                ent.PersonelSehir = dr["SEHIR"].ToString();
                ent.PersonelGorev = dr["GOREV"].ToString();
                ent.PersonelMaas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int PersonelAdd(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,SEHIR,GOREV,MAAS) values (@p1,@p2,@p3,@p4,@p5)", Connection.connect);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.PersonelAd);
            komut2.Parameters.AddWithValue("@p2", p.PersonelSoyad);
            komut2.Parameters.AddWithValue("@p3", p.PersonelSehir);
            komut2.Parameters.AddWithValue("@p4", p.PersonelGorev);
            komut2.Parameters.AddWithValue("@p5", p.PersonelMaas);
            return komut2.ExecuteNonQuery();
        }
    
        public static bool PersonelDelete(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLBILGI where ID=@p1", Connection.connect);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
    
        public static bool PersonelUpdate(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update TBLBILGI set AD=@p1,SOYAD=@p2,SEHIR=@p3,GOREV=@p4,MAAS=@p5 where ID=@p6", Connection.connect);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.PersonelAd);
            komut4.Parameters.AddWithValue("@p2", ent.PersonelSoyad);
            komut4.Parameters.AddWithValue("@p3", ent.PersonelSehir);
            komut4.Parameters.AddWithValue("@p4", ent.PersonelGorev);
            komut4.Parameters.AddWithValue("@p5", ent.PersonelMaas);
            komut4.Parameters.AddWithValue("@p6", ent.PersonelId);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
