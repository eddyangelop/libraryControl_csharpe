﻿using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivrariaControleEmprestimo.DATA.Repositories
{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {
        protected ControleEmprestimoLivroContext _Contexto;
        public bool _SaveChanges = true;

        public RepositoryBase(bool SaveChanges = true)
        {

            _SaveChanges = SaveChanges;
            _Contexto = new ControleEmprestimoLivroContext();
        }

        public T Alterar(T objeto)
        {
            _Contexto.Entry(objeto).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public void Excluir(T objeto)
        {
           _Contexto.Set<T>().Remove(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
           
        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            if (obj != null)
            {
                Excluir(obj);
            }
        }

        public T Incluir(T objeto)
        {
            _Contexto.Set<T>().Add(objeto);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return objeto;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        }

        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
        }
    }
}
