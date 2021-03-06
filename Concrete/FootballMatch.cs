using PublishSubscribeExampleWithObserverPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublishSubscribeExampleWithObserverPattern.Concrete
{
    public class FootballMatch : IObservableMatch
    {
        private List<MatchObserver> _observers;
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Points1 { get; set; }
        public int Points2 { get; set; }
        public int Minute { get; set; }

        public FootballMatch(string t1, string t2)
        {
            _observers = new List<MatchObserver>();
            Team1 = t1;
            Team2 = t2;
        }
        public void UpdateScore(int minuto, int p1, int p2)
        {
            Minute = minuto;
            Points1 = p1;
            Points2 = p2;
            Notify();
        }
        public void Attach(MatchObserver a)
        {
            this._observers.Add(a);
            a.Update();
        }

        public void Detach(MatchObserver d)
        {
            this._observers.Remove(d);
        }

        public string GetScore()
        {
            return string.Format("{0}' => {1} - {2} = {3} - {4}", Minute, Team1, Team2, Points1, Points2);
        }

        public void Notify()
        {
            foreach(var o in _observers)
            {
                o.Update();
            }
        }
    }
}
