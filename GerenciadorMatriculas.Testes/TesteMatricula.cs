namespace GerenciadorMatriculas.Testes
{
    public class TesteMatricula
    {
        [Theory]
        [InlineData("Davi", "Sandra", "Marcos", "22", "Rua Silva Jardim, N 55, Rio de Janeiro")]
        public void TestaMatricula(string nome, string nomeMae, string nomePai, string idade, string endereco)
        {
            //Arrange
            Aluno aluno = new Aluno()
            {
                Nome = nome,
                NomeMae = nomeMae,
                NomePai = nomePai, 
                Idade = idade,
                Endereco = endereco
            };

            //Act
            bool response = aluno.MatricularAluno();

            //Assert
            Assert.True(response);
        }
    }
}