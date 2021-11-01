using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsArrange.Models;

namespace DocumentsArrange
{
    public interface IRepository
    {
        public List<SubDocument> GetDocuments();
    }
}
