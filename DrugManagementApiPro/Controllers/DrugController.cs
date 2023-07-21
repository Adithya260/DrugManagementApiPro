using DrugManagement.Data.Entities;
using DrugManagement.Data.Repository;
using DrugManagementApiPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace DrugManagementApiPro.Controllers
{
    public class DrugController : Controller
    {
        /* public IActionResult Index()
         {
             return View();
         }*/
        public DrugRepository DrugRepository { get; set; }
        public DrugController()
        {
            this.DrugRepository = new DrugRepository();
        }
        [HttpGet("GetAllDrugs")]
        public List<TblDrug>GetAllDrugs() 
        {
            return this.DrugRepository.GetAllDrugs();
        }
        [HttpPost("AddDrug")]
        public void AddDrug(TblDrug drug)
        {
            this.DrugRepository.AddDrug(drug);
           
        }
        [HttpDelete("DeleteDrug")]
        public void DeleteDrug(int id)
        {
            this.DrugRepository.DeleteDrug(id); 

            

        }
    }
}
