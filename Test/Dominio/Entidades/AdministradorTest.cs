using GerenciadorDeVeiculos.Dominio.Entidades;
namespace Test.Dominio.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //arrange
        var adm = new Administrador();

        //Act
        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "Teste";
        adm.Perfil = "Adm";

        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("Teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}
