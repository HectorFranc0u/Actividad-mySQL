using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Actividad_mySQL
{
    class Recetas
    {
        public int _ID { get; set; }
        public string _nombre { get; set; }
        public string _tipo { get; set; }
        public string _ingredientes { get; set; }
        public string _autor { get; set; }

        private Crud crud = new Crud();

        public MySqlDataReader getallrecipies()
        {
            string query = "SELECT ID,nombre,tipo,ingredientes,autor FROM recetas";

            return crud.select(query);
        }

        public Boolean newEditrecipe(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO recetas(Nombre, tipo, ingredientes, autor)" +
                    "VALUES ('"+ _nombre +"', '"+ _tipo +"', '"+ _ingredientes +"', '"+ _autor +"')";
                crud.executeQuery(query);
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE recetas SET "
                    + "Nombre='"+ _nombre +"' ,"
                    + "tipo='" + _tipo + "',"
                    + "ingredientes='" + _ingredientes + "',"
                    + "autor='" + _autor + "'"
                    + "WHERE "
                    + "ID= '"+ _ID +"'";
                crud.executeQuery(query);
                return true;
            }
            return false;
        }

        public Boolean deleterecipe()
        {
            string query = "DELETE FROM recetas WHERE ID='" + _ID + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
