using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Notification
{
	public class Sms : Notification
	{
		private string phoneNumber;
		public Sms(string phoneNumber) :base()
		{
			this.phoneNumber = phoneNumber;
		}
		public override string Recipient 
		{
			get { return phoneNumber; }
			set { phoneNumber = value; }
		}
		public override int MaxLength
		{
			get { return 160; }
		}
		public override string Type
		{
			get { return "SMS"; }
		}
		public override bool Send(string message)
		{
			if (!IsValidNumberPhone(phoneNumber))
			{
				Console.WriteLine("Ошибка: указан неверный номер телефона");
				return false;
			}
			if (!ValidateMessage(message)) return false;
			Console.WriteLine($"Отправляем SMS на {Recipient}: \"{message}\"");
			SentCount++;
			return true;
		}
		private bool IsValidNumberPhone(string phoneNumber)
		{
			//return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.Contains("+") && (phoneNumber.Contains("7") || phoneNumber.Contains("8")) && phoneNumber.Length <= 12 && phoneNumber.Length >= 11;
			string WithPlus = @"^\+7\d{10}$";	//Для записи начинающейся с +7
			// ^ - начало строки, +7 - то с чего должен начинаться номер, \d - Цифра от 0 до 9, {10} - цикл из 10 повторений для \d
			string WithoutPlus = @"^[8]\d{10}$";
			return Regex.IsMatch(phoneNumber, WithPlus) || Regex.IsMatch(phoneNumber, WithoutPlus);
			//Regex - regular expression, необходим для валидации email, номеров и паролей. Инструмент для работы со строками, который находит точные слова, подходящие под опрдеделённый вид
			//IsMatch - метод класса Regex, проверяет соответсвие строки к заданному шаблону 
		}
	}
}
