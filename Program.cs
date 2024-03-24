// 1 dan 1000 gacha bo’lgan toq sonlarni yig’indisini ekranga chiqaradigan dastur tuzing. While loop dan foydalaning!
int i = 1;
int num = 0;
while(i<=1000)
{
    num += 1;
    i+=2;
}
System.Console.WriteLine($"yig'indi: {num}");

// 2 Array ichidagi eng katta va eng kichik qiymatlarni ko’paytmasini ekranga chiqaradigan dastur tuzing. For loop dan foydalaning!
int[] numbers = {34567,2,23,445,67,8,32,876,3,8,}; //barcha int type.dagi sonlar uchun ishlaydi;
int kichikSon = numbers[0];
int kattaSon = numbers[0];
for(int j=0;j<numbers.Length;j++)
{
    if(kichikSon > numbers[j])
    {
        kichikSon = numbers[j];
    }
    if(kattaSon < numbers[j])
    {
        kattaSon = numbers[j];
    }
}
System.Console.WriteLine("katta va kichik son;;larning ko'paytmasi: "+kichikSon*kattaSon);

// 3 Consolga int tipidagi butun son kiritilgan => int x
// x! (x factorial) ni hisoblaydigan dastur tuzing.
Console.Write("Son kiriting: ");
int x = Convert.ToInt32(Console.ReadLine());
int k = 1;
int f = 1;
while(k<=x)
{
    f *= k;
    k++;
}
System.Console.WriteLine("factorial: "+f);