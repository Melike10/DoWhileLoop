int sayac = 0;
int limit;
do
{

    Console.WriteLine("Litfen bir limit Giriniz");
    limit = int.Parse(Console.ReadLine());
    if (limit >= 0) {
        Console.WriteLine("Ben bir Patika'lıyım.");
    }
   
    sayac++;


} while (sayac <= limit);
/* do-while döngüsü en az bir kez kodların çalışmasını garanti ederken while koşula uyma durumunda sadece kodları çalıştırır.*/