using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Adapter
{

    //Цель: Формирует требуемый клиенту интерфейс (набор имен методов).
    public interface ITarget
    {
        void Request();
    }

    //Адаптируемый: Содержит интерфейс (набор методов) требующий адаптации.
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("SpecificRequest");
        }
    }

    //Адаптер: Адаптирует интерфейс Adaptee к интерфейсу Target.

    //Адаптирует интерфейс Adaptee к интерфейсу ITarget, делегируя ответственность за выполнение
    //операций(методов) конкретному классу Adaptee.

    // Позволяет классу Adapter переопределить или заместить некоторые операции из базового класса
    //Adaptee.

    // Оставляет возможность создания только одного экземпляра класса Adapter. Так как Adapter
    //наследуется от Adaptee, то не придётся отдельно создавать экземпляр Adaptee внутри класса
    //Adapter.
    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
