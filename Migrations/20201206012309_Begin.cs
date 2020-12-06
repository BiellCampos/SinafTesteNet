using Microsoft.EntityFrameworkCore.Migrations;

namespace SinafTeste.Migrations
{
    public partial class Begin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    DtNascimento = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Cobertura",
                columns: table => new
                {
                    IdCobertura = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(nullable: true),
                    Percentual = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobertura", x => x.IdCobertura);
                });

            migrationBuilder.CreateTable(
                name: "DependenteAgregado",
                columns: table => new
                {
                    IdDependenteAgregado = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tipo = table.Column<int>(nullable: false),
                    NomeDepen = table.Column<string>(nullable: true),
                    CPF = table.Column<string>(nullable: true),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DependenteAgregado", x => x.IdDependenteAgregado);
                    table.ForeignKey(
                        name: "FK_DependenteAgregado_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCliente = table.Column<int>(nullable: false),
                    Cep = table.Column<string>(nullable: true),
                    EnderecoLog = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropostaSeguro",
                columns: table => new
                {
                    IdPropostaSeguro = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Valortotalpremio = table.Column<int>(nullable: false),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropostaSeguro", x => x.IdPropostaSeguro);
                    table.ForeignKey(
                        name: "FK_PropostaSeguro_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    IdTelefone = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Numero = table.Column<string>(nullable: true),
                    ClienteIdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefone", x => x.IdTelefone);
                    table.ForeignKey(
                        name: "FK_Telefone_Cliente_ClienteIdCliente",
                        column: x => x.ClienteIdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoberturasCliente",
                columns: table => new
                {
                    IdCoberturascliente = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCliente = table.Column<int>(nullable: false),
                    CoberturaIdCobertura = table.Column<int>(nullable: true),
                    Valorsegurado = table.Column<int>(nullable: false),
                    Valorpremio = table.Column<int>(nullable: false),
                    PropostaSeguroIdPropostaSeguro = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoberturasCliente", x => x.IdCoberturascliente);
                    table.ForeignKey(
                        name: "FK_CoberturasCliente_Cobertura_CoberturaIdCobertura",
                        column: x => x.CoberturaIdCobertura,
                        principalTable: "Cobertura",
                        principalColumn: "IdCobertura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoberturasCliente_PropostaSeguro_PropostaSeguroIdPropostaSeguro",
                        column: x => x.PropostaSeguroIdPropostaSeguro,
                        principalTable: "PropostaSeguro",
                        principalColumn: "IdPropostaSeguro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasCliente_CoberturaIdCobertura",
                table: "CoberturasCliente",
                column: "CoberturaIdCobertura");

            migrationBuilder.CreateIndex(
                name: "IX_CoberturasCliente_PropostaSeguroIdPropostaSeguro",
                table: "CoberturasCliente",
                column: "PropostaSeguroIdPropostaSeguro");

            migrationBuilder.CreateIndex(
                name: "IX_DependenteAgregado_ClienteIdCliente",
                table: "DependenteAgregado",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_ClienteIdCliente",
                table: "Endereco",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_PropostaSeguro_ClienteIdCliente",
                table: "PropostaSeguro",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_ClienteIdCliente",
                table: "Telefone",
                column: "ClienteIdCliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoberturasCliente");

            migrationBuilder.DropTable(
                name: "DependenteAgregado");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "Cobertura");

            migrationBuilder.DropTable(
                name: "PropostaSeguro");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
