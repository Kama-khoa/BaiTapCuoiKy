using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportInvoiceBUS
    {
        private static ImportInvoiceBUS instance = new();
        public static ImportInvoiceBUS Instance
        {
            get { return instance; }
        }
        public List<ImportInvoice> get()
        {
            return ImportInvoiceDAL.Instance.get();
        }
        public bool insert(ImportInvoice importInvoice)
        {
            return ImportInvoiceDAL.Instance.insert(importInvoice);
        }
        public bool update(ImportInvoice importInvoice)
        {
            return ImportInvoiceDAL.Instance.update(importInvoice);
        }
        public bool delete(ImportInvoice importInvoice)
        {
            return ImportInvoiceDAL.Instance.delete(importInvoice);
        }
    }
}
