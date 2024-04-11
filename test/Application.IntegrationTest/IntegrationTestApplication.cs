
namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(8, 4, 128)]
    [InlineData(5, 7, 87.5)]
    [InlineData(6, 2, 36)]
    [InlineData(9, 10, 405)]
    [InlineData(1, 3, 1.5)]

    public void TestVolumen(double lado, double altura, double Volumen)
    {
        // Arrange – Set up
        double Diagonal_M = lado;
        double Diagonal_menor = lado; // En un rombo, ambas diagonales son iguales
        double AreaRombo = Rombo.Area(Diagonal_M, Diagonal_menor);

        // Act – Perform
        double resultado = PrismaCuadrangular.Volumen(AreaRombo, altura);

        // Assert – Verify
        Assert.Equal(resultado, Volumen);
    }
}