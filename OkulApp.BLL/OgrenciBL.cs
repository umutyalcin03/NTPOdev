using System;
using OkulApp.Model;
using System.Data.SqlClient;
using OkulApp.DAL;

namespace OkulApp.BLL
{
    public class OgrenciBL
    {
        private Helper hlp;
        public OgrenciBL()
        {
            hlp = Helper.GetInstance;
        }
        public bool OgrenciKaydet(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = {
                                  new SqlParameter("@Ad",ogr.Ad),
                                  new SqlParameter("@Soyad",ogr.Soyad),
                                  new SqlParameter("@Numara",ogr.Numara)
                            };

                
                return hlp.ExecuteNonQuery("Insert into tbl_Ogrenciler (Ad,Soyad,Numara) values (@Ad,@Soyad,@Numara)", p) > 0;
             

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
            }
        }
        public Ogrenci OgrenciBul(string numara)
        {
            
            try
            {
                SqlParameter[] p = { new SqlParameter("@Numara", numara) };
                var dr = hlp.ExecuteReader("Select OgrenciId,Ad,Soyad,Numara from tbl_Ogrenciler where Numara=@Numara", p);
                Ogrenci ogr = null;
                if (dr.Read())
                {
                    ogr = new Ogrenci();
                    ogr.Ad = dr["Ad"].ToString();
                    ogr.Soyad = dr["Soyad"].ToString();
                    ogr.Numara = dr["Numara"].ToString();
                    ogr.OgrenciId = Convert.ToInt32(dr["OgrenciId"]);
                }
                dr.Close();
                return ogr;

            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
            finally { hlp.Dispose(); }
        }
        public bool OgrenciSil(int id)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id", id) };
                
                return hlp.ExecuteNonQuery("Delete from tbl_Ogrenciler where OgrenciId=@Id", p) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool OgrenciGuncelle(Ogrenci ogr)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad",ogr.Ad),
            new SqlParameter("@Soyad",ogr.Soyad),
            new SqlParameter("@Numara",ogr.Numara),
            new SqlParameter("@OgrenciId",ogr.OgrenciId)};

                
                return hlp.ExecuteNonQuery("Update tbl_Ogrenciler set Ad=@Ad,Soyad=@Soyad,Numara=@Numara where OgrenciId=@OgrenciId", p) > 0;
            }
            catch (SqlException)
            {

                throw;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
