using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alumnos
{
    class Alumno
    {
        private int matricula;
        private string nombre;
        private int edad;
        private char sexo;
        private int telefono;
        private string entidad_nacional;

        public Alumno()
        {
            this.matricula = 0;
            this.nombre = null;
            this.edad = 0;
            this.sexo = ' ';
            this.telefono = 0;
            this.entidad_nacional = null;
        }
        public int mat
        {
            get { return matricula; }
            set { this.matricula = value; }
        }
        public string nom
        {
            get { return nombre; }
            set { this.nombre = value; }
        }
        public int eda
        {
            get { return edad; }
            set { this.edad = value; }        
        }
        public char sex
        {
            get { return sexo; }
            set { this.sexo = value; }
        }
        public int telf
        {
            get { return telefono; }
            set { this.telefono = value; }
        }
        public string entid
        {
            get { return entidad_nacional; }
            set { this.entidad_nacional = value; }
        }
        public override string ToString()
        {
            return "ALUMNO: \n " +
                   "Matricula: " + mat + "\n" +
                   "Nombre: " + nom + "\n" +
                   "Edad: " + edad + "\n" +
                   "Sexo: " + sex + "\n" +
                   "Telefono: " + telf + "\n" +
                   "Entidad de nacimiento: " + entid;
        }
    }
}