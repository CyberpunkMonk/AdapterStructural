using System;

namespace AdapterStructural {
	/// <summary>
	/// The "Target" class
	/// </summary>
	class Target {
		public virtual void Request() {
			Console.WriteLine("Called Target Request()");
		}
	}
}
