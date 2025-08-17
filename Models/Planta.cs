namespace Tarea1.Models
{
    public class Planta
    {
        public int Id { get; set; }                 // Planta (ID)
        public string Nombre { get; set; } = "";
        public string Origen { get; set; } = "";    // Perú (región/zona)
        public string Especie { get; set; } = "";
        public decimal Altura_Maxima { get; set; }  // metros
        public string Notas { get; set; } = "";     // Descripción
        public string Imagen { get; set; } = "";    // URL
    }
}