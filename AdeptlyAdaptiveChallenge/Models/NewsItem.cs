using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptlyAdaptiveChallenge.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public String Category { get; set; }
        public String Headline { get; set; }
        public String Subhead { get; set; }
        public String DateLine { get; set; }
        public String Image { get; set; }
    }
}
