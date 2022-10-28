
#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdio.h>
#include <string.h>

int main(){
    setlocale (LC_ALL, "Portuguese");
    char nome[50][50],endereco[5][50],cidade[5][50],telefone[5][50];
    char cpf[5][50], email[50][50], genero[50][50], idade[5][50], raca[5][50];
    char diaDeCadastro[5][50], tipoDeProduto[5][50], fornecedor[5][50];
    int idProduto, quantidadeProduto, qntExec;
    int i,j,quant;
    FILE *arquivo;

    printf("Quantas pessoas serão cadastradas ? \n");
    scanf("%d", & quant);

    for(i=0;i<quant;i++){
        printf("Digite nome: ");
        fflush(stdin);

        gets(nome[i]);
        printf("Digite endereco: ");
        fflush(stdin);

        gets(endereco[i]);
        printf("Digite cidade: ");
        fflush(stdin);

        gets(cidade[i]);
        printf("Digite estado: ");
        fflush(stdin);

        gets(telefone[i]);
        printf("Digite CPF/CNPJ: ");
        fflush(stdin);

        gets(cpf[i]);
    }
    printf("\n-------------------------------------------------------------------------------\n");
    printf("Cadastros Realizados\n\n");
    for(i=0;i<quant;i++){
        printf("NOME ------: %s\n",nome[i]    );
        printf("ENDERECO --: %s\n",endereco[i]);
        printf("CIDADE ----: %s\n",cidade[i]  );
        printf("TELEFONE ----: %s\n",telefone[i]  );
        printf("CPF/CNPJ --: %s\n",cpf[i]     );
    }

    printf("Quantos PETs serão cadastrados ? \n");
    scanf("%d", & quant);

    for(i=0;i<quant;i++){
        printf("Digite nome: ");
        fflush(stdin);

        gets(nome[i]);
        printf("Digite idade: ");
        fflush(stdin);

        gets(idade[i]);
        printf("Digite genero: ");
        fflush(stdin);

        gets(genero[i]);
        printf("Digite raça: ");
        fflush(stdin);

        gets(raca[i]);
        printf("Digite CPF/CNPJ do tutor: ");
        fflush(stdin);

        gets(cpf[i]);
    }
    printf("\n-------------------------------------------------------------------------------\n");
    printf("Cadastros Realizados\n\n");
    for(i=0;i<quant;i++){
        printf("NOME ------: %s\n",nome[i]    );
        printf("IDADE -----: %s\n",idade[i]);
        printf("GENERO ----: %s\n",genero[i]  );
        printf("RAÇA ------: %s\n",raca[i]  );
        printf("CPF/CNPJ --: %s\n",cpf[i]     );
    }
    printf("Digite quantos produtos serao cadastrados:\n");
 scanf("%d", &qntExec);

    for (i=0; i < qntExec; i++){
            printf("Qual a data de cadastro deste produto?");
        scanf("%s", &diaDeCadastro);
            printf("Qual tipo desse produto");
        scanf("%s", &tipoDeProduto);
            printf("Digite o fornecedor deste produto");
        scanf("%s", &fornecedor);
            printf("Quantos desse produto vai ser registrado?");
        scanf("%d", &quantidadeProduto);
    }
}
