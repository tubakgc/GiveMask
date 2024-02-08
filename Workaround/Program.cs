using System;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround {
    class Program { 
    static void Main(string[] args) {

            Console.WriteLine();
           

            

            Person person1 = new Person();
            person1.FirstName = "Tuğba";
            person1.LastName = "Akgüç";
            person1.DateOfBirthYear = 1994;
            person1.NationalIdentity =13579;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            
            Console.ReadLine();

        }
    }
    

    public class National {
        public string  Name{ get; set; }
        public string lastName { get; set; }    
        public int  DateOfBirthYear { get; set; }
        public long NationalIdentity { get; set; }


    }
}