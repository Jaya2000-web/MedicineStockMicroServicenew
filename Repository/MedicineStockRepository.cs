using MedicineStockMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStockMicroService.Repository
{
    public class MedicineStockRepository : IMedicineStockRepository
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly List<MedicineStockDTO> MedicineStockInformation = new List<MedicineStockDTO>() {
           new MedicineStockDTO
            {
                Name = "Dolo 650",
                ChemicalComposition = new List<string> { "Paracetamol", "Acetaminophen" },
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("31-12-2022"),
                NumberOfTabletsInStock = 300
            },
            new MedicineStockDTO
            {
                Name = "Orthoherb",
                ChemicalComposition = new List<string> { "Castor Plant", "Adulsa","Neem","Guggul" },
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("26-11-2021"),
                NumberOfTabletsInStock = 190
            },
            new MedicineStockDTO
            {
                Name = "Cholecalciferol",
                ChemicalComposition = new List<string> { "Ergocalciferol","Cholecalciferol","22-DiHydroergoCalciferol" },
                TargetAilment = "Orthopaedics",
                DateOfExpiry = DateTime.Parse("10-11-2023"),
                NumberOfTabletsInStock = 200
            },
            new MedicineStockDTO
            {
                Name = "Gaviscon",
                ChemicalComposition = new List<string> { "Magnesium","Oxide,Silicon","Sodium" },
                TargetAilment = "General",
                DateOfExpiry = DateTime.Parse("20-08-2022"),
                NumberOfTabletsInStock = 150
            },
            new MedicineStockDTO
            {
                Name = "Hilact",
                ChemicalComposition = new List<string> { "Pancreatin","Dimethicone","Polydimethylsiloxane" },
                TargetAilment = "Gynaecology",
                DateOfExpiry = DateTime.Parse("11-06-2024"),
                NumberOfTabletsInStock = 400
            },
            new MedicineStockDTO
            {

                 Name = "Cyclopam",
                 ChemicalComposition = new List<string> {"Dicyclomine","Hydrochloride","Paracetamol" },
                 TargetAilment = "Gynaecology",
                 DateOfExpiry = DateTime.Parse("02-11-2025"),
                 NumberOfTabletsInStock = 500
            }

        };

        public IEnumerable<MedicineStockDTO> GetAll()
        {

            var MedicineStocklist = from Medicine in MedicineStockInformation select Medicine;
            return MedicineStocklist.ToList();
           
        }
    }
}
