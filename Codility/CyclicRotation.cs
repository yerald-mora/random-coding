void Main()
{
	int[] a = new int[] { };
	int[] cycledArray = CyclicRotation(a, 5);

	Console.WriteLine("[{0}]", string.Join(", ", cycledArray));
}

int[] CyclicRotation(int[] a, int k)
{
	k = (a.Length == 0) ? 0 : k;

	while (k != 0)
	{
		int lastIndex = a.Length - 1;
		int[] lastElement = new int[] { a[lastIndex] };
		int[] elementsExceptLast = a[0..(lastIndex)];

		a = lastElement.Concat(elementsExceptLast).ToArray();
		k -= 1;
	}

	return a;
}