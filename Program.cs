using System;
using Unity;
using DocumentsArrange.Models;
using System.Collections.Generic;

namespace DocumentsArrange
{
    class Program
    {
        private readonly IRepository _repository;
        private readonly IIntermediateDocuments _intermediateDocuments;
        private readonly IDocuments _documents;
        public Program(IRepository repository, IIntermediateDocuments intermediateDocuments, IDocuments documents)
        {
            _repository = repository;
            _intermediateDocuments = intermediateDocuments;
            _documents = documents;
        }
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRepository, Repository>();
            container.RegisterType<IIntermediateDocuments, IntermediateDocuments>();
            container.RegisterType<IDocuments, Documents>();
            Program program = container.Resolve<Program>();
            program.Demo();
        }

        void Demo()
        {
            List<SubDocument> intermediateDocumentsList = _intermediateDocuments.GetDocuments();
            intermediateDocumentsList = _intermediateDocuments.GetDocumentsInSorted(intermediateDocumentsList);
            foreach (var item in intermediateDocumentsList)
            {
                Document document = _documents.FindParentDocument(item.ParentDocumentId);
                if (document != null)
                    _documents.AddChildDocumentToParent(item, document);
                else
                    _documents.AddNewNodeToDocuments(item);
            }
            foreach (var item in _documents.GetDocuments())
            {
                Console.WriteLine("*********************************");
                Console.WriteLine($"Document No -{item.DocumentNumber}");
                Console.WriteLine($"Document Id - {item.LastAddedDocument}");
                Console.WriteLine($"Document Type - {item.DocumentType}");
                Console.WriteLine("-----------------------------------------");

                foreach (var subItem in item.SubDocuments)
                {
                    Console.WriteLine($"Sub Document Id: {subItem.DocumentId}");
                }
            }
        }
    }
}
