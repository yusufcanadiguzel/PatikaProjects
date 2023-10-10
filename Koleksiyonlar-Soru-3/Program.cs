//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

char[] vowels = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };
List<char> textVowels = new List<char>();

string text;

Console.Write("Bir cümle giriniz: ");
text = (Console.ReadLine()).ToLower();

foreach (var character in text)
{
    if(!textVowels.Contains(character) && vowels.Contains(character))
        textVowels.Add(character);
}

Console.Write("Girilen metindeki sesli harfler:");
textVowels.ForEach(x => Console.Write($" {x}"));