Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower()=="наташа")
{
  Console.WriteLine("Ура! Это же Наташа!");  
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}