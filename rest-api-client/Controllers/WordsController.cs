using System;
using System.Linq;
using System.Web.Mvc;
using IO.Swagger.Api;
using rest_api_client.Models;

namespace rest_api_client.Controllers
{
    public class WordsController: Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var words = new ViewWord();            
            return View(words);
        }     
                
        public ActionResult GetWord(Word model)
        {
            var api = new WordsApi();
            var word = model._Word;
            var word_ex = "Ошибка";
            var entity = api.WordGet(word: word_ex);
            if (word == null)
                ModelState.AddModelError("_Word", "Заполните поле ввода");
            
            try
            {
                entity = api.WordGet(word: word);
            }
            catch (Exception)
            {
                ModelState.AddModelError("_Word", "К сожалению данного слова нет в словаре");                                
            }
                        
            var result = ConvertInfo(entity);

            return View("Info", result);
        }
        private Word ConvertInfo(IO.Swagger.Model.Words entity)
        {
            var word = entity.First();
            var def = word.Meanings.SelectMany(x => x.Definitions).Select(x=> x.Definition).Distinct().ToList();
            return new Word()
            {
                _Word = word._Word,
                Defenitons = def
            };
        }
        
    }
}
