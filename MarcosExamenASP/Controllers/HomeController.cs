using BL;
using Entidades;
using MarcosExamenASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MarcosExamenASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<clsDepartamento> listadoDepartamento;
            try
            {
                listadoDepartamento = clsListadosBL.ObtenerDepartamentosBL();
                return View(listadoDepartamento);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        /// <summary>
        /// IActionResult que va a la vista de confirmar borrar personas.
        /// </summary>
        /// <returns>Vista con el listado de personas con el idDep seleccionado.</returns>
        public IActionResult ConfirmarBorrado(int idDepartamento)
        {
            List<clsPersona> listadoPersonas;
            try
            {
                listadoPersonas = clsListadosBL.ListaPersonasPorDepBL(idDepartamento);
                ViewBag.IdDepartamento = idDepartamento;
                return View(listadoPersonas);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        /// <summary>
        /// IActionResult que hace que se borren las personas y que te mande a la vista del Index.
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>La vista inicial</returns>
        [HttpPost]
        [ActionName("ConfirmarBorrado")]
        public IActionResult BorrarBoton(int idDepartamento)
        {
            try
            {
                clsListadosBL.BorrarPersonasBL(idDepartamento);
                List<clsDepartamento> listadoDepartamento = clsListadosBL.ObtenerDepartamentosBL();
                return View("Index", listadoDepartamento);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
    }
}
