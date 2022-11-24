namespace Module_12._1_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>//список пользователей
            {
                new User { Login = "login23423", Name = "Mahesh Chand", IsPremium = true },
                new User { Login = "login43535", Name = "Neel Beniwal", IsPremium = true },
                new User { Login = "PakT", Name = "Chris Love",  IsPremium = false}
            };


            string login = Console.ReadLine();//ввод логина

            foreach (User u in users)
            {
                if (u.Login == login)
                {
                    Console.WriteLine($"Hello, {u.Name}");//вывод приветствия с именем
                    if(u.IsPremium == true)
                    {
                        User.ShowAds();
                    }
                }
            }
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }


}