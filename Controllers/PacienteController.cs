using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using testeNess.Models;
using testeNess.Repositorio;


namespace testeNess.Controllers
{
    public class PacienteController : Controller
    {
        private PacienteRepositorio _repositorio;


        public ActionResult ObterPacientes()
        {

            _repositorio = new PacienteRepositorio();
            ModelState.Clear();

            return View(_repositorio.ObterPacientes());


        }

        public JsonResult BuscaTodosDados()
        {
            _repositorio = new PacienteRepositorio();
            var retorno = _repositorio.ObterPacientes();
            return Json(retorno, JsonRequestBehavior.AllowGet);

        }




        [HttpGet]
        public ActionResult IncluirPaciente()
        {
            return View();

        }


        [HttpPost]
        public ActionResult IncluirPaciente(Paciente PacienteObj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositorio = new PacienteRepositorio();
                    if (_repositorio.AdicionarPaciente(PacienteObj))
                    {
                        ViewBag.Mensagem = "Paciente cadastrado com sucesso";
                    }
                }

                return View();
            }
            catch (Exception)
            {
                return View("ObterPacientes");
            }

        }


        [HttpGet]
        public ActionResult EditarPaciente(int id)
        {
            _repositorio = new PacienteRepositorio();
            return View(_repositorio.ObterPacientes().Find(t => t.IdPaciente == id));

        }


        [HttpPost]
        public ActionResult EditarPaciente(Paciente PacienteObj)
        {
            try
            {


                _repositorio = new PacienteRepositorio();
                if (_repositorio.AtualizarPaciente(PacienteObj))
                {
                    ViewBag.Mensagem = "Dados do paciente alterados com sucesso";
                }
                return View();

            }
            catch (Exception)
            {

                return View("ObterPacientes");

            }
        }




        [HttpPost]
        public JsonResult ExcluiDeNovo(int id)
        {
            _repositorio = new PacienteRepositorio();
            var retorno = _repositorio.DeletarPaciente(id);
            return Json(retorno, JsonRequestBehavior.AllowGet);

        }

        // AGENDADOR DE CONSULTAS


        [HttpGet]
        public ActionResult AgendasConsulta(int id)
        {
            _repositorio = new PacienteRepositorio();
            return View(_repositorio.ObterConsulta().Find(t => t.IdPaciente == id));

        }


        [HttpPost]
        public ActionResult AgendasConsulta(Paciente PacienteObj)
        {
            try
            {

                _repositorio = new PacienteRepositorio();
                var retorno = _repositorio.AdicionarConsulta(PacienteObj);

                if (retorno)
                {
                    return RedirectToAction("ObterPacientes");
                }
                else
                {
                    return RedirectToAction("ObterPacientes");
                }

            }
            catch (Exception)
            {

                return View("ObterPacientes");

            }
        }


        List<Paciente> post = new List<Paciente>();
        [HttpGet]
        public JsonResult RetornaDados()
        {

            // ############# Tive alguns problemas com essa chamada na view onde faria a validação do calendário... vou manter o código para analisarem onde errei.
            // No console do navegador retorna erro 500 creio que seja algo relativamente tranquilo de consertar mas pelo prazo preciso lhes entregar como esta por modos didaticos irei terminar o projeto

            //_repositorio = new PacienteRepositorio();
            ////var itens = _repositorio.ObterPacientes();
            //var resposta = _repositorio.ObterPacientes();

            var exemploEx = "{“titulo”: “JSON x XML”,“resumo”: “o duelo de dois modelos de representação de informações”,“ano”: 2012,“genero”: [“aventura”, “ação”, “ficção”]}";


            return Json(new { teste = "bar",outro  = "Blech" });



        }



        }
}