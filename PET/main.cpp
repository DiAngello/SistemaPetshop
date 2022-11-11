#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <stdio.h>
#include <string.h>
#include <unistd.h>

int main(){
    setlocale (LC_ALL, "Portuguese");
    char nome[50][50],endereco[5][50],cidade[5][50],telefone[5][50];
    char cpf[5][50], email[50][50], genero[50][50], idade[5][50], raca[5][50];
    char diaDeCadastro[5][50], tipoDeProduto[5][50], fornecedor[5][50];
    char usuario [2][10], escolha;
    int senha, senhavalida = 1234, servico;
    int idProduto, quantidadeProduto, qntExec;
    int i,j,quant;
    int dia, agendamento;
    char nomeTutor, nomePet, tipoTosa;

    printf("=============================================\n");
    printf("=      -                           -        =\n");
    printf("=      -                           -        =\n");
    printf("=      -         PET & GATO        -        =\n");
    printf("=      -                           -        =\n");
    printf("=      -                           -        =\n");
    printf("=============================================\n\n");
    printf("                -         -                \n");
    printf("              -   -------   -              \n");
    printf("              -             -              \n");
    printf("              -  --  .  --  -              \n");
    printf("         ---  -     = =     - ---          \n");


    sleep(2);

    printf("=============================================\n");
    printf("      -                           -          \n");
    printf("      -        Faca o login       -          \n");
    printf("                                             \n");
    printf("      Usuário:  ");
    scanf("%s", &usuario);
    printf("      Senha:  ");
    scanf("%d", &senha);
    printf("=============================================\n");

do{
    if (senha != senhavalida){
       printf("Acesso negado");
    } else {
        printf("==========================\n");
        printf("=     Seja bem-vindo     =\n");
        printf("==========================\n");
        sleep(1);
        printf("==========================\n");
        printf("=     Carrengando...     =\n");
        printf("==========================\n");
        sleep(2);
        printf("[1] = Cadastro de cliente\n");
        printf("[2] = Cadastro de Pet\n");
        printf("[3] = Agendamento de serviços\n");
        printf("[4] = Cadastro de Produtos\n");
        printf("O que deseja realizar?");
        scanf("%d", &servico);
    if (servico == 1){
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
    sleep(1);
    printf("==========================\n");
    printf("=     Carrengando...     =\n");
    printf("==========================\n");
    sleep(2);
    printf("\n-------------------------------------------------------------------------------\n");
    printf("Cadastros Realizados\n\n");
    for(i=0;i<quant;i++){
        printf("NOME ------: %s\n",nome[i]    );
        printf("ENDERECO --: %s\n",endereco[i]);
        printf("CIDADE ----: %s\n",cidade[i]  );
        printf("TELEFONE ----: %s\n",telefone[i]  );
        printf("CPF/CNPJ --: %s\n",cpf[i]     );
    }} else if (servico == 2){

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
    sleep(1);
    printf("==========================\n");
    printf("=     Carrengando...     =\n");
    printf("==========================\n");
    sleep(2);
    printf("\n-------------------------------------------------------------------------------\n");
    printf("Cadastros Realizados\n\n");
    for(i=0;i<quant;i++){
        printf("NOME ------: %s\n",nome[i]    );
        printf("IDADE -----: %s\n",idade[i]);
        printf("GENERO ----: %s\n",genero[i]  );
        printf("RAÇA ------: %s\n",raca[i]  );
        printf("CPF/CNPJ --: %s\n",cpf[i]     );
    }}else if (servico == 3){
    printf("Selecione o serviço que deseja\n [1] = Banho\n [2] = Tosa\n [3] = Banho e Tosa");
    scanf("%d", &agendamento);

    switch (agendamento){
    case 1:
        printf("Banho");
        printf("Digite o nome do tutor:\n");
        scanf("%s", &nomeTutor);
        printf("Digite o CPF do tutor:\n");
            scanf("%d", &cpf);
        printf("Digite o nome do Pet:\n");
            scanf("%s", &nomePet);
        break;
    case 2:
        printf("Tosa");
        printf("Digite o CPF do tutor:\n");
            scanf("%d", &cpf);
        printf("Digite o nome do Pet:\n");
            scanf("%s", &nomePet);
        printf("Digite o tipo de tosa");
            scanf("%s", &tipoTosa);
    break;

    default:
        break;
    }
} else if (servico == 4){
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
    }}
}
printf("Deseja realizar outro servico? [S/N]");
scanf("%s", &escolha);}
    while(escolha == 's');
    system("pause");
    return 0;}
