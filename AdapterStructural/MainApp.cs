using System;

namespace AdapterStructural {
	/// <summary>
	/// MainApp startup class for Structural Adapter Design Pattern
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			//Create adapter and place a request
			Target target = new Adapter();
			target.Request();
			//Wait for user
			Console.ReadKey();
		}
	}
}