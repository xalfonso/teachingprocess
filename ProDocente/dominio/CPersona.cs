using System;
using System.Collections.Generic;
using System.Text;

namespace ProDocente.dominio
{
    [Serializable]
    public class CPersona
    {
        private String primerNombre;

        public String PrimerNombre
        {
            get { return primerNombre; }
            set { primerNombre = value; }
        }

        private String segundoNombre;

        public String SegundoNombre
        {
            get { return segundoNombre; }
            set { segundoNombre = value; }
        }

        private String primerApellido;

        public String PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }
        private String segundoApellido;

        public String SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }

        private String ci;

        public String CI
        {
            get { return ci; }
            set { ci = value; }
        }

        public CPersona(String primerNombre, String segundoNombre, String primerApellido, String segundoApellido, String ci)
        {
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.ci = ci;
        }

       

        public CPersona()
        {
            this.primerNombre = "";
            this.segundoNombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.ci = "";
        }

        public override string ToString()
        {
            return this.primerNombre+ " "+this.segundoNombre+ " "+this.PrimerApellido+" "+this.segundoApellido;
        }
    }
}
