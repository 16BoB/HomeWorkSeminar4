// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int AddValuesNumber (int arg) {
    int sumNum = 0;
    int temp = arg;
    while (temp != 0) {
        sumNum = sumNum + temp % 10;
        temp /= 10;
    }
    return sumNum;
}

Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());

int result = AddValuesNumber(num);

Console.WriteLine("the sum of the values in a number " + result);