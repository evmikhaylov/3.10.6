using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _3._10._6
{
	/// <summary>
	///  Класс Program
	///  основной класс программы
	///  выводящий имя, возраст, вес,
	///  баллы по предметам и средний был
	///  по центру консоли
	/// </summary>
	internal class Program
	{
		
		static void Main(string[] args)
		{

			string entered = "Введите ";
			string strName = "Ваше имя ";
			Console.SetCursorPosition((Console.WindowWidth - strName.Length - entered.Length)/2, 0);//Выравнивание по центру
			Console.WriteLine(entered + strName);
			Console.SetCursorPosition(Console.WindowWidth /2, 1);
			string name = Console.ReadLine(); // Получение имени пользователя
			

			string strAge = "Ваш возраст ";
			Console.SetCursorPosition((Console.WindowWidth - strAge.Length - entered.Length+1)/2, 2);//Выравнивание по центру
			Console.WriteLine(entered + strAge);
			Console.SetCursorPosition(Console.WindowWidth /2, 3);
			byte age = Byte.Parse(Console.ReadLine());// Получение возраста

			string strHeight = "Ваш рост ";
			Console.SetCursorPosition((Console.WindowWidth - strHeight.Length - entered.Length+1)/2, 4);//Выравнивание по центру
			Console.WriteLine(entered + strHeight);
			Console.SetCursorPosition(Console.WindowWidth /2, 5);
			float height = Single.Parse(Console.ReadLine()); // Получение роста

			string strHistory = "Ваш балл по истории ";
			Console.SetCursorPosition((Console.WindowWidth - strHistory.Length - entered.Length +1)/2, 6);//Выравнивание по центру
			Console.WriteLine(entered + strHistory);
			Console.SetCursorPosition(Console.WindowWidth/2, 7);
            float history = Single.Parse(Console.ReadLine()); // балл по истории 

			string strMath = "Ваш балл по математике ";
			Console.SetCursorPosition((Console.WindowWidth - strMath.Length - entered.Length + 1) / 2, 8);//Выравнивание по центру
			Console.WriteLine(entered + strMath);
			Console.SetCursorPosition(Console.WindowWidth/2, 9);
			float math = Single.Parse(Console.ReadLine()); // балл математики 

			string strRussian = "Ваш балл по русскому языку ";
			Console.SetCursorPosition((Console.WindowWidth - strRussian.Length - entered.Length + 1)/2, 10);//Выравнивание по центру
			Console.WriteLine(entered + strRussian);
			Console.SetCursorPosition(Console.WindowWidth/2, 11);
			float russian = Single.Parse(Console.ReadLine()); // балл Русского языка

			float average = (float)(history + math + russian) / 3 ; // Среднее значение по трём предметам
			string strAverage = "Средний балл ";
			Console.WriteLine("Нажмите Enter для продолжения");
			Console.ReadKey();
			Console.Clear();
			/*
			  Обычный ввод
			Console.WriteLine(strName + " - " + name + "\n" + strAge + " - " + age + "\n" + strHeight + " - " + height + "\n" + strHistory + " - " + history +
			"\n" + strMath + " - " + math + "\n" + strRussian + " - " + russian + "\n" + strAverage + " - " + average);

			 Интерполяция строк
			Console.WriteLine($"{strName} - {name} \n{strAge} - {age} \n{strHeight} - {height} \n{strHistory} - {history} \n{strMath} - {math} \n{strRussian} - {russian}" +
				$"\n{strAverage} - {average}");

			 Форматированный вывод
			Console.WriteLine("{0} - {1} \n{2} - {3} \n{4} - {5} \n{6} - {7} \n{8} - {9} \n{10} - {11} \n{12} - {13}",
				strName, name, strAge, age, strHeight, height, strHistory, history, strMath, math, strRussian, russian, strAverage, average);
			*/

			Console.SetCursorPosition((Console.WindowWidth - strName.Length - name.Length-1)/2, 0);//Выравнивание по центру
			Console.WriteLine(strName + name);

			Console.SetCursorPosition((Console.WindowWidth-strAge.Length - age.ToString().Length-1)/2, 1);//Выравнивание по центру
			Console.WriteLine(strAge + age);

			Console.SetCursorPosition((Console.WindowWidth - strHeight.Length - height.ToString().Length-1)/2, 2);//Выравнивание по центру
			Console.WriteLine(strHeight + height);

			Console.SetCursorPosition((Console.WindowWidth - strHistory.ToString().Length - history.ToString().Length-1)/2, 3);//Выравнивание по центру
			Console.WriteLine(strHistory + history);

			Console.SetCursorPosition((Console.WindowWidth - strMath.ToString().Length - math.ToString().Length-1)/2, 4);//Выравнивание по центру
			Console.WriteLine(strMath + math);

			Console.SetCursorPosition((Console.WindowWidth - strRussian.ToString().Length - russian.ToString().Length-1)/2, 5);//Выравнивание по центру
			Console.WriteLine(strRussian + russian);

			Console.SetCursorPosition((Console.WindowWidth - strAverage.Length - average.ToString().Length-1)/2, 6);//Выравнивание по центру
			Console.WriteLine(strAverage + average);

			Console.ReadKey();
        }
	}
}
