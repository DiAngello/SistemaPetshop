#ifndef PETSHOP_H
#define PETSHOP_H

#include <QDialog>

QT_BEGIN_NAMESPACE
namespace Ui { class PetShop; }
QT_END_NAMESPACE

class PetShop : public QDialog
{
    Q_OBJECT

public:
    PetShop(QWidget *parent = nullptr);
    ~PetShop();

private slots:
    void on_botao_cad_clicked();

    void on_botao_agen_clicked();

    void on_botao_prod_clicked();

private:
    Ui::PetShop *ui;
};
#endif // PETSHOP_H
