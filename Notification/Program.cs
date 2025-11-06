using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Email email = new Email($"Danila.Debilovi4@email.com");
			email.Send($"Sib the maid - Dissociation");

			Sms sms = new Sms($"89605951826");
			sms.Send($"Please LiveStream My Funeral");
		}
	}
}
