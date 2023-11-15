using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{
    internal class Program
    {
        //Паттерн Adapter рекомендуется использовать, когда:

        // Требуется использовать уже существующий класс, но его интерфейс(набор методов) не
        //соответствует требованиям клиента.
        // Требуется создать повторно используемый класс который должен взаимодействовать с
        //классами имеющими не совместимые интерфейсы.

        static void Main(string[] args)
        {
            ITarget target = new Adapter();
            target.Request();
        }
    }
}
