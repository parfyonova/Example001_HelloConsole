Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "надежда"){
    Console.WriteLine("Ура, это Надежда!");
}
else {
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
