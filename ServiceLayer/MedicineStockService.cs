using MedicineStockMicroService.Models;
using MedicineStockMicroService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.ServiceLayer
{
    public class MedicineStockService : IMedicineStockService
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly IMedicineStockRepository IMedicineStock;
        public MedicineStockService(IMedicineStockRepository IMedicineStock)
        {
            this.IMedicineStock = IMedicineStock;
        }
        public IEnumerable<MedicineStockDTO> GetMedicineStock()
        {


            log.Info("Medicine Stock requested");
            //var MedicineStockList = IMedicineStock.GetAll();
            //log.Info("Medicine Stock Retrieved");
            //return MedicineStockList.ToList();
            return IMedicineStock.GetAll();
        }

        
    }
}
