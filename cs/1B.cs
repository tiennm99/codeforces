using System;

namespace problem_1B
{
    class problem_1B
    {
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string s = Console.ReadLine();
				int pos_R = s.IndexOf('R');
				int pos_C = s.IndexOf('C');
				if (pos_R == 0 && pos_C > 1 && char.IsDigit(s[1]))
				{
					int r = int.Parse(s.Substring(1, pos_C - 1));
					int c = int.Parse(s.Substring(pos_C + 1, s.Length - 1 - pos_C));
					string output = "";
                    while (c > 0)
					{
						if (c % 26 == 0)
						{
							output += "Z";
							c = c / 26 - 1;
						}
						else
						{
							output += Convert.ToString(Convert.ToChar('A' + c % 26 - 1));
							c /= 26;
						}
					}
					for (int j = output.Length - 1; j >= 0; j--)
					{
						Console.Write(output[j]);
					}
					Console.WriteLine(r);
				}
				else
				{
					int j = 0;
					int r = 0;
					int c = 0;
					while(char.IsDigit(s[j]) == false)
					{
						j++;
					}
					r = int.Parse(s.Substring(j, s.Length - j));
					for (int k = 0; k < j; k++)
					{
						c = c * 26 + Convert.ToInt32(s[k]) + 1 - 'A';
					}
					Console.WriteLine("R{0}C{1}", r, c);
				}
			}
		}
	}
}