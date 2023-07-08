using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UT_JsonRouteTest.Controllers
{
	public class AnotherController : Controller
	{
		// GET: AnotherController
		public ActionResult Index()
		{
			return View();
		}

		// GET: AnotherController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: AnotherController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: AnotherController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: AnotherController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: AnotherController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: AnotherController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: AnotherController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
