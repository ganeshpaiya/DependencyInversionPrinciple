using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
   public class Intimation: ISendIntimation//low 
    {
        public string TO { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public void sendintimation()
        {
            Console.WriteLine("Email Send Successfully");
        }
    }

    public interface ISendIntimation
    {
        public void sendintimation();
    }
}
