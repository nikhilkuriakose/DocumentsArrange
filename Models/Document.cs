using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsArrange.Models
{
    public class Document
    {
        public int DocumentNumber { get; set; }
        public DocumentType DocumentType { get; set; }
        public DocumentExtension DocumentExtension { get; set; }
        public int LastAddedDocument { get; set; }
        public byte Status { get; set; }
        public List<SubDocument> SubDocuments { get; set; }
    }
}
