
using Business.Concrete;
using Entities.Concrete;


SelamVer(isim: "Ali");


static void SelamVer(string isim = "noname")
{
    Console.WriteLine("Merhaba ");
}


Person person1 = new Person();
person1.FirstName = "İrfan Mert";
person1.LastName = "Yavuz";
person1.BirtYear = 1998;
person1.NatinonalIdentity = 12345678912 ; 



PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

public class citizen
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public int BirthYear { get; set; }
    public long CitizenNo { get; set; }
}
