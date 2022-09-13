namespace GerenciadorMatriculas.Testes
{
    public class TesteMatricula
    {
        [Theory]
        [InlineData("Davi", "Sandra", "Marcos", "22", "Rua Silva Jardim, N 55, Rio de Janeiro")]
        [InlineData("Bruno", "Thais", "Paulo", "26", "Rua Maria Es, N 100, Rio de Janeiro")]
        [InlineData("Joao", "Fulana", "Fulano", "25", "Rua Astolfo Nunes, N 74, Rio de Janeiro")]

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