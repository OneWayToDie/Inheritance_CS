using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notification
{
	public class ID : Notification
	{
		private string id;
		public ID(string id) : base()
		{
			this.id = id;
		}
		public override string Recipient
		{
			get { return id; }
			set { id = value; }
		}
		public override int MaxLength
		{
			get { return 200; }
		}
		public override string Type
		{
			get { return "ID"; }
		}
		public override bool Send(string message)
		{
			if (!IsValidID(id))
			{
				Console.WriteLine("Ошибка: указан неверный ID");
				return false;
			}
			if (!ValidateMessage(message)) return false;
			Console.WriteLine($"Сообщение по номеру ID \"{Recipient}\" Отправлено: \"{message}\"");
			SentCount++;
			return true;
		}
		private bool IsValidID(string id)
		{
			string TypeID_1 = @"^user-\d{3}_profile$";
			string TypeID_2 = @"^user-\d{4}_profile$";
			string TypeID_3 = @"^user-\d{5}_profile$";
			return Regex.IsMatch(id, TypeID_1) || Regex.IsMatch(id, TypeID_2) || Regex.IsMatch(id, TypeID_3);
		}
	}
}
