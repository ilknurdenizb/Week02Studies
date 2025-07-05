//All values defined in here
string appcontinue;
string inputLocation;
string inputTransportaiton;
bool verified = false;
bool verified2 = false;
do // Loop to continue the application until the user decides to exit
{

    Console.WriteLine("Merhaba! Tatil planınızı yapmaya hazır mısınız? Lokasyonlar aşağıdaki gibidir:"); 
    Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL) \n2 - Marmaris (Paket başlangıç fiyatı 3000 TL) \n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");

    do  // Loop to ensure valid location input
    {
        Console.WriteLine("\nLütfen gitmek istediğiniz lokasyonu seçiniz (1, 2, 3 veya lokasyon adı):");
        inputLocation = Console.ReadLine().ToUpper();

        if (inputLocation == "bodrum" || inputLocation == "1")
        {
            Console.WriteLine("Bodrum'a hoş geldiniz!");
            verified = true;
        }
        else if (inputLocation == "marmaris" || inputLocation == "2")
        {
            Console.WriteLine("Marmaris'e hoş geldiniz!");
            verified = true;
        }
        else if (inputLocation == "çeşme" || inputLocation == "3")
        {
            Console.WriteLine("Çeşme'ye hoş geldiniz!");
            verified = true;
        }
        else
        {
            Console.WriteLine("Geçersiz bir lokasyon girdiniz. Lütfen 1, 2, 3 ya da geçerli bir lokasyon adı giriniz.");
        }

    } while (!verified); // Loop continues until a valid location is entered

    Console.WriteLine($"\nGirdiğiniz Konum: {inputLocation}"); // Display the selected location

    Console.WriteLine("------------------------------");


    Console.WriteLine("Kaç kişi tatil yapacaksınız?");  // Ask for the number of people going on holiday
    int personCount = Convert.ToInt32(Console.ReadLine()); // Read the number of people from user input
    Console.WriteLine($"\n{personCount} kişi için {inputLocation} lokasyonunda tatil planınız hazırlanıyor..."); // Display the number of people and the selected location
    Console.WriteLine("Tatil Özeti:"); // Display the holiday summary

    if (inputLocation == "bodrum" || inputLocation == "1") // Check the selected location and display relevant information
    {
        Console.WriteLine("Bodrum'da güneşli plajlar, gece hayatı ve tarihi kalıntılar sizi bekliyor."); // Display information for Bodrum"
    }
    else if (inputLocation == "marmaris" || inputLocation == "2")
    {
        Console.WriteLine("Marmaris'te doğayla iç içe koylar, tekne turları ve temiz hava keyfi yaşayabilirsiniz."); // Display information for Marmaris
    }
    else if (inputLocation == "çeşme" || inputLocation == "3")
    {
        Console.WriteLine("Çeşme'de rüzgar sörfü, güzel plajlar ve Alaçatı sokakları sizi karşılıyor."); // Display information for Çeşme
    }

    Console.WriteLine("------------------------------");


    Console.WriteLine("\nPeki tatile hangi ulaşım aracıyla gitmek istersiniz? "); // Ask for the transportation method
    Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)"); // Display transportation options
    do  // Loop to ensure valid transportation input
    {
        inputTransportaiton = Console.ReadLine().ToUpper();

        if (inputTransportaiton == "Kara Yolu" || inputTransportaiton == "1")
        {
            Console.WriteLine("Kara yolu ile gitmeye hazırsınız.");
            verified2 = true;
        }
        else if (inputTransportaiton == "Hava Yolu" || inputTransportaiton == "2")
        {
            Console.WriteLine("Hava yolu ile gitmeye hazırsınız.");
            verified2 = true;
        }
        else
        {
            Console.WriteLine("Geçersiz bir lokasyon girdiniz. Lütfen 1, 2 ya da Kara Yolu Hava Yolu seçeneklerinden birini giriniz.");
        }

    } while (!verified2); // Loop continues until a valid transportation method is entered

    Console.WriteLine($"\nUlaşım aracınız: {inputTransportaiton}"); // Display the selected transportation method

    Console.WriteLine("------------------------------");

    int holidayPrice = 0; // Initialize holiday price
    int transportationPrice = 0; // Initialize transportation price

    // Holiday price based on location
    if (inputLocation == "bodrum" || inputLocation == "1")
    {
        holidayPrice = 4000;
    }
    else if (inputLocation == "marmaris" || inputLocation == "2")
    {
        holidayPrice = 3000;
    }
    else if (inputLocation == "çeşme" || inputLocation == "3")
    {
        holidayPrice = 5000;
    }

    // Transportation price based on transportation type
    if (inputTransportaiton == "kara yolu" || inputTransportaiton == "1")
    {
        transportationPrice = 1500;
    }
    else if (inputTransportaiton == "hava yolu" || inputTransportaiton == "2")
    {
        transportationPrice = 4000;
    }

    // Total price calculation
    int toplamFiyat = (holidayPrice + transportationPrice) * personCount;

    Console.WriteLine($"\n Hesaplama özeti:");
    Console.WriteLine($"Tatil paketi kişi başı: {holidayPrice} TL");
    Console.WriteLine($"Ulaşım kişi başı: {transportationPrice} TL");
    Console.WriteLine($"Toplam kişi sayısı: {personCount}");

    Console.WriteLine($"\n Tatil planınızın toplam maliyeti: {toplamFiyat} TL");

    Console.WriteLine("\nİyi tatiller dileriz!");
    Console.WriteLine("\nBaşka bir tatil planlamak ister misiniz? (Evet / Hayır)");

    appcontinue = Console.ReadLine().ToUpper();

    if (appcontinue != "evet") // If the user does not want to continue, exit the loop
    {
        Console.WriteLine("\nGörüşmek üzere! İyi günler dileriz.");
    }


    verified = false; // Reset verified for the next iteration
    verified2 = false; // Reset verified2 for the next iteration

}
while (appcontinue == "evet"); // Continue the loop if the user wants to plan another holiday



Console.ReadLine(); // Prevent the console from closing immediately