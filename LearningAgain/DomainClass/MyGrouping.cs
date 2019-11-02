using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAgain.DomainClass
{
    public class MyGrouping<TKey, TElement> : List<TElement>, IGrouping<TKey, TElement>
    {
        public TKey Key
        {
            get;
            set;
        }
        public TElement element
        {
            get;
            set;
        }
    }
}
