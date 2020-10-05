using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using Alvin_P1_API.Entidades;
using Alvin_P1_API.DAL;

namespace Alvin_P1_API.BLL
{
    public class CiudadesBLL
    {
        public static bool Guardar(Ciudades ciudad)
        {
            if (!Existe(ciudad.ciudadId))
                return Insertar(ciudad);
            else
                return Editar(ciudad);
        }
        private static bool Insertar(Ciudades ciudad)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Ciudades.Add(ciudad);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Editar(Ciudades ciudad)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ciudad).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var ciudad = contexto.Ciudades.Find(id);
                if (ciudad != null)
                {
                    contexto.Ciudades.Remove(ciudad);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static Ciudades Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ciudades ciudad;
            try
            {
                ciudad = contexto.Ciudades.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return ciudad;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;
            try
            {
                encontrado = contexto.Ciudades
                    .Any(e => e.ciudadId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }

    }
}
