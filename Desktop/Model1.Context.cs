﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Desktop
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class EntiEspaiEntities : DbContext
{
    public EntiEspaiEntities()
        : base("name=EntiEspaiEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Act_concedida> Act_concedida { get; set; }

    public virtual DbSet<Act_demandadas> Act_demandadas { get; set; }

    public virtual DbSet<Admin> Admin { get; set; }

    public virtual DbSet<Categoria_edad> Categoria_edad { get; set; }

    public virtual DbSet<Competicion> Competicion { get; set; }

    public virtual DbSet<Deportes> Deportes { get; set; }

    public virtual DbSet<Dias_Semana> Dias_Semana { get; set; }

    public virtual DbSet<Entidad> Entidad { get; set; }

    public virtual DbSet<Equipo> Equipo { get; set; }

    public virtual DbSet<Espacio> Espacio { get; set; }

    public virtual DbSet<Horario_Act_Con> Horario_Act_Con { get; set; }

    public virtual DbSet<Horario_Act_Dem> Horario_Act_Dem { get; set; }

    public virtual DbSet<Nivel> Nivel { get; set; }

    public virtual DbSet<Sexo> Sexo { get; set; }

    public virtual DbSet<Telefonos> Telefonos { get; set; }

    public virtual DbSet<Tipo_Act> Tipo_Act { get; set; }

    public virtual DbSet<Tipo_gestion> Tipo_gestion { get; set; }

    public virtual DbSet<Instalacion_Horario> Instalacion_Horario { get; set; }

    public virtual DbSet<Instalacion> Instalacion { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

}

}

