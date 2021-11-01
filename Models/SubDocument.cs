using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsArrange.Models
{
    public class SubDocument
    {
        public int DocumentId { get; set; }
        public byte Status { get; set; }
        public int DocumentNo { get; set; }
        public int? ParentDocumentId { get; set; }
        public DocumentType DocumentType { get; set; }
        public DocumentExtension DocumentExtension { get; set; }

    }
}
