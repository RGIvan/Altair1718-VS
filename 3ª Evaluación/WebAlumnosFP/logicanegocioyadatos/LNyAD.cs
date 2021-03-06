﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaNegocioyADatos.DataSet1TableAdapters;
using LogicaNegocioyADatos.Entidades;

namespace LogicaNegocioyADatos
{
    public class LNyAD
    {
        static AlumnosTableAdapter alumnosAdapt = new AlumnosTableAdapter();
        static GruposTableAdapter gruposAdapt = new GruposTableAdapter();

        static DataSet1.AlumnosDataTable alumnosTabla = new DataSet1.AlumnosDataTable();
        static DataSet1.GruposDataTable gruposTabla = new DataSet1.GruposDataTable();

        public static List<Grupo> ListaGrupos()
        {
            Grupo grupo;
            List<Grupo> listaGrupos = new List<Grupo>();
            gruposTabla = gruposAdapt.GetData();

            foreach (DataSet1.GruposRow regGrupo in gruposTabla)
            {
                grupo = new Grupo(regGrupo.idGrupo, regGrupo.nombre, regGrupo.alias);
                listaGrupos.Add(grupo);
            }

            return listaGrupos;
        }

        public static DataSet1.AlumnosDataTable TablaAlumnos(int idGrupo)
        {
            if (idGrupo == 0)
                alumnosTabla = alumnosAdapt.GetAlumnosConAliasGrupo();
            else
                alumnosTabla = alumnosAdapt.GetDataByIdGrupo(idGrupo);

            return alumnosTabla;
        }
    }
}
