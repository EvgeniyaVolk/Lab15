using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        interface ISeries
        {
            void setStart(int x);//Устанавливает начальное значение
            int getNext();//Возвращает следующее число ряда
            void reset();//Выполняет сброс к начальному значению
        }
        class ArithProgression : ISeries
        {
            public void setStart(int x)
            {
                throw new NotImplementedException();
            }
            public int getNext()
            {
                throw new NotImplementedException();
            }

            public void reset()
            {
                throw new NotImplementedException();
            }

           
        }
        class GeomProgression : ISeries
        {
            public void setStart(int x)
            {
                throw new NotImplementedException();
            }
            public int getNext()
            {
                throw new NotImplementedException();
            }

            public void reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
