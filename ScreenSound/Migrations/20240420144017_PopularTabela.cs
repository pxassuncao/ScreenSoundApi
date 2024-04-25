using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Djavan", "Cantor conhecido internacionalmente, um dos melhores da cultura popular brasileira", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Caetano Veloso", "Cantor nordestino,nascido na Paraiba em 1957,pai de 10 filhos.", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Leonardo", "Cantor sertanejo,dono de várias fazendas no Mato Grosso.", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Roberto Carlos", "Cantor das multidões e hoje somente realiza shows nos cruzeiros.", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Gustavo Lima", "Cantor setarnejo o embaixador!", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Aviões do Forró", "Banda de forró que leva o tempero do nordeste nas suas músicas ", "C:Users/miras/Downloads/CAp_logotipo_Prancheta 1.png" });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
