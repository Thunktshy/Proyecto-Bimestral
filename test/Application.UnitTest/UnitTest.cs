using System;
using Xunit;
using Application;

namespace Application.UnitTest_Poligono
{
    public class UnitTest_Poligono_R
    {
        [Theory]
        [InlineData(4, 4, 16)]
        [InlineData(5, 4, 20)]
        public void TestPerimetro(double lado, int n_lados, double perimetro)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Poligono_R.Perimetro(lado,n_lados); 
           
            // Assert – Verify
            Assert.Equal(resultado, perimetro);
        }

        [Theory]
        [InlineData(4, 5, 6,60)]
        public void TestArea(double lado, int n_lados, double radio, double area)
        {
            // Arrange – Set up

            // Act – Perform
            double resultado = Poligono_R.Area(lado,n_lados,radio); 
           
            // Assert – Verify
            Assert.Equal(resultado, area);
        }
    }
    public class UnitTestPrismaRegular
        {
            [Theory]
            [InlineData(60 , 3,  180)]
            [InlineData(60 , 4 , 240)]
            [InlineData(30 , 3 , 90 )]
            [InlineData(105, 3 , 315)]
            [InlineData(105, 8 , 840)]
            [InlineData(60 , 12, 720)]
            public void TestVolumen(double area,double altura,double volumen)
            {
                //Arrange - Set Up

                //Act - Perform
                double resultado2 = PrismaRegular.Volumen (area,altura);
                //Assert - Verify
                Assert.Equal(resultado2,volumen);
            }
        }
}