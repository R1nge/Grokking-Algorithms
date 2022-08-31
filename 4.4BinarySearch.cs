static int BinarySearch(int[] array, int number, int start, int end, int index = 0)
{
		if(index != number && index == start && index == end)
			return -1;
		
		index = (start + end) / 2;
		
		if(array[index] < number)
		{
			end = (start + end) / 2;
		}
		else if (array[index] > number)
		{
			start = (start + end) / 2;
		}
		else if (array[index] == number)
		{
			return index;
		}
		
		return BinarySearch(array, number, index, start, end);
}
