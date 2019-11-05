using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Outline.Models
{
    public class Template
    {
        public static int IncrementalID = 0;
        public int ID { get; set; }
        public string Name { get; set; }

        public List<string> fields { get; set; }
        public Template(string name)
        {
            this.ID = IncrementalID;
            this.Name = name;
            IncrementalID++;
            this.fields = new List<string>();
        }
    }

}
