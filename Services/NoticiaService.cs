﻿using NoticiasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasAPI.Services
{
    public class NoticiaService
    {
        public readonly NoticiasDBContext _noticiaDbContext;
        public NoticiaService(NoticiasDBContext noticiaDBContext)
        {
            _noticiaDbContext = noticiaDBContext;
        }

        public Boolean AgregarNoticia (Noticia _noticia)
        {
            try
            {
                _noticiaDbContext.Noticia.Add(_noticia);
                _noticiaDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}