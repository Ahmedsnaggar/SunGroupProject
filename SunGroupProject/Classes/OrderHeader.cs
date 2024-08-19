using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGroupProject.Classes
{
    public class OrderHeader
    {

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Customer { get; set; }

        public List<OrderDetails> details = new List<OrderDetails>();
        public IEnumerator<OrderDetails> GetEnumerator()
        {
            return details.GetEnumerator();
        }
    }
}
