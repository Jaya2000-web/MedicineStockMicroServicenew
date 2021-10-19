using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.ServiceLayer
{
    public interface IMedicineStockService
    {
        public IEnumerable<MedicineStockDTO> GetMedicineStock();
    }
}
