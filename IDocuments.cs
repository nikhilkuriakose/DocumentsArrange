using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentsArrange.Models;

namespace DocumentsArrange
{
    public interface IDocuments
    {
        public Document FindParentDocument(int? parentDocumentID);
        public bool AddChildDocumentToParent(SubDocument subDocument, Document document);
        public bool AddNewNodeToDocuments(SubDocument subDocument);
        public List<Document> GetDocuments();
        public List<SubDocument> GetSubDocuments(Document document);
    }
}
