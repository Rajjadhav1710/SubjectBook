using Microsoft.AspNetCore.Mvc;
using SubjectBook.data;
using SubjectBook.Models;
using System.Collections.Generic;

namespace SubjectBook.Controllers{
    public class SubjectController : Controller{
        private readonly ApplicationDbContext _db;

        public SubjectController(ApplicationDbContext db){
            _db=db;
        }

        //create
        //get
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        //post
        [HttpPost]
        public IActionResult Create([Bind("subjectID,subjectName,subjectSyllabus,subjectCredits")]Subject subject){

            _db.Subject.Add(subject);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        //read
        //get
        public IActionResult Index(){
            IEnumerable<Subject> listofsubjects=_db.Subject;
            return View(listofsubjects);
        }

        //update
        //get
        [HttpGet]
        public IActionResult Edit(int subjectID){
            Subject subject=_db.Subject.Find(subjectID);
            return View(subject);
        }
        //post
        [HttpPost]
        public IActionResult Edit([Bind("subjectID,subjectName,subjectSyllabus,subjectCredits")]Subject subject){
            _db.Subject.Update(subject);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //delete
        //get
        [HttpGet]
        public IActionResult Delete(int subjectID){
            Subject subject=_db.Subject.Find(subjectID);

            _db.Subject.Remove(subject);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}