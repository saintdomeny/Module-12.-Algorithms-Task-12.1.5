
namespace Module_12._Algorithms_Task_12._1._5
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
}