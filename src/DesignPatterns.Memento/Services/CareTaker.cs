using DesignPatterns.Memento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento.Services
{
    public class CareTaker<T>
    {
        private readonly IList<Memento<T>> _histories;
        private int _lastIndex;

        public CareTaker()
        {
            _histories = new List<Memento<T>>();
            _lastIndex = -1;
        }

        public void Add(Memento<T> memento)
        {
            Destroy();
            _histories.Add(memento);
            _lastIndex+=1;
        }

        public Memento<T> Undo()
        {
            return _histories[--_lastIndex];
        }

        public Memento<T> Redo()
        {
            return _histories[++_lastIndex];
        }

        private void Destroy()
        {
            if (_lastIndex < _histories.Count-1)
            {
                for (int i = _histories.Count-1; i > _lastIndex; i--)
                {
                    _histories.RemoveAt(i);
                }
            }
        }
    }
}
