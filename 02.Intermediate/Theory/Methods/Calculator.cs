namespace IntermediateLevel
{
    public class Calculator
	{
		// because of params keyword we can provide random number of parameters and they will be all put into the numbers array
		public int Add(params int[] numbers)
		{
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
			return sum;
		}
	}
}
