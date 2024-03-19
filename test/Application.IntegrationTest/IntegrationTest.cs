using System;
using Xunit;
using Application;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Theory]
        [InlineData(5  ,6  ,7  ,5  ,525 )]
        [InlineData(5  ,6  ,8  ,5  ,600 )]
        [InlineData(6  ,7  ,8  ,5  ,840 )]
        [InlineData(8  ,8  ,8  ,6  ,1536 )]
        [InlineData(11 ,4  ,9  ,13 ,2574 )]
        public void TestVolumen(double lado,int n_lados,double radio,double altura,double volumen)
        {
        // Arrange – Set up
        double area = Poligono_R.Area(lado,n_lados,radio);

        // Act – Perform
        double resultado = PrismaRegular.Volumen(area, altura);

        // Assert – Verify
        Assert.Equal(resultado, volumen);
        }
    }
}