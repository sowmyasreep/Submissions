
using System;

using System.Collections.Generic;

using System.Linq;

using System.Web;

using System.Web.Mvc;

using Question_02.Models;

using Question_02.Models.Repository;
 
namespace Question_02.Controllers

{

    public class MoviesController : Controller

    {

        IRepository<Movie> _repository = null;

        public MoviesController()

        {

            _repository = new Repository<Movie>();

        }

        // GET: Movies

        public ActionResult Index()

        {

            var movie = _repository.GetAll();

            return View(movie);

        }

        public ActionResult Create()

        {

            return View();

        }

        [HttpPost]

        public ActionResult Create(Movie movie)

        {

            if (ModelState.IsValid)

            {

                _repository.Insert(movie);

                _repository.Save();

                return RedirectToAction("Index");

            }

            else

            {

                return View(movie);

            }

        }

        public ActionResult Edit(int Mid)

        {

            var movie = _repository.GetById(Mid);

            return View(movie);

        }

        [HttpPost]

        public ActionResult Edit(Movie m)

        {

            if (ModelState.IsValid)

            {

                _repository.Update(m);

                _repository.Save();

                return RedirectToAction("Index");

            }

            else

            {

                return View(m);

            }

        }

        public ActionResult Details(int Mid)

        {

            var movie = _repository.GetById(Mid);

            return View(movie);

        }

        public ActionResult Delete(int Mid)

        {

            var movie = _repository.GetById(Mid);

            return View(movie);

        }

        [HttpPost]

        [ActionName("Delete")]

        public ActionResult DeletePost(int Mid)

        {

            var movie = _repository.GetById(Mid);

            _repository.Delete(Mid);

            _repository.Save();

            return RedirectToAction("Index");

        }

        public ActionResult MoviesByYear()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MoviesByYear(int? year)
        {
            if (year.HasValue)
            {
                var movies = _repository.GetAll().Where(m => m.DateofRelease.Year == year.Value).ToList();
                ViewBag.Movies = movies;
                ViewBag.SelectedYear = year.Value;
            }

            return View("MoviesByYear");
        }
    }

}