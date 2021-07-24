namespace ConsoleApp2
{
    public class Algorithm
    {
        public int thirdMax(int[] ls)
        {
            if (ls.Length < 3)
            {
                return ls[0];
            }
            int first, secord, third;
            first = ls[0];
            secord = ls[1];
            third = ls[2];

            for (int i = 1; i < ls.Length; i++)
            {
                if (first < ls[i])
                {
                    third = secord;
                    secord = first;
                    first = ls[i];
                    continue;
                }

                if (secord == first)
                {
                    secord = ls[i];
                }

                if (third == secord)
                {
                    third = ls[i];
                }

                if (ls[i] < first && ls[i] > secord)
                {
                    third = secord;
                    secord = ls[i];
                }

                if (ls[i] < secord && ls[i] > third)
                    third = ls[i];
            }

            // không có 3rd thì trả về 1st
            return third == secord ? ls[0] : third;
        }
    }
}
