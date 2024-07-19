int sayac = 0;
 Console.WriteLine("Lütfen bir limit Giriniz");
int limit = int.Parse(Console.ReadLine());
while(sayac <= limit){
    Console.WriteLine("Ben bir Patika'lıyım.");
}

sayac = 0;
limit =0;
do
{

    Console.WriteLine("Lütfen bir limit Giriniz");
    limit = int.Parse(Console.ReadLine());
    if (limit >= 0) {
        Console.WriteLine("Ben bir Patika'lıyım.");
    }
   
    sayac++;


} while (sayac <= limit);
/* do-while döngüsü en az bir kez kodların çalışmasını garanti ederken while koşula uyma durumunda sadece kodları çalıştırır.*/
