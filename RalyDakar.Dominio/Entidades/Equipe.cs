﻿using System.Collections.Generic;

namespace RallyDakar.Dominio.Entidades
{
    public class Equipe
    {
        public int Id { get; set; }
        public string CodIdentificador { get; set; }
        public string Nome { get; set; }
        public int TemporadaId { get; set; }
        public virtual Temporada Temporada { get; set; }
        public ICollection<Piloto> Pilotos { get; set; }

        public bool Validado()
        {
            if (string.IsNullOrEmpty(Nome))
                return false;
            return true;
        }
    }
}
