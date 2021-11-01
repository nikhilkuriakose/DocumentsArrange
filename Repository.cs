using DocumentsArrange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsArrange
{
    public class Repository : IRepository
    {
        public List<SubDocument> SubDocuments { get; }
        public Repository()
        {
            SubDocuments = new List<SubDocument>()
            {
                new SubDocument
                {
                    DocumentId = 1,
                    DocumentNo = 100,
                    DocumentExtension = DocumentExtension.XML,
                    DocumentType = DocumentType.Invoice,
                    ParentDocumentId = null,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 2,
                    DocumentNo = 95,
                    DocumentExtension = DocumentExtension.XML,
                    DocumentType = DocumentType.CreditNote,
                    ParentDocumentId = null,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 5,
                    DocumentNo = 100,
                    DocumentExtension = DocumentExtension.XML,
                    DocumentType = DocumentType.Invoice,
                    ParentDocumentId = 3,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 6,
                    DocumentNo = 95,
                    DocumentExtension = DocumentExtension.PDF,
                    DocumentType = DocumentType.CreditNote,
                    ParentDocumentId = 4,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 7,
                    DocumentNo = 100,
                    DocumentExtension = DocumentExtension.PDF,
                    DocumentType = DocumentType.Invoice,
                    ParentDocumentId = 5,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 3,
                    DocumentNo = 100,
                    DocumentExtension = DocumentExtension.XML,
                    DocumentType = DocumentType.Invoice,
                    ParentDocumentId = 1,
                    Status = 0
                },
                new SubDocument
                {
                    DocumentId = 4,
                    DocumentNo = 95,
                    DocumentExtension = DocumentExtension.XML,
                    DocumentType = DocumentType.CreditNote,
                    ParentDocumentId = 2,
                    Status = 0
                }
            };
        }
        public List<SubDocument> GetDocuments()
        {
            return this.SubDocuments;
        }


    }
}
