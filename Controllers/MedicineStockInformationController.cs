using MedicineStockMicroService.ServiceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "Log4net.config", Watch = true)]
namespace MedicineStockMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockInformationController : Controller
    {
        public static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //creating service layer interface object
        private  readonly IMedicineStockService iMedicineStock;
        public MedicineStockInformationController(IMedicineStockService iMedicineStock)
        {
            this.iMedicineStock = iMedicineStock;
        }


        //hhtp get method to get all the medicine stock list 
        [HttpGet]
        public IActionResult Get()
        {
            
            try
            {
                var res = iMedicineStock.GetMedicineStock();
                
                if (res != null)
                {
                    
                    log.Info("Medicine Stock Retrieved Successfully");
                    return Ok(res.ToList());
                }
                log.Info("No details retrieved");
                return Content("No such details found please try again.");
            }
            catch (Exception e)
            {
                log.Error("Excpetion:" + e.Message + " has occurred while trying to retrieve stock info.");
                return Content("The following exception has occurred while retreving the stock." + e.Message + " Please try again");
            }
        }
    }
}
