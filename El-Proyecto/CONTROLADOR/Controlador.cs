﻿using MODELO;
namespace CONTROLADOR
{
    public class Contrl
    {
        Donante donante=new Donante();
        baseDeDatos datosBase = new baseDeDatos();
        public void verDatos(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Add(donante.Apellido, donante.Nombre, donante.Sexo, donante.F_Nac, donante.Peso);
        }
    }
}