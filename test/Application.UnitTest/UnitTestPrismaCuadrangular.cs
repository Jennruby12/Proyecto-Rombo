
namespace Application.UnitTest;

public class UnitTestPrismaCuadrangular
{
    [Theory]
    [InlineData(16, 4, 64)]
    [InlineData(25, 6, 150)]
    [InlineData(9, 10, 90)]
    [InlineData(70, 2, 140)]
    [InlineData(45, 6, 270)]
    public void TestVolumen(double Area, double altura, double Volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = PrismaCuadrangular.Volumen(Area, altura);
        
        // Assert – Verify
        Assert.Equal(resultado, Volumen);
    }
}