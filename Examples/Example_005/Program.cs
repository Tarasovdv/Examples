Console.Write("Введите имя: ");
string username = Console.ReadLine();


if (username.ToLower() == "маша"){
    Console.WriteLine("Урааа, это Маша");
} else {
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
