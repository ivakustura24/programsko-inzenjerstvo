using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleLogic
{
    public class Title
    {

        public string Id { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }   
        public string PublisherId { get; set; }
        public DateTime PublishDate { get; set; }  

        public Title()
        {

        }
    }
}
