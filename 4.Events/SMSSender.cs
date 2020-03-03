using System;
using Evento;

namespace Events
{
    public class SMSSender
    {
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            System.Console.WriteLine($"SMS was send - '{e.Agenda.AgendaDate}' ");
        }
         public void OnAddedAgenda2(object o, AgendaEventArgs e)
        {
            System.Console.WriteLine($"SMS was send - '{e.Agenda.AgendaName}' ");
        }
    } 
}