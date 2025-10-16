using GerenciadorDeVeiculos.Dominio.Entidades;
namespace Test.Dominio.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "veiculoNome";
        veiculo.Marca = "veiculoMarca";
        veiculo.Ano = 1886;

        //Assert
        Assert.AreEqual(veiculo.Id, 1);
        Assert.AreEqual(veiculo.Nome, "veiculoNome");
        Assert.AreEqual(veiculo.Marca, "veiculoMarca");
        Assert.AreEqual(veiculo.Ano, 1886);
    }
}
