using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImportInvoiceDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static ImportInvoiceDAL instance = new();
        public static ImportInvoiceDAL Instance
        {
            get { return instance; }
        }
        public List<ImportInvoice> get()
        {
            List<ImportInvoice> list = new List<ImportInvoice>();
            conn.Open();
            using (var cmd = new SqlCommand("GetImportInvoiceData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ImportInvoice importInvoice = new ImportInvoice();
                    importInvoice.ID = reader.GetInt32("invoice_id");
                    importInvoice.WarehouseKeeper.ID = reader.GetInt32("staff_id");
                    importInvoice.Provider.ID = reader.GetInt32("provider_id");
                    importInvoice.ImportDate = reader.GetDateTime("import_time");
                    importInvoice.Note = reader.GetString("note");
                    list.Add(importInvoice);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertImportInvoiceData", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = importInvoice.WarehouseKeeper.ID;
                    cmd.Parameters.Add("@provider_id", SqlDbType.Int).Value = importInvoice.Provider.ID;
                    cmd.Parameters.Add("@import_time", SqlDbType.DateTime).Value = DateTime.Now;
                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new SqlCommand("getNewImportInvoiceID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    DbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        importInvoice.ID = reader.GetInt32("max_id");
                    }
                    reader.Close();
                }
                foreach (var item in importInvoice.Laptops)
                {
                    insertDetail(item,importInvoice);
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateImportInvoice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@invoice_id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.Parameters.Add("@staff_id", SqlDbType.Int).Value = importInvoice.WarehouseKeeper.ID;
                    cmd.Parameters.Add("@provider_id", SqlDbType.Int).Value = importInvoice.Provider.ID;
                    cmd.Parameters.Add("@note", SqlDbType.VarChar).Value = importInvoice.Note;
                    cmd.ExecuteNonQuery();
                }
                
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("DeleteImportInvoice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@invoice_id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void insertDetail(Laptop laptop, ImportInvoice importInvoice)
        {
            try
            {
                using (var cmd = new SqlCommand("InsertInvoiceDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@invoice_id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.Parameters.Add("@quantity_import", SqlDbType.Int).Value = laptop.QuantityImport;
                    cmd.Parameters.Add("@laptop_id", SqlDbType.Int).Value = laptop.ID;
                    cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = laptop.ImportPrice;
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
               
            }
        }
    }
}