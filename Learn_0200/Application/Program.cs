// **************************************************
// *** Step (1) *************************************
// **************************************************
namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		System.Console.WriteLine
			(value: $"{nameof(Main)} method execution started");

		Method1();
		Method2();

		System.Console.WriteLine
			(value: $"{nameof(Main)} method execution completed");
	}

	private static void Method1()
	{
		System.Console.WriteLine
			(value: $"{nameof(Method1)} method execution started");

		for (var index = 1; index <= 5; index++)
		{
			System.Console.WriteLine
				(value: $"{nameof(Method1)} method: {index}");
		}

		System.Console.WriteLine
			(value: $"{nameof(Method1)} method execution completed");
	}

	private static void Method2()
	{
		System.Console.WriteLine
			(value: $"{nameof(Method2)} method execution started");

		for (var index = 1; index <= 5; index++)
		{
			System.Console.WriteLine
				(value: $"{nameof(Method2)} method: {index}");
		}

		System.Console.WriteLine
			(value: $"{nameof(Method2)} method execution completed");
	}
}
// **************************************************
// *** /Step (1) ************************************
// **************************************************

// **************************************************
// *** Step (2) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Method1);

//		thread1.Start();

//		var thread2 = new System
//			.Threading.Thread(start: Method2);

//		thread2.Start();

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution completed");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (2) ************************************
// **************************************************

// **************************************************
// *** Step (3) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Method1);

//		thread1.Start();

//		// New
//		thread1.Join();

//		var thread2 = new System
//			.Threading.Thread(start: Method2);

//		thread2.Start();

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution completed");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (3) ************************************
// **************************************************

// **************************************************
// *** Step (4) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Method1);

//		thread1.Start();

//		// New
//		thread1.Join();

//		var thread2 = new System
//			.Threading.Thread(start: Method2);

//		thread2.Start();

//		// New
//		thread2.Join();

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution completed");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (4) ************************************
// **************************************************

// **************************************************
// *** Step (5) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Method1);

//		thread1.Start();

//		var thread2 = new System
//			.Threading.Thread(start: Method2);

//		thread2.Start();

//		// New
//		thread1.Join();

//		// New
//		thread2.Join();

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution completed");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (5) ************************************
// **************************************************

// **************************************************
// *** Step (6) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Method1);

//		thread1.Start();

//		// **************************************************
//		//// New
//		//thread1.Join(millisecondsTimeout: 10_000);

//		//System.Console.WriteLine
//		//	(value: $"{nameof(thread1)} thread Is Alive: {thread1.IsAlive}");
//		// **************************************************

//		// **************************************************
//		// New
//		thread1.Join(millisecondsTimeout: 2_000);

//		System.Console.WriteLine
//			(value: $"{nameof(thread1)} thread Is Alive: {thread1.IsAlive}");
//		// **************************************************

//		var thread2 = new System
//			.Threading.Thread(start: Method2);

//		thread2.Start();

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)} method: {index}");

//			if (index == 2)
//			{
//				System.Console.WriteLine
//					(value: $"{nameof(Method1)} is sleep");

//				System.Threading.Thread
//					.Sleep(millisecondsTimeout: 5_000);

//				System.Console.WriteLine
//					(value: $"{nameof(Method1)} is awake");
//			}
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method1)} method execution completed");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution started");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)} method: {index}");
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(Method2)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (6) ************************************
// **************************************************
