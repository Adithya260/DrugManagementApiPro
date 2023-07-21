using DrugManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugManagement.Data.Repository
{
    public  class DrugRepository
    {
        DmaContext dmaContext { get; set; } 
        public DrugRepository() 
        {
            this.dmaContext = new DmaContext();
            
        }
        public List<TblDrug> GetAllDrugs()
        {
            return this.dmaContext.TblDrugs.ToList();

        }
        public void AddDrug(TblDrug drug)
        { 
            this.dmaContext.TblDrugs.Add(drug);
            this.dmaContext.SaveChanges();
        }
        public void DeleteDrug(int id)
        {
            var D=this.dmaContext.TblDrugs.Where(d=>d.DrugId==id).FirstOrDefault();
            if (D!=null)
            {
                this.dmaContext.TblDrugs.Remove(D);
                this.dmaContext.SaveChanges();

            }
        }
        

        
    }
}
