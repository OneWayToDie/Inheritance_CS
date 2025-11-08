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
			Console.WriteLine($"Введите логин и пароль:");
			Notification.Login(Console.ReadLine(), Console.ReadLine());
			
			Email email = new Email($"Danila.Debilovi4@email.com");
			email.Send($"Sib The Maid - Dissociation");

			Sms sms = new Sms($"89605951826");
			sms.Send($"Darknet - Please LiveStream My Funeral");
			Sms sms_again = new Sms($"+79206121538");
			sms_again.Send($"Decalius - Loneliness");

			ID id = new ID($"user-123_profile");
			id.Send($"Sledges - June Is Better Than July");
			ID id_1 = new ID($"user-666_profile");
			id_1.Send($"DIESECT - THERE WAS NEVER LIGHT");
			ID id_2 = new ID($"user-1897_profile");
			id_2.Send($"Breaking Benjamin - Unknown Soldier");

			IP ip = new IP($"255.255.255.253");
			ip.Send($"Tekaruu - Die With A Cat");
			IP ip_1 = new IP($"255.100.0.1");
			ip_1.Send($"Sadness - You Dance Like The June Sky");
		}
	}
}
