using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //degiskenler();

        Person person = new Person();
        person.FirstName = "İREM";
        person.LastName = "BULUT";
        person.DateOfBirthYear = 2002;
        person.NationalIdentity = 12345;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);
      

        Console.ReadLine();
    }

    static void SelamVer()
    {
        Console.WriteLine("Merhaba");
    }

    static int Topla()
    {
        return 5;
    }

    private static void degiskenler()
    {
        string mesaj = "Merhaba";
        double tutar = 100000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Engin";
        string soyad = "Demiroğ";
        int dogumYili = 1985;
        long tcNo = 123;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(tutar * 1.18);
    }
}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
