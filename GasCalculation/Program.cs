using System.ComponentModel.Design;

namespace GasCalculation
{
    public class Program
    {
        static void Main(string[] args)
        {

            double distance, price, averageGasSpend, totalGasSpend, totalPrice;

            Console.WriteLine("Lütfen mesafeyi giriniz");

            distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen yakıt litre fiyatını giriniz?");

            price = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen 100km'de kaç litre yaktığınızı giriniz?");

            averageGasSpend = double.Parse(Console.ReadLine());

            Console.WriteLine("Mesafe" + " = " + distance + "km");
            Console.WriteLine("Fiyat" + " = " + price + "tl");
            Console.WriteLine("100 km'de harcanan yakıt" + " = " +  averageGasSpend + " litre");

            totalGasSpend = ((averageGasSpend * distance) / 100);
            totalPrice = (totalGasSpend * price);
            Console.WriteLine("Toplam harcanan yakıt" + "=" +  totalGasSpend + " litre");
            Console.WriteLine("Toplam tutar" + "=" +  totalPrice + "tl");

            double  times;
            string resume;
            int days;

            Console.WriteLine("Kaç kez olduğunu belirtmek için lütfen 'devam' yazın");

            resume = Console.ReadLine();

            Console.WriteLine("Kaç gün?");
            days = int.Parse(Console.ReadLine());
            times = (totalPrice * days);

            if (resume == "devam")

                

                

           
                Console.WriteLine(days + " günlük tutar " + " = " + times + "tl");

            else
                Console.WriteLine("Program sonlanmıştır.");








        }
    }
}