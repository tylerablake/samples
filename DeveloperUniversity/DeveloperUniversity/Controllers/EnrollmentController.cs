using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DeveloperUniversity.Models;
using DeveloperUniversity.Models.ViewModels.Enrollment;

namespace DeveloperUniversity.Controllers
{
    [Authorize]
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: Enrollment
        public ActionResult Index()
        {
            var enrollment = db.Enrollments.Include(e => e.Course).Include(e => e.Student);
            
            return View(enrollment.ToList());
        }

        // GET: Enrollment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // GET: Enrollment/Create
        public ActionResult Create()
        {
            //Before
            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title");
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "LastName");
            //ViewBag.ProgramId = new SelectList(db.Progams, "Id", "Name");
            //return View();

            //After
            //var courseDropDownList = new SelectList(db.Courses, "Id", "Title");
            //var studentDropDownList = new SelectList(db.Students, "Id", "LastName");
            //var programDropDownList = new SelectList(db.Progams, "Id", "Name");

            //Final
            var viewModel = new CreateEnrollmentViewModel()
            {
                CourseDropDownList = new SelectList(db.Courses, "Id", "Title"),
                StudentDropDownList = new SelectList(db.Students, "Id", "LastName"),
                ProgramDropDownList = new SelectList(db.Programs, "Id", "Name")
            };

            return View(viewModel);
        }

        // POST: Enrollment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEnrollmentViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var enrollment = new Enrollment()
                {
                    Id = viewModel.Id,                                        
                    CourseId = viewModel.CourseId,
                    ProgramId = viewModel.ProgramId,
                    StudentId = viewModel.StudentId
                };

                db.Enrollments.Add(enrollment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title", viewModel.Enrollment.CourseId);
            //ViewBag.StudentId = new SelectList(db.Students, "Id", "LastName", enrollment.StudentId);
            //ViewBag.ProgramId = new SelectList(db.Progams, "Id", "Name", enrollment.ProgramId);
            return View();
        }

        // GET: Enrollment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title", enrollment.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "LastName", enrollment.StudentId);
            ViewBag.ProgramId = new SelectList(db.Programs, "Id", "Name", enrollment.ProgramId);

            //var viewModel = new EditEnrollmentViewModel();

            return View(enrollment);
        }

        // POST: Enrollment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,StudentId,Grade")] Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enrollment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "Title", enrollment.CourseId);
            ViewBag.StudentId = new SelectList(db.Students, "Id", "LastName", enrollment.StudentId);
            ViewBag.ProgramId = new SelectList(db.Programs, "Id", "Name", enrollment.ProgramId);

            return View(enrollment);
        }

        // GET: Enrollment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enrollment enrollment = db.Enrollments.Find(id);
            if (enrollment == null)
            {
                return HttpNotFound();
            }
            return View(enrollment);
        }

        // POST: Enrollment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enrollment enrollment = db.Enrollments.Find(id);
            db.Enrollments.Remove(enrollment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
