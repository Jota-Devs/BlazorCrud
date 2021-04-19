﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceBlazorCRUD.Models.Response;
using WebServiceBlazorCRUD.Models;
using WebServiceBlazorCRUD.Models.Request;

namespace WebServiceBlazorCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Persona>> oRespuesta = new Respuesta<List<Persona>>();
            try
            {
                using (BlazorCRUDContext db = new BlazorCRUDContext())
                {
                    var lst = db.Personas.ToList();
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            Respuesta<Persona> oRespuesta = new Respuesta<Persona>();
            try
            {
                using (BlazorCRUDContext db = new BlazorCRUDContext())
                {
                    var lst = db.Personas.Find(Id);
                    oRespuesta.Exito = 1;
                    oRespuesta.Data = lst;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpPost]
        public IActionResult Add(PersonaRequest model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (BlazorCRUDContext db = new BlazorCRUDContext())
                {
                    Persona oPersona = new Persona();
                    oPersona.Name = model.Name;
                    db.Personas.Add(oPersona);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpPut]
        public IActionResult Edit(PersonaRequest model)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (BlazorCRUDContext db = new BlazorCRUDContext())
                {
                    Persona oPersona = db.Personas.Find(model.Id);
                    oPersona.Name = model.Name;
                    db.Entry(oPersona).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<object> oRespuesta = new Respuesta<object>();
            try
            {
                using (BlazorCRUDContext db = new BlazorCRUDContext())
                {
                    Persona oPersona = db.Personas.Find(Id);
                    db.Remove(oPersona);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }
}
