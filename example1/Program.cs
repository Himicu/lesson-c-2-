//Циклы, break, continue

// int x = 5;
// while(x > 0){
//     x--;
//     if(x == 3) continue;
    
//     Console.WriteLine($"{x} 111");
//  //break - прерывает выполнение цикла
//  //continue - возвращяет в начало цикла
// } 
// Console.WriteLine("OK");

for (int i = 0; i < 10; i++) //переменная i существует только внутри цикла
{
    Console.WriteLine($"{i} 111");
}
Console.WriteLine("OK");
//Console.WriteLine($"{i} 111"); //тут она уже не работает. прога ее не видит

