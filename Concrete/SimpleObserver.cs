using PublishSubscribeExampleWithObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishSubscribeExampleWithObserverPattern.Concrete
{
    public class SimpleObserver : MatchObserver
    {
        private string _id;
        public SimpleObserver(string id, IObservableMatch m) : base(m)
        {
            _id = id;
        }
        public override void Update()
        {
            Console.WriteLine($"observer {_id} -> Risultato: {_match.GetScore()}");
        }
    }

}
