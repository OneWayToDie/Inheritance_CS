using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notification
{
	internal class IP :Notification
	{
		private string ip;
		public IP(string ip) : base()
		{
			this.ip = ip;
		}
		public override string Recipient
		{
			get { return ip; }
			set { ip = value; }
		}
		public override int MaxLength
		{
			get { return 150; }
		}
		public override string Type
		{
			get { return "IP"; }
		}
		public override bool Send(string message)
		{
			if (!IsValidIP(ip))
			{
				Console.WriteLine("Ошибка: указан неверный IP");
				return false;
			}
			if (!ValidateMessage(message)) return false;
			Console.WriteLine($"Сообщение по номеру IP \"{Recipient}\" отправлено: \"{message}\"");
			SentCount++;
			return true;
		}
		private bool IsValidIP(string ip)
		{
			string TypeIP = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";   
			//(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3} - {3} означает повторение этого участка три раза, ибо айпи с точкой пишется 3 раза, а другая половина - всё тоже самое, но без точки, и она делается один раз
			//25[0-5] - диапазон от 250 до 255, 2[0-4][0-9] - диапазон от 200 до 249,  [01]?[0-9][0-9] - задаётся диапазон от 0 до 199
			return Regex.IsMatch(ip, TypeIP);
		}
	}
}
