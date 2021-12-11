// See https://aka.ms/new-console-template for more information
#region sozlerin sayi
//string word = "i     am        sat      student   ";
//string[] arr = word.Split(" ");
//int value = 0;
//foreach (var item in arr)
//{
//    if (item !="")
//    {
//        value++;
//    }
//}
//Console.WriteLine(value);
#endregion


#region tekrarlanan sozlerin sayi
string soz = " i have so many many thing many.";
string[] arr = soz.Split(" ");
string search = "code";
int value = 0;

foreach (var item in arr)
{
    if (item.ToLower() == search)
    {
        value++;
    }
}
Console.WriteLine(value);
#endregion