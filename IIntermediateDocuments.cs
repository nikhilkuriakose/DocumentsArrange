using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsArrange.Models;

namespace DocumentsArrange
{
    public interface IIntermediateDocuments
    {
        public List<SubDocument> GetDocuments();
        public List<SubDocument> GetDocumentsInSorted(List<SubDocument> subDocuments);
    }
}
