using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProviderBUS
    {
        private static ProviderBUS instance = new();
        public static ProviderBUS Instance
        {
            get { return instance; }
        }

        public List<Provider> get()
        {
            return ProviderDAL.Instance.get();
        }
        public bool insert(Provider provider)
        {
            return ProviderDAL.Instance.insert(provider);
        }
        public bool update(Provider provider)
        {
            return ProviderDAL.Instance.update(provider);
        }
        public bool delete(Provider provider)
        {
            return ProviderDAL.Instance.delete(provider);
        }
    }
}
