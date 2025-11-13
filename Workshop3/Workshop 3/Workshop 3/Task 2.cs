using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;
            string message = (username == null) ? "Username is not available" : username;
            Console.WriteLine(message);

            string result = username ?? "No username found";
            Console.WriteLine($"Null-Coalescing Check: {result}");

            username ??= "Shristi"; // assigns only if username is null
            Console.WriteLine($"The updated name of username is {username}");
        }
    }
}
