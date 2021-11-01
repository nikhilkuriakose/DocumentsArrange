using DocumentsArrange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsArrange
{
    public class IntermediateDocuments : IIntermediateDocuments
    {
        private readonly IRepository _repository;
        public IntermediateDocuments(IRepository repository)
        {
            _repository = repository;
        }
        public List<SubDocument> GetDocuments()
        {
            return _repository.GetDocuments();
        }

        public List<SubDocument> GetDocumentsInSorted(List<SubDocument> subDocuments)
        {
            subDocuments.Sort((x, y) => x.DocumentId.CompareTo(y.DocumentId));
            return subDocuments;
        }
    }
}
