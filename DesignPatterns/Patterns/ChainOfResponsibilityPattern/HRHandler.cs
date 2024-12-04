using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Of_Chain_Of_Responsibility
{
    public class HRHandler:BaseHandler
    {
        public override void HandleRequest(JopApplication application)
        {
            #region Handling 1
            //application.Comments.AppendLine("HR Comments");
            //if(_Handler!=null)
            //{
            //    _Handler.HandleRequest(application);
            //}
            //else
            //{
            //    application.Comments.AppendLine("End by Hr handler");
            //}
            #endregion
            #region Handling 2
            //if (application.JopCode=="123")
            //{
            //    application.Comments.AppendLine("HR Comments");
            //}
            //else
            //{
            //    if(_Handler!=null)
            //    {
            //        _Handler.HandleRequest(application);
            //    }
            //    else
            //    {
            //        application.Comments.AppendLine("end in hr handle");
            //    }
            //}
            #endregion
            #region Handling 3
            if (application.JopCode=="123")
            {
                application.Comments.AppendLine("Hr Comments");
                if(_Handler!=null)
                {
                    _Handler.HandleRequest(application);
                }
                else
                {
                    application.Comments.AppendLine("End in hr");
                }
            }
            else
            {
                if (_Handler != null)
                {
                    _Handler.HandleRequest(application);
                }
                else
                {
                    application.Comments.AppendLine("End in hr");
                }
            }
            #endregion

        }
    }
}
