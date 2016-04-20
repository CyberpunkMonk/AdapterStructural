using System;

namespace AdapterStructural {
	/// <summary>
	/// The "Adapter" class
	/// </summary>
	/// <seealso cref="AdapterStructural.Target" />
	class Adapter:Target{
		private Adaptee _adaptee = new Adaptee();
		public override void Request() {
			//possibly do some other work
			//and the call SpecificRequest
			_adaptee.SpecificRequest();
		}
	}
}
