using System.ComponentModel.DataAnnotations;

namespace RegistroPersonas.Entidades
{
    public class TelefonosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }


        public TelefonosDetalle()
        {
            Id = 0;
            PersonaId = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }

        
        public TelefonosDetalle(int idPersona, string tipoTelefono, string telefono)
        {
            PersonaId = idPersona;
            TipoTelefono = tipoTelefono;
            Telefono = telefono;
        }

        
        public TelefonosDetalle(int id, int idPersona, string tipoTelefono, string telefono)
        {
            Id = id;
            PersonaId = idPersona;
            TipoTelefono = tipoTelefono;
            Telefono = telefono;
        }
    }
}
