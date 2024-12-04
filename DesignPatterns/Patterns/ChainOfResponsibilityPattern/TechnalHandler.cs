using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Chain_Of_Responsibility
{
    public class TechnalHandler:BaseHandler
    {
        public void tonext(JopApplication app)
        {
            if(_Handler!=null)
            {
                _Handler.HandleRequest(app);
            }
            else
            {
                app.Comments.AppendLine("End in Tech");
            }
        }
        public override void HandleRequest(JopApplication jop)
        {
            #region Handling 1
            //jop.Comments.AppendLine("Technical Comments");

            //if(_Handler!=null)
            //{
            //    _Handler.HandleRequest(jop);
            //}
            //else
            //{
            //    jop.Comments.AppendLine("End By Tech Handler");
            //}
            #endregion
            #region Handling 2
            //if (jop.JopCode == "000")
            //{
            //    jop.Comments.AppendLine("Technical Comments");
            //}
            //else
            //{
            //    if (_Handler != null)
            //    {
            //        _Handler.HandleRequest(jop);
            //    }
            //    else
            //    {
            //        jop.Comments.AppendLine("End By Tech Handler");
            //    }
            //}
            #endregion
            if(jop.JopCode=="000")
            {
                jop.Comments.AppendLine("Tech Comment");
                tonext(jop);
            }
            else
            {
                tonext(jop);
            }
            
        }
    }
}
