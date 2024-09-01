namespace boblle_sort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bubble_sort([3, 1, 5, 2, 7, 4, 0]);
        }
		public static int[] bubble_sort(int[] arr)
		{
			int[] res = arr;
            for (int i = 0; i < res.Length; i++)
            {
                for (int j = 0; j < res.Length - 1 - i; j++)
                {
					if (res[j] > res[j + 1])
					{
						(res[j], res[j + 1]) = ( res[j + 1], res[j]);

					}
                }
            }
            return res;
        }
		public static int[] selection_sort(int[] arr)
		{
			int[] res = arr;
			for (int i = 0; i < res.Length - 1; i++)
			{
				int min = 0;
				for (int j = i + 1; j < res.Length; j++)
				{
					if (min < res[j])
					{
						min = j;

					}
				}
				(res[i], res[min]) = (res[min], res[i]);
			}
			return res;
		}

	}
}
