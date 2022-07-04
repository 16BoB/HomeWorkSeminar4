// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] userArr = new int[8];

int[] CreateArrayEightElement (int[] arr) {
    int maxElement = 8;
    for (int i = 0; i < maxElement; i++) {
        Console.WriteLine("Введите элемент масива под индексом: " + i);
        int element = Convert.ToInt32(Console.ReadLine());
        arr[i] = element;
    }
    return arr;
}

CreateArrayEightElement(userArr);

Console.Write("Ваш массив: ");

for (int i = 0; i < userArr.Length; i++) {
    if (i == 7) {
        Console.Write(userArr[i]);
    }
    else {
       Console.Write(userArr[i] + ", "); 
    }  
}
