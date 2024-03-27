using MyClassLibrary1;

public class Program
{
    public static void Main()
    {
        Volvo volvo = new Volvo("Volvo","XC60",2020,"2.0 B4 Momentum");
        volvo.AboutCar();
        BMW bmw = new BMW("BMW", "X1", 2021, "18i 1.5 sDrive");
        bmw.AboutCar();
        Ford ford = new Ford("Ford", "Focus", 2024, "1.5 Trend X");
        ford.AboutCar();
        Jeep jeep = new Jeep("Jeep", "Cherokee", 2016, "2.0 Limited AWD");
        jeep.AboutCar();
    }
}