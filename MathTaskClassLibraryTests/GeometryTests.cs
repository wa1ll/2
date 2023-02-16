using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibrary;
using System.Collections.Generic;

namespace MathTaskClassLibraryTests
{
	[TestClass]
	public class GeometryTests
	{
		[TestMethod]
		public void Test1() // Тестирование пустого набора данных 
		{
			// исходные данные
			List<double> l = new List<double>() { };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Последовательность пуста", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test2() // Единичный набор /  Слишком короткий набор
		{
			// исходные данные
			List<double> l = new List<double>() { 1, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Единичная последовательность", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test3() // Единичный набор /  Слишком короткий набор
		{
			// исходные данные
			List<double> l = new List<double>() { -3, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Единичная последовательность", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test4() // Тестирование минимально возможной длинны
		{
			// исходные данные
			List<double> l = new List<double>() { 2, 7, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Введена максимально короткая последовательность. Минимальный элемент равен 2. Максимальный элемент равен 7", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test5() // Тестирование минимально возможной длинны
		{
			// исходные данные
			List<double> l = new List<double>() { -5, -7, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Введена максимально короткая последовательность. Минимальный элемент равен -7. Максимальный элемент равен -5", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test6() // Тестирование минимально возможной длинны
		{
			// исходные данные
			List<double> l = new List<double>() { 1, 1, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Введена максимально короткая последовательность. В последовательности отсутствуют минимальные и максимальные элементы", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test7() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 7, 3, 1, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 10; Наименьших: 4", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test8() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { -3, -2, -4, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: -5; Наименьших: -7", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test9() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 5, -1, 2, -3, 4, 7, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 12; Наименьших: -4", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test10() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { -4, -1, 7, 2, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 9; Наименьших: -5", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test11() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 3, -2, 4, -3, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 7; Наименьших: -5", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test12() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 1, 1, 1, 1, 1, 1, 1, 1, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("В последовательности отсутствуют минимальные и максимальные элементы", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test13() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { -5, 4, 2, -6, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 6; Наименьших: -11", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test14() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 2, -2, -7, -9, -6, -7, -1, 4, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 6; Наименьших: -16", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test15() // Тестирование нормального набора данных
		{
			// исходные данные
			List<double> l = new List<double>() { 2, -1, 2, 9, -5, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 11; Наименьших: -6", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test16() // Тестирование нормального набора данных  (с вещественными)
		{
			// исходные данные
			List<double> l = new List<double>() { 0.555, 3, 5, 2.00055, 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Наибольших: 8; Наименьших: 2,55555", actual); // первое - ожидаемый, второе - фактический
		}

		[TestMethod]
		public void Test17() // Нулевое значение
		{
			// исходные данные
			List<double> l = new List<double>() { 0 };

			// получение значения с помощью тестируемого метода
			Geometry g = new Geometry();
			string actual = g.Func(l); // Результат работы Func

			// сравнение ожидаемого результата с полученным
			Assert.AreEqual("Последовательность пуста", actual); // первое - ожидаемый, второе - фактический
		}
	}
}