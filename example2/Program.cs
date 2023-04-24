// //математические функции, рандом
//!!!!!!!!!!!перед началосм работы, проверьте, что раскомментировали объявление переменных!!!!!!!!
// double x = -7;
// //чтобы отбросить минус, можно использовать математические функции(по модулю) 
// double result = Math.Abs(x); // тут объявила, а в остальных просто пользовалась
// Console.WriteLine(result);

// //округление дробного числа до нужного количества знаков
// x = 7.12345;
// result = Math.Round(x, 1); // переменная, количество символов после запятой
// Console.WriteLine(result);

// x = 7.62345;
// result = Math.Floor(x); //математическое округление
// Console.WriteLine(result);

// //математические функции для поиска максимум и минимум
// x = 7.45;
// double y = 3.845;
// result = Math.Max(x, y);
// Console.WriteLine(result);
// result = Math.Min(x, y);
// Console.WriteLine(result);

//возведение в корень и извлечение
// x = 4; y =3;
// result = Math.Pow(x, y); // возвести
// Console.WriteLine(result);
// result = Math.Sqrt(x); //извлечь
// Console.WriteLine(result);

// int x = 0; //новое объявление х, с другим типом данный !! дабл х закоментить!!
// for (int i = 0; i < 10; i++)
// {
//     x = new Random().Next(1, 10);
//     Console.WriteLine($"{i} {x}");
// }