using PublishSubscribeExampleWithObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishSubscribeExampleWithObserverPattern.Concrete
{
    public class LogObserver : MatchObserver
    {
        private List<string> _history;
        public LogObserver(IObservableMatch m) : base(m)
        {
            _history = new List<string>();
        }
        public override void Update()
        {
            this._history.Add($"{DateTime.Now} aggoirnamento risultato: {_match.GetScore()}");
        }

        public void PrintHistory()
        {
            foreach(var log in _history)
            {
                Console.WriteLine(log);
            }
        }
    }
}
