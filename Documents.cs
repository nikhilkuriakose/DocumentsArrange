using DocumentsArrange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsArrange
{
    public class Documents : IDocuments
    {
        public List<Document> DocumentsList { get; private set; }

        public Documents()
        {
            DocumentsList = new List<Document>();
        }
        public bool AddChildDocumentToParent(SubDocument subDocument, Document document)
        {
            if (subDocument != null && document != null)
            {
                document.SubDocuments.Add(subDocument);
                document.Status = subDocument.Status;
                document.DocumentType = subDocument.DocumentType;
                document.DocumentExtension = subDocument.DocumentExtension;
                document.LastAddedDocument = subDocument.DocumentId;
                return true;
            }
            return false;
        }

        public bool AddNewNodeToDocuments(SubDocument subDocument)
        {
            if (subDocument != null)
            {
                Document document = new Document();
                document.SubDocuments = new List<SubDocument>();
                document.SubDocuments.Add(subDocument);
                document.Status = subDocument.Status;
                document.DocumentType = subDocument.DocumentType;
                document.DocumentNumber = subDocument.DocumentNo;
                document.DocumentExtension = subDocument.DocumentExtension;
                document.LastAddedDocument = subDocument.DocumentId;
                DocumentsList.Add(document);
                return true;
            }
            return false;
        }

        public Document FindParentDocument(int? parentDocumentID)
        {
            return this.DocumentsList == null && parentDocumentID == null? null:
            this.DocumentsList.Find(x => x.LastAddedDocument == parentDocumentID);
        }

        public List<Document> GetDocuments()
        {
            return DocumentsList;
        }

        public List<SubDocument> GetSubDocuments(Document document)
        {
            return document.SubDocuments;
        }
    }
}
