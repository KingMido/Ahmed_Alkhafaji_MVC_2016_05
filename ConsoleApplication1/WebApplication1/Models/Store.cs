using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Store
    {
        public int Id { get; set; }
        [Maxlength(1)]
        //validation sätts här övanför metoden, jag har missat vad man ska göra för de skulle fungera.
        public string Name { get; set; }
        public string Address { get; set; }
        public string Products { get; set; }
        public List<Product> ProductsList { get; set; }

    }
}
