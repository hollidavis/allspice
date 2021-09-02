using System;
using System.Collections.Generic;
using allspice.Models;
using allspice.Repositories;

namespace allspice.Services
{
  public class RecipesService
  {
        private readonly RecipesRepository _repo;
        public RecipesService(RecipesRepository repo){
            _repo = repo;
        }
        internal List<Recipe> Get(){
            return _repo.Get();
        }
  }
}