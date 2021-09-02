using System;
using System.Collections.Generic;
using allspice.Models;
using allspice.Services;
using Microsoft.AspNetCore.Mvc;

namespace allspice.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class RecipesController : ControllerBase{
        private readonly RecipesService _recipesService;
        public RecipesController(RecipesService recipesService){
            _recipesService = recipesService;
        }

        [HttpGet]
        public ActionResult<List<Recipe>> Get(){
            try
            {
                List<Recipe> recipes = _recipesService.Get();
                return Ok(recipes);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Recipe> Get(int id){
            try{
                Recipe recipe = _recipesService.Get(id);
                return Ok(recipe);
            } catch (Exception err){
                return BadRequest(err.Message);
            }
        }
    }
}