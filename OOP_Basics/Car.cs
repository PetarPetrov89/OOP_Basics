using System;
using System.Collections.Generic;
using System.Text;

//Класа е рецепта, може да се призползва. Обекта е ястието.

namespace OOP_Basics
{
    class Car
    {
		private string _model;
		private string _make;
		private DateTime _dateCreated;
		private int _hp;

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}
		
		public string Make
		{
			get { return _make; }
			set { _make = value; }
		}
	
		public int HP
		{
			get { return _hp; }
			set { _hp = value; }
		}

		public DateTime dateCreated
		{
			get { return _dateCreated; }
			set { _dateCreated = value; }
		}

		public string Race(Car car)
		{
			if (_hp < car.HP)
			{
				return $"{car.Make} has won!";
			}
			else
			{
				return $"{Make} has won!";
			}
		}

		public static Car GetCarFromDB(int ID)
		{
			Car car = new Car();

			car.Model = "Fiat";
			car.HP = 125;

			return car;
		}
	}
}
