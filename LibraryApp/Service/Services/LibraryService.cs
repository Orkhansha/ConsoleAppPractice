
using Domain.Models;
using Repository.Repostories;
using Service.Services.Interfaces;
using System.Collections.Generic;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private LibraryRepository _libraryRepository;
        private int _count;
        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }
        public Library Create(Library library)
        {
            library.Id = _count;
            _libraryRepository.Create(library);
            _count++;
            return library;
        }

        public void Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Library> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Library GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public Library Update(int Id, Library library)
        {
            throw new System.NotImplementedException();
        }
    }
}
