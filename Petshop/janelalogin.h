#ifndef JANELALOGIN_H
#define JANELALOGIN_H

#include <QMainWindow>
#include <PetShop.h>

QT_BEGIN_NAMESPACE
namespace Ui { class JanelaLogin; }
QT_END_NAMESPACE

class JanelaLogin : public QMainWindow
{
    Q_OBJECT

public:
    JanelaLogin(QWidget *parent = nullptr);
    ~JanelaLogin();

private slots:
    void on_botaologin_clicked();

private:
    Ui::JanelaLogin *ui;
};
#endif // JANELALOGIN_H
