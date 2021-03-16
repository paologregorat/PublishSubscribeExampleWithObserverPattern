using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishSubscribeExampleWithObserverPattern.Abstract
{
    public interface IObservableMatch
    {
        public void Attach(MatchObserver a);
        public void Detach(MatchObserver d);
        public void Notify();
        public string GetScore();
    }
}
