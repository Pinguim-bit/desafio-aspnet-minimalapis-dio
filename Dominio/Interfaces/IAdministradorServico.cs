using GerenciadorDeVeiculos.Dominio.DTOs;
using GerenciadorDeVeiculos.Dominio.Entidades;

namespace GerenciadorDeVeiculos.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO); 
}