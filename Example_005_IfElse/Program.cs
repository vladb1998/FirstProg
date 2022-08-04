Console.Write("Введите имя пользователя:");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "vlad")
{
    Console.Write("Ура, это же Влад!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(UserName);
}