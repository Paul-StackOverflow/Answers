using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDPrototypes.Ans34612672Files
{
    public class Ans34883361
    {
        SampleCollection<Sampler> _inputs = new SampleCollection<Sampler>();
        public T GetSensorValue<T>(InPort port)
        {
            return (T)_inputs[port].GetValue();
        }
    }

    internal class Sampler
    {
        internal object GetValue()
        {
            throw new NotImplementedException();
        }
    }

    public enum InPort
    {
        None
    }
    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer, which will allow client code
        // to use [] notation on the class instance itself.
        // (See line 2 of code in Main below.)        
        public T this[InPort i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                return arr[Array.IndexOf(Enum.GetValues(i.GetType()), i)];
            }
            set
            {
                arr[Array.IndexOf(Enum.GetValues(i.GetType()), i)] = value;
            }
        }
    }

}
