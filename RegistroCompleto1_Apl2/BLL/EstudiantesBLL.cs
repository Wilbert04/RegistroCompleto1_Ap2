using Microsoft.EntityFrameworkCore;
using RegistroCompleto1_Apl2.DAL;
using RegistroCompleto1_Apl2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroCompleto1_Apl2.BLL
{
    public class EstudiantesBLL
    {

        public static bool Guardar(Estudiantes estudiantes)
        {
            if (!Existe(estudiantes.Id))

                return Insertar(estudiantes);
            else
                return Modificar(estudiantes);
        }

        private static bool Insertar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Estudiantes.Add(estudiantes);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
               db.Dispose();
            }
            return paso;
        }

        private static bool Modificar(Estudiantes estudiantes)
        {
            bool paso = false;
            Contexto db =new Contexto();

            try
            {

                db.Entry(estudiantes).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Estudiantes.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static Estudiantes Buscar(int id)
        {

            Estudiantes estudiantes;
            Contexto db = new Contexto();

            try
            {
                estudiantes = db.Estudiantes.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return estudiantes;
        }

        public static bool Existe(int id)
        {

            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Estudiantes.Any(p => p.Id == id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;

        }

    }
}
