using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NullableReferenceTypes.Attributes
{
#nullable enable
	internal class MaybeNullWhen
	{
		private void QueueTest(MyQueue<string> q)
		{
			if (!q.TryDequeue(out var s))
			{
				// for reference types this generates a warning because of that [MaybeNullWhen(false)] aatribute - not its false so it can be null => warning
				Console.WriteLine(s.Length);
				return;
			}

			Console.WriteLine(s.Length); // Safe - now the method returns true and the type is not nullable - we are safe to do this (if that would be string? that would case warning as well)
		}

		public class MyQueue<T>
		{
			// 'result' could be null if we couldn't Dequeue it.
			// The MaybeNullWhen(bool) signifies that a parameter could be null even if the type disallows it, conditional on the bool returned value of the method.
			public bool TryDequeue([MaybeNullWhen(false)] out T result)
			{
				if (DateTime.Now.Year == 2020)
				{
					result = default;
					return false;
				}

				result = (T)new object(); //just imagine that that is some value which we obtained somewhere ... this is just to confuse the compiler
				return true;
			}
		}
	}
}
