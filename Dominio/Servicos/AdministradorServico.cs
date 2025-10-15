using GerenciadorDeVeiculos.Dominio.DTOs;
using GerenciadorDeVeiculos.Dominio.Entidades;
using GerenciadorDeVeiculos.Dominio.Interfaces;
using GerenciadorDeVeiculos.Infraestrutura.Db;

namespace GerenciadorDeVeiculos.Dominio.Servicos;

public class AdministradorServico : IAdministradorServico
{
    private readonly DbContexto _contexto;
    public AdministradorServico(DbContexto contexto)
    {
        _contexto = contexto;
    }
    public Administrador? Login(LoginDTO loginDTO)
    {
        var adm = _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        return adm;
    }
}