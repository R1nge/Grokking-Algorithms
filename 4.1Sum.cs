static int Sum(int[] array, int index, int sum)
{
	if(index == array.Length)
		return sum;
	sum += array[index];
	index++;
	return Sum(array,index,sum);
}
