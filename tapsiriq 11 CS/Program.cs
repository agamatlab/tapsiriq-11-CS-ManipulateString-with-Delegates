class ManipulateString
{

	public void Space(string str) => Console.WriteLine($"Space: {string.Join("-", str.ToCharArray())}" );
    public void Reverse(string str) => Console.WriteLine($"Reverse: {new string(str.Reverse().ToArray())}");
}

delegate void Func(string str);


class Run
{
	// public void RunFunc(Action<string> funcDell, string str) => funcDell(str);
	public void RunFunc(Func funcDell, string str) => funcDell(str);
}

class Program
{
	public static void Main()
	{
		while(true){
			Console.Write("Enter string: ");
			var str = Console.ReadLine();
			ManipulateString cls = new ManipulateString();
			//Action<string> funcDell = cls.Reverse;
			Func funcDell = cls.Reverse;
			funcDell += cls.Space;
			Run run = new Run();
			run.RunFunc(funcDell, str); 

            Console.Write("\nPress any key to continue...");
			Console.ReadKey();
			Console.Clear();
        }
	}

}