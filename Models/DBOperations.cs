using System.Collections.Generic;
using System.Linq;

namespace Emamzadeh.Models
{
    public class DBOperations
    {
        private readonly EMContext _emcontext;
        public DBOperations(EMContext eMContext)
        {
            _emcontext = eMContext;
        }
        public List<History> HistoryList()
        {
            return _emcontext.Histories.ToList();
        }
    }
}
