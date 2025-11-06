using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
	public abstract class Notification
	{
		public abstract string Recipient { get; set; }
		public abstract int MaxLength { get; }
		public abstract string Type { get; }

		public abstract bool Send(string message);
		public virtual bool ValidateMessage(string message)
		{
			return !string.IsNullOrEmpty(message) && message.Length <= MaxLength;
		}
		public int SentCount { get; protected set; }
	}
}
