
namespace Application.UnitTest
{

    public class UnitTestRombo
    {
        [Theory]
        [InlineData(1,4)]
        [InlineData(2,8)]
        [InlineData(3,12)]
        [InlineData(4,16)]
        [InlineData(5,20)]
        public void TestPerimetro(double lado, double Perimetro)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Rombo.Perimetro(lado);

            // Assert – Verify
            Assert.Equal(Perimetro, resultado);
        }

        [Theory]
        [InlineData(6, 3, 9)]  // Diagonal mayor: 6, Diagonal menor: 3, Área esperada: 9
        [InlineData(10, 4, 20)] // Diagonal mayor: 10, Diagonal menor: 4, Área esperada: 20
        [InlineData(7.5, 2.5, 9.375)] // Diagonal mayor: 7.5, Diagonal menor: 2.5, Área esperada: 9.375
        [InlineData(12, 6, 36)] // Diagonal mayor: 12, Diagonal menor: 6, Área esperada: 36
        [InlineData(15, 7, 52.5)] // Diagonal mayor: 15, Diagonal menor: 7, Área esperada: 52.5
        public void TestArea(double Diagonal_M, double Diagonal_menor, double Area)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Rombo.Area(Diagonal_M, Diagonal_menor);

            // Assert – Verify
            Assert.Equal(Area, resultado);
        }
    }
}