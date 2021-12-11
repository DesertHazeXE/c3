// See https://aka.ms/new-console-template for more information
#region 10 dene elementin gedis sisrasini deyisdirmek
//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr[i]);
//}
#endregion


#region arraylari birlesdirmek
//int[] arr1 = { 18, 33, 24, 932, 31 };
//int[] arr2 = { 216, 863, 16, 547};
//int[] arr3 = new int[arr1.Length + arr2.Length];
//for (int i = 0, a = 0; i < arr3.Length; i++)
//{
//    if (i < arr1.Length)
//    {
//        arr3[i] = arr1[i];
//    }
//    if (i == arr1.Length || i > arr1.Length)
//    {
//        arr3[i] = arr2[a];
//        a++;
//    }

//}
//foreach (var item in arr3)
//{

//}

//Array.Sort(arr3);
//Array.Reverse(arr3);
//foreach (int item in arr3)
//{

//}
//Console.WriteLine(string.Join(" ", arr3));
#endregion


#region min max ededler
//int[] arr = { 0, 19885, 226, 5218, 13 };
//int min = arr[0];
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//    else if (min > arr[i])
//    {
//        min = arr[i];
//    }
//}

//Console.WriteLine(min);
//Console.WriteLine(max);

#endregion


#region ededlerin cut veya tek eded olmasi
//int[] arr1 = { 41, 8, 129, 0, 514, 141, 619 };
//int[] arr2 = new int[arr1.Length];
//int[] arr3 = new int[arr1.Length];
//int i, j = 0, k = 0;
//for (i = 0; i < arr1.Length; i++)
//{
//    if (arr1[i] % 2 == 0)
//    {
//        arr2[k] = arr1[i];
//        k++;
//    }
//    else
//    {
//        arr3[j] = arr1[i];
//        j++;
//    }
//}
//for (i = 0; i < k; i++)
//{
//    Console.WriteLine($"Cut ededler{arr2[i]}");
//}
//for (i = 0; i < j; i++)
//{
//    Console.WriteLine($"Tek ededler{arr3[i]}");
//}
#endregion



