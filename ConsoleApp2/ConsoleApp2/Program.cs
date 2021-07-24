using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ls = { 9, 1, 3, 5, 8, 2, 4 };
            //int[] ls = { 1, 3, 5, 4 };
            int[] ls = { 1, 3, 5, 4, 5 };
            //int[] ls = { 5, 4, 5 };

            Giaithuat g = new Giaithuat();

            //Console.WriteLine(g.c1(ls));
            //Console.WriteLine(g.c2(ls));
            Console.WriteLine(g.c3(ls));

        }
    }

    public class Giaithuat
    {
        // tự sắp xếp rồi tự tìm
        // sinh viên cùi
        public int c1(int[] ls)
        {
            int temp = 0;

            for (int i = 0; i < ls.Length - 1; i++)
            {
                for (int j = i + 1; j < ls.Length; j++)
                {
                    if (ls[i] < ls[j])
                    {
                        temp = ls[i];
                        ls[i] = ls[j];
                        ls[j] = temp;
                    }
                }
            }

            int secord = ls[0];
            for (int i = 1; i < ls.Length; i++)
            {
                if (secord > ls[i])
                {
                    secord = ls[i];
                    break;
                }
            }

            return secord;
        }

        private int GetSecordMax(int[] ls)
        {
            // dãy đã được xắp sếp
            // pt 0 là max
            int secord = ls[0];
            for (int i = 1; i < ls.Length; i++)
            {
                if (secord > ls[i])
                {
                    secord = ls[i];
                    break;
                }
            }
            return secord;
        }

        // đi làm
        public int c2(int[] ls)
        {
            Array.Sort(ls);
            Array.Reverse(ls);
            return GetSecordMax(ls);
        }

        // không dùng pp sắp xếp
        // có tí gọi là giải thuật
        public int c3(int[] ls)
        {
            int first, secord;
            first = secord = ls[0];

            for (int i = 1; i < ls.Length; i++)
            {
                if (first < ls[i])
                {
                    secord = first;
                    first = ls[i];
                    continue;
                }

                // trường hợp số đầu tiên là số lớn nhất
                // mà init secord lại là số đầu tiên thì phải next nó về vị trí tiếp theo
                if (secord == first)
                {
                    secord = ls[i];
                }

                if (ls[i] < first && ls[i] > secord)
                    secord = ls[i];
            }
            return secord;
        }
    }
}
