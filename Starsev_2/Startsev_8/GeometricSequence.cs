using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startsev_8
{
    class GeometricSequence
    {
        private double beginElement;
        private double step;

        public GeometricSequence() // конструктор
        {
            this.beginElement = Math.PI;
            this.step = Math.E;
        }

        public GeometricSequence(double beginElement, double step)// перегруженный
        {
            this.beginElement = beginElement;
            this.step = step;
        }

        public bool IsDescending// проверка на убываемость
        {
           
            get
            {
                if (step >= 0)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        public string InstanseInfo()// инфа про элементы
        {
            return ($"beginElement = {beginElement} /n step = {step}");
        }
          
    }
}
