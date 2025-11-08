using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
	public abstract class Notification
	{
		private static readonly string DefaultLogin = "Asphodel";
		private static readonly string DefaultPassword = "135790!@";
		private static bool isAuthenticated = false;
		public abstract string Recipient { get; set; }
		public abstract int MaxLength { get; }
		public abstract string Type { get; }

		public virtual bool Send(string message)
		{
			if (!isAuthenticated)
			{
				Console.WriteLine($"Вы не прошли аутентификацию");
			}
			if (!ValidateMessage(message))return false;

			return true;
		}
		public static bool Login(string login, string password)
		{
			if (login == DefaultLogin && password == DefaultPassword)
			{
				isAuthenticated = true;
				Console.WriteLine($"Аутентификация прошла успешно");
				return true;
			}
			Console.WriteLine($"Не верный логин или пароль");
			return false;
		}
		public static bool IsAuthenticated
		{
			get {return isAuthenticated; }
		}
		public static void logout()
		{
			isAuthenticated = false;
			Console.WriteLine($"Произведён выход из системы");
		}
		public virtual bool ValidateMessage(string message)
		{
			return !string.IsNullOrEmpty(message) && message.Length <= MaxLength;
		}
		public int SentCount { get; protected set; }
	}
}
