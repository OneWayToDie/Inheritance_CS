using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
	public class Email :Notification
	{
		private string email;
		public Email(string email) :base()
		{
			this.email = email;
		}
		public override string Recipient
		{
			get { return email; }
			set { email = value; }
		}
		public override int MaxLength
		{
			get { return 1000; }
		}
		public override string Type
		{
			get { return "Email"; }
		}
		public override bool Send(string message)
		{
			if (!IsValidEmail(email))
			{
				Console.WriteLine("Ошибка: указан неверный адрес email");
				return false;
			}
			if (!ValidateMessage(message)) return false;
			Console.WriteLine($"Отправлен Email по адресу {Recipient}:\t\"{message}\"");
			SentCount++;
			return true;
		}
		private bool IsValidEmail(string email)
		{
			return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".") && email.Length > 4;
		}
	}
}
