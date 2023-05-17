﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("cliCPF")]
        [StringLength(14)]
        [DisplayName("CPF")]
        public string CliCpf { get; set; }
        [Required]
        [Column("cliNome")]
        [StringLength(200)]
        [DisplayName("NOME")]
        public string CliNome { get; set; }
        [Required]
        [Column("cliEndereco")]
        [StringLength(200)]
        [DisplayName("ENDEREÇO")]
        public string CliEndereco { get; set; }
        [Required]
        [Column("cliCidade")]
        [StringLength(100)]
        [DisplayName("CIDADE")]
        public string CliCidade { get; set; }
        [Required]
        [Column("cliBairro")]
        [StringLength(100)]
        [DisplayName("BAIRRO")]
        public string CliBairro { get; set; }
        [Required]
        [Column("cliNumero")]
        [StringLength(50)]
        [DisplayName("NÚMERO")]
        public string CliNumero { get; set; }
        
        [Required]
        [Column("cliTelefoneCelular")]
        [StringLength(14)]
        [DisplayName("CELULAR")]
        public string CliTelefoneCelular { get; set; }
        
        [Required]
        [Column("cliTelefoneFixo")]
        [StringLength(13)]
        [DisplayName(" TELELEFONE FIXO")]
        public string CliTelefoneFixo { get; set; }
        

        [InverseProperty("LceIdClienteNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}