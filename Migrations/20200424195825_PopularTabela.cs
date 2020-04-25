using Microsoft.EntityFrameworkCore.Migrations;

namespace Lanchonete.Migrations
{
    public partial class PopularTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        /*  migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES('Normal', 'Alface tomate milho batata e uma carne')");
          migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) VALUES('Natural', 'Alface tomate milho batata')");

         migrationBuilder.Sql(@"INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Preco)
         Values((SELECT CategoriaId FROM Categorias WHERE CategoriaNome='Normal'),
         'Pão, hamburger, queijo e batata palha', 'catchup, maionese, palmito',1,
         'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg',
         'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1 ,12.50)");
        */
 
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
