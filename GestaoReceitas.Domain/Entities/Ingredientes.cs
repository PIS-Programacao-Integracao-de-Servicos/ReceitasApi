using GestaoReceitas.Domain.Enums;

namespace GestaoReceitas.Domain.Entities
{
    public class Ingredientes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double QtdMedida { get; set; }
        public MedidasEnum Medida { get; set; }
    }
}
