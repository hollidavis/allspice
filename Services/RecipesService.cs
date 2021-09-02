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

    internal Recipe Get(int id){
      Recipe recipe = _repo.Get(id);
      if (recipe == null)
      {
        throw new Exception("Invalid Id");
      }
      return recipe;
    }

    internal Recipe Create(Recipe newRecipe)
    {
      return _repo.Create(newRecipe);
    }
  }
}