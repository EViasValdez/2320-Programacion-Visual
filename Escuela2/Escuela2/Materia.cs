using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela2
{
    class Materia
    {
        private int id_;
        private string materia;
        private int horas;
        private int creditos;

        public Materia()
        {
            this.id_ = 0;
            this.materia = null;
            this.horas = 0;
            this.creditos = 0;
        }

        public int id
        {
            get { return id_; }
            set { this.id_ = value; }
        }

        public string mater
        {
            get { return materia; }
            set { this.materia = value; }
        }

        public int hora
        {
            get { return horas; }
            set { this.horas = value; }
        }

        public int cred
        {
            get { return creditos; }
            set { this.creditos = value; }
        }
    }
}
