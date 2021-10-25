void Main()
{
	Console.WriteLine(LongestBinaryGap(647));
}


int LongestBinaryGap(int number)
{
	string binary = Convert.ToString(number,2);
	var indexesOne = binary
						.Select((x,y) => (x=='1') ? y : -1)
						.Where( x => x != -1)
						.ToList();
	
	if(indexesOne.Count()==1)
		return 0;
	
	var gaps = indexesOne
				.Select((x,y) => binary
									.Where((bx,by) => by> x && by < indexesOne[y+1])
						)
				.ToList();
	
	return gaps.Select(x => x.Count()).Max();
}
