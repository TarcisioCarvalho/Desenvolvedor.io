﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasica.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        [Required(ErrorMessage ="O Campo {0} é Obrigatório")]
        [StringLength(200,ErrorMessage ="O Campo {0} precisa ter entre {2} e {1} caracteres",MinimumLength =2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(1000, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // EF Relation

        public Fornecedor Fornecedor { get; set; }
    }
}
