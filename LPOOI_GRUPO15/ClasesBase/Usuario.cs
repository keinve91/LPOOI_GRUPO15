using System;

namespace ClasesBase
{
    public class Usuario
    {

        private int USU_ID;

        public string USU_NombreUsuario { get; set; }
        public string USU_Contraseña { get; set; }
        public string USU_ApellidoNombre { get; set; }


        protected string ROL_Codigo;

        public Usuario() { }

        public Usuario(int id, string rolCodigo)
        {
            this.USU_ID = id;
            this.ROL_Codigo = rolCodigo;
        }


        public int GetID()
        {
            return this.USU_ID;
        }

        public void SetID(int id)
        {
            this.USU_ID = id;
        }


    }
}
