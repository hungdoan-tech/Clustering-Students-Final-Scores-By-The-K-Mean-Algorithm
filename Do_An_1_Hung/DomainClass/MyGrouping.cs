using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_1.DomainClass
{
    [NotMapped]
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
