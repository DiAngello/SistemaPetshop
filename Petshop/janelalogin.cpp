#include "janelalogin.h"
#include "ui_janelalogin.h"
#include "QMessageBox"

JanelaLogin::JanelaLogin(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::JanelaLogin)
{
    ui->setupUi(this);
}

JanelaLogin::~JanelaLogin()
{
    delete ui;
}


void JanelaLogin::on_botaologin_clicked()
{
    this->close();
    PetShop f_principal;
    f_principal.exec();
}

