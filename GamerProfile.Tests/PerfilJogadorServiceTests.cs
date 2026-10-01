using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamerProfile;
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceApp
    {
       [Fact]
        public void GerarTagUsuario_DeveGerarFormatoCorreto()
        {
            // Arrange
            PerfilJogadorService service = new PerfilJogadorService();

            // Act
            string resultado = service.GerarTagUsuario("Aragorn", "1042");

            // Assert
            Assert.Equal("Aragorn#1042", resultado);
        }

        [Fact]
        public void CalcularXPTotal_DeveRetornar600()
        {
            // Arrange
            PerfilJogadorService service = new PerfilJogadorService();

            // Act
            int resultado = service.CalcularXPTotal(200, 300);

            // Assert
            Assert.Equal(600, resultado);
        }

        [Fact]
        public void ElegivelParaRanked_DeveRetornarTrue()
        {
            // Arrange
            PerfilJogadorService service = new PerfilJogadorService();

            // Act
            bool resultado = service.ElegivelParaRanked(15);

            // Assert
            Assert.True(resultado);
        } 
    }
}