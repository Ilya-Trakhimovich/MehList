using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DAL.EF.Entities;
using MehList.ViewModels;
using AutoMapper;
using DAL.Abstract.IUnitOfWork;

namespace MehList.Controllers
{
    public class MechanismController : Controller
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public MechanismController(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var mechanisms = _uow.MechanismRepository.GetItems().ToList();
            var buildingObjects = _uow.BuildingObjectRepository.GetItems().ToList();

            var mechanismsVM = _mapper.Map<List<Mechanism>, List<MechanismVM>>(mechanisms);
            var buildingObjectsVM = _mapper.Map<List<BuildingObject>, List<BuildingObjectVM>>(buildingObjects);

            var indexVM = new IndexVM()
            {
                Mechanisms = mechanismsVM,
                BuildingObjects = buildingObjectsVM
            };

            return View(indexVM);
        }

        public IActionResult AddMechanism()
        {
            return View("AddMechanism");
        }

        [HttpPost]
        public IActionResult AddMechanism(AddMechanismVM mechanism)
        {
            bool result = double.TryParse(mechanism?.FuelСonsumption, out double fuelConsuption);

            if (!result || fuelConsuption < 0)
            {
                ModelState.AddModelError("FuelСonsumption", "The value must be a number and cannot be negative or equal to 0");
            }

            if (ModelState.IsValid)
            {
                Mechanism mechanization = _mapper.Map<Mechanism>(mechanism);

                _uow.MechanismRepository.Create(mechanization);

                return RedirectToAction("Index");
            }
            else
            {
                return View("AddMechanism", mechanism);
            }
        }
    }
}
