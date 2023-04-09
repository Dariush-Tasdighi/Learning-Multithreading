// **************************************************
// *** Step (1) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	/// <summary>
//	/// Single Thread Application
//	/// </summary>
//	private static void Main()
//	{
//		//System.Threading.Thread currentThread =
//		//	System.Threading.Thread.CurrentThread;

//		var currentThread =
//			System.Threading.Thread.CurrentThread;

//		System.Console.WriteLine
//			(value: $"Thread Name: {currentThread.Name}");

//		currentThread.Name = "Main Thread";

//		System.Console.WriteLine
//			(value: $"Thread Name: {currentThread.Name}");

//		System.Console.WriteLine
//			(value: $"Alive: {currentThread.IsAlive}");

//		System.Console.WriteLine
//			(value: $"Priority: {currentThread.Priority}");

//		//switch(currentThread.Priority)
//		//{
//		//	case System.Threading.ThreadPriority.Lowest:
//		//	case System.Threading.ThreadPriority.BelowNormal:
//		//	case System.Threading.ThreadPriority.Normal: // Default
//		//	case System.Threading.ThreadPriority.AboveNormal:
//		//	case System.Threading.ThreadPriority.Highest:
//		//}

//		System.Console.WriteLine
//			(value: $"ManagedThreadId: {currentThread.ManagedThreadId}");
//	}
//}
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
//		Method1();
//		Method2();
//		Method3();
//	}

//	private static void Method1()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)}: {index}");
//		}
//	}

//	private static void Method2()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)}: {index}");
//		}
//	}

//	private static void Method3()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method3)}: {index}");
//		}
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
//		Method1();
//		Method2();
//		Method3();
//	}

//	private static void Method1()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)}: {index}");
//		}
//	}

//	private static void Method2()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)}: {index}");

//			if (index == 3)
//			{
//				System.Console.WriteLine
//					(value: $"Heavy Executing Code Started...");

//				//System.Threading.Thread.Sleep
//				//	(millisecondsTimeout: 10000);

//				System.Threading.Thread.Sleep
//					(millisecondsTimeout: 10_000);

//				System.Console.WriteLine
//					(value: $"Heavy Executing Code Compeleted!");
//			}
//		}
//	}

//	private static void Method3()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method3)}: {index}");
//		}
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
//			(value: $"Main Thread Started");

//		// Creating some new threads

//		var thread1 =
//			new System.Threading.Thread(start: Method1)
//			{
//				Name = "Thread 1",
//			};

//		var thread2 =
//			new System.Threading.Thread(start: Method2)
//			{
//				Name = "Thread 2",
//			};

//		var thread3 =
//			new System.Threading.Thread(start: Method3)
//			{
//				Name = "Thread 3",
//			};

//		// Executing the Methods

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		System.Console.WriteLine
//			(value: $"Main Thread Completed");
//	}

//	private static void Method1()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Method1)} started with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method1)}: {index}");
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(Method1)} compeleted with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");
//	}

//	private static void Method2()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Method2)} started with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method2)}: {index}");

//			if (index == 3)
//			{
//				System.Console.WriteLine
//					(value: $"Heavy Executing Code Started...");

//				System.Threading.Thread.Sleep
//					(millisecondsTimeout: 10_000);

//				System.Console.WriteLine
//					(value: $"Heavy Executing Code Compeleted!");
//			}
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(Method2)} compeleted with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");
//	}

//	private static void Method3()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Method3)} started with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"{nameof(Method3)}: {index}");
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(Method3)} compeleted with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");
//	}
//}
// **************************************************
// *** /Step (4) ************************************
// **************************************************

// **************************************************
// *** Step (5) *************************************
// **************************************************
// *** Learning ThreadStart *************************
// **************************************************
// *** ThreadStart is Delegate **********************
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
//			(value: $"Main Thread Started");

//		var myThreadStart = new System
//			.Threading.ThreadStart(ShowNumbers);

//		var myThread =
//			new System.Threading.Thread(start: myThreadStart)
//			{
//				Name = "My Thread",
//			};

//		myThread.Start();

//		System.Console.WriteLine
//			(value: $"Main Thread Completed");
//	}

//	private static void ShowNumbers()
//	{
//		System.Console.WriteLine(value:
//			$"'{nameof(ShowNumbers)}' method started with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine
//				(value: $"'{nameof(ShowNumbers)}' method: {index}");
//		}

//		System.Console.WriteLine(value:
//			$"'{nameof(ShowNumbers)}' method compeleted with using:" +
//			$" {System.Threading.Thread.CurrentThread.Name}");
//	}
//}
// **************************************************
// *** /Step (5) ************************************
// **************************************************

// **************************************************
// *** Step (6) *************************************
// **************************************************
// *** Learning ThreadStart *************************
// **************************************************
// *** Working with Delegate ***********************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		// **************************************************
//		var myThread = new System
//			.Threading.Thread(start: ShowNumbers);

//		myThread.Start();
//		// **************************************************

//		// **************************************************
//		//var myThreadStart = new System
//		//	.Threading.ThreadStart(ShowNumbers);

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************

//		// **************************************************
//		//System.Threading.ThreadStart myThreadStart = ShowNumbers;

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************

//		// **************************************************
//		// Anonymous Method
//		// **************************************************
//		//System.Threading.ThreadStart myThreadStart = delegate () { ShowNumbers(); };

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************

//		// **************************************************
//		// Anonymous Method
//		// **************************************************
//		//System.Threading.ThreadStart myThreadStart =
//		//	delegate ()
//		//	{
//		//		for (var index = 1; index <= 5; index++)
//		//		{
//		//			System.Console.WriteLine(value: index);
//		//		}
//		//	};

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************

//		// **************************************************
//		// Lambda Expression
//		// **************************************************
//		//System.Threading.ThreadStart myThreadStart = () => ShowNumbers();

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************

//		// **************************************************
//		// Lambda Expression
//		// **************************************************
//		//System.Threading.ThreadStart myThreadStart = () =>
//		//{
//		//	for (var index = 1; index <= 5; index++)
//		//	{
//		//		System.Console.WriteLine(value: index);
//		//	}
//		//};

//		//var myThread = new System
//		//	.Threading.Thread(start: myThreadStart);

//		//myThread.Start();
//		// **************************************************
//	}

//	private static void ShowNumbers()
//	{
//		for (var index = 1; index <= 5; index++)
//		{
//			System.Console.WriteLine(value: index);
//		}
//	}
//}
// **************************************************
// *** /Step (6) ************************************
// **************************************************

// **************************************************
// *** Step (7) *************************************
// **************************************************
// *** Learning ThreadStart *************************
// **************************************************
// *** ParameterizedThreadStart *********************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		var myThreadStart = new System
//			.Threading.ParameterizedThreadStart(ShowNumbers);

//		var myThread = new System
//			.Threading.Thread(start: myThreadStart);

//		// دستور ذیل خطا نمی‌دهد
//		// ولی نتیجه‌ای هم ندارد
//		//myThread.Start();

//		// دستور ذیل خطا نمی‌دهد
//		// ولی نتیجه‌ای هم ندارد
//		//myThread.Start
//		//	(parameter: "Hello, World!");

//		myThread.Start(parameter: 10);
//	}

//	/// <summary>
//	/// متاسفانه کامپایلر خطا می‌دهد و پروژه اجرا نمی‌شود
//	/// </summary>
//	//private static void ShowNumbers(int maxNumber)
//	//{
//	//	for (var index = 1; index <= maxNumber; index++)
//	//	{
//	//		System.Console.WriteLine(value: index);
//	//	}
//	//}

//	/// <summary>
//	/// دارد Warning
//	/// </summary>
//	//private static void ShowNumbers(object maxNumber)
//	//{
//	//}

//	private static void ShowNumbers(object? maxNumber)
//	{
//		if (maxNumber is null)
//		{
//			return;
//		}

//		int maxNumberInt;

//		try
//		{
//			maxNumberInt = System
//				.Convert.ToInt32(value: maxNumber);
//		}
//		catch (System.Exception)
//		{
//			return;
//		}

//		for (var index = 1; index <= maxNumberInt; index++)
//		{
//			System.Console.WriteLine(value: index);
//		}
//	}
//}
// **************************************************
// *** /Step (7) ************************************
// **************************************************

// **************************************************
// *** Step (8) *************************************
// **************************************************
// *** Learning ThreadStart *************************
// **************************************************
// *** Passing Data to Thread Method (Function)   ***
// *** in a Type Safe Manner -> Helper Class      ***
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		var instance =
//			new ShowNumbersHelper(maxNumber: 10);

//		var myThreadStart = new System
//			.Threading.ThreadStart(instance.ShowNumbers);

//		var myThread = new System
//			.Threading.Thread(start: myThreadStart);

//		myThread.Start();
//	}
//}

//public class ShowNumbersHelper : object
//{
//	public ShowNumbersHelper(int maxNumber) : base()
//	{
//		//_maxNumber = maxNumber;

//		MaxNumber = maxNumber;
//	}

//	//private int _maxNumber;

//	//private readonly int _maxNumber;

//	//private int MaxNumber { get; }

//	private int MaxNumber { get; init; }

//	public void ShowNumbers()
//	{
//		for (var index = 1; index <= MaxNumber; index++)
//		{
//			System.Console.WriteLine(value: index);
//		}
//	}
//}
// **************************************************
// *** /Step (8) ************************************
// **************************************************

// **************************************************
// *** Step (9) *************************************
// **************************************************
// *** Learning ThreadStart *************************
// **************************************************
// *** Retrieving data from Thread function       ***
// *** using callback method                      ***
// **************************************************
namespace Application;

// First: Define Delegate
public delegate void TheSumOfNumbersCallback(int sum);

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		System.Console.WriteLine
			(value: $"Main Thread Started");

		// Seventh: Define a variable from callback delegate and assign
		TheSumOfNumbersCallback callback = DisplaySumOfNumbers;

		var instance = new CalculateSumHelper
			(maxNumber: 10, callback: callback);

		var myThreadStart = new System
			.Threading.ThreadStart(instance.CalculateSum);

		var myThread = new System
			.Threading.Thread(start: myThreadStart);

		myThread.Start();

		System.Console.WriteLine
			(value: $"Main Thread Completed");
	}

	/// <summary>
	/// Sixth: Define the favorite function (method)
	/// </summary>
	private static void DisplaySumOfNumbers(int sum)
	{
		System.Console.WriteLine
			(value: $"The sum of numbers is {sum}.");
	}
}

public class CalculateSumHelper : object
{
	// Third: Inject callback delegate to constructor
	public CalculateSumHelper(int maxNumber,
		TheSumOfNumbersCallback? callback) : base()
	{
		MaxNumber = maxNumber;

		// Forth: Assign injected parameter to property
		Callback = callback;
	}

	private int MaxNumber { get; init; }

	// Second: Defint a variable. It is better it be nullable
	private TheSumOfNumbersCallback? Callback { get; init; }

	public void CalculateSum()
	{
		var sum = 0;

		for (var index = 1; index <= MaxNumber; index++)
		{
			sum += index;
		}

		System.Threading.Thread.Sleep
			(millisecondsTimeout: 10_000);

		// Fifth: Callback
		if (Callback is not null)
		{
			Callback(sum: sum);
		}
	}
}
// **************************************************
// *** /Step (9) ************************************
// **************************************************
