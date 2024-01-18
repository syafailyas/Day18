void Main()
{
	List<int> myList = new() { 1, 2, 3 };
	IEnumerable<int> ienumerableint = myList;
	IEnumerator<int> ienumerator = ienumerableint.GetEnumerator();
	
	ienumerator.MoveNext();
	ienumerator.MoveNext();
	ienumerator.Reset();
	Console.WriteLine(ienumerator.Current);
}

