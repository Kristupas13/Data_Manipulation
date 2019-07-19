﻿using AnagramGenerator.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnagramGenerator.EF.CodeFirst.Services;
using AnagramGenerator.EF.CodeFirst.Interfaces;
using AnagramGenerator.EF.CodeFirst.Models;

namespace AnagramGenerator.WebApp.Services
{
    public class RequestService : IRequestService
    {
        private readonly IAnagramSolver _anagramSolver;
        private readonly IManagerRepository _managerRepository;
        private readonly ICacheRepository _cacheRepository;
        public RequestService(IAnagramSolver anagramSolver, IManagerRepository managerRepository, ICacheRepository cacheRepository)
        {
            _anagramSolver = anagramSolver;
            _managerRepository = managerRepository;
            _cacheRepository = cacheRepository;
        }
        public IList<string> DetectAnagrams(string requestWord)
        {
            IList<string> words =  _anagramSolver.GetAnagramsSeperated(requestWord);

            return words;
        }

        public void TruncateTable(string tableName)
        {
            _managerRepository.TruncateTable(tableName);
        }
        public IList<string> GetAnagramsFromCache(string word)
        {

            IList<string> words = _cacheRepository.GetAll().Where(p => p.Request.Word == word).Select(p => p.Anagram.Word).ToList();

            return words;
        }

    }
}
