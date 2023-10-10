//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

// NOT: Tekrar eden sayılar için farklı bir liste oluşturulup eklenme öncesinde içerip içermediği kontrol edilebilir.

using System.Collections;

var counter = 20;

string requestMessage = $"Lütfen pozitif tam bir sayı giriniz: ";
string errorMessage = "Hatalı bir giriş yaptınız.";

ArrayList primeNumbers = new ArrayList();
ArrayList nonPrimeNumbers = new ArrayList();

int number;

while (counter > 0)
{
    Console.WriteLine($"Kalan sayı adedi:{counter}");
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

    if (number <= 0)
    {
        Console.WriteLine(errorMessage);
        continue;
    }
    else
    {
        if (IsPrimeNumber(number))
            primeNumbers.Add(number);
        else
            nonPrimeNumbers.Add(number);
    }

    counter--;
}

Console.Write("\n" + "Asal sayılar:");
ListNumbersDesc(primeNumbers);
ListAverageAndCount(primeNumbers);

Console.Write("\n" + "Asal olmayan sayılar:");
ListNumbersDesc(nonPrimeNumbers);
ListAverageAndCount(nonPrimeNumbers);

static void ListNumbersDesc(ArrayList numbers)
{
    numbers.Sort();
    numbers.Reverse();

    foreach (var number in numbers)
        Console.Write($" {number}");
}

static void ListAverageAndCount(ArrayList numbers)
{
    var total = 0;

    double average = 0;

    foreach (int number in numbers)
        total += number;

    average = total / numbers.Count;

    Console.WriteLine("\n" + $"Eleman sayısı:{numbers.Count}");
    Console.WriteLine($"Listenin Ortalaması:{average}");
}

static bool IsPrimeNumber(int number)
{
    bool result = true;

    if (number == 1)
        result = false;
    else
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                result = false;
        }

    return result;
}