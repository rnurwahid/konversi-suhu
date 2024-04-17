//11. Konversi Suhu
using System;

public class KonversiSuhu
{
    public static double CelciusToReamur(double celsius)
    {
        return celsius * 0.8;
    }

    public static double CelciusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    public static double CelciusToFahrenheit(double celsius)
    {
        return (celsius * 9.0 / 5.0) + 32.0;
    }

    public static double ReamurToCelsius(double reamur)
    {
        return reamur * 1.25;
    }

    public static double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32.0) * 5.0 / 9.0;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("=============KONVERSI SUHU==========");
        Console.WriteLine("1. Celcius (C)");
        Console.WriteLine("2. Reamur (R)");
        Console.WriteLine("3. Kelvin (K)");
        Console.WriteLine("4. Fahrenheit (F)");

        Console.Write("Konversi suhu dari (pilih 1/2/3/4): ");
        int dariSuhu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Suhu dikonversi menjadi (pilih 1/2/3/4): ");
        int keSuhu = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan suhu: ");
        double suhuAwal = Convert.ToDouble(Console.ReadLine());

        double suhuAkhir;
        string lambang;

        switch (dariSuhu)
        {
            case 1: // Celcius
                switch (keSuhu)
                {
                    case 1: // Celcius
                        suhuAkhir = suhuAwal;
                        lambang = "C";
                        break;
                    case 2: // Reamur
                        suhuAkhir = CelciusToReamur(suhuAwal);
                        lambang = "R";
                        break;
                    case 3: // Kelvin
                        suhuAkhir = CelciusToKelvin(suhuAwal);
                        lambang = "K";
                        break;
                    case 4: // Fahrenheit
                        suhuAkhir = CelciusToFahrenheit(suhuAwal);
                        lambang = "F";
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        return;
                }
                break;
            case 2: // Reamur
                switch (keSuhu)
                {
                    case 1: // Celcius
                        suhuAkhir = ReamurToCelsius(suhuAwal);
                        lambang = "C";
                        break;
                    case 2: // Reamur
                        suhuAkhir = suhuAwal;
                        lambang = "R";
                        break;
                    case 3: // Kelvin
                        suhuAkhir = ReamurToCelsius(suhuAwal) + 273.15;
                        lambang = "K";
                        break;
                    case 4: // Fahrenheit
                        suhuAkhir = (ReamurToCelsius(suhuAwal) * 9.0 / 5.0) + 32.0;
                        lambang = "F";
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        return;
                }
                break;
            case 3: // Kelvin
                switch (keSuhu)
                {
                    case 1: // Celcius
                        suhuAkhir = KelvinToCelsius(suhuAwal);
                        lambang = "C";
                        break;
                    case 2: // Reamur
                        suhuAkhir = (KelvinToCelsius(suhuAwal)) * 0.8;
                        lambang = "R";
                        break;
                    case 3: // Kelvin
                        suhuAkhir = suhuAwal;
                        lambang = "K";
                        break;
                    case 4: // Fahrenheit
                        suhuAkhir = (KelvinToCelsius(suhuAwal) * 9.0 / 5.0) + 32.0;
                        lambang = "F";
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        return;
                }
                break;
            case 4: // Fahrenheit
                switch (keSuhu)
                {
                    case 1: // Celcius
                        suhuAkhir = FahrenheitToCelsius(suhuAwal);
                        lambang = "C";
                        break;
                    case 2: // Reamur
                        suhuAkhir = (FahrenheitToCelsius(suhuAwal)) * 0.8;
                        lambang = "R";
                        break;
                    case 3: // Kelvin
                        suhuAkhir = FahrenheitToCelsius(suhuAwal) + 273.15;
                        lambang = "K";
                        break;
                    case 4: // Fahrenheit
                        suhuAkhir = suhuAwal;
                        lambang = "F";
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        return;
                }
                break;
            default:
                Console.WriteLine("Pilihan tidak valid!");
                return;
        }

        Console.WriteLine($"Hasil konversi: {suhuAkhir} {lambang}");
    }
}