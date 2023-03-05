using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOftheFigures.Figures
{
    public class Triangle : IFigure
    {

        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        //небольшая оптимизация, если треуголник прямоугольный, то гипотенузу можно прировнять единице
        public bool IsRectangular()
        {
            if (_firstSide > _secondSide && _firstSide > _thirdSide)
                if(Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2))
                {
                    _firstSide = 1;
                    return true;
                }
            if (_secondSide > _firstSide && _secondSide > _thirdSide)
                if (Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2))
                {
                    _secondSide = 1;
                    return true;
                }
            if (_thirdSide > _firstSide && _thirdSide > _secondSide)
                if (Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2))
                {
                    _thirdSide = 1;
                    return true;
                }
            return false;
        }

        public double GetSquare()
        {
            if (IsRectangular())
            {
                //гипотенуза будет равна 1, не влияет на расчеты 
                return _firstSide * _secondSide * _thirdSide * 0.5;
            }
            else
            {
                double p = (_firstSide + _secondSide + _thirdSide) / 2;
                return Math.Round(Math.Sqrt(p * (p - _firstSide) * (p - _secondSide) * (p - _thirdSide)), 1);
            }
        }
    }
}
