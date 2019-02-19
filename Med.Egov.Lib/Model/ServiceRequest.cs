using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Med.Egov.Lib.Model
{
    public class ServiceRequest
    {
        private LiteEntity db = new LiteEntity();
        private Logger logger = LogManager.GetCurrentClassLogger();

        public bool createRequest(Request r)
        {
            try
            {
                db.createRequest(r);
                return true;
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
                return false;
            }
        }
    }
}
