using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mementoPattern
{
    internal class Caretaker
    {
        private List<CarMemento> carMementos = new List<CarMemento>();

        public void AddMemento(CarMemento memento)
        {
            carMementos.Add(memento);
        }

        public CarMemento GetMemento(int index)
        {
            return carMementos[index];
        }

        public void UndoMemento()
        {
            carMementos[carMementos.Count - 1].Restore();
            carMementos.RemoveAt(carMementos.Count - 1);
        }

        public void UndoMementoToIndex(int index)
        {
            carMementos[index].Restore();
            for (int i = carMementos.Count - 1; i >= index; i--)
            {
                carMementos.RemoveAt(i);
            }
        }

        public int GetMementoCount()
        {
            return carMementos.Count;
        }
    }
}
