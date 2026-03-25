namespace second_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //    static bool CanConstruct(string ransomNote, string magazine)
            //    {
            //        char[] ransomChars = ransomNote.ToCharArray();
            //        char[] magazineChars = magazine.ToCharArray();

            //        Array.Sort(ransomChars);
            //        Array.Sort(magazineChars);

            //        int i = 0;
            //        int j = 0;

            //        while (i < ransomChars.Length && j < magazineChars.Length)
            //        {
            //            if (ransomChars[i] == magazineChars[j])
            //            {
            //                i++;
            //                j++;
            //            }
            //            else if (ransomChars[i] > magazineChars[j])
            //            {
            //                j++;
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
            //        return i == ransomChars.Length;
            //    }

            //    bool result1 = CanConstruct("a", "b");
            //    bool result2 = CanConstruct("aa", "ab");
            //    bool result3 = CanConstruct("aa", "aab");

            //    Console.WriteLine(result1);     
            //    Console.WriteLine(result2);   
            //    Console.WriteLine(result3);          
            //}


            //Задание 2
            //    static int FindLucky(int[] arr)
            //{
            //    Array.Sort(arr);

            //    int maxLucky = 0;
            //    int i = 0;

            //    while (i < arr.Length)
            //    {
            //        int currentNumber = arr[i];
            //        int count = 0;

            //        while (i < arr.Length && arr[i] == currentNumber)
            //        {
            //            count++;
            //            i++;
            //        }

            //        if (currentNumber == count)
            //        {
            //            maxLucky = currentNumber;
            //        }
            //    }

            //    return maxLucky;
            //}
            //    int[] result1 = {2, 2, 3, 4 };
            //    int[] result2 = {1, 2, 2, 3, 3, 3 };
            //    int[] result3 = {5};
            //    int[] result4 = {2, 2, 2, 3, 3};

            //    Console.WriteLine(FindLucky(result1));
            //    Console.WriteLine(FindLucky(result2));
            //    Console.WriteLine(FindLucky(result3));
            //    Console.WriteLine(FindLucky(result4));
            //}

            //Задание 3
            static int LongestOnes(int[] nums, int k)
            {
                int left = 0;
                int maxLength = 0;
                int zeroCount = 0;

                for (int right = 0; right < nums.Length; right++)
                {
                    if (nums[right] == 0)
                    {
                        zeroCount++;
                    }

                    while (zeroCount > k)
                    {
                        if (nums[left] == 0)
                        {
                            zeroCount--;
                        }
                        left++;
                    }

                    maxLength = Math.Max(maxLength, right - left + 1);
                }

                return maxLength;
            }
            int[] result1 = { 1, 1, 0, 1, 1, 1 };
            int k_res1 = 0;

            Console.WriteLine(LongestOnes(result1, k_res1)); // 2

            int[] result2 = { 1, 1, 0, 1, 1, 1};
            int k_res2 = 1;

            Console.WriteLine(LongestOnes(result2, k_res2)); // 6

            int[] result3 = {0, 0, 0, 0};
            int k_res3 = 2;

            Console.WriteLine(LongestOnes(result3, k_res3)); // 2
        }
    }
}