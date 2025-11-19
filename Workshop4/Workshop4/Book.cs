using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    public record Book(string title, string author, double price)
    {
        public override string ToString()
        {
            return $"Title: {title}\nAuthor: {author}\nPrice: {price}";
        }
    }
}
