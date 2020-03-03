using System;
using Evento;
using Events;

namespace _4.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaManager am = new AgendaManager();
            SMSSender sms = new SMSSender();

            am.AddedAgenda += sms.OnAddedAgenda;
            am.AddedAgenda2 += sms.OnAddedAgenda2;

            am.AddAgenda(new Agenda()
            {
                AgendaDate = DateTime.Now.AddDays(2),
                AgendaName = "Test"
            });


            Console.ReadKey();
        }
    }
}
