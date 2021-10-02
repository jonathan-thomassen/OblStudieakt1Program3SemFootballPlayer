using System;

namespace OblStudieakt1Program3Sem
{
    public class FootballPlayer
    {
        private double _price;
        private string _name;
        private int _id;
        private int _shirtNumber;
        private static int _nextId = 1;

        public int Id
        {
            get => _id;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length >= 4)
                    _name = value;
                else
                    throw new ArgumentException();
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                if (value > 0.0)
                    _price = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value >= 1 && value <= 100)
                    _shirtNumber = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        public FootballPlayer()
        {
            _id = _nextId;
            _nextId++;
        }
    }
}
