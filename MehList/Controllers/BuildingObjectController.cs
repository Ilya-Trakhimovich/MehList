using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Abstract.IUnitOfWork;
using DAL.EF.Entities;
using MehList.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MehList.Controllers
{
    public class BuildingObjectController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public BuildingObjectController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var buildengObjects = _uow.BuildingObjectRepository.GetItems();

            return PartialView("ObjectList", buildengObjects);
        }

        public IActionResult AddBuildingObject()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBuildingObject(AddBuildingObjectVM model)
        {
            if (ModelState.IsValid)
            {
                var buildingObject = _mapper.Map<BuildingObject>(model);

                _uow.BuildingObjectRepository.Create(buildingObject);


                return RedirectToAction("Index", "Mechanism");
            }
            else
            {
                return View(model);
            }
        }
    }
}
