

//while ve if  ile rastgele gelen sayıyı tahmin etmek

int tahmin=0; 
int tutulan;
int sayac=0;
Random rasgele = new Random();
tutulan = rasgele.Next(1, 20);

while (tahmin!=tutulan)
{
    sayac++;
    Console.WriteLine("Sayı girin");
    tahmin = int.Parse(Console.ReadLine());
 
                
    if(tahmin > tutulan)
    {
        Console.WriteLine("aşağı");
                    
    }
    else if (tahmin < tutulan)
    {
        Console.WriteLine("yukarı");
    }
}
 
Console.WriteLine("Tebrikler.");