﻿int month =DateTime.Now.Month;

switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındayız!");
        break;
    case 2:
        Console.WriteLine("Şubat ayındayız!");
        break;
    case 3:
        Console.WriteLine("Mart ayındayız!");
        break;
    case 8:
        Console.WriteLine("Ağustos ayındayız!");        //Ay sırası bozulabilir.
        break;
    case 4:
        Console.WriteLine("Nisan ayındayız!");
        break;
    case 5:
        Console.WriteLine("Mayıs ayındayız!");
        break;
    case 6:
        Console.WriteLine("Haziran ayındayız!");
        break;
    case 7:
        Console.WriteLine("Temmuz ayındayız!");
        break;
    case 9:
        Console.WriteLine("Eylül ayındayız!");
        break;
    case 10:
        Console.WriteLine("Ekim ayındayız!");
        break;
    case 11:
        Console.WriteLine("Kasım ayındayız!");
        break;
    case 12:
        Console.WriteLine("Aralık ayındayız!");
        break;
    default:
        Console.WriteLine("Yanlış değer girdiniz!");            // 1-12 dışında.
        break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış mevsimizdeyiz!");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar mevsimizdeyiz!");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz mevsimizdeyiz!");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar mevsimizdeyiz!");
        break;
    default:
        Console.WriteLine("Yanlış değer girdiniz!");
        break;
}