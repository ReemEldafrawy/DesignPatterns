using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Chain_Of_Responsibility
{
    public class JopApplication
    {

public string ApplicantName { get; set; }
        public string JopTitle { get; set; }
        public string JopCode {  get; set; }
        public StringBuilder Comments { get; set; }
        public string ShowComments()
        {
            return Comments.ToString();
        }















    }
}
