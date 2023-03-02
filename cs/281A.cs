using System;

namespace problem_281A
{
    public class problem_281A
    {
		public static void Main(string[] args)
        {
			string ip = Console.ReadLine();
			ip = char.ToUpper(ip[0]) + ip.Substring(1);
			Console.Write(ip);
        }
    }
}
