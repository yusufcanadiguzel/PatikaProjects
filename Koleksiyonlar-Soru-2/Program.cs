//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

var numberCount = 20;
var counter = 0;

int number;

int[] numbers = new int[numberCount];

string requestMessage = "Lütfen bir sayı giriniz: ";
string errorMessage = "Hatalı bir giriş yaptınız.";
string infoMessage = $"Kalan sayı adedi: ";

while (counter < numberCount)
{
    Console.WriteLine(infoMessage + (numberCount - counter));
    Console.Write(requestMessage);
    
    try
    {
        number = int.Parse(Console.ReadLine());
    }
    catch (Exception exception)
    {
        Console.WriteLine(errorMessage);
        continue;
    }

    numbers[counter] = number;

    counter++;
}

ListNumbers(numbers);
FindAverage(ListNumbersAsc(numbers, 3));
FindAverage(ListNumbersDesc(numbers, 3));

static void ListNumbers(int[] numbers)
{
    Console.Write("\n" + "Girilen sayılar:");
    Array.ForEach(numbers, number => Console.Write($" {number}"));
}

static int[] ListNumbersAsc(int[] numbers, int pickCount)
{
    Array.Sort(numbers);

    int[] result = new int[pickCount];

    Console.Write("\n" + $"En küçük {pickCount} elaman:");

    for (int i = 0; i < pickCount; i++)
    {
        Console.Write($" {numbers[i]}");
        result[i] = numbers[i];
    }

    return result;
}

static int[] ListNumbersDesc(int[] numbers, int pickCount)
{
    Array.Sort(numbers);
    Array.Reverse(numbers);

    int[] result = new int[pickCount];

    Console.Write("\n" + $"En büyük {pickCount} elaman:");

    for (int i = 0; i < pickCount; i++)
    {
        Console.Write($" {numbers[i]}");
        result[i] = numbers[i];
    }

    return result;
}

static void FindAverage(int[] numbers)
{
    double average = 0;

    var total = 0;

    Array.ForEach(numbers, number => total += number);

    average = total / numbers.Length;

    Console.WriteLine("\n" + $"Elemanların ortalaması: {average}");
}