

using System;
using System.Threading;
using Events;

namespace Evento
{
    public class AgendaManager
    {
        public delegate void AddedAgendaEventHandler(object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        //EventHandler
        //EventHandler<TEventArgs>
        public event EventHandler<AgendaEventArgs> AddedAgenda2;

        //Event publisher should be:
        //1. protected
        //2.virtual
        //3.void
        //4.Name start with "On"
        //Example
        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            //if(AddedAgenda != null && newAgenda != null)
            AddedAgenda(this,new AgendaEventArgs() {Agenda = newAgenda});
        }
        protected virtual void OnAddedAgenda2(Agenda newAgenda)
        {
            //if(AddedAgenda != null && newAgenda != null)
            AddedAgenda2(this,new AgendaEventArgs() {Agenda = newAgenda});
        }
        public void AddAgenda(Agenda newAgenda)
        {
            System.Console.WriteLine($"...");
            Thread.Sleep(3000);
            OnAddedAgenda(newAgenda);
            OnAddedAgenda2(newAgenda);
            System.Console.WriteLine($"...koniec");
        }
    }
}