using System;
using Events;

namespace Evento
{
    public class AgendaEventArgs : EventArgs
    {
        public Agenda Agenda { get; set; }
    }
}