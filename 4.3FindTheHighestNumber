static int FindTheHighestNumber(int[] array, int index, int current)
{
		if(index == array.Length)
			return current;
		if(array[index] > current)
			current = array[index];
		index++;
		return FindTheHighestNumber(array, index, current);
}
