// **************************************************
// *** Step (1) *************************************
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	/// <summary>
//	/// Shared Resource
//	/// </summary>
//	private static int Counter = 0;

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		MyMethod();
//		MyMethod();
//		MyMethod();

//		System.Console.WriteLine
//			(value: $"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void MyMethod()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution started");

//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			Counter++;
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution completed");
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
//	/// <summary>
//	/// Shared Resource
//	/// </summary>
//	private static int Counter = 0;

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread2 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread3 = new System
//			.Threading.Thread(start: MyMethod);

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		thread1.Join();
//		thread2.Join();
//		thread3.Join();

//		// هر دفعه که اجرا می‌کنیم، اعداد
//		// متفاوت و البته غلطی نمایش می‌دهد
//		System.Console.WriteLine
//			(value: $"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void MyMethod()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution started");

//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			Counter++;
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (2) ************************************
// **************************************************

// **************************************************
// *** Step (3) *************************************
// **************************************************
// System.Threading.Interlocked.Add               ***
// System.Threading.Interlocked.Increment         ***
// ...                                            ***
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	/// <summary>
//	/// Shared Resource
//	/// </summary>
//	private static int Counter = 0;

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread2 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread3 = new System
//			.Threading.Thread(start: MyMethod);

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		thread1.Join();
//		thread2.Join();
//		thread3.Join();

//		// حال پاسخ درستی دریافت می‌کنیم
//		System.Console.WriteLine
//			(value: $"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void MyMethod()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution started");

//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			System.Threading.Interlocked
//				.Increment(location: ref Counter);

//			// OR

//			//System.Threading.Interlocked
//			//	.Add(location1: ref Counter, value: 1);
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (3) ************************************
// **************************************************

// **************************************************
// *** Step (4) *************************************
// **************************************************
// lock() and LockedObject                        ***
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	/// <summary>
//	/// Shared Resource
//	/// </summary>
//	private static int Counter = 0;

//	/// <summary>
//	/// Lock or lockObject or LockedObject
//	/// </summary>
//	public static object LockedObject = new();

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread2 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread3 = new System
//			.Threading.Thread(start: MyMethod);

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		thread1.Join();
//		thread2.Join();
//		thread3.Join();

//		// حال پاسخ درستی دریافت می‌کنیم
//		System.Console.WriteLine
//			(value: $"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine
//			(value: $"{nameof(Main)} method execution completed");
//	}

//	private static void MyMethod()
//	{
//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution started");

//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			lock (LockedObject)
//			{
//				Counter++;
//			}
//		}

//		System.Console.WriteLine
//			(value: $"{nameof(MyMethod)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (4) ************************************
// **************************************************

// **************************************************
// *** Step (5) *************************************
// **************************************************
// Monitor.Enter                                  ***
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	private static int Counter = 0;

//	public static object LockedObject = new();

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread2 = new System
//			.Threading.Thread(start: MyMethod);

//		var thread3 = new System
//			.Threading.Thread(start: MyMethod);

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		thread1.Join();
//		thread2.Join();
//		thread3.Join();

//		// حال پاسخ درستی دریافت می‌کنیم
//		System.Console.WriteLine(value:
//			$"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine(value:
//			$"{nameof(Main)} method execution completed");
//	}

//	private static void MyMethod()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(MyMethod)} method execution started");

//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			// **************************************************
//			//System.Threading.Monitor
//			//	.Enter(obj: LockedObject);

//			//Counter++;

//			//System.Threading.Monitor
//			//	.Exit(obj: LockedObject);
//			// **************************************************

//			// **************************************************
//			System.Threading.Monitor
//				.Enter(obj: LockedObject);

//			try
//			{
//				Counter++;
//			}
//			finally
//			{
//				System.Threading.Monitor
//					.Exit(obj: LockedObject);
//			}
//			// **************************************************

//			// **************************************************
//			//var lockTaken = false;

//			//System.Threading.Monitor
//			//	.Enter(obj: LockedObject, ref lockTaken);

//			//try
//			//{
//			//	Counter++;
//			//}
//			//finally
//			//{
//			//	if (lockTaken)
//			//	{
//			//		System.Threading.Monitor
//			//			.Exit(obj: LockedObject);
//			//	}
//			//}
//			// **************************************************
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(MyMethod)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (5) ************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// کدام‌یک بهتر است Performance حال می‌خواهیم ببینیم که تا این‌جای کار
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// *** Step (6) *************************************
// **************************************************
// Check Performance                              ***
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	private static int Counter = 0;

//	public static object LockedObject = new();

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		// **************************************************
//		// **************************************************
//		// **************************************************
//		var stopwatch =
//			new System.Diagnostics.Stopwatch();

//		stopwatch.Start();

//		var thread1 = new System
//			.Threading.Thread(start: MyMethod1);

//		var thread2 = new System
//			.Threading.Thread(start: MyMethod1);

//		var thread3 = new System
//			.Threading.Thread(start: MyMethod1);

//		thread1.Start();
//		thread2.Start();
//		thread3.Start();

//		thread1.Join();
//		thread2.Join();
//		thread3.Join();

//		stopwatch.Stop();

//		System.Console.WriteLine(value:
//			$"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine(value:
//			$"With using: 'Interlocked' ->" +
//			$"{System.Environment.NewLine}" +
//			$"{nameof(stopwatch.ElapsedTicks)}: {stopwatch.ElapsedTicks.ToString(format: "#,##0")}");
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		// **************************************************
//		// **************************************************
//		stopwatch =
//			new System.Diagnostics.Stopwatch();

//		stopwatch.Start();

//		var thread4 = new System
//			.Threading.Thread(start: MyMethod2);

//		var thread5 = new System
//			.Threading.Thread(start: MyMethod2);

//		var thread6 = new System
//			.Threading.Thread(start: MyMethod2);

//		thread4.Start();
//		thread5.Start();
//		thread6.Start();

//		thread4.Join();
//		thread5.Join();
//		thread6.Join();

//		stopwatch.Stop();

//		System.Console.WriteLine(value:
//			$"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine(value:
//			$"With using: 'lock()' ->" +
//			$"{System.Environment.NewLine}" +
//			$"{nameof(stopwatch.ElapsedTicks)}: {stopwatch.ElapsedTicks.ToString(format: "#,##0")}");
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		// **************************************************
//		// **************************************************
//		stopwatch =
//			new System.Diagnostics.Stopwatch();

//		stopwatch.Start();

//		var thread7 = new System
//			.Threading.Thread(start: MyMethod3);

//		var thread8 = new System
//			.Threading.Thread(start: MyMethod3);

//		var thread9 = new System
//			.Threading.Thread(start: MyMethod3);

//		thread7.Start();
//		thread8.Start();
//		thread9.Start();

//		thread7.Join();
//		thread8.Join();
//		thread9.Join();

//		stopwatch.Stop();

//		System.Console.WriteLine(value:
//			$"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine(value:
//			$"With using: 'Monitor.Enter(): Type (1)' ->" +
//			$"{System.Environment.NewLine}" +
//			$"{nameof(stopwatch.ElapsedTicks)}: {stopwatch.ElapsedTicks.ToString(format: "#,##0")}");
//		// **************************************************
//		// **************************************************
//		// **************************************************

//		// **************************************************
//		// **************************************************
//		// **************************************************
//		stopwatch =
//			new System.Diagnostics.Stopwatch();

//		stopwatch.Start();

//		var thread10 = new System
//			.Threading.Thread(start: MyMethod4);

//		var thread11 = new System
//			.Threading.Thread(start: MyMethod4);

//		var thread12 = new System
//			.Threading.Thread(start: MyMethod4);

//		thread10.Start();
//		thread11.Start();
//		thread12.Start();

//		thread10.Join();
//		thread11.Join();
//		thread12.Join();

//		stopwatch.Stop();

//		System.Console.WriteLine(value:
//			$"{nameof(Counter)}: {Counter}");

//		System.Console.WriteLine(value:
//			$"With using: 'Monitor.Enter(): Type (2)' ->" +
//			$"{System.Environment.NewLine}" +
//			$"{nameof(stopwatch.ElapsedTicks)}: {stopwatch.ElapsedTicks.ToString(format: "#,##0")}");
//		// **************************************************
//		// **************************************************
//		// **************************************************
//	}

//	private static void MyMethod1()
//	{
//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			System.Threading.Interlocked
//				.Increment(location: ref Counter);
//		}
//	}

//	private static void MyMethod2()
//	{
//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			lock (LockedObject)
//			{
//				Counter++;
//			}
//		}
//	}

//	private static void MyMethod3()
//	{
//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			System.Threading.Monitor
//				.Enter(obj: LockedObject);

//			try
//			{
//				Counter++;
//			}
//			finally
//			{
//				System.Threading.Monitor
//					.Exit(obj: LockedObject);
//			}
//		}
//	}

//	private static void MyMethod4()
//	{
//		for (var index = 1; index <= 5_000_000; index++)
//		{
//			var lockTaken = false;

//			System.Threading.Monitor.Enter
//				(obj: LockedObject, ref lockTaken);

//			try
//			{
//				Counter++;
//			}
//			finally
//			{
//				if (lockTaken)
//				{
//					System.Threading.Monitor
//						.Exit(obj: LockedObject);
//				}
//			}
//		}
//	}
//}
// **************************************************
// *** /Step (6) ************************************
// **************************************************

// **************************************************
// *** Step (7) *************************************
// **************************************************
// Advanced Topic:
//		Monitor.Wait()
//		Monitor.Pulse()
// **************************************************
//namespace Application;

//internal static class Program : object
//{
//	public static object LockedObject = new();

//	static Program()
//	{
//	}

//	private static void Main()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Main)} method execution started");

//		var thread1 = new System
//			.Threading.Thread(start: Read);

//		var thread2 = new System
//			.Threading.Thread(start: Write);

//		thread1.Start();
//		thread2.Start();

//		thread1.Join();
//		thread2.Join();

//		System.Console.WriteLine(value:
//			$"{nameof(Main)} method execution completed");
//	}
//	private static void Read()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Read)} method execution started");

//		System.Threading.Monitor
//			.Enter(obj: LockedObject);

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Threading.Monitor
//				.Pulse(obj: LockedObject);

//			System.Console.WriteLine(value:
//				$"{nameof(Read)} method: {index}");

//			System.Threading.Monitor
//				.Wait(obj: LockedObject);
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(Read)} method execution completed");
//	}

//	private static void Write()
//	{
//		System.Console.WriteLine(value:
//			$"{nameof(Write)} method execution started");

//		System.Threading.Monitor
//			.Enter(obj: LockedObject);

//		for (var index = 1; index <= 5; index++)
//		{
//			System.Threading.Monitor
//				.Pulse(obj: LockedObject);

//			System.Console.WriteLine(value:
//				$"{nameof(Write)} method: {index}");

//			System.Threading.Monitor
//				.Wait(obj: LockedObject);
//		}

//		System.Console.WriteLine(value:
//			$"{nameof(Write)} method execution completed");
//	}
//}
// **************************************************
// *** /Step (7) ************************************
// **************************************************

// **************************************************
// *** Step (8) *************************************
// **************************************************
// Advanced Topic:
//		ManualResetEvent
// **************************************************
namespace Application;

internal static class Program : object
{
	static Program()
	{
		ManualResetEvent = new System.Threading
			.ManualResetEvent(initialState: false);
	}

	private static System.Threading.ManualResetEvent ManualResetEvent { get; }

	private static void Main()
	{
		var readThread = new System
			.Threading.Thread(start: Read);

		readThread.Start();

		for (var index = 1; index <= 5; index++)
		{
			new System.Threading.Thread(start: Write).Start();
		}
	}
	private static void Read()
	{
		System.Console.WriteLine(value:
			$"{nameof(Read)} method execution started");

		ManualResetEvent.Reset(); // initialState: false

		// Reading from File...
		System.Threading.Thread.Sleep
			(millisecondsTimeout: 2_000);

		System.Console.WriteLine(value:
			$"{nameof(Read)} method execution completed");

		ManualResetEvent.Set(); // initialState: true
	}

	private static void Write()
	{
		System.Console.WriteLine(value:
			$"{nameof(Write)} method wait...");

		ManualResetEvent.WaitOne();

		// Writing to the File...

		System.Console.WriteLine(value:
			$"{nameof(Write)} method execution completed");
	}
}
// **************************************************
// *** /Step (8) ************************************
// **************************************************
