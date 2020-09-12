using System;

namespace MainWithArguments
{
class MainWithArgument{
	static void Main(string[] args)
	{
		
		Console.WriteLine("demo for commandLineArgument");
		Console.WriteLine("No.of arguments passed " +args.Length);
		Console.WriteLine("first args: " +args[0]);
		Console.WriteLine("second args: " +args[1]);
		Console.WriteLine("second args: {0}" ,args[1]);
		Console.WriteLine("second args: {0}{1}", args[0],args[1]);
		Console.ReadLine();
	}
}
}