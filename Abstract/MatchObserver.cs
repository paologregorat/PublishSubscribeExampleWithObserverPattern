using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishSubscribeExampleWithObserverPattern.Abstract
{
    public abstract class MatchObserver
    {
        protected IObservableMatch _match;
        public MatchObserver(IObservableMatch match)
        {
            _match = match;
        }
        public abstract void Update();
    }
}
