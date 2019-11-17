﻿using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Minimundo.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SugestaoAvaliacaoController : Controller
    {
        private readonly ISugestaoAvaliacaoService _service;

        public SugestaoAvaliacaoController(ISugestaoAvaliacaoService service)
        {
            _service = service;
        }

        #region CRUD

        public IActionResult ListarTodos()
        {
            IEnumerable<SugestaoAvaliacao> obj = _service.SelectAll();
            return View(obj);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Mostrar(int id)
        {
            SugestaoAvaliacao obj = _service.Select(id);
            return Json(obj);
        }

        [HttpPost]
        public IActionResult Inserir(SugestaoAvaliacao obj)
        {
            _service.Insert(obj);
            return Json(obj);
        }

        [HttpPut]
        public IActionResult Atualizar(SugestaoAvaliacao obj)
        {
            _service.Update(obj);
            return Json(obj);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Deletar(int id)
        {
            var obj = _service.Delete(id);
            return Json(obj);
        }

        #endregion CRUD
    }
}