using System;

namespace ClasesBase
{
    public class Usuario
    {
        // Atributo privado
        private int USU_ID;

        // Propiedades públicas
        public string USU_NombreUsuario { get; set; }
        public string USU_Contraseña { get; set; }
        public string USU_ApellidoNombre { get; set; }

        // Atributo protegido
        protected string ROL_Codigo;

        // ✅ Constructor por defecto (obligatorio si vas a hacer new Usuario() sin parámetros)
        public Usuario() { }

        // ✅ Constructor con parámetros
        public Usuario(int id, string rolCodigo)
        {
            this.USU_ID = id;
            this.ROL_Codigo = rolCodigo;
        }

        // Métodos Get/Set para USU_ID
        public int GetID()
        {
            return this.USU_ID;
        }

        public void SetID(int id)
        {
            this.USU_ID = id;
        }

        // Podés agregar más métodos si lo necesitás
    }
}
