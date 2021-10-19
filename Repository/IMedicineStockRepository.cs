using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.Repository
{
    public interface IMedicineStockRepository
    {
        public IEnumerable<MedicineStockDTO> GetAll();
    }
}
