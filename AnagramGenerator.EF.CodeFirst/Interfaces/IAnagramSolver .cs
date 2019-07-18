﻿using AnagramGenerator.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramGenerator.EF.CodeFirst.Interfaces
{
    public interface IAnagramSolver
    {
      /*   IList<string> GetAnagrams(string myWords);*/
        IList<WordModel> GetAnagramsSeperated(string myWords);
    }
}
