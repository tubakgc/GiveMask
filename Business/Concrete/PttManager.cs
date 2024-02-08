using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
        private  IApplicentService _applicentService;
        public PttManager(IApplicentService applicentService)
        { 
            
            _applicentService = applicentService;
        }
        public void GiveMask(Person person) 
        {


            if (_applicentService.CheckPerson(person)) 
            {

                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else 
            {

                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            
            }
        }
    }
}
