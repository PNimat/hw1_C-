// ex2
/*
Console.Write("Введите превое число ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int j = Convert.ToInt32(Console.ReadLine());

if (i>j) {
    Console.WriteLine("Первое число больше второго");
} else if (i==j) {
    Console.WriteLine("Числа равны");
} else {
   Console.WriteLine("Второе число больше первого");
}
*/


/*
// ex3
Console.Write("Введите превое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a>c) {
    Console.WriteLine("Первое число самое большое");
} else if (b<c) {
    Console.WriteLine("Второе число самое большое");
} else {
    Console.WriteLine("Третье число самое большое");
}
*/


//ex6
/*
Console.Write("Введите число ");
int o = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0) {
    Console.WriteLine("Число делится на 2 без остатка");
} else {
    Console.WriteLine("Число не делится на 2 без остатка");
}
*/

//ex8

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int k = 2;

if (n>2) {
    do {
        if (k % 2 == 0) {
            Console.WriteLine(k);
            k++;
        } else {
            k++;
            }
    } while (n>k);
} else {
    Console.WriteLine("Число не подходит");
}


