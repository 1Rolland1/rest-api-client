using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var word = new Word();
            return View(word);
        }

        
        //public ActionResult GetWord()
        //{
        //    var word = new Word();
        //    return View(word);
        //}

        
        public ActionResult GetWord(IO.Swagger.Model.Word model, Word model2)
        {
            var api = new WordsApi();
            var word = model2._Word;
            var entity = api.ApiV2EntriesRuWordGet(word: word);
            ApplayImport(entity, model2);
                        
            return RedirectPermanent("/Words/GetWord");
        }

        private void ApplayImport(IO.Swagger.Model.Word entity, Word model2)
        {
            var db = new TimetableContext();

            db.Words.RemoveRange(db.Words);

           model2._Word = entity._Word;
            model2.Phon = entity.Meanings.Select(x=>x.PartOfSpeech).ToString();
           //model2.Phonetics.Text =  entity.Phonetics.Text; ;
            db.Words.Add(model2);
            db.SaveChanges();       
                      
        }             
    }
}
