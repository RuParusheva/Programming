using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Popcorn
{
    public interface IObjectProducer
    {
        IEnumerable<GameObject> ProduceObjects();
    }
}
